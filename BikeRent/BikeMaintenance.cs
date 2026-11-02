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
    public partial class BikeMaintenance : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private string Sql1 {  set; get; }
        private Validation vd = new Validation();
        public BikeMaintenance()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            GenerateMaintenanceID();
            PopulateGridView2();
        }

        private void PopulateGridView(string sql = "select * from BikeMaintenance;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvMaintenanceList.AutoGenerateColumns = false;
            this.dgvMaintenanceList.DataSource = this.Ds.Tables[0];
        }
        private void PopulateGridView2(string sql = "select * from Bike where availabilityStatus = 'Available';")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvbikeDetails.AutoGenerateColumns = false;
            this.dgvbikeDetails.DataSource = this.Ds.Tables[0];
        }

        private void GenerateMaintenanceID()
        {
            this.Sql = "select * from BikeMaintenance order by maintenanceID desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);

            string newMaintenanceID;

            if (Dt.Rows.Count > 0)
            {
                string bikeID = Dt.Rows[0]["maintenanceID"].ToString();
                string[] str = bikeID.Split('M');
                int n = Convert.ToInt32(str[1]);
                newMaintenanceID = "M" + (++n).ToString("d3");
            }
            else
            {
                newMaintenanceID = "M001";
            }

            this.txtMaintenanceID.Text = newMaintenanceID;
        }

        private void ClearAll()
        {
            this.txtMaintenanceID.Clear();
            this.txtMaintenanceID.ReadOnly = true;
            this.txtBikeID.Clear();
            this.txtBikeName.Clear();
            this.cbMaintenanceType.SelectedIndex = -1;
            this.dateMDate.Text = "";
            this.dateCDate.Text = "";
            this.txtcostOfMaintenance.Clear();
            this.txtSearch.Clear();
            GenerateMaintenanceID();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DateTime d1 = this.dateMDate.Value.Date;
            DateTime d2 = this.dateCDate.Value.Date;

            if (string.IsNullOrWhiteSpace(this.txtBikeID.Text) ||
                string.IsNullOrWhiteSpace(this.cbMaintenanceType.Text) ||
                string.IsNullOrWhiteSpace(this.dateMDate.Text) ||
                string.IsNullOrWhiteSpace(this.dateCDate.Text) ||
                string.IsNullOrWhiteSpace(this.txtcostOfMaintenance.Text))
            {
                MessageBox.Show("All Fields are Required!!");
            }
            else if (!vd.isInt(this.txtcostOfMaintenance.Text.ToString()))
            {
                MessageBox.Show("Invalid Cost!!");
            }
            else if (d1 > d2)
            {
                MessageBox.Show("Invalid Date!!");
            }
            else
            {
                try
                {

                    string formattedDate = this.dateMDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    string formattedDate1 = this.dateCDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

                    this.Sql = "select * from BikeMaintenance where maintenanceID = '" + this.txtMaintenanceID.Text + "'";
                    this.Ds = this.Da.ExecuteQuery(this.Sql);

                    if (this.Ds.Tables[0].Rows.Count == 1)
                    {
                        this.Sql = @"update BikeMaintenance
                            set bikeID = '" + this.txtBikeID.Text + @"',
                            maintenanceType = '" + this.cbMaintenanceType.Text + @"',
                            maintenanceDate = '" + formattedDate + @"',
                            completionDate = '" + formattedDate1 + @"',
                            costOfMaintenance = '" + this.txtcostOfMaintenance.Text + @"'
                            where maintenanceID = '" + this.txtMaintenanceID.Text + "';";
                        int count = this.Da.ExecuteUpdateQuery(this.Sql);
                        if (count == 1)
                        {
                            MessageBox.Show(this.txtMaintenanceID.Text + " has been updated properly");
                        }
                        else
                        {
                            MessageBox.Show("Maintenance data updation failed");
                        }
                    }

                    else
                    {
                        DataAccess da = new DataAccess();
                        string sql = @"select availabilityStatus from Bike where bikeId = '" + this.txtBikeID.Text + "';";
                        DataSet ds = da.ExecuteQuery(sql);
                        string sql1 = @"select * from BikeMaintenance where bikeId = '" + this.txtBikeID.Text + "';";
                        DataSet ds1 = da.ExecuteQuery(sql1);
                        //ds = this.da.ExecuteQuery(sql);
                        string value = ds.Tables[0].Rows[0][0].ToString();
                        //MessageBox.Show("hello");
                        if (ds.Tables[0].Rows[0][0].ToString() != "Available")
                        {
                            MessageBox.Show("Bike is Not Available!!");
                        }
                        else if (ds1.Tables[0].Rows.Count > 0)
                        {
                            MessageBox.Show("Bike is Alredy in Maintenance!!");
                        }
                        else
                        {
                            this.Sql = @"UPDATE Bike
                            SET availabilityStatus = 'Maintenance'
                            WHERE bikeID = '" + this.txtBikeID.Text + "';";
                            Da.ExecuteUpdateQuery(Sql);
                            this.Sql = @"insert into BikeMaintenance
                    values ('" + this.txtMaintenanceID.Text + "', '" + this.txtBikeID.Text + "', '" + this.cbMaintenanceType.Text + "', '" + formattedDate + "','" + formattedDate1 + "', '" + this.txtcostOfMaintenance.Text + "'); ";

                            int count = this.Da.ExecuteUpdateQuery(this.Sql);
                            if (count == 1)
                            {
                                MessageBox.Show(this.txtMaintenanceID.Text + " has been added properly");
                                this.GenerateMaintenanceID();
                            }
                            else
                            {
                                MessageBox.Show("Maintenance data insertion failed");
                            }
                        }
                    }
                    this.PopulateGridView2();
                    this.PopulateGridView();
                    this.ClearAll();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error has occured during saving the maintenance data\n\n" + exc.Message);
                }
            }
        
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvMaintenanceList.CurrentRow.Cells["maintenanceID"].Value.ToString();
                string bikeid = this.dgvMaintenanceList.CurrentRow.Cells["bikeID"].Value.ToString();
                this.Sql = @"UPDATE Bike
                SET availabilityStatus = 'Available'
                WHERE bikeID = '" + bikeid + "';";
                this.Da.ExecuteUpdateQuery(this.Sql);

                this.Sql = @"delete from BikeMaintenance
                        where maintenanceID = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(id + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Maintenance data deletion failed");
                }
                this.PopulateGridView();
                this.PopulateGridView2();

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
            this.Sql = "select * from BikeMaintenance where maintenanceID like '" + this.txtSearch.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void dgvMaintenanceList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMaintenanceList.CurrentRow != null)
            {
                try
                {
                    this.txtMaintenanceID.ReadOnly = true;
                    this.txtMaintenanceID.Text = dgvMaintenanceList.CurrentRow.Cells["maintenanceID"].Value?.ToString();
                    this.txtBikeID.Text = dgvMaintenanceList.CurrentRow.Cells["bikeID"].Value?.ToString();
                    this.cbMaintenanceType.Text = dgvMaintenanceList.CurrentRow.Cells["maintenanceType"].Value?.ToString();
                    this.dateMDate.Text = dgvMaintenanceList.CurrentRow.Cells["maintenanceDate"].Value?.ToString();
                    this.dateCDate.Text = dgvMaintenanceList.CurrentRow.Cells["completionDate"].Value?.ToString();
                    this.txtcostOfMaintenance.Text = dgvMaintenanceList.CurrentRow.Cells["costOfMaintenance"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading maintenance details: " + ex.Message);
                }
            }
        }

        private void BikeMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void dgvbikeDetails_DoubleClick(object sender, EventArgs e)
        {
            this.txtBikeName.Text = dgvbikeDetails.CurrentRow.Cells["cbikeName"].Value?.ToString();
            this.txtBikeID.Text = dgvbikeDetails.CurrentRow.Cells["cbikeID"].Value?.ToString();
        }

        private void txtBikeID_TextChanged(object sender, EventArgs e)
        {
            //this.Sql = "select * from Bike where  bikeID like '" + this.txtBikeID.Text + "%';";
            //PopulateGridView2(Sql);

        }

        private void txtBikeName_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from Bike where  availabilityStatus = 'Available' and  bikeName like '" + this.txtBikeName.Text + "%';";
            PopulateGridView2(Sql);
        }
    }
}
