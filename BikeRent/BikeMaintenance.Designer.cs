namespace BikeRent
{
    partial class BikeMaintenance
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
            this.lblBikeMaintenance = new System.Windows.Forms.Label();
            this.lblMaintenanceID = new System.Windows.Forms.Label();
            this.lblBikeID = new System.Windows.Forms.Label();
            this.lblMaintenanceType = new System.Windows.Forms.Label();
            this.dateMaintenanceDate = new System.Windows.Forms.Label();
            this.dateCompletionDate = new System.Windows.Forms.Label();
            this.lblCostOfMaintenance = new System.Windows.Forms.Label();
            this.txtMaintenanceID = new System.Windows.Forms.TextBox();
            this.txtBikeID = new System.Windows.Forms.TextBox();
            this.txtcostOfMaintenance = new System.Windows.Forms.TextBox();
            this.cbMaintenanceType = new System.Windows.Forms.ComboBox();
            this.dateMDate = new System.Windows.Forms.DateTimePicker();
            this.dateCDate = new System.Windows.Forms.DateTimePicker();
            this.btSave = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btShowDetails = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.dgvMaintenanceList = new System.Windows.Forms.DataGridView();
            this.maintenanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bikeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costOfMaintenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtBikeName = new System.Windows.Forms.TextBox();
            this.lblBikeName = new System.Windows.Forms.Label();
            this.dgvbikeDetails = new System.Windows.Forms.DataGridView();
            this.cbikeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbikeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbikeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBikeMaintenance
            // 
            this.lblBikeMaintenance.AutoSize = true;
            this.lblBikeMaintenance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBikeMaintenance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBikeMaintenance.Location = new System.Drawing.Point(296, 30);
            this.lblBikeMaintenance.Name = "lblBikeMaintenance";
            this.lblBikeMaintenance.Size = new System.Drawing.Size(301, 39);
            this.lblBikeMaintenance.TabIndex = 0;
            this.lblBikeMaintenance.Text = "Bike Maintenance";
            // 
            // lblMaintenanceID
            // 
            this.lblMaintenanceID.AutoSize = true;
            this.lblMaintenanceID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceID.Location = new System.Drawing.Point(60, 320);
            this.lblMaintenanceID.Name = "lblMaintenanceID";
            this.lblMaintenanceID.Size = new System.Drawing.Size(133, 22);
            this.lblMaintenanceID.TabIndex = 1;
            this.lblMaintenanceID.Text = "Maintenance ID";
            // 
            // lblBikeID
            // 
            this.lblBikeID.AutoSize = true;
            this.lblBikeID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBikeID.Location = new System.Drawing.Point(60, 80);
            this.lblBikeID.Name = "lblBikeID";
            this.lblBikeID.Size = new System.Drawing.Size(68, 22);
            this.lblBikeID.TabIndex = 2;
            this.lblBikeID.Text = "Bike ID";
            // 
            // lblMaintenanceType
            // 
            this.lblMaintenanceType.AutoSize = true;
            this.lblMaintenanceType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceType.Location = new System.Drawing.Point(60, 370);
            this.lblMaintenanceType.Name = "lblMaintenanceType";
            this.lblMaintenanceType.Size = new System.Drawing.Size(49, 22);
            this.lblMaintenanceType.TabIndex = 3;
            this.lblMaintenanceType.Text = "Type";
            // 
            // dateMaintenanceDate
            // 
            this.dateMaintenanceDate.AutoSize = true;
            this.dateMaintenanceDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateMaintenanceDate.Location = new System.Drawing.Point(60, 420);
            this.dateMaintenanceDate.Name = "dateMaintenanceDate";
            this.dateMaintenanceDate.Size = new System.Drawing.Size(89, 22);
            this.dateMaintenanceDate.TabIndex = 4;
            this.dateMaintenanceDate.Text = "Start Date";
            // 
            // dateCompletionDate
            // 
            this.dateCompletionDate.AutoSize = true;
            this.dateCompletionDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCompletionDate.Location = new System.Drawing.Point(465, 320);
            this.dateCompletionDate.Name = "dateCompletionDate";
            this.dateCompletionDate.Size = new System.Drawing.Size(141, 22);
            this.dateCompletionDate.TabIndex = 5;
            this.dateCompletionDate.Text = "Completion Date";
            // 
            // lblCostOfMaintenance
            // 
            this.lblCostOfMaintenance.AutoSize = true;
            this.lblCostOfMaintenance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostOfMaintenance.Location = new System.Drawing.Point(465, 370);
            this.lblCostOfMaintenance.Name = "lblCostOfMaintenance";
            this.lblCostOfMaintenance.Size = new System.Drawing.Size(45, 22);
            this.lblCostOfMaintenance.TabIndex = 6;
            this.lblCostOfMaintenance.Text = "Cost";
            // 
            // txtMaintenanceID
            // 
            this.txtMaintenanceID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaintenanceID.Location = new System.Drawing.Point(216, 320);
            this.txtMaintenanceID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaintenanceID.Name = "txtMaintenanceID";
            this.txtMaintenanceID.ReadOnly = true;
            this.txtMaintenanceID.Size = new System.Drawing.Size(220, 29);
            this.txtMaintenanceID.TabIndex = 7;
            // 
            // txtBikeID
            // 
            this.txtBikeID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBikeID.Location = new System.Drawing.Point(170, 80);
            this.txtBikeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBikeID.Name = "txtBikeID";
            this.txtBikeID.ReadOnly = true;
            this.txtBikeID.Size = new System.Drawing.Size(230, 29);
            this.txtBikeID.TabIndex = 8;
            this.txtBikeID.TextChanged += new System.EventHandler(this.txtBikeID_TextChanged);
            // 
            // txtcostOfMaintenance
            // 
            this.txtcostOfMaintenance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcostOfMaintenance.Location = new System.Drawing.Point(610, 370);
            this.txtcostOfMaintenance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcostOfMaintenance.Name = "txtcostOfMaintenance";
            this.txtcostOfMaintenance.Size = new System.Drawing.Size(226, 29);
            this.txtcostOfMaintenance.TabIndex = 9;
            // 
            // cbMaintenanceType
            // 
            this.cbMaintenanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaintenanceType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaintenanceType.FormattingEnabled = true;
            this.cbMaintenanceType.Items.AddRange(new object[] {
            "Repair",
            "Service",
            "Check-up"});
            this.cbMaintenanceType.Location = new System.Drawing.Point(216, 370);
            this.cbMaintenanceType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMaintenanceType.Name = "cbMaintenanceType";
            this.cbMaintenanceType.Size = new System.Drawing.Size(220, 30);
            this.cbMaintenanceType.TabIndex = 10;
            // 
            // dateMDate
            // 
            this.dateMDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateMDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMDate.Location = new System.Drawing.Point(216, 420);
            this.dateMDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateMDate.Name = "dateMDate";
            this.dateMDate.Size = new System.Drawing.Size(220, 29);
            this.dateMDate.TabIndex = 11;
            // 
            // dateCDate
            // 
            this.dateCDate.CustomFormat = "yyyy-MM-dd";
            this.dateCDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCDate.Location = new System.Drawing.Point(610, 320);
            this.dateCDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateCDate.Name = "dateCDate";
            this.dateCDate.Size = new System.Drawing.Size(226, 29);
            this.dateCDate.TabIndex = 12;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.btSave.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(60, 470);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(150, 62);
            this.btSave.TabIndex = 23;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btRemove.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.ForeColor = System.Drawing.Color.White;
            this.btRemove.Location = new System.Drawing.Point(270, 470);
            this.btRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(150, 62);
            this.btRemove.TabIndex = 24;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btShowDetails
            // 
            this.btShowDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btShowDetails.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowDetails.ForeColor = System.Drawing.Color.White;
            this.btShowDetails.Location = new System.Drawing.Point(690, 470);
            this.btShowDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btShowDetails.Name = "btShowDetails";
            this.btShowDetails.Size = new System.Drawing.Size(150, 62);
            this.btShowDetails.TabIndex = 25;
            this.btShowDetails.Text = "Show Details";
            this.btShowDetails.UseVisualStyleBackColor = false;
            this.btShowDetails.Click += new System.EventHandler(this.btShowDetails_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btClear.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.Color.White;
            this.btClear.Location = new System.Drawing.Point(480, 470);
            this.btClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(150, 62);
            this.btClear.TabIndex = 26;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // dgvMaintenanceList
            // 
            this.dgvMaintenanceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaintenanceList.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvMaintenanceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenanceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maintenanceID,
            this.bikeID,
            this.maintenanceType,
            this.maintenanceDate,
            this.completionDate,
            this.costOfMaintenance});
            this.dgvMaintenanceList.Location = new System.Drawing.Point(60, 560);
            this.dgvMaintenanceList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMaintenanceList.Name = "dgvMaintenanceList";
            this.dgvMaintenanceList.ReadOnly = true;
            this.dgvMaintenanceList.RowHeadersWidth = 51;
            this.dgvMaintenanceList.RowTemplate.Height = 24;
            this.dgvMaintenanceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaintenanceList.Size = new System.Drawing.Size(774, 363);
            this.dgvMaintenanceList.TabIndex = 27;
            this.dgvMaintenanceList.DoubleClick += new System.EventHandler(this.dgvMaintenanceList_DoubleClick);
            // 
            // maintenanceID
            // 
            this.maintenanceID.DataPropertyName = "maintenanceID";
            this.maintenanceID.HeaderText = "Maintenance ID";
            this.maintenanceID.MinimumWidth = 6;
            this.maintenanceID.Name = "maintenanceID";
            this.maintenanceID.ReadOnly = true;
            // 
            // bikeID
            // 
            this.bikeID.DataPropertyName = "bikeID";
            this.bikeID.HeaderText = "Bike ID";
            this.bikeID.MinimumWidth = 6;
            this.bikeID.Name = "bikeID";
            this.bikeID.ReadOnly = true;
            // 
            // maintenanceType
            // 
            this.maintenanceType.DataPropertyName = "maintenanceType";
            this.maintenanceType.HeaderText = "Maintenance Type";
            this.maintenanceType.MinimumWidth = 6;
            this.maintenanceType.Name = "maintenanceType";
            this.maintenanceType.ReadOnly = true;
            // 
            // maintenanceDate
            // 
            this.maintenanceDate.DataPropertyName = "maintenanceDate";
            this.maintenanceDate.HeaderText = "Maintenance Date";
            this.maintenanceDate.MinimumWidth = 6;
            this.maintenanceDate.Name = "maintenanceDate";
            this.maintenanceDate.ReadOnly = true;
            // 
            // completionDate
            // 
            this.completionDate.DataPropertyName = "completionDate";
            this.completionDate.HeaderText = "Completion Date";
            this.completionDate.MinimumWidth = 6;
            this.completionDate.Name = "completionDate";
            this.completionDate.ReadOnly = true;
            // 
            // costOfMaintenance
            // 
            this.costOfMaintenance.DataPropertyName = "costOfMaintenance";
            this.costOfMaintenance.HeaderText = "Cost of Maintenance";
            this.costOfMaintenance.MinimumWidth = 6;
            this.costOfMaintenance.Name = "costOfMaintenance";
            this.costOfMaintenance.ReadOnly = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(465, 420);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(68, 22);
            this.lblSearch.TabIndex = 28;
            this.lblSearch.Text = "Search ";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(610, 420);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(226, 29);
            this.txtSearch.TabIndex = 29;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtBikeName
            // 
            this.txtBikeName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBikeName.Location = new System.Drawing.Point(604, 77);
            this.txtBikeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBikeName.Name = "txtBikeName";
            this.txtBikeName.Size = new System.Drawing.Size(230, 29);
            this.txtBikeName.TabIndex = 31;
            this.txtBikeName.TextChanged += new System.EventHandler(this.txtBikeName_TextChanged);
            // 
            // lblBikeName
            // 
            this.lblBikeName.AutoSize = true;
            this.lblBikeName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBikeName.Location = new System.Drawing.Point(480, 80);
            this.lblBikeName.Name = "lblBikeName";
            this.lblBikeName.Size = new System.Drawing.Size(113, 22);
            this.lblBikeName.TabIndex = 30;
            this.lblBikeName.Text = "Search Name";
            // 
            // dgvbikeDetails
            // 
            this.dgvbikeDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbikeDetails.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvbikeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbikeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbikeID,
            this.cbikeName,
            this.cbrand});
            this.dgvbikeDetails.Location = new System.Drawing.Point(61, 135);
            this.dgvbikeDetails.Name = "dgvbikeDetails";
            this.dgvbikeDetails.ReadOnly = true;
            this.dgvbikeDetails.RowHeadersWidth = 62;
            this.dgvbikeDetails.RowTemplate.Height = 28;
            this.dgvbikeDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbikeDetails.Size = new System.Drawing.Size(774, 155);
            this.dgvbikeDetails.TabIndex = 32;
            this.dgvbikeDetails.DoubleClick += new System.EventHandler(this.dgvbikeDetails_DoubleClick);
            // 
            // cbikeID
            // 
            this.cbikeID.DataPropertyName = "bikeID";
            this.cbikeID.HeaderText = "Bike Id";
            this.cbikeID.MinimumWidth = 8;
            this.cbikeID.Name = "cbikeID";
            this.cbikeID.ReadOnly = true;
            // 
            // cbikeName
            // 
            this.cbikeName.DataPropertyName = "BikeName";
            this.cbikeName.HeaderText = "Bike Name";
            this.cbikeName.MinimumWidth = 8;
            this.cbikeName.Name = "cbikeName";
            this.cbikeName.ReadOnly = true;
            // 
            // cbrand
            // 
            this.cbrand.DataPropertyName = "brand";
            this.cbrand.HeaderText = "Brand";
            this.cbrand.MinimumWidth = 8;
            this.cbrand.Name = "cbrand";
            this.cbrand.ReadOnly = true;
            // 
            // BikeMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvbikeDetails);
            this.Controls.Add(this.txtBikeName);
            this.Controls.Add(this.lblBikeName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvMaintenanceList);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btShowDetails);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dateCDate);
            this.Controls.Add(this.dateMDate);
            this.Controls.Add(this.cbMaintenanceType);
            this.Controls.Add(this.txtcostOfMaintenance);
            this.Controls.Add(this.txtBikeID);
            this.Controls.Add(this.txtMaintenanceID);
            this.Controls.Add(this.lblCostOfMaintenance);
            this.Controls.Add(this.dateCompletionDate);
            this.Controls.Add(this.dateMaintenanceDate);
            this.Controls.Add(this.lblMaintenanceType);
            this.Controls.Add(this.lblBikeID);
            this.Controls.Add(this.lblMaintenanceID);
            this.Controls.Add(this.lblBikeMaintenance);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BikeMaintenance";
            this.Size = new System.Drawing.Size(900, 1000);
            this.Load += new System.EventHandler(this.BikeMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbikeDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBikeMaintenance;
        private System.Windows.Forms.Label lblMaintenanceID;
        private System.Windows.Forms.Label lblBikeID;
        private System.Windows.Forms.Label lblMaintenanceType;
        private System.Windows.Forms.Label dateMaintenanceDate;
        private System.Windows.Forms.Label dateCompletionDate;
        private System.Windows.Forms.Label lblCostOfMaintenance;
        private System.Windows.Forms.TextBox txtMaintenanceID;
        private System.Windows.Forms.TextBox txtBikeID;
        private System.Windows.Forms.TextBox txtcostOfMaintenance;
        private System.Windows.Forms.ComboBox cbMaintenanceType;
        private System.Windows.Forms.DateTimePicker dateMDate;
        private System.Windows.Forms.DateTimePicker dateCDate;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btShowDetails;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.DataGridView dgvMaintenanceList;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bikeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn completionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn costOfMaintenance;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtBikeName;
        private System.Windows.Forms.Label lblBikeName;
        private System.Windows.Forms.DataGridView dgvbikeDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbikeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbikeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbrand;
    }
}
