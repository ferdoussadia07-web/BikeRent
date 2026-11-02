using cashhistory;
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
    public partial class Cashier : Form
    {
        public string employeeid {get;set;}

        public Cashier(string empid)
        {
            employeeid = empid;
            InitializeComponent();
            LoadUserControl(new CashierHistory(this.employeeid));
        }
        private void LoadUserControl(UserControl uc)
        {
            pnlCashierContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlCashierContainer.Controls.Add(uc);
        }
        private void pnlCashierContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnManageRent_Click(object sender, EventArgs e)
        {
            ManageRent m = new ManageRent();
            m.employeid = this.employeeid;
            LoadUserControl(m);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ManageCustomer());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadUserControl(new CashierHistory(this.employeeid));
        }
    }
}
