namespace cashhistory
{
    partial class CashierHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCashier = new System.Windows.Forms.DataGridView();
            this.rentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bikeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSellcount = new System.Windows.Forms.TextBox();
            this.LSellCount = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.LSearch = new System.Windows.Forms.Label();
            this.UpdateInfo = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNewValue = new System.Windows.Forms.TextBox();
            this.cbSelectField = new System.Windows.Forms.ComboBox();
            this.LNewValue = new System.Windows.Forms.Label();
            this.LSelectInfo = new System.Windows.Forms.Label();
            this.LUpdateInfo = new System.Windows.Forms.Label();
            this.txtContactInfo = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.LContactInfo = new System.Windows.Forms.Label();
            this.LAdress = new System.Windows.Forms.Label();
            this.LSalary = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.LCashierID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashier)).BeginInit();
            this.UpdateInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 40);
            this.label1.TabIndex = 33;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvCashier
            // 
            this.dgvCashier.AllowUserToAddRows = false;
            this.dgvCashier.AllowUserToDeleteRows = false;
            this.dgvCashier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCashier.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentID,
            this.bikeID,
            this.cost,
            this.status});
            this.dgvCashier.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCashier.Location = new System.Drawing.Point(55, 486);
            this.dgvCashier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCashier.Name = "dgvCashier";
            this.dgvCashier.ReadOnly = true;
            this.dgvCashier.RowHeadersWidth = 51;
            this.dgvCashier.RowTemplate.Height = 24;
            this.dgvCashier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCashier.Size = new System.Drawing.Size(793, 414);
            this.dgvCashier.TabIndex = 32;
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
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "Sale";
            this.cost.MinimumWidth = 8;
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // txtSellcount
            // 
            this.txtSellcount.Enabled = false;
            this.txtSellcount.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSellcount.Location = new System.Drawing.Point(196, 399);
            this.txtSellcount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSellcount.Name = "txtSellcount";
            this.txtSellcount.ReadOnly = true;
            this.txtSellcount.Size = new System.Drawing.Size(76, 32);
            this.txtSellcount.TabIndex = 31;
            // 
            // LSellCount
            // 
            this.LSellCount.AutoSize = true;
            this.LSellCount.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSellCount.ForeColor = System.Drawing.Color.Red;
            this.LSellCount.Location = new System.Drawing.Point(51, 402);
            this.LSellCount.Name = "LSellCount";
            this.LSellCount.Size = new System.Drawing.Size(117, 25);
            this.LSellCount.TabIndex = 30;
            this.LSellCount.Text = "Sell Count";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtSearch.Location = new System.Drawing.Point(667, 402);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 27);
            this.txtSearch.TabIndex = 29;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // LSearch
            // 
            this.LSearch.AutoSize = true;
            this.LSearch.Font = new System.Drawing.Font("Tahoma", 8F);
            this.LSearch.Location = new System.Drawing.Point(591, 402);
            this.LSearch.Name = "LSearch";
            this.LSearch.Size = new System.Drawing.Size(56, 19);
            this.LSearch.TabIndex = 28;
            this.LSearch.Text = "Search";
            // 
            // UpdateInfo
            // 
            this.UpdateInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UpdateInfo.Controls.Add(this.btnUpdate);
            this.UpdateInfo.Controls.Add(this.txtNewValue);
            this.UpdateInfo.Controls.Add(this.cbSelectField);
            this.UpdateInfo.Controls.Add(this.LNewValue);
            this.UpdateInfo.Controls.Add(this.LSelectInfo);
            this.UpdateInfo.Controls.Add(this.LUpdateInfo);
            this.UpdateInfo.Location = new System.Drawing.Point(471, 102);
            this.UpdateInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateInfo.Name = "UpdateInfo";
            this.UpdateInfo.Size = new System.Drawing.Size(378, 262);
            this.UpdateInfo.TabIndex = 27;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(278, 206);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 38);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNewValue
            // 
            this.txtNewValue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNewValue.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewValue.Location = new System.Drawing.Point(199, 144);
            this.txtNewValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewValue.Name = "txtNewValue";
            this.txtNewValue.Size = new System.Drawing.Size(163, 26);
            this.txtNewValue.TabIndex = 4;
            // 
            // cbSelectField
            // 
            this.cbSelectField.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbSelectField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSelectField.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectField.FormattingEnabled = true;
            this.cbSelectField.Items.AddRange(new object[] {
            "Password",
            "Contact Info"});
            this.cbSelectField.Location = new System.Drawing.Point(199, 94);
            this.cbSelectField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSelectField.Name = "cbSelectField";
            this.cbSelectField.Size = new System.Drawing.Size(163, 27);
            this.cbSelectField.TabIndex = 3;
            this.cbSelectField.Text = "Select one field";
            // 
            // LNewValue
            // 
            this.LNewValue.AutoSize = true;
            this.LNewValue.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNewValue.Location = new System.Drawing.Point(28, 144);
            this.LNewValue.Name = "LNewValue";
            this.LNewValue.Size = new System.Drawing.Size(84, 19);
            this.LNewValue.TabIndex = 2;
            this.LNewValue.Text = "New Value";
            // 
            // LSelectInfo
            // 
            this.LSelectInfo.AutoSize = true;
            this.LSelectInfo.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSelectInfo.Location = new System.Drawing.Point(28, 94);
            this.LSelectInfo.Name = "LSelectInfo";
            this.LSelectInfo.Size = new System.Drawing.Size(162, 19);
            this.LSelectInfo.TabIndex = 1;
            this.LSelectInfo.Text = "Select Field to Update";
            // 
            // LUpdateInfo
            // 
            this.LUpdateInfo.AutoSize = true;
            this.LUpdateInfo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.LUpdateInfo.Location = new System.Drawing.Point(88, 25);
            this.LUpdateInfo.Name = "LUpdateInfo";
            this.LUpdateInfo.Size = new System.Drawing.Size(211, 24);
            this.LUpdateInfo.TabIndex = 0;
            this.LUpdateInfo.Text = "Update Information";
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.Enabled = false;
            this.txtContactInfo.Location = new System.Drawing.Point(196, 334);
            this.txtContactInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.ReadOnly = true;
            this.txtContactInfo.Size = new System.Drawing.Size(219, 26);
            this.txtContactInfo.TabIndex = 26;
            // 
            // txtAdress
            // 
            this.txtAdress.Enabled = false;
            this.txtAdress.Location = new System.Drawing.Point(196, 276);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.ReadOnly = true;
            this.txtAdress.Size = new System.Drawing.Size(219, 26);
            this.txtAdress.TabIndex = 25;
            // 
            // txtSalary
            // 
            this.txtSalary.Enabled = false;
            this.txtSalary.Location = new System.Drawing.Point(196, 219);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(219, 26);
            this.txtSalary.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(196, 161);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(219, 26);
            this.txtName.TabIndex = 23;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeID.Location = new System.Drawing.Point(196, 104);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.ReadOnly = true;
            this.txtEmployeeID.Size = new System.Drawing.Size(219, 26);
            this.txtEmployeeID.TabIndex = 22;
            // 
            // LContactInfo
            // 
            this.LContactInfo.AutoSize = true;
            this.LContactInfo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContactInfo.Location = new System.Drawing.Point(51, 334);
            this.LContactInfo.Name = "LContactInfo";
            this.LContactInfo.Size = new System.Drawing.Size(128, 25);
            this.LContactInfo.TabIndex = 21;
            this.LContactInfo.Text = "Contact Info";
            // 
            // LAdress
            // 
            this.LAdress.AutoSize = true;
            this.LAdress.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAdress.Location = new System.Drawing.Point(51, 276);
            this.LAdress.Name = "LAdress";
            this.LAdress.Size = new System.Drawing.Size(74, 25);
            this.LAdress.TabIndex = 20;
            this.LAdress.Text = "Adress";
            // 
            // LSalary
            // 
            this.LSalary.AutoSize = true;
            this.LSalary.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSalary.Location = new System.Drawing.Point(51, 219);
            this.LSalary.Name = "LSalary";
            this.LSalary.Size = new System.Drawing.Size(69, 25);
            this.LSalary.TabIndex = 19;
            this.LSalary.Text = "Salary";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(51, 161);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(66, 25);
            this.LName.TabIndex = 18;
            this.LName.Text = "Name";
            // 
            // LCashierID
            // 
            this.LCashierID.AutoSize = true;
            this.LCashierID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCashierID.Location = new System.Drawing.Point(51, 104);
            this.LCashierID.Name = "LCashierID";
            this.LCashierID.Size = new System.Drawing.Size(110, 25);
            this.LCashierID.TabIndex = 17;
            this.LCashierID.Text = "Cashier ID";
            // 
            // CashierHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCashier);
            this.Controls.Add(this.txtSellcount);
            this.Controls.Add(this.LSellCount);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.LSearch);
            this.Controls.Add(this.UpdateInfo);
            this.Controls.Add(this.txtContactInfo);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.LContactInfo);
            this.Controls.Add(this.LAdress);
            this.Controls.Add(this.LSalary);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.LCashierID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CashierHistory";
            this.Size = new System.Drawing.Size(900, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashier)).EndInit();
            this.UpdateInfo.ResumeLayout(false);
            this.UpdateInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCashier;
        private System.Windows.Forms.TextBox txtSellcount;
        private System.Windows.Forms.Label LSellCount;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label LSearch;
        private System.Windows.Forms.Panel UpdateInfo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNewValue;
        private System.Windows.Forms.ComboBox cbSelectField;
        private System.Windows.Forms.Label LNewValue;
        private System.Windows.Forms.Label LSelectInfo;
        private System.Windows.Forms.Label LUpdateInfo;
        private System.Windows.Forms.TextBox txtContactInfo;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label LContactInfo;
        private System.Windows.Forms.Label LAdress;
        private System.Windows.Forms.Label LSalary;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LCashierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bikeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}
