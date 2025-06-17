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
using Project.SupAccess;

namespace Project
{
    public partial class fmSupplier : Form
    {
        A6 d = new A6();
        SqlCommand com;
        SqlDataAdapter dap = new SqlDataAdapter();

        supplier sp;
        supRepo repo;


        public fmSupplier()
        {
            d.Connection();
            InitializeComponent();
            LoadData();
        }
        // code for create object for new customer 
        private supplier CreateSupFormFrom()
        {
            return new supplier
            {
                Id = txtId.Text,
                Name = txtName.Text,
                Address = txtAdd.Text,
                Contacts =txtCon.Text,
            };
        }
        // function clear form
        public void ClearForm()
        {
            txtId.Clear();
            txtName.Clear();
            txtAdd.Clear(); 
            txtCon.Clear();
        }
        // this is function for close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // function load data
        public void LoadData()
        {

            dgSpView.DataSource = null;            
            //com = new SqlCommand("select supID,Supplier,supAdd,supCon from dbo.tbSuppliers", d.conn);
            com = new SqlCommand("spGetAllSuppliers", d.conn);
            com.CommandType = CommandType.StoredProcedure;
            SqlDependency dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(Onchange);

            dap = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dgSpView.DataSource = dt;


        }
        public void Onchange(Object caller, SqlNotificationEventArgs e) {
            if(this.InvokeRequired)
            { 
                dgSpView.BeginInvoke(new MethodInvoker(LoadData));
            }else
            {
                LoadData();
            }
        
        }
        
        // button add new supplier
        private void btnAN_Click(object sender, EventArgs e)
        {
            sp = CreateSupFormFrom();
            repo = new supRepo(d.conn);
            repo.insertSup(sp);

            //clear form
            ClearForm();
        }

        // button edit supplier
        private void btnEdit_Click(object sender, EventArgs e)
        {
            sp = CreateSupFormFrom();
            repo = new supRepo(d.conn);
            repo.editSup(sp);

            //clear form
            ClearForm();
        }
        // datagrid view using with event clickCell
        private void dgSpView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            // rowcount using for count the row of the table
            if (dgSpView.RowCount > 0)
            {
                i = e.RowIndex; // this is cut all the indexs in the data grid view
                if (i < 0) return;
                DataGridViewRow row = dgSpView.Rows[i]; // that's mean the row = row in the data grid view in table
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtAdd.Text = row.Cells[2].Value.ToString();
                txtCon.Text = row.Cells[3].Value.ToString();
            }
        }

        //button delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("delete from dbo.tbSuppliers  where supID = @supID", d.conn);
            com.Parameters.AddWithValue("@supID", txtId.Text);
            com.ExecuteNonQuery();
            ClearForm();
        }

        // Search
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (dgSpView.DataSource as DataTable).DefaultView.RowFilter = String.Format("Supplier like '%{0}%' or convert(supID,'System.String') like '%{0}%'", txtSearch.Text,txtId.Text);
        }


    }
}
