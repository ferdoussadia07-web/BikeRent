namespace BikeRent
{
    partial class Employee
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlAdminSidebar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnManageBike = new System.Windows.Forms.Button();
            this.btnManageEmployee = new System.Windows.Forms.Button();
            this.pnlAdminContaier = new System.Windows.Forms.Panel();
            this.pnlAdminSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 440);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(300, 80);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlAdminSidebar
            // 
            this.pnlAdminSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlAdminSidebar.Controls.Add(this.pictureBox1);
            this.pnlAdminSidebar.Controls.Add(this.btnHome);
            this.pnlAdminSidebar.Controls.Add(this.button2);
            this.pnlAdminSidebar.Controls.Add(this.btnManageBike);
            this.pnlAdminSidebar.Controls.Add(this.btnManageEmployee);
            this.pnlAdminSidebar.Controls.Add(this.btnLogout);
            this.pnlAdminSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAdminSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminSidebar.Name = "pnlAdminSidebar";
            this.pnlAdminSidebar.Size = new System.Drawing.Size(300, 1000);
            this.pnlAdminSidebar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::BikeRent.Properties.Resources.Screenshot_2025_09_10_190759;
            this.pictureBox1.InitialImage = global::BikeRent.Properties.Resources.ChatGPT_Image_Sep_1__2025__10_49_27_PM;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 120);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(300, 80);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 360);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 80);
            this.button2.TabIndex = 4;
            this.button2.Text = "Manage Rent";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnManageBike
            // 
            this.btnManageBike.AutoSize = true;
            this.btnManageBike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnManageBike.FlatAppearance.BorderSize = 0;
            this.btnManageBike.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.btnManageBike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBike.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBike.ForeColor = System.Drawing.Color.White;
            this.btnManageBike.Location = new System.Drawing.Point(0, 280);
            this.btnManageBike.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageBike.Name = "btnManageBike";
            this.btnManageBike.Size = new System.Drawing.Size(300, 80);
            this.btnManageBike.TabIndex = 3;
            this.btnManageBike.Text = "Manage Bike";
            this.btnManageBike.UseVisualStyleBackColor = false;
            this.btnManageBike.Click += new System.EventHandler(this.btnManageBike_Click);
            // 
            // btnManageEmployee
            // 
            this.btnManageEmployee.AutoSize = true;
            this.btnManageEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnManageEmployee.FlatAppearance.BorderSize = 0;
            this.btnManageEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.btnManageEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageEmployee.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployee.ForeColor = System.Drawing.Color.White;
            this.btnManageEmployee.Location = new System.Drawing.Point(0, 200);
            this.btnManageEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageEmployee.Name = "btnManageEmployee";
            this.btnManageEmployee.Size = new System.Drawing.Size(300, 80);
            this.btnManageEmployee.TabIndex = 2;
            this.btnManageEmployee.Text = "Manage Employee";
            this.btnManageEmployee.UseVisualStyleBackColor = false;
            this.btnManageEmployee.Click += new System.EventHandler(this.btnManageEmployee_Click);
            // 
            // pnlAdminContaier
            // 
            this.pnlAdminContaier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlAdminContaier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminContaier.Location = new System.Drawing.Point(300, 0);
            this.pnlAdminContaier.Name = "pnlAdminContaier";
            this.pnlAdminContaier.Size = new System.Drawing.Size(900, 1000);
            this.pnlAdminContaier.TabIndex = 2;
            this.pnlAdminContaier.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAdminContaier_Paint);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 1000);
            this.Controls.Add(this.pnlAdminContaier);
            this.Controls.Add(this.pnlAdminSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.pnlAdminSidebar.ResumeLayout(false);
            this.pnlAdminSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlAdminSidebar;
        private System.Windows.Forms.Button btnManageEmployee;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnManageBike;
        private System.Windows.Forms.Panel pnlAdminContaier;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}