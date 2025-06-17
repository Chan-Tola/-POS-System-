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
using Project.ProAccess;
namespace Project
{
    public partial class fmProduct : Form
    {
        A6 d = new A6();
        SqlCommand com;

        products pro;
        productRepo repo;

        public fmProduct()
        {
            d.Connection();
            InitializeComponent();
            LoadData();
        }

        // create data for store object
        private products CreateProFormForm()
        {
            return new products
            {
                Id = txtId.Text,
                ProName = txtProName.Text
            };
        }

        // this is the event for Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // this is function loadData
        public void LoadData()
        {
            dgPdView.DataSource = null;
            com = new SqlCommand("select ProCode,ProName from dbo.tbProducts", d.conn);

            SqlDependency dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);
            
            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dgPdView.DataSource = dt;



        }
        // this is function for Onchange in the loading data table
        public void OnChange(Object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired) {
                dgPdView.BeginInvoke(new MethodInvoker(LoadData));
            } else { LoadData(); }
        }
        // this is event for get cell in the data grid view
        private void dgPdView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if(dgPdView.RowCount > 0)
            {
;                i = e.RowIndex;

                if (i < 0) return;
                DataGridViewRow row = dgPdView.Rows[i];
                txtId.Text = row.Cells[0].Value.ToString();
                txtProName.Text = row.Cells[1].Value.ToString();
            }

        }
        // this is function delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("delete from dbo.tbProducts where ProCode = @ProCode ", d.conn);
            com.Parameters.AddWithValue("@ProCode", txtId.Text);
            com.ExecuteNonQuery();

            ClearForm();
        }
        // function clear form
        public void ClearForm()
        {
            txtId.Clear();
            txtProName.Clear();
        }

        private void btnAN_Click(object sender, EventArgs e)
        {
            pro = CreateProFormForm();
            repo = new productRepo(d.conn);
            repo.insertPro(pro);

            ClearForm();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pro = CreateProFormForm();
            repo = new productRepo(d.conn);
            repo.editPro(pro);
            ClearForm();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (dgPdView.DataSource as DataTable).DefaultView.RowFilter = String.Format("ProName like '%{0}%' or convert(ProCode,'System.String') like '%{0}%'", txtSearch.Text,txtId.Text);
        }
    }
}
