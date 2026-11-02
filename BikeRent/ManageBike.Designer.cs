namespace BikeRent
{
    partial class ManageBike
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
            this.lblBikeManagement = new System.Windows.Forms.Label();
            this.lblBikeID = new System.Windows.Forms.Label();
            this.lblBikeName = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btLicensePlateNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAvailabilityStatus = new System.Windows.Forms.Label();
            this.txtBikeID = new System.Windows.Forms.TextBox();
            this.txtBikeName = new System.Windows.Forms.TextBox();
            this.txtBikeBrand = new System.Windows.Forms.TextBox();
            this.txtLicensePlateNo = new System.Windows.Forms.TextBox();
            this.txtRentPrice = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbAvailabilityStatus = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btShowDetails = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.dgvBikeList = new System.Windows.Forms.DataGridView();
            this.bikeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bikeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensePlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBikeList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBikeManagement
            // 
            this.lblBikeManagement.AutoSize = true;
            this.lblBikeManagement.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBikeManagement.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBikeManagement.Location = new System.Drawing.Point(312, 30);
            this.lblBikeManagement.Name = "lblBikeManagement";
            this.lblBikeManagement.Size = new System.Drawing.Size(270, 34);
            this.lblBikeManagement.TabIndex = 0;
            this.lblBikeManagement.Text = "Bike Management";
            // 
            // lblBikeID
            // 
            this.lblBikeID.AutoSize = true;
            this.lblBikeID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBikeID.Location = new System.Drawing.Point(60, 85);
            this.lblBikeID.Name = "lblBikeID";
            this.lblBikeID.Size = new System.Drawing.Size(68, 22);
            this.lblBikeID.TabIndex = 1;
            this.lblBikeID.Text = "Bike ID";
            // 
            // lblBikeName
            // 
            this.lblBikeName.AutoSize = true;
            this.lblBikeName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBikeName.Location = new System.Drawing.Point(60, 145);
            this.lblBikeName.Name = "lblBikeName";
            this.lblBikeName.Size = new System.Drawing.Size(94, 22);
            this.lblBikeName.TabIndex = 2;
            this.lblBikeName.Text = "Bike Name";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(60, 205);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(56, 22);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "Brand";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(60, 265);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(49, 22);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            // 
            // btLicensePlateNo
            // 
            this.btLicensePlateNo.AutoSize = true;
            this.btLicensePlateNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLicensePlateNo.Location = new System.Drawing.Point(450, 205);
            this.btLicensePlateNo.Name = "btLicensePlateNo";
            this.btLicensePlateNo.Size = new System.Drawing.Size(139, 22);
            this.btLicensePlateNo.TabIndex = 5;
            this.btLicensePlateNo.Text = "License Plate No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rent Price (Per Day)";
            // 
            // lblAvailabilityStatus
            // 
            this.lblAvailabilityStatus.AutoSize = true;
            this.lblAvailabilityStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailabilityStatus.Location = new System.Drawing.Point(450, 145);
            this.lblAvailabilityStatus.Name = "lblAvailabilityStatus";
            this.lblAvailabilityStatus.Size = new System.Drawing.Size(148, 22);
            this.lblAvailabilityStatus.TabIndex = 7;
            this.lblAvailabilityStatus.Text = "Availability Status";
            // 
            // txtBikeID
            // 
            this.txtBikeID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBikeID.Location = new System.Drawing.Point(180, 85);
            this.txtBikeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBikeID.Name = "txtBikeID";
            this.txtBikeID.ReadOnly = true;
            this.txtBikeID.Size = new System.Drawing.Size(200, 29);
            this.txtBikeID.TabIndex = 9;
            this.txtBikeID.TextChanged += new System.EventHandler(this.txtBikeID_TextChanged);
            // 
            // txtBikeName
            // 
            this.txtBikeName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBikeName.Location = new System.Drawing.Point(180, 145);
            this.txtBikeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBikeName.Name = "txtBikeName";
            this.txtBikeName.Size = new System.Drawing.Size(200, 29);
            this.txtBikeName.TabIndex = 10;
            this.txtBikeName.TextChanged += new System.EventHandler(this.txtBikeName_TextChanged);
            // 
            // txtBikeBrand
            // 
            this.txtBikeBrand.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBikeBrand.Location = new System.Drawing.Point(180, 205);
            this.txtBikeBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBikeBrand.Name = "txtBikeBrand";
            this.txtBikeBrand.Size = new System.Drawing.Size(200, 29);
            this.txtBikeBrand.TabIndex = 11;
            // 
            // txtLicensePlateNo
            // 
            this.txtLicensePlateNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicensePlateNo.Location = new System.Drawing.Point(630, 205);
            this.txtLicensePlateNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLicensePlateNo.Name = "txtLicensePlateNo";
            this.txtLicensePlateNo.Size = new System.Drawing.Size(200, 29);
            this.txtLicensePlateNo.TabIndex = 13;
            // 
            // txtRentPrice
            // 
            this.txtRentPrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentPrice.Location = new System.Drawing.Point(630, 85);
            this.txtRentPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRentPrice.Name = "txtRentPrice";
            this.txtRentPrice.Size = new System.Drawing.Size(200, 29);
            this.txtRentPrice.TabIndex = 14;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Standard",
            "Electric"});
            this.cbType.Location = new System.Drawing.Point(180, 265);
            this.cbType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(200, 30);
            this.cbType.TabIndex = 15;
            // 
            // cbAvailabilityStatus
            // 
            this.cbAvailabilityStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAvailabilityStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAvailabilityStatus.FormattingEnabled = true;
            this.cbAvailabilityStatus.Items.AddRange(new object[] {
            "Available",
            "Rented",
            "Maintenance"});
            this.cbAvailabilityStatus.Location = new System.Drawing.Point(630, 145);
            this.cbAvailabilityStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAvailabilityStatus.Name = "cbAvailabilityStatus";
            this.cbAvailabilityStatus.Size = new System.Drawing.Size(200, 30);
            this.cbAvailabilityStatus.TabIndex = 16;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(60, 325);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(62, 22);
            this.lblSearch.TabIndex = 18;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(180, 325);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 29);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.btSave.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSave.Location = new System.Drawing.Point(450, 250);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(175, 55);
            this.btSave.TabIndex = 22;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btDelete.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btDelete.Location = new System.Drawing.Point(655, 250);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(175, 55);
            this.btDelete.TabIndex = 23;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btShowDetails
            // 
            this.btShowDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btShowDetails.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btShowDetails.Location = new System.Drawing.Point(655, 310);
            this.btShowDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btShowDetails.Name = "btShowDetails";
            this.btShowDetails.Size = new System.Drawing.Size(175, 55);
            this.btShowDetails.TabIndex = 24;
            this.btShowDetails.Text = "Show Details";
            this.btShowDetails.UseVisualStyleBackColor = false;
            this.btShowDetails.Click += new System.EventHandler(this.btShowDetails_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btClear.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btClear.Location = new System.Drawing.Point(450, 310);
            this.btClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(175, 55);
            this.btClear.TabIndex = 25;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // dgvBikeList
            // 
            this.dgvBikeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBikeList.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvBikeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBikeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bikeID,
            this.bikeName,
            this.brand,
            this.type,
            this.licensePlateNo,
            this.rentPrice,
            this.availabilityStatus,
            this.employeeID});
            this.dgvBikeList.Location = new System.Drawing.Point(60, 400);
            this.dgvBikeList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBikeList.MultiSelect = false;
            this.dgvBikeList.Name = "dgvBikeList";
            this.dgvBikeList.ReadOnly = true;
            this.dgvBikeList.RowHeadersWidth = 51;
            this.dgvBikeList.RowTemplate.Height = 24;
            this.dgvBikeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBikeList.Size = new System.Drawing.Size(770, 513);
            this.dgvBikeList.TabIndex = 26;
            this.dgvBikeList.DoubleClick += new System.EventHandler(this.dgvBikeList_DoubleClick);
            // 
            // bikeID
            // 
            this.bikeID.DataPropertyName = "bikeID";
            this.bikeID.HeaderText = "Bike ID";
            this.bikeID.MinimumWidth = 6;
            this.bikeID.Name = "bikeID";
            this.bikeID.ReadOnly = true;
            // 
            // bikeName
            // 
            this.bikeName.DataPropertyName = "bikeName";
            this.bikeName.HeaderText = "Bike Name";
            this.bikeName.MinimumWidth = 6;
            this.bikeName.Name = "bikeName";
            this.bikeName.ReadOnly = true;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "Brand";
            this.brand.MinimumWidth = 6;
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // licensePlateNo
            // 
            this.licensePlateNo.DataPropertyName = "licensePlateNo";
            this.licensePlateNo.HeaderText = "License Plate No";
            this.licensePlateNo.MinimumWidth = 6;
            this.licensePlateNo.Name = "licensePlateNo";
            this.licensePlateNo.ReadOnly = true;
            // 
            // rentPrice
            // 
            this.rentPrice.DataPropertyName = "rentPrice";
            this.rentPrice.HeaderText = "Rent Price";
            this.rentPrice.MinimumWidth = 6;
            this.rentPrice.Name = "rentPrice";
            this.rentPrice.ReadOnly = true;
            // 
            // availabilityStatus
            // 
            this.availabilityStatus.DataPropertyName = "availabilityStatus";
            this.availabilityStatus.HeaderText = "Availability Status ";
            this.availabilityStatus.MinimumWidth = 6;
            this.availabilityStatus.Name = "availabilityStatus";
            this.availabilityStatus.ReadOnly = true;
            this.availabilityStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.availabilityStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // employeeID
            // 
            this.employeeID.DataPropertyName = "employeeID";
            this.employeeID.HeaderText = "Employee ID";
            this.employeeID.MinimumWidth = 6;
            this.employeeID.Name = "employeeID";
            this.employeeID.ReadOnly = true;
            // 
            // ManageBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvBikeList);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btShowDetails);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cbAvailabilityStatus);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.txtRentPrice);
            this.Controls.Add(this.txtLicensePlateNo);
            this.Controls.Add(this.txtBikeBrand);
            this.Controls.Add(this.txtBikeName);
            this.Controls.Add(this.txtBikeID);
            this.Controls.Add(this.lblAvailabilityStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLicensePlateNo);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblBikeName);
            this.Controls.Add(this.lblBikeID);
            this.Controls.Add(this.lblBikeManagement);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ManageBike";
            this.Size = new System.Drawing.Size(900, 1000);
            this.Load += new System.EventHandler(this.ManageBike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBikeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBikeManagement;
        private System.Windows.Forms.Label lblBikeID;
        private System.Windows.Forms.Label lblBikeName;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label btLicensePlateNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAvailabilityStatus;
        private System.Windows.Forms.TextBox txtBikeID;
        private System.Windows.Forms.TextBox txtBikeName;
        private System.Windows.Forms.TextBox txtBikeBrand;
        private System.Windows.Forms.TextBox txtLicensePlateNo;
        private System.Windows.Forms.TextBox txtRentPrice;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbAvailabilityStatus;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btShowDetails;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.DataGridView dgvBikeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn bikeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bikeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn availabilityStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
    }
}
