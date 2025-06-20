using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class fmPayment : Form
    {
        A6 d = new A6();
        SqlCommand com = new SqlCommand();
        Decimal t, ds, r;

        public fmPayment()
        {
            InitializeComponent();
        }
        private void fmPayment_Load(object sender, EventArgs e)
        {
            // connection to database
            d.Connection();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM dbo.fnGetStaffs() order by staffID", d.conn);
            DataTable dt = new DataTable();

            // get data from table staff
            dap.Fill(dt);
            cbStaffId.DataSource = dt;
            cbStaffId.DisplayMember = "staffID";
            cbStaffId.ValueMember = "FullName";
            cbStaffId.Text = null;

            dap = new SqlDataAdapter("SELECT * FROM dbo.fnGetOrderCode() order by OrdCode", d.conn);
            dt = new DataTable();
            // get data from table payment
            dap.Fill(dt);
            cbOC.DataSource = null;
            cbOC.Items.Clear();
            cbOC.DataSource = dt;
            cbOC.DisplayMember = "OrdCode";
            cbOC.ValueMember = "OrdCode";
            cbOC.Text = null;
        }

        private void cbStaffId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtStaff.Text = cbStaffId.SelectedValue.ToString();
        }

        private void txtDP_Leave(object sender, EventArgs e)
        {
            t = decimal.Parse(txtTotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat);
            ds = decimal.Parse(txtDP.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat);
            r = t - ds;
            txtRemain.Text = string.Format("{0:c}", decimal.Parse(r.ToString()));
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("spPayment", d.conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@PD", dtp.Value);
            com.Parameters.AddWithValue("@SI", cbStaffId.Text);
            com.Parameters.AddWithValue("@FN", txtStaff.Text);
            com.Parameters.AddWithValue("@IC", int.Parse(cbOC.SelectedValue.ToString()));

            if (txtDP.ReadOnly == false)
            {
                com.Parameters.AddWithValue("@Dep", decimal.Parse(txtDP.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat));
            }
            else
            {
                com.Parameters.AddWithValue("@Dep", decimal.Parse(txtRemain.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat));
            }
            com.Parameters.AddWithValue("@A", decimal.Parse(txtTotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat));
            com.ExecuteNonQuery();

            MessageBox.Show("Payment successfully");
        }

        private void cbOC_SelectionChangeCommitted(object sender, EventArgs e)
        {
            com = new SqlCommand("spGetPayment", d.conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@oc", cbOC.SelectedValue.ToString());
            var dr = com.ExecuteReader();

            if (dr.Read())
            {
                txtTotal.Text = string.Format("{0:C}", decimal.Parse(dr[0].ToString()));
                txtDP.Text = dr[1].ToString();
                if (string.IsNullOrEmpty(txtDP.Text))
                {
                    txtRemain.Text = txtTotal.Text;
                }
                else
                {
                    t = decimal.Parse(txtTotal.Text, NumberStyles.Currency);

                    ds = decimal.Parse(txtDP.Text, NumberStyles.Currency);

                    r = t - ds;

                    txtRemain.Text = string.Format("{0:c}", decimal.Parse(r.ToString()));
                    txtDP.ReadOnly = true;
                }

            }
            dr.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 
    }
}
