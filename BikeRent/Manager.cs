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
    public partial class Manager : Form
    {
        public string employeeId { get; set; }
        //public string password { get; set; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }


        public Manager(string empid)
        {
            employeeId = empid;
            InitializeComponent();
            this.Da = new DataAccess();
            LoadUserControl(new Home_Manager_(this.employeeId));
        }

        private void LoadUserControl(UserControl uc)
        {
            pnlManagerContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlManagerContainer.Controls.Add(uc);
        }



        private void btManageBike_Click(object sender, EventArgs e)
        {
            //ManageBike mb = new ManageBike();
            LoadUserControl(new ManageBike(employeeId));
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btBikeMaintenance_Click(object sender, EventArgs e)
        {
            LoadUserControl(new BikeMaintenance());
        }

        private void btManageAccessories_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ManageAccessories());
        }

        private void btAddOffer_Click(object sender, EventArgs e)
        {
            //LoadUserControl(new AddOffer());
        }

        private void pnlManagerContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Home_Manager_(this.employeeId));
        }
    }
}
