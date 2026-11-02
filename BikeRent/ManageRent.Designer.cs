namespace BikeRent
{
    partial class ManageRent
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
            this.LBikeID = new System.Windows.Forms.Label();
            this.lblSearchBike = new System.Windows.Forms.Label();
            this.LAccesoryID = new System.Windows.Forms.Label();
            this.LAccesoryName = new System.Windows.Forms.Label();
            this.LCustomerID = new System.Windows.Forms.Label();
            this.LCustomerName = new System.Windows.Forms.Label();
            this.txtBikeID = new System.Windows.Forms.TextBox();
            this.txtSearchBike = new System.Windows.Forms.TextBox();
            this.txtAccessoryID = new System.Windows.Forms.TextBox();
            this.txtSearchAccessory = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.dgvBike = new System.Windows.Forms.DataGridView();
            this.bikeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bikeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAccessory = new System.Windows.Forms.DataGridView();
            this.accessoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTRentalStartDate = new System.Windows.Forms.DateTimePicker();
            this.LRentalStartDate = new System.Windows.Forms.Label();
            this.LRentalEndDate = new System.Windows.Forms.Label();
            this.DTRentalEndDate = new System.Windows.Forms.DateTimePicker();
            this.LCost = new System.Windows.Forms.Label();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.LManageREnt = new System.Windows.Forms.Label();
            this.dgvRent = new System.Windows.Forms.DataGridView();
            this.rentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbikeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessory_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalSDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalEDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtRent = new System.Windows.Forms.Button();
            this.btReceive = new System.Windows.Forms.Button();
            this.BtClear = new System.Windows.Forms.Button();
            this.LRentID = new System.Windows.Forms.Label();
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerateCost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccessory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // LBikeID
            // 
            this.LBikeID.AutoSize = true;
            this.LBikeID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBikeID.Location = new System.Drawing.Point(30, 120);
            this.LBikeID.Name = "LBikeID";
            this.LBikeID.Size = new System.Drawing.Size(60, 19);
            this.LBikeID.TabIndex = 0;
            this.LBikeID.Text = "Bike ID";
            this.LBikeID.Click += new System.EventHandler(this.LBikeID_Click);
            // 
            // lblSearchBike
            // 
            this.lblSearchBike.AutoSize = true;
            this.lblSearchBike.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBike.Location = new System.Drawing.Point(30, 190);
            this.lblSearchBike.Name = "lblSearchBike";
            this.lblSearchBike.Size = new System.Drawing.Size(90, 19);
            this.lblSearchBike.TabIndex = 1;
            this.lblSearchBike.Text = "Search Bike";
            // 
            // LAccesoryID
            // 
            this.LAccesoryID.AutoSize = true;
            this.LAccesoryID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAccesoryID.Location = new System.Drawing.Point(600, 120);
            this.LAccesoryID.Name = "LAccesoryID";
            this.LAccesoryID.Size = new System.Drawing.Size(94, 19);
            this.LAccesoryID.TabIndex = 2;
            this.LAccesoryID.Text = "Accesory ID";
            // 
            // LAccesoryName
            // 
            this.LAccesoryName.AutoSize = true;
            this.LAccesoryName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAccesoryName.Location = new System.Drawing.Point(600, 190);
            this.LAccesoryName.Name = "LAccesoryName";
            this.LAccesoryName.Size = new System.Drawing.Size(131, 19);
            this.LAccesoryName.TabIndex = 3;
            this.LAccesoryName.Text = "Search Accessory";
            this.LAccesoryName.Click += new System.EventHandler(this.LAccesoryName_Click);
            // 
            // LCustomerID
            // 
            this.LCustomerID.AutoSize = true;
            this.LCustomerID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCustomerID.Location = new System.Drawing.Point(315, 120);
            this.LCustomerID.Name = "LCustomerID";
            this.LCustomerID.Size = new System.Drawing.Size(99, 19);
            this.LCustomerID.TabIndex = 4;
            this.LCustomerID.Text = "Customer ID";
            // 
            // LCustomerName
            // 
            this.LCustomerName.AutoSize = true;
            this.LCustomerName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCustomerName.Location = new System.Drawing.Point(315, 190);
            this.LCustomerName.Name = "LCustomerName";
            this.LCustomerName.Size = new System.Drawing.Size(129, 19);
            this.LCustomerName.TabIndex = 5;
            this.LCustomerName.Text = "Search Customer";
            // 
            // txtBikeID
            // 
            this.txtBikeID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtBikeID.Location = new System.Drawing.Point(170, 120);
            this.txtBikeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBikeID.Name = "txtBikeID";
            this.txtBikeID.ReadOnly = true;
            this.txtBikeID.Size = new System.Drawing.Size(130, 27);
            this.txtBikeID.TabIndex = 8;
            this.txtBikeID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSearchBike
            // 
            this.txtSearchBike.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtSearchBike.Location = new System.Drawing.Point(170, 190);
            this.txtSearchBike.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchBike.Name = "txtSearchBike";
            this.txtSearchBike.Size = new System.Drawing.Size(130, 27);
            this.txtSearchBike.TabIndex = 9;
            this.txtSearchBike.TextChanged += new System.EventHandler(this.txtSearchBike_TextChanged);
            // 
            // txtAccessoryID
            // 
            this.txtAccessoryID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtAccessoryID.Location = new System.Drawing.Point(740, 120);
            this.txtAccessoryID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccessoryID.Name = "txtAccessoryID";
            this.txtAccessoryID.ReadOnly = true;
            this.txtAccessoryID.Size = new System.Drawing.Size(130, 27);
            this.txtAccessoryID.TabIndex = 10;
            // 
            // txtSearchAccessory
            // 
            this.txtSearchAccessory.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtSearchAccessory.Location = new System.Drawing.Point(740, 190);
            this.txtSearchAccessory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchAccessory.Name = "txtSearchAccessory";
            this.txtSearchAccessory.Size = new System.Drawing.Size(130, 27);
            this.txtSearchAccessory.TabIndex = 11;
            this.txtSearchAccessory.TextChanged += new System.EventHandler(this.txtSearchAccessory_TextChanged);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtCustomerID.Location = new System.Drawing.Point(455, 120);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(130, 27);
            this.txtCustomerID.TabIndex = 12;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtSearchCustomer.Location = new System.Drawing.Point(455, 190);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(130, 27);
            this.txtSearchCustomer.TabIndex = 13;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // dgvBike
            // 
            this.dgvBike.AllowUserToAddRows = false;
            this.dgvBike.AllowUserToResizeColumns = false;
            this.dgvBike.AllowUserToResizeRows = false;
            this.dgvBike.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBike.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvBike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBike.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bikeID,
            this.bikeName,
            this.rentPrice});
            this.dgvBike.Location = new System.Drawing.Point(30, 251);
            this.dgvBike.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBike.Name = "dgvBike";
            this.dgvBike.ReadOnly = true;
            this.dgvBike.RowHeadersVisible = false;
            this.dgvBike.RowHeadersWidth = 51;
            this.dgvBike.RowTemplate.Height = 24;
            this.dgvBike.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBike.Size = new System.Drawing.Size(270, 190);
            this.dgvBike.TabIndex = 14;
            this.dgvBike.DoubleClick += new System.EventHandler(this.dgvBike_DoubleClick);
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
            // rentPrice
            // 
            this.rentPrice.DataPropertyName = "rentPrice";
            this.rentPrice.HeaderText = "Price";
            this.rentPrice.MinimumWidth = 8;
            this.rentPrice.Name = "rentPrice";
            this.rentPrice.ReadOnly = true;
            // 
            // dgvAccessory
            // 
            this.dgvAccessory.AllowUserToAddRows = false;
            this.dgvAccessory.AllowUserToResizeColumns = false;
            this.dgvAccessory.AllowUserToResizeRows = false;
            this.dgvAccessory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccessory.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvAccessory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccessory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accessoryID,
            this.accessoryName,
            this.quantity});
            this.dgvAccessory.Location = new System.Drawing.Point(600, 251);
            this.dgvAccessory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAccessory.Name = "dgvAccessory";
            this.dgvAccessory.ReadOnly = true;
            this.dgvAccessory.RowHeadersVisible = false;
            this.dgvAccessory.RowHeadersWidth = 51;
            this.dgvAccessory.RowTemplate.Height = 24;
            this.dgvAccessory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccessory.Size = new System.Drawing.Size(270, 190);
            this.dgvAccessory.TabIndex = 16;
            this.dgvAccessory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccessory_CellContentClick);
            this.dgvAccessory.DoubleClick += new System.EventHandler(this.dgvAccessory_DoubleClick);
            // 
            // accessoryID
            // 
            this.accessoryID.DataPropertyName = "accessoryID";
            this.accessoryID.HeaderText = "Accessory ID";
            this.accessoryID.MinimumWidth = 6;
            this.accessoryID.Name = "accessoryID";
            this.accessoryID.ReadOnly = true;
            // 
            // accessoryName
            // 
            this.accessoryName.DataPropertyName = "accessoryName";
            this.accessoryName.HeaderText = "Accessory Name";
            this.accessoryName.MinimumWidth = 6;
            this.accessoryName.Name = "accessoryName";
            this.accessoryName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 8;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // DTRentalStartDate
            // 
            this.DTRentalStartDate.CustomFormat = "yyyy-MM-dd";
            this.DTRentalStartDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.DTRentalStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTRentalStartDate.Location = new System.Drawing.Point(245, 472);
            this.DTRentalStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DTRentalStartDate.Name = "DTRentalStartDate";
            this.DTRentalStartDate.Size = new System.Drawing.Size(170, 27);
            this.DTRentalStartDate.TabIndex = 17;
            // 
            // LRentalStartDate
            // 
            this.LRentalStartDate.AutoSize = true;
            this.LRentalStartDate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.LRentalStartDate.Location = new System.Drawing.Point(27, 472);
            this.LRentalStartDate.Name = "LRentalStartDate";
            this.LRentalStartDate.Size = new System.Drawing.Size(185, 24);
            this.LRentalStartDate.TabIndex = 18;
            this.LRentalStartDate.Text = "Rental Start Date";
            this.LRentalStartDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // LRentalEndDate
            // 
            this.LRentalEndDate.AutoSize = true;
            this.LRentalEndDate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.LRentalEndDate.Location = new System.Drawing.Point(494, 471);
            this.LRentalEndDate.Name = "LRentalEndDate";
            this.LRentalEndDate.Size = new System.Drawing.Size(173, 24);
            this.LRentalEndDate.TabIndex = 19;
            this.LRentalEndDate.Text = "Rantal End Date";
            // 
            // DTRentalEndDate
            // 
            this.DTRentalEndDate.CustomFormat = "yyyy-MM-dd";
            this.DTRentalEndDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.DTRentalEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTRentalEndDate.Location = new System.Drawing.Point(700, 472);
            this.DTRentalEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DTRentalEndDate.Name = "DTRentalEndDate";
            this.DTRentalEndDate.Size = new System.Drawing.Size(170, 27);
            this.DTRentalEndDate.TabIndex = 20;
            // 
            // LCost
            // 
            this.LCost.BackColor = System.Drawing.SystemColors.Control;
            this.LCost.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.LCost.ForeColor = System.Drawing.Color.Red;
            this.LCost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LCost.Location = new System.Drawing.Point(0, 628);
            this.LCost.Name = "LCost";
            this.LCost.Size = new System.Drawing.Size(900, 56);
            this.LCost.TabIndex = 21;
            this.LCost.Text = "                                                               Cost";
            this.LCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtCost
            // 
            this.TxtCost.BackColor = System.Drawing.SystemColors.Control;
            this.TxtCost.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.TxtCost.Location = new System.Drawing.Point(681, 634);
            this.TxtCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.ReadOnly = true;
            this.TxtCost.Size = new System.Drawing.Size(189, 46);
            this.TxtCost.TabIndex = 22;
            this.TxtCost.TextChanged += new System.EventHandler(this.TxtCost_TextChanged);
            // 
            // LManageREnt
            // 
            this.LManageREnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LManageREnt.AutoSize = true;
            this.LManageREnt.BackColor = System.Drawing.Color.Ivory;
            this.LManageREnt.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.LManageREnt.ForeColor = System.Drawing.Color.OliveDrab;
            this.LManageREnt.Location = new System.Drawing.Point(333, 30);
            this.LManageREnt.Name = "LManageREnt";
            this.LManageREnt.Size = new System.Drawing.Size(227, 39);
            this.LManageREnt.TabIndex = 23;
            this.LManageREnt.Text = "Manage Rent";
            this.LManageREnt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvRent
            // 
            this.dgvRent.AllowUserToAddRows = false;
            this.dgvRent.AllowUserToDeleteRows = false;
            this.dgvRent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRent.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentID,
            this.rbikeID,
            this.status,
            this.customer_ID,
            this.accessory_ID,
            this.rentalSDate,
            this.rentalEDate,
            this.cost});
            this.dgvRent.Location = new System.Drawing.Point(30, 709);
            this.dgvRent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvRent.Name = "dgvRent";
            this.dgvRent.ReadOnly = true;
            this.dgvRent.RowHeadersWidth = 51;
            this.dgvRent.RowTemplate.Height = 24;
            this.dgvRent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRent.Size = new System.Drawing.Size(840, 233);
            this.dgvRent.TabIndex = 24;
            this.dgvRent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRent_CellContentClick);
            this.dgvRent.DoubleClick += new System.EventHandler(this.dgvRent_DoubleClick);
            // 
            // rentID
            // 
            this.rentID.DataPropertyName = "rentID";
            this.rentID.HeaderText = "Rent ID";
            this.rentID.MinimumWidth = 6;
            this.rentID.Name = "rentID";
            this.rentID.ReadOnly = true;
            // 
            // rbikeID
            // 
            this.rbikeID.DataPropertyName = "bikeID";
            this.rbikeID.HeaderText = "Bike ID";
            this.rbikeID.MinimumWidth = 6;
            this.rbikeID.Name = "rbikeID";
            this.rbikeID.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // customer_ID
            // 
            this.customer_ID.DataPropertyName = "customerID";
            this.customer_ID.HeaderText = "Customer ID";
            this.customer_ID.MinimumWidth = 6;
            this.customer_ID.Name = "customer_ID";
            this.customer_ID.ReadOnly = true;
            // 
            // accessory_ID
            // 
            this.accessory_ID.DataPropertyName = "accessoryID";
            this.accessory_ID.HeaderText = "Accessory ID";
            this.accessory_ID.MinimumWidth = 6;
            this.accessory_ID.Name = "accessory_ID";
            this.accessory_ID.ReadOnly = true;
            // 
            // rentalSDate
            // 
            this.rentalSDate.DataPropertyName = "rentalSDate";
            this.rentalSDate.HeaderText = "Rental Start Date";
            this.rentalSDate.MinimumWidth = 6;
            this.rentalSDate.Name = "rentalSDate";
            this.rentalSDate.ReadOnly = true;
            // 
            // rentalEDate
            // 
            this.rentalEDate.DataPropertyName = "rentalEDate";
            this.rentalEDate.HeaderText = "Rental End Date";
            this.rentalEDate.MinimumWidth = 6;
            this.rentalEDate.Name = "rentalEDate";
            this.rentalEDate.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "Cost";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // BtRent
            // 
            this.BtRent.BackColor = System.Drawing.Color.DarkGreen;
            this.BtRent.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtRent.Location = new System.Drawing.Point(31, 566);
            this.BtRent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtRent.Name = "BtRent";
            this.BtRent.Size = new System.Drawing.Size(169, 58);
            this.BtRent.TabIndex = 25;
            this.BtRent.Text = "Rent";
            this.BtRent.UseVisualStyleBackColor = false;
            this.BtRent.Click += new System.EventHandler(this.BtRent_Click);
            // 
            // btReceive
            // 
            this.btReceive.BackColor = System.Drawing.Color.Firebrick;
            this.btReceive.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReceive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btReceive.Location = new System.Drawing.Point(245, 565);
            this.btReceive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btReceive.Name = "btReceive";
            this.btReceive.Size = new System.Drawing.Size(172, 56);
            this.btReceive.TabIndex = 26;
            this.btReceive.Text = "Receive";
            this.btReceive.UseVisualStyleBackColor = false;
            this.btReceive.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // BtClear
            // 
            this.BtClear.BackColor = System.Drawing.Color.SteelBlue;
            this.BtClear.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtClear.Location = new System.Drawing.Point(681, 564);
            this.BtClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(189, 59);
            this.BtClear.TabIndex = 27;
            this.BtClear.Text = "Clear";
            this.BtClear.UseVisualStyleBackColor = false;
            this.BtClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // LRentID
            // 
            this.LRentID.AutoSize = true;
            this.LRentID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.LRentID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LRentID.Location = new System.Drawing.Point(28, 531);
            this.LRentID.Name = "LRentID";
            this.LRentID.Size = new System.Drawing.Size(72, 19);
            this.LRentID.TabIndex = 28;
            this.LRentID.Text = "Rent ID";
            // 
            // txtRentID
            // 
            this.txtRentID.BackColor = System.Drawing.Color.Ivory;
            this.txtRentID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtRentID.Location = new System.Drawing.Point(115, 528);
            this.txtRentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.ReadOnly = true;
            this.txtRentID.Size = new System.Drawing.Size(150, 27);
            this.txtRentID.TabIndex = 29;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToResizeColumns = false;
            this.dgvCustomer.AllowUserToResizeRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.customerName});
            this.dgvCustomer.Location = new System.Drawing.Point(315, 251);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.RowHeadersWidth = 62;
            this.dgvCustomer.RowTemplate.Height = 28;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(270, 190);
            this.dgvCustomer.TabIndex = 30;
            this.dgvCustomer.DoubleClick += new System.EventHandler(this.dgvCustomer_DoubleClick);
            // 
            // customerID
            // 
            this.customerID.DataPropertyName = "customerID";
            this.customerID.HeaderText = "Customer ID";
            this.customerID.MinimumWidth = 8;
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "customerName";
            this.customerName.HeaderText = "Customer Name";
            this.customerName.MinimumWidth = 8;
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            // 
            // btnGenerateCost
            // 
            this.btnGenerateCost.BackColor = System.Drawing.Color.Firebrick;
            this.btnGenerateCost.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateCost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerateCost.Location = new System.Drawing.Point(464, 565);
            this.btnGenerateCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerateCost.Name = "btnGenerateCost";
            this.btnGenerateCost.Size = new System.Drawing.Size(172, 56);
            this.btnGenerateCost.TabIndex = 31;
            this.btnGenerateCost.Text = "Generate Cost";
            this.btnGenerateCost.UseVisualStyleBackColor = false;
            this.btnGenerateCost.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.btnGenerateCost);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.txtRentID);
            this.Controls.Add(this.LRentID);
            this.Controls.Add(this.BtClear);
            this.Controls.Add(this.btReceive);
            this.Controls.Add(this.BtRent);
            this.Controls.Add(this.dgvRent);
            this.Controls.Add(this.LManageREnt);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.LCost);
            this.Controls.Add(this.DTRentalEndDate);
            this.Controls.Add(this.LRentalEndDate);
            this.Controls.Add(this.LRentalStartDate);
            this.Controls.Add(this.DTRentalStartDate);
            this.Controls.Add(this.dgvAccessory);
            this.Controls.Add(this.dgvBike);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtSearchAccessory);
            this.Controls.Add(this.txtAccessoryID);
            this.Controls.Add(this.txtSearchBike);
            this.Controls.Add(this.txtBikeID);
            this.Controls.Add(this.LCustomerName);
            this.Controls.Add(this.LCustomerID);
            this.Controls.Add(this.LAccesoryName);
            this.Controls.Add(this.LAccesoryID);
            this.Controls.Add(this.lblSearchBike);
            this.Controls.Add(this.LBikeID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageRent";
            this.Size = new System.Drawing.Size(900, 1000);
            this.Load += new System.EventHandler(this.ManageRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccessory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBikeID;
        private System.Windows.Forms.Label lblSearchBike;
        private System.Windows.Forms.Label LAccesoryID;
        private System.Windows.Forms.Label LAccesoryName;
        private System.Windows.Forms.Label LCustomerID;
        private System.Windows.Forms.Label LCustomerName;
        private System.Windows.Forms.TextBox txtBikeID;
        private System.Windows.Forms.TextBox txtSearchBike;
        private System.Windows.Forms.TextBox txtAccessoryID;
        private System.Windows.Forms.TextBox txtSearchAccessory;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.DataGridView dgvBike;
        private System.Windows.Forms.DataGridView dgvAccessory;
        private System.Windows.Forms.DateTimePicker DTRentalStartDate;
        private System.Windows.Forms.Label LRentalStartDate;
        private System.Windows.Forms.Label LRentalEndDate;
        private System.Windows.Forms.DateTimePicker DTRentalEndDate;
        private System.Windows.Forms.Label LCost;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.Label LManageREnt;
        private System.Windows.Forms.DataGridView dgvRent;
        private System.Windows.Forms.Button BtRent;
        private System.Windows.Forms.Button btReceive;
        private System.Windows.Forms.Button BtClear;
        private System.Windows.Forms.Label LRentID;
        private System.Windows.Forms.TextBox txtRentID;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.Button btnGenerateCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn bikeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bikeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rbikeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessory_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalSDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalEDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
    }
}
