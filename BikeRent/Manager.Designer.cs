namespace BikeRent
{
    partial class Manager
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
            this.pnlManagerSideBar = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btLogout = new System.Windows.Forms.Button();
            this.btManageAccessories = new System.Windows.Forms.Button();
            this.btBikeMaintenance = new System.Windows.Forms.Button();
            this.btManageBike = new System.Windows.Forms.Button();
            this.pnlManagerContainer = new System.Windows.Forms.Panel();
            this.pnlManagerSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlManagerSideBar
            // 
            this.pnlManagerSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(151)))), ((int)(((byte)(149)))));
            this.pnlManagerSideBar.Controls.Add(this.btnHome);
            this.pnlManagerSideBar.Controls.Add(this.pictureBox1);
            this.pnlManagerSideBar.Controls.Add(this.btLogout);
            this.pnlManagerSideBar.Controls.Add(this.btManageAccessories);
            this.pnlManagerSideBar.Controls.Add(this.btBikeMaintenance);
            this.pnlManagerSideBar.Controls.Add(this.btManageBike);
            this.pnlManagerSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlManagerSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlManagerSideBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlManagerSideBar.Name = "pnlManagerSideBar";
            this.pnlManagerSideBar.Size = new System.Drawing.Size(300, 1000);
            this.pnlManagerSideBar.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(151)))), ((int)(((byte)(149)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Linen;
            this.btnHome.Location = new System.Drawing.Point(0, 120);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(300, 100);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(154)))), ((int)(((byte)(146)))));
            this.pictureBox1.Image = global::BikeRent.Properties.Resources.ChatGPT_Image_Sep_12__2025__09_56_16_PM1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(151)))), ((int)(((byte)(149)))));
            this.btLogout.FlatAppearance.BorderSize = 0;
            this.btLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.Color.Linen;
            this.btLogout.Location = new System.Drawing.Point(0, 520);
            this.btLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(300, 100);
            this.btLogout.TabIndex = 4;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btManageAccessories
            // 
            this.btManageAccessories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(151)))), ((int)(((byte)(149)))));
            this.btManageAccessories.FlatAppearance.BorderSize = 0;
            this.btManageAccessories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.btManageAccessories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btManageAccessories.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btManageAccessories.ForeColor = System.Drawing.Color.Linen;
            this.btManageAccessories.Location = new System.Drawing.Point(0, 420);
            this.btManageAccessories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btManageAccessories.Name = "btManageAccessories";
            this.btManageAccessories.Size = new System.Drawing.Size(300, 100);
            this.btManageAccessories.TabIndex = 2;
            this.btManageAccessories.Text = "Manage Accessories";
            this.btManageAccessories.UseVisualStyleBackColor = false;
            this.btManageAccessories.Click += new System.EventHandler(this.btManageAccessories_Click);
            // 
            // btBikeMaintenance
            // 
            this.btBikeMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(151)))), ((int)(((byte)(149)))));
            this.btBikeMaintenance.FlatAppearance.BorderSize = 0;
            this.btBikeMaintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.btBikeMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBikeMaintenance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBikeMaintenance.ForeColor = System.Drawing.Color.Linen;
            this.btBikeMaintenance.Location = new System.Drawing.Point(0, 320);
            this.btBikeMaintenance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btBikeMaintenance.Name = "btBikeMaintenance";
            this.btBikeMaintenance.Size = new System.Drawing.Size(300, 100);
            this.btBikeMaintenance.TabIndex = 1;
            this.btBikeMaintenance.Text = "Bike Maintenance";
            this.btBikeMaintenance.UseVisualStyleBackColor = false;
            this.btBikeMaintenance.Click += new System.EventHandler(this.btBikeMaintenance_Click);
            // 
            // btManageBike
            // 
            this.btManageBike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(151)))), ((int)(((byte)(149)))));
            this.btManageBike.FlatAppearance.BorderSize = 0;
            this.btManageBike.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.btManageBike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btManageBike.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btManageBike.ForeColor = System.Drawing.Color.Linen;
            this.btManageBike.Location = new System.Drawing.Point(0, 220);
            this.btManageBike.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btManageBike.Name = "btManageBike";
            this.btManageBike.Size = new System.Drawing.Size(300, 100);
            this.btManageBike.TabIndex = 0;
            this.btManageBike.Text = "Manage Bike";
            this.btManageBike.UseVisualStyleBackColor = false;
            this.btManageBike.Click += new System.EventHandler(this.btManageBike_Click);
            // 
            // pnlManagerContainer
            // 
            this.pnlManagerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManagerContainer.Location = new System.Drawing.Point(300, 0);
            this.pnlManagerContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlManagerContainer.Name = "pnlManagerContainer";
            this.pnlManagerContainer.Size = new System.Drawing.Size(900, 1000);
            this.pnlManagerContainer.TabIndex = 1;
            this.pnlManagerContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlManagerContainer_Paint);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 1000);
            this.Controls.Add(this.pnlManagerContainer);
            this.Controls.Add(this.pnlManagerSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.pnlManagerSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManagerSideBar;
        private System.Windows.Forms.Panel pnlManagerContainer;
        private System.Windows.Forms.Button btManageBike;
        private System.Windows.Forms.Button btManageAccessories;
        private System.Windows.Forms.Button btBikeMaintenance;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
    }
}