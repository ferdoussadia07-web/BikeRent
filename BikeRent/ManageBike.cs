using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BikeRent
{
    public partial class ManageBike : UserControl
    {
        string employeeId { get; set; }
        //string password { get; set; }

        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        Validation vd = new Validation();
        
        public ManageBike(string s1)
        {
            this.Da = new DataAccess();
            this.employeeId = s1;
            InitializeComponent();
            PopulateGridView();
            GenerateBikeID();
        }

        private void PopulateGridView(string sql = "select * from Bike ORDER BY bikeID;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvBikeList.AutoGenerateColumns = false;
            this.dgvBikeList.DataSource = this.Ds.Tables[0];
        }

        private void ManageBike_Load(object sender, EventArgs e)
        {

        }

        private void GenerateBikeID()
        {
            this.Sql = "select * from Bike order by bikeID desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);

            string newBikeID;

            if (Dt.Rows.Count > 0)
            {
                string bikeID = Dt.Rows[0]["bikeID"].ToString();
                string[] str = bikeID.Split('B');
                int n = Convert.ToInt32(str[1]);
                newBikeID = "B" + (++n).ToString("d3");
            }
            else
            {
                newBikeID = "B001";
            }

            this.txtBikeID.Text = newBikeID;
        }

        private void ClearAll()
        {
            this.txtBikeID.Clear();
            this.txtBikeID.ReadOnly = true;
            this.txtBikeName.Clear();
            this.txtBikeBrand.Clear();
            this.cbType.SelectedIndex = -1;
            this.txtLicensePlateNo.Clear();
            this.txtRentPrice.Clear();
            this.cbAvailabilityStatus.SelectedIndex = -1;
            //this.datePurchaseDate.Text = "";
            //this.txtEmployeeID.Clear();
            this.txtSearch.Clear();
            GenerateBikeID();
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from Bike where licensePlateNo = '" + this.txtLicensePlateNo.Text + "'";
            this.Ds = this.Da.ExecuteQuery(this.Sql);
            int cnt = Ds.Tables[0].Rows.Count;
            if (string.IsNullOrWhiteSpace(txtBikeID.Text)
            || string.IsNullOrWhiteSpace(txtBikeName.Text)
            || string.IsNullOrWhiteSpace(txtBikeBrand.Text)
            || cbType.SelectedIndex == -1
            || string.IsNullOrWhiteSpace(txtLicensePlateNo.Text)
            || string.IsNullOrWhiteSpace(txtRentPrice.Text)
            || cbAvailabilityStatus.SelectedIndex == -1)
            {
                MessageBox.Show("All Fields are Required");
            }
            else if (!vd.isInt(this.txtRentPrice.Text.ToString()))
            {
                MessageBox.Show("Invalid Price!!");
            }
            else if(cnt > 0)
            {
                MessageBox.Show("License Number Alredy Exist!");
            }
            else
            {
                try
                {


                    this.Sql = "select * from Bike where bikeID = '" + this.txtBikeID.Text + "'";
                    this.Ds = this.Da.ExecuteQuery(this.Sql);
                    if (this.Ds.Tables[0].Rows.Count == 1)
                    {
                        this.Sql = @"update Bike
                    set bikeName = '" + this.txtBikeName.Text + @"',
                    brand = '" + this.txtBikeBrand.Text + @"',
                    type = '" + this.cbType.Text + @"',
                    licensePlateNo = '" + this.txtLicensePlateNo.Text + @"',
                    rentPrice = '" + this.txtRentPrice.Text + @"',
                    availabilityStatus = '" + this.cbAvailabilityStatus.Text + @"',
                    employeeID = '" + this.employeeId + @"'
                    where bikeID = '" + this.txtBikeID.Text + "';";
                        int count = this.Da.ExecuteUpdateQuery(this.Sql);
                        if (count == 1)
                        {
                            MessageBox.Show(this.txtBikeID.Text + " has been updated properly");
                        }
                        else
                        {
                            MessageBox.Show("Bike data updation failed");
                        }
                    }
                    else
                    {
                        this.Sql = @"insert into Bike
                    values ('" + this.txtBikeID.Text + "', '" + this.txtBikeName.Text + "', '" + this.txtBikeBrand.Text + "', '" + this.cbType.Text + "','" + this.txtLicensePlateNo.Text + "', '" + this.txtRentPrice.Text + "', '" + this.cbAvailabilityStatus.Text + "', '" + this.employeeId + "'); ";

                        int count = this.Da.ExecuteUpdateQuery(this.Sql);
                        if (count == 1)
                        {
                            MessageBox.Show(this.txtBikeID.Text + " has been added properly");
                            this.GenerateBikeID();
                        }
                        else
                        {
                            MessageBox.Show("Bike data insertion failed");
                        }
                    }
                    this.PopulateGridView();
                    this.ClearAll();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error has occured during saving the bike data\n\n" + exc.Message);
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvBikeList.CurrentRow.Cells["bikeID"].Value?.ToString();

                this.Sql = @"delete from Bike
                        where bikeID = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(id + " has been deleted"); 
                }
                else
                {
                    MessageBox.Show("Bike data deletion failed");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
        }

        private void dgvBikeList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvBikeList.CurrentRow != null)
            {
                try
                {
                    this.txtBikeID.ReadOnly = true;
                    this.txtBikeID.Text = dgvBikeList.CurrentRow.Cells["bikeID"].Value?.ToString();
                    this.txtBikeName.Text = dgvBikeList.CurrentRow.Cells["bikeName"].Value?.ToString();
                    this.txtBikeBrand.Text = dgvBikeList.CurrentRow.Cells["brand"].Value?.ToString();
                    this.cbType.Text = dgvBikeList.CurrentRow.Cells["type"].Value?.ToString();
                    this.txtLicensePlateNo.Text = dgvBikeList.CurrentRow.Cells["licensePlateNo"].Value?.ToString();
                    this.txtRentPrice.Text = dgvBikeList.CurrentRow.Cells["rentPrice"].Value?.ToString();
                    this.cbAvailabilityStatus.Text = dgvBikeList.CurrentRow.Cells["availabilityStatus"].Value?.ToString();
                    //this.datePurchaseDate.Text = dgvBikeList.CurrentRow.Cells["purchaseDate"].Value?.ToString();
                    //this.txtEmployeeID.Text = dgvBikeList.CurrentRow.Cells["employeeID"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading bike details: " + ex.Message);
                }
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
            //ClearAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from Bike where bikeName like '" + this.txtSearch.Text + @"%' 
             or bikeName like '" + this.txtSearch.Text + @"%' 
             or brand like '" + this.txtSearch.Text + @"%' 
             or type like '" + this.txtSearch.Text + @"%' 
             or licensePlateNo like '" + this.txtSearch.Text + @"%' 
             or rentPrice like '" + this.txtSearch.Text + @"%' 
             or availabilityStatus like '" + this.txtSearch.Text + @"%' 
             or employeeID like '" + this.txtSearch.Text + @"%';";
            this.PopulateGridView(this.Sql);
        }

        private void txtBikeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBikeName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
