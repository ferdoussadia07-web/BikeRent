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
    public partial class ManageRent : UserControl
    {
        public string employeid { get; set; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }


        public ManageRent()
        {
            this.Da = new DataAccess();
            InitializeComponent();
            PopulateBikeGridView();
            PopulateCustomerGridView();
            PopulateAccessoryGridView();
            PopulateRentGridView();
            GenerateRentID();
        }
        private void PopulateBikeGridView(string sql = "select * from Bike where availabilityStatus = 'Available';")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvBike.AutoGenerateColumns = false;
            this.dgvBike.DataSource = this.Ds.Tables[0];  
        }

        private void PopulateCustomerGridView(string sql = "select * from Customer;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.DataSource = this.Ds.Tables[0];
        }

        private void PopulateAccessoryGridView(string sql = "select * from Accessory;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvAccessory.AutoGenerateColumns = false;
            this.dgvAccessory.DataSource = this.Ds.Tables[0];
        }

        private void PopulateRentGridView(string sql = "select * from Rent;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvRent.AutoGenerateColumns = false;
            this.dgvRent.DataSource = this.Ds.Tables[0];
            GenerateRentID();
        }

        private void GenerateRentID()
        {
            this.Sql = "select * from Rent order by rentID desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);

            string newRentID;

            if (Dt.Rows.Count > 0)
            {
                string rentID = Dt.Rows[0]["rentID"].ToString();
                string[] str = rentID.Split('R');
                int n = Convert.ToInt32(str[1]);
                newRentID = "R" + (++n).ToString("d3");
            }
            else
            {
                newRentID = "R001";
            }

            this.txtRentID.Text = newRentID;
        }

        private void ClearAll()
        {
            this.txtRentID.Clear(); 
            this.txtRentID.ReadOnly = true;
            this.txtBikeID.Clear();
            this.txtSearchBike.Clear();
            this.txtCustomerID.Clear();
            this.txtSearchCustomer.Clear();
            this.txtAccessoryID.Clear();
            this.txtSearchAccessory.Clear();
            this.DTRentalStartDate.Text = "";
            this.DTRentalEndDate.Text = "";
            this.TxtCost.Clear();
            GenerateRentID();
        }


        private void ManageRent_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LAccesoryName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            PopulateBikeGridView();
            PopulateCustomerGridView();
            PopulateAccessoryGridView();
            PopulateRentGridView();
        } 

        private void BtRent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.TxtCost.Text))
            {
                MessageBox.Show("Generate Cost First!!");
            }
            else
            {
                try
                {
                    string formattedStartDate = this.DTRentalStartDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    string formattedEndDate = this.DTRentalStartDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    this.Sql = "select * from Rent where rentID = '" + this.txtRentID.Text + @"'";
                    this.Ds = this.Da.ExecuteQuery(this.Sql);
                    if (this.Ds.Tables[0].Rows.Count == 1)
                    {
                        this.Sql = @"update Rent
                    set bikeID = '" + this.txtBikeID.Text + @"',
                    customerID = '" + this.txtSearchCustomer.Text + @"',
                    accessoryID = '" + this.txtCustomerID.Text + @"',
                    rentalSDate = '" + formattedStartDate + @"',
                    rentalEDate = '" + formattedEndDate + @"',
                    cost = '" + this.TxtCost.Text + @"'
                    where rentID = '" + this.txtRentID.Text + "';";
                        int count = this.Da.ExecuteUpdateQuery(this.Sql);
                        if (count == 1)
                        {
                            MessageBox.Show(this.txtRentID.Text + " has been updated properly");
                        }
                        else
                        {
                            MessageBox.Show("Rent data updation failed");
                        }
                    }
                    else
                    {

                        this.Sql = @"insert into Rent
                    values ('" + this.txtRentID.Text + "', '" + this.txtBikeID.Text + "', '" + this.txtCustomerID.Text + "', '" + this.txtAccessoryID.Text + "','" + formattedStartDate + "', '" + formattedEndDate + "', '" + this.TxtCost.Text + "','" + this.employeid + "','InRent'); ";

                        int count = this.Da.ExecuteUpdateQuery(this.Sql);
                        if (count == 1)
                        {
                            MessageBox.Show(this.txtRentID.Text + " has been added properly");
                            this.GenerateRentID();
                            this.Sql = @"UPDATE Bike
                            SET availabilityStatus = 'Rented'
                            WHERE bikeID = '" + this.txtBikeID.Text + "';";
                            this.Da.ExecuteUpdateQuery(this.Sql);

                            this.Sql = "select * from Accessory where accessoryID = '" + this.txtAccessoryID.Text + "';";
                            DataTable Dq = this.Da.ExecuteQueryTable(this.Sql);
                            int q = Convert.ToInt32(Dq.Rows[0]["quantity"].ToString());
                            string p = Convert.ToString(q - 1);
                            //MessageBox.Show(p);
                            this.Sql = @"UPDATE Accessory
                            SET quantity = '" + p+ @"'
                            WHERE accessoryID = '" + this.txtAccessoryID.Text + "';";
                            this.Da.ExecuteUpdateQuery(Sql);
                        }
                        else
                        {
                            MessageBox.Show("Rent data insertion failed");
                        }
                    }
                    this.PopulateBikeGridView();
                    this.PopulateCustomerGridView();
                    this.PopulateAccessoryGridView();
                    this.PopulateRentGridView();
                    this.ClearAll();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error has occured during saving the rent data\n\n" + exc.Message);
                }
            }
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvRent.CurrentRow.Cells["rentID"].Value.ToString();
                string bikeid = this.dgvRent.CurrentRow.Cells["rbikeID"].Value.ToString();
                string acid = this.dgvRent.CurrentRow.Cells["accessory_ID"].Value.ToString();
                string status = this.dgvRent.CurrentRow.Cells["status"].Value.ToString();

                if (status == "Received")
                {
                    MessageBox.Show("Alredy Received!!");
                }
                else
                {
                    //MessageBox.Show(bikeid);
                    this.Sql = @"UPDATE Bike
                    SET availabilityStatus = 'Available'
                    WHERE bikeID = '" + bikeid + "';";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);

                    this.Sql = @"UPDATE Rent
                    SET status = 'Received'
                    WHERE rentID = '" + id + "';";
                    this.Da.ExecuteUpdateQuery(this.Sql);

                    this.Sql = "select * from Accessory where accessoryID = '" + acid + "';";
                    DataTable Dq = this.Da.ExecuteQueryTable(this.Sql);
                    int q = Convert.ToInt32(Dq.Rows[0]["quantity"].ToString());
                    string p = Convert.ToString(q + 1);
                    //MessageBox.Show(p);
                    this.Sql = @"UPDATE Accessory
                            SET quantity = '" + p + @"'
                            WHERE accessoryID = '" + acid + "';";
                    this.Da.ExecuteUpdateQuery(Sql);
                    if (count == 1)
                    {
                        MessageBox.Show(id + " has been Received");
                    }
                    else
                    {
                        MessageBox.Show("Rent data receive failed");
                    }
                }
                this.PopulateBikeGridView();
                this.PopulateCustomerGridView();
                this.PopulateAccessoryGridView();
                this.PopulateRentGridView();
                this.ClearAll();
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
        }

        private void txtSearchBike_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from Bike where bikeName like '" + this.txtSearchBike.Text + "%';";
            this.PopulateBikeGridView(this.Sql);
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from Customer where customerName like '" + this.txtSearchCustomer.Text + "%';";
            this.PopulateCustomerGridView(this.Sql);
        }

        private void txtSearchAccessory_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from Accessory where accessoryName like '" + this.txtSearchAccessory.Text + "%';";
            this.PopulateAccessoryGridView(this.Sql);
        }

        private void dgvBike_DoubleClick(object sender, EventArgs e)
        {
            if (dgvBike.CurrentRow != null)
            {
                try
                {
                    this.txtBikeID.ReadOnly = true;
                    this.txtBikeID.Text = dgvBike.CurrentRow.Cells["bikeID"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading bike details: " + ex.Message);
                }
            }
        }

        private void dgvAccessory_DoubleClick(object sender, EventArgs e)
        {
            if (dgvAccessory.CurrentRow != null)
            {
                try
                {
                    this.txtAccessoryID.ReadOnly = true;
                    this.txtAccessoryID.Text = dgvAccessory.CurrentRow.Cells["accessoryID"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading accessory details: " + ex.Message);
                }
            }
        }

        private void dgvAccessory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LBikeID_Click(object sender, EventArgs e)
        {

        }

        private void TxtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvRent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow != null)
            {
                try
                {
                    this.txtCustomerID.ReadOnly = true;
                    this.txtCustomerID.Text = dgvCustomer.CurrentRow.Cells["customerID"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customer details: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from Accessory where accessoryID like '" + this.txtAccessoryID.Text + "%';";
            DataTable Dq = this.Da.ExecuteQueryTable(this.Sql);
            int q = Convert.ToInt32(Dq.Rows[0]["quantity"].ToString());
            if (string.IsNullOrWhiteSpace(this.txtBikeID.Text) ||
                string.IsNullOrWhiteSpace(this.txtCustomerID.Text)
                )
            {
                MessageBox.Show("You Have to choose Bike and Customer!!");
            }
            else if (q == 0)
            {
                MessageBox.Show("This accessory is Out of Stock!!");
            }
            else
            {
                this.Sql = "select * from Bike where bikeID like '" + this.txtBikeID.Text + "%';";
                DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
                string price = Dt.Rows[0]["rentPrice"].ToString();
                int RentPrice = Convert.ToInt32(price);
                DateTime d1 = this.DTRentalEndDate.Value;
                d1 = d1.Date;
                DateTime d2 = this.DTRentalStartDate.Value;
                d2 = d2.Date;
                int cnt = (d1 - d2).Days;
                //MessageBox.Show(cnt.ToString());
                cnt++;
                if (cnt <= 0)
                {
                    MessageBox.Show("Ivalid Date!!");
                }
                else
                {
                    int totalPrice = cnt * RentPrice;
                    this.TxtCost.Text = totalPrice.ToString();
                }
            }
        }

        private void dgvRent_DoubleClick(object sender, EventArgs e)
        {
            this.txtRentID.Text = this.dgvRent.CurrentRow.Cells["rentID"].Value.ToString();
        }
    }
}
