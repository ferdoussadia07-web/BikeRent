namespace BikeRent
{
    partial class AdminHome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalRent = new System.Windows.Forms.TextBox();
            this.lblTotalRent = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotalBike = new System.Windows.Forms.TextBox();
            this.lblTotalBike = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvAdminView = new System.Windows.Forms.DataGridView();
            this.rentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bikeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRentInformation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(333, 14);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(247, 58);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.txtRevenue);
            this.panel1.Controls.Add(this.lblRevenue);
            this.panel1.Location = new System.Drawing.Point(60, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 150);
            this.panel1.TabIndex = 1;
            // 
            // txtRevenue
            // 
            this.txtRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRevenue.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevenue.Location = new System.Drawing.Point(0, 60);
            this.txtRevenue.Multiline = true;
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.ReadOnly = true;
            this.txtRevenue.Size = new System.Drawing.Size(230, 90);
            this.txtRevenue.TabIndex = 1;
            this.txtRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRevenue
            // 
            this.lblRevenue.BackColor = System.Drawing.Color.SandyBrown;
            this.lblRevenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRevenue.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.Location = new System.Drawing.Point(0, 0);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(230, 60);
            this.lblRevenue.TabIndex = 0;
            this.lblRevenue.Text = "Revenue";
            this.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.txtTotalRent);
            this.panel2.Controls.Add(this.lblTotalRent);
            this.panel2.Location = new System.Drawing.Point(336, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 150);
            this.panel2.TabIndex = 2;
            // 
            // txtTotalRent
            // 
            this.txtTotalRent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalRent.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalRent.Location = new System.Drawing.Point(0, 60);
            this.txtTotalRent.Multiline = true;
            this.txtTotalRent.Name = "txtTotalRent";
            this.txtTotalRent.ReadOnly = true;
            this.txtTotalRent.Size = new System.Drawing.Size(230, 90);
            this.txtTotalRent.TabIndex = 1;
            this.txtTotalRent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalRent
            // 
            this.lblTotalRent.BackColor = System.Drawing.Color.SandyBrown;
            this.lblTotalRent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalRent.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRent.Location = new System.Drawing.Point(0, 0);
            this.lblTotalRent.Name = "lblTotalRent";
            this.lblTotalRent.Size = new System.Drawing.Size(230, 60);
            this.lblTotalRent.TabIndex = 0;
            this.lblTotalRent.Text = "Total Rent";
            this.lblTotalRent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.txtTotalBike);
            this.panel3.Controls.Add(this.lblTotalBike);
            this.panel3.Location = new System.Drawing.Point(610, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 150);
            this.panel3.TabIndex = 3;
            // 
            // txtTotalBike
            // 
            this.txtTotalBike.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalBike.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBike.Location = new System.Drawing.Point(0, 60);
            this.txtTotalBike.Multiline = true;
            this.txtTotalBike.Name = "txtTotalBike";
            this.txtTotalBike.ReadOnly = true;
            this.txtTotalBike.Size = new System.Drawing.Size(230, 90);
            this.txtTotalBike.TabIndex = 1;
            this.txtTotalBike.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalBike
            // 
            this.lblTotalBike.BackColor = System.Drawing.Color.SandyBrown;
            this.lblTotalBike.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalBike.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBike.Location = new System.Drawing.Point(0, 0);
            this.lblTotalBike.Name = "lblTotalBike";
            this.lblTotalBike.Size = new System.Drawing.Size(230, 60);
            this.lblTotalBike.TabIndex = 0;
            this.lblTotalBike.Text = "Total Bike";
            this.lblTotalBike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(60, 300);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 24);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Update Password";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(148, 300);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 32);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePassword.Location = new System.Drawing.Point(640, 292);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.Size = new System.Drawing.Size(200, 32);
            this.txtUpdatePassword.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(710, 360);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 50);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Green;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(539, 360);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 50);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvAdminView
            // 
            this.dgvAdminView.AllowUserToAddRows = false;
            this.dgvAdminView.AllowUserToDeleteRows = false;
            this.dgvAdminView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminView.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvAdminView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentID,
            this.bikeID,
            this.customerID,
            this.employeeID,
            this.Cost,
            this.status});
            this.dgvAdminView.Location = new System.Drawing.Point(60, 475);
            this.dgvAdminView.Name = "dgvAdminView";
            this.dgvAdminView.ReadOnly = true;
            this.dgvAdminView.RowHeadersWidth = 62;
            this.dgvAdminView.RowTemplate.Height = 28;
            this.dgvAdminView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminView.Size = new System.Drawing.Size(779, 425);
            this.dgvAdminView.TabIndex = 10;
            // 
            // rentID
            // 
            this.rentID.DataPropertyName = "rentID";
            this.rentID.HeaderText = "Rent ID";
            this.rentID.MinimumWidth = 8;
            this.rentID.Name = "rentID";
            this.rentID.ReadOnly = true;
            // 
            // bikeID
            // 
            this.bikeID.DataPropertyName = "bikeID";
            this.bikeID.HeaderText = "Bike ID";
            this.bikeID.MinimumWidth = 8;
            this.bikeID.Name = "bikeID";
            this.bikeID.ReadOnly = true;
            // 
            // customerID
            // 
            this.customerID.DataPropertyName = "customerID";
            this.customerID.HeaderText = "Customer ID";
            this.customerID.MinimumWidth = 8;
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            // 
            // employeeID
            // 
            this.employeeID.DataPropertyName = "employeeID";
            this.employeeID.HeaderText = "Employee ID";
            this.employeeID.MinimumWidth = 8;
            this.employeeID.Name = "employeeID";
            this.employeeID.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "cost";
            this.Cost.HeaderText = "Sale";
            this.Cost.MinimumWidth = 8;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // lblRentInformation
            // 
            this.lblRentInformation.AutoSize = true;
            this.lblRentInformation.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentInformation.Location = new System.Drawing.Point(60, 420);
            this.lblRentInformation.Name = "lblRentInformation";
            this.lblRentInformation.Size = new System.Drawing.Size(168, 24);
            this.lblRentInformation.TabIndex = 11;
            this.lblRentInformation.Text = "Rent Information:";
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRentInformation);
            this.Controls.Add(this.dgvAdminView);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtUpdatePassword);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWelcome);
            this.Name = "AdminHome";
            this.Size = new System.Drawing.Size(900, 1000);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTotalRent;
        private System.Windows.Forms.Label lblTotalRent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTotalBike;
        private System.Windows.Forms.Label lblTotalBike;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvAdminView;
        private System.Windows.Forms.Label lblRentInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bikeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}
