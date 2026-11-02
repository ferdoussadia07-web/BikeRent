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
    public partial class Login : Form
    {
        Validation va = new Validation();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUsername.Text) || string.IsNullOrEmpty(this.txtPassword.Text))
            {
                MessageBox.Show("Both Filleds are Requied!!!");
            }
            else
            {
                string sql = @"select * from Login where Username = '" + this.txtUsername.Text + "' and Password = '" + this.txtPassword.Text + "';";

                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);
                //string userType = ds..["Type"].ToString();
                string id, pass,tid,tpass;
                tid = this.txtUsername.Text.ToString();
                tpass = this.txtPassword.Text.ToString();
                if (ds.Tables[0].Rows.Count == 1)
                {
                    id = ds.Tables[0].Rows[0][0].ToString();
                    pass = ds.Tables[0].Rows[0][1].ToString();
                    if (va.isEqual(id, tid) && va.isEqual(pass, tpass))
                    {
                        string value = ds.Tables[0].Rows[0][2].ToString();
                        if (value == "Admin")
                        {
                            Employee d = new Employee();
                            this.Hide();
                            d.Show();
                        }
                        else if (value == "Manager")
                        {

                            Manager m = new Manager(this.txtUsername.Text.ToString());
                            //m.employeeId = this.txtUsername.Text.ToString();
                            //m.password = this.txtPassword.Text;
                            this.Hide();
                            m.Show();
                        }
                        else if (value == "Cashier")
                        {
                            Cashier c = new Cashier(this.txtUsername.Text.ToString());
                            this.Hide();
                            c.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username Or Password!!");
                    }
                }
                else
                {
                    MessageBox.Show("Login Invalid!!!");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPassword.Checked)
            {
                this.txtPassword.PasswordChar = '\0';
            }
            else
            {
                this.txtPassword.PasswordChar = '*';
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void lblDevelopedBy_Click(object sender, EventArgs e)
        {
            moreabout mo = new moreabout();
            this.Hide();
            mo.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
