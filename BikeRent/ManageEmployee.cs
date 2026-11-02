using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRent
{
    public partial class ManageEmployee : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        Validation vd = new Validation();
        private bool  isString(string st)
        {
            for(int i = 0;i < st.Length; i++)
            {
                if (!((st[i] <= 'z' &&  st[i] >= 'a') || (st[i] >= 'A' && st[i] <= 'Z')))
                {
                    return false;
                }
            }
            return true;
        }
        private bool isInt(string st)
        {
            for(int i = 0;i < st.Length; i++)
            {
                if (!(st[i] <= '9' && st[i] >= '0'))
                {
                    return false;
                }
            }
            return true;
        }
        public ManageEmployee()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            GenerateEmployeeID();
            //this.dgvEmployeeList.BringToFront();
        }
        private void PopulateGridView(string sql = "select * from employee order by employeeId ;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvEmployeeList.AutoGenerateColumns = false;
            dgvEmployeeList.ClearSelection();
            this.txtPassword.ReadOnly = false;
            this.txtPassword.PasswordChar = '\0';
            this.dgvEmployeeList.DataSource = this.Ds.Tables[0];

        }
        private void GenerateEmployeeID()
        {
            this.Sql = "select * from employee order by employeeId desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            if (Dt.Rows.Count > 0)
            {
                string empId = Dt.Rows[0]["employeeId"].ToString();
                string[] str = empId.Split('E');
                int n = Convert.ToInt32(str[1]);
                string newempId = "E" + (++n).ToString("d3");
                this.txtEmployeeId.Text = newempId;
            }
            else
            {
                this.txtEmployeeId.Text = "E001";
            }
        }
        private void ClearAll()
        {
            this.txtPassword.ReadOnly = false;
            this.txtEmployeeId.Clear();
            this.txtEmployeeId.ReadOnly = true;
            this.txtName.Clear();
            this.txtSalary.Clear();
            this.cmbRole.SelectedIndex = -1;
            this.txtAddress.Clear();
            this.txtPassword.Clear();
            this.dtpJoinDate.Text = "";
            this.txtSearch.Clear();
            this.txtContactInfo.Clear();
            GenerateEmployeeID();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            PopulateGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //string s1, s2;
            //s2 = this.txtSalary.Text;
            //s1 = this.txtContactInfo.Text;
            if (string.IsNullOrWhiteSpace(this.txtName.Text) ||
                string.IsNullOrWhiteSpace(this.txtPassword.Text) ||
                string.IsNullOrWhiteSpace(this.cmbRole.Text) ||
                string.IsNullOrWhiteSpace(this.txtContactInfo.Text) ||
                string.IsNullOrWhiteSpace(this.txtAddress.Text) ||
                string.IsNullOrWhiteSpace(this.txtSalary.Text))
            {

                MessageBox.Show("All Filled are Required!");
            }
            else if (!vd.isString(this.txtName.Text.ToString()))
            {
                MessageBox.Show("Invalid Name!!");
            }
            else if (!vd.isInt(this.txtSalary.Text.ToString()))
            {
                MessageBox.Show("Invalid Salary!!");
            }
            else if (!vd.isContact(this.txtContactInfo.Text.ToString()))
            {
                MessageBox.Show("Ivalid Number!!");
            }
            //else if (s1.Length != 11)
            //{
            //    MessageBox.Show("Incorrect Number!!");
            //}
            //else if (s1[0] != '0' || s1[1] != '1' || s1[2] == '2' || s1[2] == '1' || s1[2] == '1')
            //{
            //    MessageBox.Show("Incorrect Number!!" + s1[0] + s1[1] + s1[2]);
            //}
            else
            {
                try
                {
                    this.Sql = "select * from employee where employeeId = '" + this.txtEmployeeId.Text + "'";
                    this.Ds = this.Da.ExecuteQuery(this.Sql);
                    if (this.Ds.Tables[0].Rows.Count == 1)
                    {
                        this.Sql = @"update employee
                              set 
                             name = '" + this.txtName.Text + @"',
                             role = '" + this.cmbRole.Text + @"',
                             contactInfo = '" + this.txtContactInfo.Text + @"',
                             address = '" + this.txtAddress.Text + @"',
                             salary = '" + this.txtSalary.Text + @"',
                             joinDate = '" + DateTime.Parse(this.dtpJoinDate.Text) + @"'
                         where employeeId = '" + this.txtEmployeeId.Text + "';";
                        int count = this.Da.ExecuteUpdateQuery(this.Sql);
                        if (count == 1)
                        {
                            MessageBox.Show(this.txtEmployeeId.Text + " has been updated properly");
                        }
                        else
                        {
                            MessageBox.Show("Employee data updation failed");
                        }
                    }
                    else
                    {
                        this.Sql = @"insert into employee
                         (employeeId, password, name, role, contactInfo, address, salary, joinDate)
                         values ('" + this.txtEmployeeId.Text + "', '" + this.txtPassword.Text + "', '" + this.txtName.Text + "', '" + this.cmbRole.Text + "', '" + this.txtContactInfo.Text + "','" + this.txtAddress.Text + "','" + this.txtSalary.Text + "', '" + DateTime.Parse(this.dtpJoinDate.Text) + "');";
                        int count = this.Da.ExecuteUpdateQuery(this.Sql);
                        Sql = @"insert into Login 
                                    values('" + this.txtEmployeeId.Text + "','" + this.txtPassword.Text + "','" + this.cmbRole.Text + "');";
                        int cnt = this.Da.ExecuteUpdateQuery(Sql);

                        if (count == 1 && cnt == 1)
                        {
                            MessageBox.Show(this.txtName.Text + " has been added properly");
                            this.GenerateEmployeeID();
                        }
                        else
                        {
                            MessageBox.Show("Employee data insertion failed");
                        }
                    }
                    this.PopulateGridView();
                    this.ClearAll();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error has occured during saving the Employee data\n\n" + exc.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvEmployeeList.CurrentRow.Cells["employeeId"].Value.ToString();
                string name = this.dgvEmployeeList.CurrentRow.Cells["name"].Value.ToString();

                this.Sql = @"delete from employee
                        where employeeId = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                this.Sql = @"delete from Login
                        where Username = '" + id + "';";
                int cnt = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1 && cnt == 1)
                {
                    MessageBox.Show(name + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Employee data deletion failed");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
        }

        private void dgvEmployeeList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmployeeList.CurrentRow != null)
            {
                try
                {
                    string s = dgvEmployeeList.CurrentRow.Cells["employeeId"].Value?.ToString();
                    this.Sql = "select password from employee where employeeId ='" + s + "'";
                    DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
                    string p = Dt.Rows[0]["password"].ToString();
                    this.txtPassword.ReadOnly = true;
                    this.txtPassword.PasswordChar = '*';
                    this.txtEmployeeId.ReadOnly = true;
                    this.txtEmployeeId.Text = dgvEmployeeList.CurrentRow.Cells["employeeId"].Value?.ToString();
                    this.txtPassword.Text = p;
                    this.txtName.Text = dgvEmployeeList.CurrentRow.Cells["name"].Value?.ToString();
                    this.cmbRole.Text = dgvEmployeeList.CurrentRow.Cells["role"].Value?.ToString();
                    this.txtContactInfo.Text = dgvEmployeeList.CurrentRow.Cells["contactInfo"].Value?.ToString();
                    this.txtAddress.Text = dgvEmployeeList.CurrentRow.Cells["address"].Value?.ToString();
                    this.txtSalary.Text = dgvEmployeeList.CurrentRow.Cells["salary"].Value?.ToString();
                    this.dtpJoinDate.Text = dgvEmployeeList.CurrentRow.Cells["joinDate"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Employee details: " + ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from employee where employeeId like '" + this.txtSearch.Text + @"%' 
             or name like '" + this.txtSearch.Text + @"%' 
             or role like '" + this.txtSearch.Text + @"%' 
             or contactInfo like '" + this.txtSearch.Text + @"%' 
             or address like '" + this.txtSearch.Text + @"%' ;"; 
             this.PopulateGridView(this.Sql);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            //ClearAll();
            PopulateGridView();
            this.txtPassword.PasswordChar = '*';
        }

        private void dgvEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
