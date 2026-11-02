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
    public partial class ManageCustomer : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        Validation vd = new Validation();
        public ManageCustomer()
        {
            this.Da = new DataAccess();
            InitializeComponent();
            PopulateGridView();
            GenerateCustomerID();
        }

        private void PopulateGridView(string sql = "select * from Customer;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvCustomerList.AutoGenerateColumns = false;
            this.dgvCustomerList.DataSource = this.Ds.Tables[0];
        }

        private void GenerateCustomerID()
        {
            this.Sql = "select * from Customer order by customerID desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);

            string newCustomerID;

            if (Dt.Rows.Count > 0)
            {
                string customerID = Dt.Rows[0]["customerID"].ToString();
                string[] str = customerID.Split('C');
                int n = Convert.ToInt32(str[1]);
                newCustomerID = "C" + (++n).ToString("d3");
            }
            else
            {
                newCustomerID = "C001";
            }

            this.txtCustomerID.Text = newCustomerID;
        }

        private void ClearAll()
        {
            this.txtCustomerID.Clear();
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerName.Clear();
            this.txtContact.Clear();
            this.txtAddress.Clear();
            this.txtDrivingLicense.Clear();
            GenerateCustomerID();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from Customer where drivingLicense = '" + this.txtDrivingLicense.Text + "'";
            this.Ds = this.Da.ExecuteQuery(this.Sql);
            int number = Ds.Tables[0].Rows.Count;
            //string s1, s2;
            //s1 = this.txtContact.Text;
            if (string.IsNullOrEmpty(this.txtCustomerID.Text) ||
                string.IsNullOrEmpty(this.txtContact.Text) ||
                string.IsNullOrEmpty(this.txtAddress.Text) ||
                string.IsNullOrEmpty(this.txtDrivingLicense.Text))
            {
                MessageBox.Show("All Filled are Required!");
            }
            else if (!vd.isString(this.txtCustomerName.Text.ToString()))
            {
                MessageBox.Show("Invalid Name!!");
            }
            else if (!vd.isContact(this.txtContact.Text.ToString()))
            {
                MessageBox.Show("Invalid Number!!");
            }
            else if(number > 0)
            {
                MessageBox.Show("License Number Alredy Exist!!");
            }
            //else if (s1.Length != 11)
            //{
            //    MessageBox.Show("Incorrect Number!!");
            //}
            //else if (s1[0] != '0' || s1[1] != '1' || s1[2] == '0' || s1[2] == '1' || s1[2] == '2')
            //{
            //    MessageBox.Show("Incorrect Number!!" + s1[0] + s1[1] + s1[2]);
            //}
            else
            {
                try
                {
                    this.Sql = "select * from Customer where customerID = '" + this.txtCustomerID.Text + "'";
                    this.Ds = this.Da.ExecuteQuery(this.Sql);
                    if (this.Ds.Tables[0].Rows.Count == 1)
                    {
                        this.Sql = @"update Customer
                    set customerName = '" + this.txtCustomerName.Text + @"',
                    contact = '" + this.txtContact.Text + @"',
                    address = '" + this.txtAddress.Text + @"',
                    drivingLicense = '" + this.txtDrivingLicense.Text + @"'
                    where customerID = '" + this.txtCustomerID.Text + "';";
                        int count = this.Da.ExecuteUpdateQuery(this.Sql);
                        if (count == 1)
                        {
                            MessageBox.Show(this.txtCustomerID.Text + " has been updated properly");
                        }
                        else
                        {
                            MessageBox.Show("Customer data updation failed");
                        }
                    }
                    else
                    {
                        this.Sql = @"insert into Customer
                    values ('" + this.txtCustomerID.Text + "', '" + this.txtCustomerName.Text + "', '" + this.txtContact.Text + "', '" + this.txtAddress.Text + "','" + this.txtDrivingLicense.Text + "'); ";

                        int count = this.Da.ExecuteUpdateQuery(this.Sql);
                        if (count == 1)
                        {
                            MessageBox.Show(this.txtCustomerID.Text + " has been added properly");
                            this.GenerateCustomerID();
                        }
                        else
                        {
                            MessageBox.Show("Customer data insertion failed");
                        }
                    }
                    this.PopulateGridView();
                    this.ClearAll();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error has occured during saving the Customer data\n\n" + exc.Message);
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvCustomerList.CurrentRow.Cells["customerID"].Value.ToString();

                this.Sql = @"delete from Customer
                        where customerID = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(id + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Customer data deletion failed");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            PopulateGridView();
        }

        private void btShowDetails_Click(object sender, EventArgs e)
        {
            PopulateGridView();
            this.txtSearch.Clear();
            ClearAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from Customer where customerID like '" + this.txtSearch.Text + @"%'
                       or customerName like '" + this.txtSearch.Text + @"%' ;";
            this.PopulateGridView(this.Sql);
        }

        private void dgvCustomerList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCustomerList.CurrentRow != null)
            {
                try
                {
                    this.txtCustomerID.ReadOnly = true;
                    this.txtCustomerID.Text = dgvCustomerList.CurrentRow.Cells["customerID"].Value?.ToString();
                    this.txtCustomerName.Text = dgvCustomerList.CurrentRow.Cells["customerName"].Value?.ToString();
                    this.txtContact.Text = dgvCustomerList.CurrentRow.Cells["contact"].Value?.ToString();
                    this.txtAddress.Text = dgvCustomerList.CurrentRow.Cells["address"].Value?.ToString();
                    this.txtDrivingLicense.Text = dgvCustomerList.CurrentRow.Cells["drivingLicense"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customer details: " + ex.Message);
                }
            }
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
