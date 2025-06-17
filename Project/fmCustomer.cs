using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// this is the way when we want to using class that in the folder
using Project.CusAccess;

namespace Project
{
    public partial class fmCustomer : Form
    {
        A6 d = new A6();
        SqlCommand com;

        customer customer;
        customerRepo repo;

        public fmCustomer()
        {
            d.Connection();
            InitializeComponent();
            LoadData();
        }

        // code for create object for new customer 
        private customer CreateCustomerFormForm()
        {
            return new customer
            {
                Id = txtId.Text,
                FullName = txtFN.Text,
                Phone = txtPh.Text,
            };

        }
        // this is code button X
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ClearForm()
        {
            txtId.Clear();
            txtFN.Clear();
            txtPh.Clear();
        }


        // this is code for load data
        public void LoadData()
        {

            dgViewCus.DataSource = null;
            com = new SqlCommand("spGetAllCustomers", d.conn);
            com.CommandType = CommandType.StoredProcedure;
            //com = new SqlCommand("select cusID,cusName,phone from dbo.tbCustomer", d.conn);

            SqlDependency dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(Onchange);

            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            dgViewCus.DataSource = dt;
        }

        

        // function on change
        public void Onchange(Object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {

                dgViewCus.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
        }

        // this is code for show data on datagridview
        private void dgViewCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgViewCus.RowCount > 0)
            {       
                i = e.RowIndex;
                if (i < 0) return;
                DataGridViewRow row = dgViewCus.Rows[i];
                txtId.Text = row.Cells[0].Value.ToString();
                txtFN.Text = row.Cells[1].Value.ToString();
                txtPh.Text = row.Cells[2].Value.ToString();
            }
        }


        // function add new customer 
        private void btnAN_Click(object sender, EventArgs e)
        {
            customer = CreateCustomerFormForm();
            repo = new customerRepo(d.conn);
            // insert into db
            repo.insertCustomer(customer);

            //fn clear form
            ClearForm();

        }

        // function edit customer information
        private void btnEdit_Click(object sender, EventArgs e)
        {
            customer = CreateCustomerFormForm();
            repo = new customerRepo(d.conn);
            repo.editCustomer(customer);
            //fn clear form
            ClearForm();
        }

        // function delete data
        private void btnDelete_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("delete from dbo.tbCustomer where cusID = @id", d.conn);
            //com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", txtId.Text);
            com.ExecuteNonQuery();

            ClearForm();
        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (dgViewCus.DataSource as DataTable).DefaultView.RowFilter = String.Format("cusName like '%{0}%' or convert(cusID,'System.String') like '%{0}%'",txtSearch.Text,txtId.Text);

        }
    }
}
