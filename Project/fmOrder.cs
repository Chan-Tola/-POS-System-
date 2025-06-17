using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Project
{
    public partial class fmOrder : Form
    {
        A6 d = new A6();
        SqlDataAdapter dap = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        Decimal Total = 0;
        public fmOrder()
        {
            InitializeComponent();
        }

        private void fmOrder_Load(object sender, EventArgs e)
        {
            d.Connection();
            dap = new SqlDataAdapter("select staffID,FullName from dbo.tbStaffs order by staffID", d.conn);
            DataTable dtStaff = new DataTable();
            dap.Fill(dtStaff);
            cbStaffId.DataSource = dtStaff;
            cbStaffId.DisplayMember = "staffID";
            cbStaffId.ValueMember = "FullName";
            cbStaffId.Text = null;

            // this is dap to product table 
            dap = new SqlDataAdapter("select * from fnGetAllCustomer() order by cusID", d.conn);
            DataTable dtCustomer = new DataTable();
            dap.Fill(dtCustomer);
            cbCusId.DataSource = dtCustomer;
            cbCusId.DisplayMember = "cusID";
            cbCusId.ValueMember = "cusName";
            cbCusId.Text = null;

            // this is for listView
            lvs.Clear();
            lvs.View = View.Details;
            lvs.Columns.Add("Product ID", 120); // number are the column pixel
            lvs.Columns.Add("Product Name", 200);
            lvs.Columns.Add("Quantity", 100);
            lvs.Columns.Add("Price", 120);
            lvs.Columns.Add("Amount", 170);
        }
        // function for exit
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // this is function using with combo box staff for get name from database
        private void cbStaffId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtStaff.Text = cbStaffId.SelectedValue.ToString(); 

        }
        // this is function using with combo box customer for get name from database
        private void cbCusId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtCusName.Text = cbCusId.SelectedValue.ToString();
        }

        // function input ID proudct and show name product from database 
        private void txtPID_Leave(object sender, EventArgs e)
        {
            com = new SqlCommand("spgetPBID", d.conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@pc", txtPID.Text);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtPName.Text = dr[0].ToString();
                    // this is dr[1] pi pros it come from spgetPBID col
                    txtUP.Text = string.Format("{0:c}",decimal.Parse(dr[1].ToString())) ;
                }
            }
            else
            {
                txtPName.Text = null;
            }
            dr.Dispose();
        }
        // button add Item order
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lv = null;
            Decimal amount, s;
            // these codes are using for search the id in lv have or not
            // if in lv have so it is go to the if condition
            foreach (ListViewItem item in lvs.Items)
            {
                if (item.Text.Equals(txtPID.Text, StringComparison.Ordinal))
                {
                    lv = item;
                    break;
                }
            }
            // if using for update old product. update qty, price and total
            if (lv != null)
            {
                var qty = int.Parse(lv.SubItems[2].Text) + int.Parse(txtQty.Text);
                lv.SubItems[2].Text = qty.ToString();
                Total = Total - decimal.Parse(lv.SubItems[4].Text, NumberStyles.Currency);
                var price = decimal.Parse(txtUP.Text, NumberStyles.Currency);
                amount = price * qty;
                // format using for make the amount to the money that people can understand
                lv.SubItems[4].Text = string.Format("{0:c}", amount);
                Total = amount + Total;
            }
            // else using for new product
            else
            {
                // using item for store new data
                ListViewItem item;
                /* need to have array that using for know that how many colum that u 
                want to add.
                 */
                string[] arr = new string[5]; /* if I want to know that how much columns I want 
                                               so I can go to check in the how many textboxs do I have.
                                               */
                arr[0] = txtPID.Text;
                arr[1] = txtPName.Text;
                arr[2] = txtQty.Text;
                s = decimal.Parse(txtUP.Text,NumberStyles.Currency,CultureInfo.CurrentCulture.NumberFormat);
                /*
                 txtUP.Text:
                    អត្ថបទដែលអ្នកបញ្ចូលក្នុង TextBox (ឧ. "$1,200.50" ឬ "៛12000.00")

                 NumberStyles.Currency:
                    បញ្ជាក់ថា វាគួរត្រូវបានបកប្រែជាលេខ រូបិយប័ណ្ណ ដែលអាចមាន៖

                    សញ្ញារូបិយប័ណ្ណ ($, ៛, €, ...)

                    សញ្ញាក្បៀសពាន់ (, ឬ " ")

                    សញ្ញាទសភាគ (. ឬ ,)

                    CultureInfo.CurrentCulture.NumberFormat:
                    ប្រើ ទម្រង់លេខ តាមភាសាដែលកុំព្យូទ័រប្រើ (ឧ. English US, Khmer KH, French FR)
                 */
                arr[3] = string.Format("{0:c}", s);

                amount = decimal.Parse(txtQty.Text) * decimal.Parse(txtUP.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat);
                arr[4] = string.Format("{0:c}", amount);

                item = new ListViewItem(arr);
                lvs.Items.Add(item);

                Total = amount + Total;
            }

            // ✅ 1. Show success message
            MessageBox.Show("Add successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTotal.Text = string.Format("{0:c}", Total);
            txtPID.Text = null;
            txtPName.Text = null;
            txtQty.Text = null;
            txtUP.Text = null;
        }

        // function remove
        private void btnRm_Click(object sender, EventArgs e)
        {
            DialogResult re;
            foreach (ListViewItem item in lvs.Items)
            {
                if (item.Selected)
                {
                    // assume the id is stored in the first subitem (subitem[0])
                    string id = item.SubItems[0].Text;
                    re = MessageBox.Show(
                        $"Are you sure want to delete the product with ID = {id} ?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                        );
                    if (re == DialogResult.Yes)
                    {
                        ListViewItem it = lvs.SelectedItems[0];
                        lvs.Items.Remove(it);
                        var a = Decimal.Parse(it.SubItems[4].Text, NumberStyles.Currency);
                        Total = Total - a;
                        txtTotal.Text = string.Format("{0:c}", Total);
                    }
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtMaster = new DataTable(); // Create a new DataTable to hold import master data

            // place for Import Master
            // place for Import Master
            dtMaster.Columns.Add("OrdDate", typeof(string));     // Column for import date (as string, consider DateTime if needed)
            dtMaster.Columns.Add("staffID", typeof(int));        // Column for staff ID
            dtMaster.Columns.Add("FullName", typeof(string));    // Column for staff full name
            dtMaster.Columns.Add("cusID", typeof(int));          // Column for supplier ID
            dtMaster.Columns.Add("cusName", typeof(string));    // Column for supplier name
            dtMaster.Columns.Add("Total", typeof(float));      // Column for total import amount


            // Convert the selected date from DateTimePicker to a string format, then parse it back to DateTime
            string impDate = dtp.Value.ToString("yyyy-MM-dd HH:mm:ss");

            // Add one row of data into the DataTable (dtMaster)
            // This row includes: import date, staff ID, staff name, Phone Number, Customer name, and total amount
            dtMaster.Rows.Add(DateTime.Parse(impDate), cbStaffId.Text, txtStaff.Text, cbCusId.Text,
                txtCusName.Text, Total);



            // Create a new SQL command to call the stored procedure named 'spSetImportMaster'
            com = new SqlCommand("spSetOrder    ", d.conn);
            com.CommandType = CommandType.StoredProcedure;

            // Create a new parameter to send the DataTable to the stored procedure
            SqlParameter parameter1 = new SqlParameter();
            parameter1.ParameterName = "@OM";              // This must match the parameter name in the stored procedure
            parameter1.SqlDbType = SqlDbType.Structured;   // Tells SQL Server it's a table type
            parameter1.Value = dtMaster;                   // The DataTable that holds your data
            com.Parameters.Add(parameter1);                // Add the parameter to the command


            // place for ImportDetail
            DataTable dtDetail = new DataTable();
            dtDetail.Columns.Add("ProCode", typeof(string));
            dtDetail.Columns.Add("ProName", typeof(string));
            dtDetail.Columns.Add("Qty", typeof(int));
            dtDetail.Columns.Add("Price", typeof(float));
            dtDetail.Columns.Add("Amount", typeof(float));


            foreach (ListViewItem item in lvs.Items)
            {
                string pc = item.Text;
                string pn = item.SubItems[1].Text;
                int q = int.Parse(item.SubItems[2].Text);
                float p = float.Parse(item.SubItems[3].Text, NumberStyles.Currency);
                float a = float.Parse(item.SubItems[4].Text, NumberStyles.Currency);

                dtDetail.Rows.Add(pc, pn, q, p, a);
            }

            SqlParameter parameter2 = new SqlParameter();
            parameter2.ParameterName = "@OD";              // This must match the parameter name in the stored procedure
            parameter2.SqlDbType = SqlDbType.Structured;   // Tells SQL Server it's a table type
            parameter2.Value = dtDetail;                   // The DataTable that holds your data
            com.Parameters.Add(parameter2);                // Add the parameter to the command
            // Run the stored procedure in the database
            com.ExecuteNonQuery();


            // ✅ 1. Show success message
            MessageBox.Show("Order saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ✅ 2. Optional: Clear inputs (if you want to reset the form)
            dtMaster.Clear();
            dtDetail.Clear();
            lvs.Items.Clear(); // clear ListView
            cbStaffId.SelectedIndex = -1;
            txtStaff.Clear();
            cbCusId.SelectedIndex = -1;
            txtCusName.Clear();
            Total = 0;
            txtTotal.Text = "$0.00"; // update total display

            // ✅ 3. Optional: Visual effect (e.g., change save button color briefly)
            btnSave.BackColor = Color.LimeGreen;
            await Task.Delay(300); // wait a bit
            btnSave.BackColor = SystemColors.Control; // restore default color
        }

    
    }
}
