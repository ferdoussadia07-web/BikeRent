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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            LoadUserControl(new AdminHome());
        }
        private void LoadUserControl(UserControl uc)
        {
            pnlAdminContaier.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlAdminContaier.Controls.Add(uc);
        }

        private void pnlAdminContaier_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ManageEmployee());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void btnManageBike_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ManageBike("Admin"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageRent mn = new ManageRent();
            mn.employeid = "Admin";
            LoadUserControl(mn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AdminHome());
        }
    }
}
