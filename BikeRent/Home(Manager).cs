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
    public partial class Home_Manager_ : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public string  EmployeeID { get; set; }
        Validation va = new Validation();
        public Home_Manager_(string employeeId)
        {
            this.EmployeeID = employeeId;
            InitializeComponent();
            this.Da = new DataAccess();
            this.txtEmployeeID.Text = this.EmployeeID;
            Generate();
            PopulateGridView("select * from Bike where employeeID = '"+this.txtEmployeeID.Text+@"';");
            //PopulateGridView();
        }
        private void ClearAll()
        {
            this.txtNewValue.Clear();
            this.cbUpdateValue.SelectedIndex = -1;
        }
        
        private void Generate()
        {
            this.Sql = "select * from employee where employeeID = '" + this.txtEmployeeID.Text + @"';";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            this.txtName.Text = Dt.Rows[0]["name"].ToString();
            this.txtSalary.Text = Dt.Rows[0]["salary"].ToString();
            this.txtAddress.Text = Dt.Rows[0]["address"].ToString();
            this.txtContactInfo.Text = Dt.Rows[0]["contactInfo"].ToString();
        }
        private void PopulateGridView(string sql = "select * from Bike;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvBikeList.AutoGenerateColumns = false;
            int cnt = this.Ds.Tables[0].Rows.Count;
            this.txtBikeAdded.Text = cnt.ToString();
            this.dgvBikeList.DataSource = this.Ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql =
            "SELECT * FROM Bike " +
            "WHERE (bikeID LIKE '" + this.txtSearch.Text + @"%' " +
            "OR bikeName LIKE '" + this.txtSearch.Text + @"%' " +
            "OR brand LIKE '" + this.txtSearch.Text + @"%' " +
            "OR type LIKE '" + this.txtSearch.Text + @"%' " +
            "OR availabilityStatus LIKE '" + this.txtSearch.Text + @"%' " +
            "OR employeeID LIKE '" + this.txtSearch.Text + @"%') " +
            "AND employeeID = '" + this.txtEmployeeID.Text + "';";
            this.PopulateGridView(this.Sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.cbUpdateValue.Text) || string.IsNullOrWhiteSpace(this.txtNewValue.Text))
            {
                MessageBox.Show("Both Fields Are Required!!");
            }
            else
            {
                string st = this.cbUpdateValue.Text.ToString();
                if (st == "Password")
                {
                    this.Sql = @"UPDATE employee
                    SET password = '" + this.txtNewValue.Text.ToString() + @"'
                    WHERE employeeId = '" + this.txtEmployeeID.Text + "';";
                    int cnt = Da.ExecuteUpdateQuery(this.Sql);
                    if(cnt == 1)
                    {
                        MessageBox.Show("Password Update Successfull");
                    }
                    else
                    {
                        MessageBox.Show("Error While Updating!!!");
                    }
                }
                else
                {
                    if (!va.isContact(this.txtNewValue.Text.ToString()))
                    {
                        MessageBox.Show("Invalid Contact");
                    }
                    else
                    {
                        this.Sql = @"UPDATE employee
                        SET contactInfo = '" + this.txtNewValue.Text.ToString() + @"'
                        WHERE employeeId = '" + this.txtEmployeeID.Text + "';";
                        int cnt = Da.ExecuteUpdateQuery(this.Sql);
                        if(cnt == 1)
                        {
                            MessageBox.Show("Contact Update Successfull.");
                        }
                        else
                        {
                            MessageBox.Show("Error While Updating!!!");
                        }
                    }
                }
            }
            PopulateGridView("select * from Bike where employeeID = '" + this.txtEmployeeID.Text + @"';");
            ClearAll();
            Generate();
        }
    }
}
