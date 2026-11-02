using BikeRent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashhistory
{
    public partial class CashierHistory : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public string EmployeeID { get; set; }
        Validation va = new Validation();
        public CashierHistory(string employeeId)
        {
            InitializeComponent();
            this.EmployeeID = employeeId;
            this.Da = new DataAccess();
            this.txtEmployeeID.Text = this.EmployeeID;
            Generate();
            PopulateGridView("select * from Rent where employeeID = '" + this.txtEmployeeID.Text + @"';");
        }
        private void PopulateGridView(string sql = "select * from Rent;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvCashier.AutoGenerateColumns = false;
            int cnt = this.Ds.Tables[0].Rows.Count;
            this.txtSellcount.Text = cnt.ToString();
            this.dgvCashier.DataSource = this.Ds.Tables[0];
        }
        private void ClearAll()
        {
            this.txtNewValue.Clear();
            this.cbSelectField.SelectedIndex = -1;
        }

        private void Generate()
        {
            this.Sql = "select * from employee where employeeID = '" + this.txtEmployeeID.Text + @"';";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            this.txtName.Text = Dt.Rows[0]["name"].ToString();
            this.txtSalary.Text = Dt.Rows[0]["salary"].ToString();
            this.txtAdress.Text = Dt.Rows[0]["address"].ToString();
            this.txtContactInfo.Text = Dt.Rows[0]["contactInfo"].ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.cbSelectField.Text) || string.IsNullOrWhiteSpace(this.txtNewValue.Text))
            {
                MessageBox.Show("Both Fields Are Required!!");
            }
            else
            {
                string st = this.cbSelectField.Text.ToString();
                if (st == "Password")
                {
                    this.Sql = @"UPDATE employee
                    SET password = '" + this.txtNewValue.Text.ToString() + @"'
                    WHERE employeeId = '" + this.txtEmployeeID.Text + "';";
                    int cnt = Da.ExecuteUpdateQuery(this.Sql);
                    if (cnt == 1)
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
                        if (cnt == 1)
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
            ClearAll();
            Generate();
            PopulateGridView("select * from Rent where employeeID = '" + this.txtEmployeeID.Text + @"';");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql =
            "SELECT * FROM Rent " +
            "WHERE (rentID LIKE '" + this.txtSearch.Text + @"%' " +
            "OR bikeID LIKE '" + this.txtSearch.Text + @"%' " +
            "OR cost LIKE '" + this.txtSearch.Text + @"%' " +
            "OR customerID LIKE '" + this.txtSearch.Text + @"%' " +
            "OR status LIKE '" + this.txtSearch.Text + @"%') " +
            "AND employeeID = '" + this.txtEmployeeID.Text + "';";
            this.PopulateGridView(this.Sql);
        }
    }
}
