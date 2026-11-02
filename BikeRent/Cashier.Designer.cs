namespace BikeRent
{
    partial class Cashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnManageCustomer = new System.Windows.Forms.Button();
            this.picCashier = new System.Windows.Forms.PictureBox();
            this.btnManageRent = new System.Windows.Forms.Button();
            this.pnlCashierContainer = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCashier)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(93)))));
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnHome);
            this.pnlSidebar.Controls.Add(this.btnManageCustomer);
            this.pnlSidebar.Controls.Add(this.picCashier);
            this.pnlSidebar.Controls.Add(this.btnManageRent);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(300, 1000);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Location = new System.Drawing.Point(0, 420);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(300, 100);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.Location = new System.Drawing.Point(0, 120);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(300, 100);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.FlatAppearance.BorderSize = 0;
            this.btnManageCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCustomer.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnManageCustomer.Location = new System.Drawing.Point(0, 320);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(300, 100);
            this.btnManageCustomer.TabIndex = 2;
            this.btnManageCustomer.Text = "Manage Customer";
            this.btnManageCustomer.UseVisualStyleBackColor = true;
            this.btnManageCustomer.Click += new System.EventHandler(this.btnManageCustomer_Click);
            // 
            // picCashier
            // 
            this.picCashier.Image = global::BikeRent.Properties.Resources.bike_logo;
            this.picCashier.Location = new System.Drawing.Point(0, 0);
            this.picCashier.Margin = new System.Windows.Forms.Padding(0);
            this.picCashier.Name = "picCashier";
            this.picCashier.Size = new System.Drawing.Size(300, 120);
            this.picCashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCashier.TabIndex = 1;
            this.picCashier.TabStop = false;
            // 
            // btnManageRent
            // 
            this.btnManageRent.FlatAppearance.BorderSize = 0;
            this.btnManageRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageRent.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnManageRent.Location = new System.Drawing.Point(0, 220);
            this.btnManageRent.Name = "btnManageRent";
            this.btnManageRent.Size = new System.Drawing.Size(300, 100);
            this.btnManageRent.TabIndex = 0;
            this.btnManageRent.Text = "Manage Rent";
            this.btnManageRent.UseVisualStyleBackColor = true;
            this.btnManageRent.Click += new System.EventHandler(this.btnManageRent_Click);
            // 
            // pnlCashierContainer
            // 
            this.pnlCashierContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCashierContainer.Location = new System.Drawing.Point(300, 0);
            this.pnlCashierContainer.Name = "pnlCashierContainer";
            this.pnlCashierContainer.Size = new System.Drawing.Size(900, 1000);
            this.pnlCashierContainer.TabIndex = 1;
            this.pnlCashierContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCashierContainer_Paint);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1000);
            this.Controls.Add(this.pnlCashierContainer);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCashier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlCashierContainer;
        private System.Windows.Forms.Button btnManageRent;
        private System.Windows.Forms.PictureBox picCashier;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnManageCustomer;
        private System.Windows.Forms.Button btnLogout;
    }
}