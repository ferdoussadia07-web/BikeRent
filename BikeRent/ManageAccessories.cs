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
    public partial class ManageAccessories : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }

        public ManageAccessories()
        {
            this.Da = new DataAccess();
            InitializeComponent();
            PopulateGridView();
            GenerateAccessoryID();
        }

        private void PopulateGridView(string sql = "select * from Accessory;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvAccessoryList.AutoGenerateColumns = false;
            this.dgvAccessoryList.DataSource = this.Ds.Tables[0];
        }

        private void GenerateAccessoryID()
        {
            this.Sql = "select * from Accessory order by accessoryID desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);

            string newAccessoryID;

            if (Dt.Rows.Count > 0)
            {
                string accessoryID = Dt.Rows[0]["accessoryID"].ToString();
                string[] str = accessoryID.Split('A');
                int n = Convert.ToInt32(str[1]);
                newAccessoryID = "A" + (++n).ToString("d3");
            }
            else
            {
                newAccessoryID = "A001";
            }

            this.txtAccessoryID.Text = newAccessoryID;
        }

        private void ClearAll()
        {
            this.txtAccessoryID.Clear();
            this.txtAccessoryID.ReadOnly = true;
            this.txtAccessoryName.Clear();
            this.txtQuantity.Clear();

            GenerateAccessoryID();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "select * from Accessory where accessoryID = '" + this.txtAccessoryID.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    this.Sql = @"update Accessory
                    set accessoryName = '" + this.txtAccessoryName.Text + @"',
                    quantity = '" + this.txtQuantity.Text + @"'
                    where accessoryID = '" + this.txtAccessoryID.Text + "';";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show(this.txtAccessoryName.Text + " has been updated properly");
                    }
                    else
                    {
                        MessageBox.Show("Accessory data updation failed");
                    }
                }
                else
                {
                    this.Sql = @"insert into Accessory
                    values ('" + this.txtAccessoryID.Text + "', '" + this.txtAccessoryName.Text + "', '" + this.txtQuantity.Text + "'); ";

                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show(this.txtAccessoryName.Text + " has been added properly");
                        this.GenerateAccessoryID();
                    }
                    else
                    {
                        MessageBox.Show("Accessory data insertion failed");
                    }
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during saving the accessory data\n\n" + exc.Message);
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvAccessoryList.CurrentRow.Cells["accessoryID"].Value.ToString();
                string name = this.dgvAccessoryList.CurrentRow.Cells["accessoryName"].Value.ToString();

                this.Sql = @"delete from Accessory
                        where accessoryID = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(name + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Accessory data deletion failed");
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
            this.Sql = "select * from Accessory where accessoryID like '" + this.txtSearch.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void dgvAccessoryList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvAccessoryList.CurrentRow != null)
            {
                try
                {
                    this.txtAccessoryID.ReadOnly = true;
                    this.txtAccessoryID.Text = dgvAccessoryList.CurrentRow.Cells["accessoryID"].Value?.ToString();
                    this.txtAccessoryName.Text = dgvAccessoryList.CurrentRow.Cells["accessoryName"].Value?.ToString();
                    this.txtQuantity.Text = dgvAccessoryList.CurrentRow.Cells["quantity"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading accessory details: " + ex.Message);
                }
            }
        }

        private void ManageAccessories_Load(object sender, EventArgs e)
        {

        }
    }
}
