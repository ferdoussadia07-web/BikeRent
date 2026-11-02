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
    public partial class AdminHome : UserControl
    {
        public string employeid { get; set; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public AdminHome()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            Generate();
        }
        private void Generate()
        {
            this.Sql = "select cost from Rent;";
            DataTable Dq = this.Da.ExecuteQueryTable(this.Sql);
            int cnt = Dq.Rows.Count;
            int total = 0;
            for(int i = 0;i < cnt; i++)
            {
                total += Convert.ToInt32(Dq.Rows[i]["cost"].ToString());
            }
            this.txtRevenue.Text = total.ToString();
            this.txtTotalRent.Text = cnt.ToString();

            this.Sql = "select * from Bike;";
            DataTable Db = this.Da.ExecuteQueryTable(this.Sql);
            cnt = Db.Rows.Count;
            this.txtTotalBike.Text = cnt.ToString();
        }
        private void PopulateGridView(string sql = "select * from Rent;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvAdminView.AutoGenerateColumns = false;
            this.dgvAdminView.DataSource = this.Ds.Tables[0];


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtUpdatePassword.Text))
            {
                MessageBox.Show("Empty Field!!");
            }
            else
            {
                this.Sql = @"update Login
                    set Password = '" + this.txtUpdatePassword.Text + @"'
                    where Type = 'Admin';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show("Update Successfull!!");
                }
            }
            Clear();
        }
        private void Clear()
        {
            this.txtSearch.Clear();
            this.txtTotalRent.Clear();
            PopulateGridView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from rent where rentID like '" + this.txtSearch.Text + @"%'";
            PopulateGridView(this.Sql);
        }
    }
}
