namespace BikeRent
{
    partial class ManageAccessories
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
            this.lblManageAccessories = new System.Windows.Forms.Label();
            this.lblAccessoryName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAccessoryID = new System.Windows.Forms.Label();
            this.txtAccessoryID = new System.Windows.Forms.TextBox();
            this.txtAccessoryName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btShowDetails = new System.Windows.Forms.Button();
            this.dgvAccessoryList = new System.Windows.Forms.DataGridView();
            this.accessoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccessoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageAccessories
            // 
            this.lblManageAccessories.AutoSize = true;
            this.lblManageAccessories.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageAccessories.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblManageAccessories.Location = new System.Drawing.Point(298, 30);
            this.lblManageAccessories.Name = "lblManageAccessories";
            this.lblManageAccessories.Size = new System.Drawing.Size(297, 34);
            this.lblManageAccessories.TabIndex = 0;
            this.lblManageAccessories.Text = "Manage Accessories";
            // 
            // lblAccessoryName
            // 
            this.lblAccessoryName.AutoSize = true;
            this.lblAccessoryName.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessoryName.Location = new System.Drawing.Point(60, 180);
            this.lblAccessoryName.Name = "lblAccessoryName";
            this.lblAccessoryName.Size = new System.Drawing.Size(172, 27);
            this.lblAccessoryName.TabIndex = 2;
            this.lblAccessoryName.Text = "Accessory Name";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(60, 250);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(101, 27);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity ";
            // 
            // lblAccessoryID
            // 
            this.lblAccessoryID.AutoSize = true;
            this.lblAccessoryID.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessoryID.Location = new System.Drawing.Point(60, 110);
            this.lblAccessoryID.Name = "lblAccessoryID";
            this.lblAccessoryID.Size = new System.Drawing.Size(138, 27);
            this.lblAccessoryID.TabIndex = 4;
            this.lblAccessoryID.Text = "Accessory ID";
            // 
            // txtAccessoryID
            // 
            this.txtAccessoryID.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccessoryID.Location = new System.Drawing.Point(310, 110);
            this.txtAccessoryID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccessoryID.Name = "txtAccessoryID";
            this.txtAccessoryID.ReadOnly = true;
            this.txtAccessoryID.Size = new System.Drawing.Size(281, 34);
            this.txtAccessoryID.TabIndex = 5;
            // 
            // txtAccessoryName
            // 
            this.txtAccessoryName.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccessoryName.Location = new System.Drawing.Point(310, 180);
            this.txtAccessoryName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccessoryName.Name = "txtAccessoryName";
            this.txtAccessoryName.Size = new System.Drawing.Size(281, 34);
            this.txtAccessoryName.TabIndex = 6;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(304, 250);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(281, 34);
            this.txtQuantity.TabIndex = 7;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btSave.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(671, 110);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(168, 62);
            this.btSave.TabIndex = 24;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btRemove.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.ForeColor = System.Drawing.Color.White;
            this.btRemove.Location = new System.Drawing.Point(671, 180);
            this.btRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(169, 62);
            this.btRemove.TabIndex = 25;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btClear.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.Color.White;
            this.btClear.Location = new System.Drawing.Point(671, 250);
            this.btClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(169, 62);
            this.btClear.TabIndex = 27;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btShowDetails
            // 
            this.btShowDetails.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btShowDetails.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowDetails.ForeColor = System.Drawing.Color.White;
            this.btShowDetails.Location = new System.Drawing.Point(671, 320);
            this.btShowDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btShowDetails.Name = "btShowDetails";
            this.btShowDetails.Size = new System.Drawing.Size(168, 62);
            this.btShowDetails.TabIndex = 28;
            this.btShowDetails.Text = "Show Details";
            this.btShowDetails.UseVisualStyleBackColor = false;
            this.btShowDetails.Click += new System.EventHandler(this.btShowDetails_Click);
            // 
            // dgvAccessoryList
            // 
            this.dgvAccessoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccessoryList.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvAccessoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccessoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accessoryID,
            this.accessoryName,
            this.quantity});
            this.dgvAccessoryList.Location = new System.Drawing.Point(60, 400);
            this.dgvAccessoryList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAccessoryList.Name = "dgvAccessoryList";
            this.dgvAccessoryList.ReadOnly = true;
            this.dgvAccessoryList.RowHeadersWidth = 51;
            this.dgvAccessoryList.RowTemplate.Height = 24;
            this.dgvAccessoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccessoryList.Size = new System.Drawing.Size(774, 550);
            this.dgvAccessoryList.TabIndex = 29;
            this.dgvAccessoryList.DoubleClick += new System.EventHandler(this.dgvAccessoryList_DoubleClick);
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
            this.quantity.HeaderText = "Quantity ";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(60, 320);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(78, 27);
            this.lblSearch.TabIndex = 30;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(304, 320);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(281, 34);
            this.txtSearch.TabIndex = 31;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ManageAccessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvAccessoryList);
            this.Controls.Add(this.btShowDetails);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtAccessoryName);
            this.Controls.Add(this.txtAccessoryID);
            this.Controls.Add(this.lblAccessoryID);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblAccessoryName);
            this.Controls.Add(this.lblManageAccessories);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageAccessories";
            this.Size = new System.Drawing.Size(900, 1000);
            this.Load += new System.EventHandler(this.ManageAccessories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccessoryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageAccessories;
        private System.Windows.Forms.Label lblAccessoryName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAccessoryID;
        private System.Windows.Forms.TextBox txtAccessoryID;
        private System.Windows.Forms.TextBox txtAccessoryName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btShowDetails;
        private System.Windows.Forms.DataGridView dgvAccessoryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
