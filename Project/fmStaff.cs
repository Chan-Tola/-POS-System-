using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.staffAccess;

namespace Project
{
    public partial class fmStaff : Form
    {
        // declare globally
        A6 d = new A6();
        SqlCommand com;
        SqlDataAdapter dap;
        DataTable dt;
        string fp = null; 
        byte[] photo = null;

        staff staff;
        
        staffRepository repo;

        public fmStaff()
        {
            d.Connection();
            InitializeComponent();
            LoadData();
        }
        // function clear
        private void ClearForm()
        {
            txtId.Clear();
            txtFN.Clear();
            txtPos.Clear();
            txtSalary.Clear();

            rdbF.Checked = false; 
            rdbM.Checked = false;

            dfb.Value = DateTime.Today;

            photo = null;
            fp = null;

            picStaff.Image = null;

            txtId.Focus();
        }
        // load data
        public void LoadData()
        {
            try
            {
                dgViewStaff.DataSource = null;
                com = new SqlCommand("spGetAllStaff", d.conn);
    
                com.CommandType = CommandType.StoredProcedure;

                SqlDependency dep = new SqlDependency(com);
                dep.OnChange += new OnChangeEventHandler(OnChange);

                dap = new SqlDataAdapter(com);
                dt = new DataTable();
                dap.Fill(dt);

                dgViewStaff.DataSource = dt;

                // Set image layout and row height
                DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dgViewStaff.Columns["Photo"];
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

                dgViewStaff.RowTemplate.Height = 50;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void OnChange(Object caller, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                dgViewStaff.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
        }

        // this is the object for create new staff 
        private staff CreateStaffFormForm()
        {
            return new staff
            {
                Id = txtId.Text,
                FullName = txtFN.Text,
                Gender = rdbF.Checked ? "F" : "M",
                DOB = dfb.Value,
                Position = txtPos.Text,
                Salary = decimal.Parse(txtSalary.Text, NumberStyles.Currency),
                stopwork = 0,
                Photo = photo // this is the image you loaded from file
            };
        }

        // button for browse the image

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            fd.Title = "Select Staff Image";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                fp = fd.FileName;
                picStaff.Image = Image.FromFile(fp);
            }
        }

        // button add new staff
        private void btnAN_Click(object sender, EventArgs e)
        {
            if (fp != null)
            {
                photo = File.ReadAllBytes(fp);
            }

            // get staff object form form
            staff= CreateStaffFormForm();

            //insert into DB
            repo = new staffRepository(d.conn);
            repo.InsertStaff(staff);

            // function clear
            ClearForm();
        }


        // button EDIT staff
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(fp!= null)
            {
                photo = File.ReadAllBytes(fp);
            }
            // get staff object form form
            staff = CreateStaffFormForm();

            // called method updated
            repo = new staffRepository(d.conn);
            repo.UpdatedStaff(staff);

            ClearForm();
        }
        // data grid view code
        private void dgViewStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgViewStaff.RowCount > 0)
            {
                i = e.RowIndex;
                if (i < 0) return;
                DataGridViewRow row = dgViewStaff.Rows[i];
                txtId.Text = row.Cells[0].Value.ToString();
                txtFN.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "F") {
                    rdbF.Checked = true;    
                } 
                else {
                    rdbM.Checked = true;
                }
                dfb.CustomFormat = "yyyy-MM-dd";
                dfb.Text = row.Cells[3].Value.ToString();
                txtPos.Text = row.Cells[4].Value.ToString();
                txtSalary.Text = string.Format("{0:c}",row.Cells[5].Value);

                photo = (byte[])row.Cells[7].Value;
                if (photo != null && photo.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(photo))
                    {
                        picStaff.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picStaff.Image = null;
                    MessageBox.Show("No Image Data found.");
                }
                // this is the code for make image in grid view have nomarl to look
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("spDeletestaff", d.conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id",txtId.Text);
            com.ExecuteNonQuery();
            ClearForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            (dgViewStaff.DataSource as DataTable).DefaultView.RowFilter = String.Format("FullName like '%{0}%' or convert(staffID, 'System.String') like '%{0}%' ", txtSearch.Text,txtId.Text);
        }


    }
}
