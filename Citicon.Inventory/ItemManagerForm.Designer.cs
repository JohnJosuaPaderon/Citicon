namespace Citicon.Inventory
{
    partial class ItemManagerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblInventoryItems = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemsClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemsSubClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemsStockValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.lblItemClassification = new System.Windows.Forms.Label();
            this.cmbxItemClassification = new System.Windows.Forms.ComboBox();
            this.lblItemSubClassification = new System.Windows.Forms.Label();
            this.cmbxItemSubClassification = new System.Windows.Forms.ComboBox();
            this.lblItemStockValue = new System.Windows.Forms.Label();
            this.nudItemStockValue = new System.Windows.Forms.NumericUpDown();
            this.tbxItemCode = new System.Windows.Forms.TextBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.lblNoSubClassification = new System.Windows.Forms.LinkLabel();
            this.tbxItemDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemStockValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInventoryItems
            // 
            this.lblInventoryItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInventoryItems.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryItems.Location = new System.Drawing.Point(0, 0);
            this.lblInventoryItems.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInventoryItems.Name = "lblInventoryItems";
            this.lblInventoryItems.Size = new System.Drawing.Size(1524, 100);
            this.lblInventoryItems.TabIndex = 9;
            this.lblInventoryItems.Text = "Inventory Items";
            this.lblInventoryItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvItems.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.ColumnHeadersHeight = 50;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colItemCode,
            this.colItemsClassification,
            this.colItemsSubClassification,
            this.colItemsStockValue});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvItems.Location = new System.Drawing.Point(12, 103);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowTemplate.Height = 30;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(1082, 629);
            this.dgvItems.TabIndex = 12;
            this.dgvItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvItems_RowsAdded);
            this.dgvItems.SelectionChanged += new System.EventHandler(this.dgvItems_SelectionChanged);
            // 
            // colItem
            // 
            this.colItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItem.HeaderText = "Description";
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            // 
            // colItemCode
            // 
            this.colItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colItemCode.HeaderText = "Code";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.ReadOnly = true;
            this.colItemCode.Width = 80;
            // 
            // colItemsClassification
            // 
            this.colItemsClassification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colItemsClassification.HeaderText = "Classification";
            this.colItemsClassification.Name = "colItemsClassification";
            this.colItemsClassification.ReadOnly = true;
            this.colItemsClassification.Width = 147;
            // 
            // colItemsSubClassification
            // 
            this.colItemsSubClassification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colItemsSubClassification.HeaderText = "Sub-Classification";
            this.colItemsSubClassification.Name = "colItemsSubClassification";
            this.colItemsSubClassification.ReadOnly = true;
            this.colItemsSubClassification.Width = 187;
            // 
            // colItemsStockValue
            // 
            this.colItemsStockValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colItemsStockValue.HeaderText = "Stock Value";
            this.colItemsStockValue.Name = "colItemsStockValue";
            this.colItemsStockValue.ReadOnly = true;
            this.colItemsStockValue.Width = 134;
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.Location = new System.Drawing.Point(1095, 284);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(108, 25);
            this.lblItemDescription.TabIndex = 13;
            this.lblItemDescription.Text = "Description";
            // 
            // btnNewItem
            // 
            this.btnNewItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewItem.ForeColor = System.Drawing.Color.White;
            this.btnNewItem.Location = new System.Drawing.Point(1100, 103);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(125, 50);
            this.btnNewItem.TabIndex = 35;
            this.btnNewItem.Text = "&New";
            this.btnNewItem.UseVisualStyleBackColor = false;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditItem.ForeColor = System.Drawing.Color.White;
            this.btnEditItem.Location = new System.Drawing.Point(1231, 103);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(125, 50);
            this.btnEditItem.TabIndex = 36;
            this.btnEditItem.Text = "&Edit";
            this.btnEditItem.UseVisualStyleBackColor = false;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // lblItemClassification
            // 
            this.lblItemClassification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemClassification.AutoSize = true;
            this.lblItemClassification.Location = new System.Drawing.Point(1095, 156);
            this.lblItemClassification.Name = "lblItemClassification";
            this.lblItemClassification.Size = new System.Drawing.Size(123, 25);
            this.lblItemClassification.TabIndex = 38;
            this.lblItemClassification.Text = "Classification";
            // 
            // cmbxItemClassification
            // 
            this.cmbxItemClassification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxItemClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxItemClassification.Enabled = false;
            this.cmbxItemClassification.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxItemClassification.FormattingEnabled = true;
            this.cmbxItemClassification.Location = new System.Drawing.Point(1100, 184);
            this.cmbxItemClassification.Name = "cmbxItemClassification";
            this.cmbxItemClassification.Size = new System.Drawing.Size(412, 33);
            this.cmbxItemClassification.TabIndex = 39;
            this.cmbxItemClassification.SelectedIndexChanged += new System.EventHandler(this.cmbxItemClassification_SelectedIndexChanged);
            // 
            // lblItemSubClassification
            // 
            this.lblItemSubClassification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemSubClassification.AutoSize = true;
            this.lblItemSubClassification.Location = new System.Drawing.Point(1095, 220);
            this.lblItemSubClassification.Name = "lblItemSubClassification";
            this.lblItemSubClassification.Size = new System.Drawing.Size(163, 25);
            this.lblItemSubClassification.TabIndex = 40;
            this.lblItemSubClassification.Text = "Sub-Classification";
            // 
            // cmbxItemSubClassification
            // 
            this.cmbxItemSubClassification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxItemSubClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxItemSubClassification.Enabled = false;
            this.cmbxItemSubClassification.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxItemSubClassification.FormattingEnabled = true;
            this.cmbxItemSubClassification.Location = new System.Drawing.Point(1100, 248);
            this.cmbxItemSubClassification.Name = "cmbxItemSubClassification";
            this.cmbxItemSubClassification.Size = new System.Drawing.Size(412, 33);
            this.cmbxItemSubClassification.TabIndex = 41;
            this.cmbxItemSubClassification.SelectedIndexChanged += new System.EventHandler(this.cmbxItemSubClassification_SelectedIndexChanged);
            // 
            // lblItemStockValue
            // 
            this.lblItemStockValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemStockValue.AutoSize = true;
            this.lblItemStockValue.Location = new System.Drawing.Point(1095, 412);
            this.lblItemStockValue.Name = "lblItemStockValue";
            this.lblItemStockValue.Size = new System.Drawing.Size(162, 25);
            this.lblItemStockValue.TabIndex = 44;
            this.lblItemStockValue.Text = "Initial Stock Value";
            // 
            // nudItemStockValue
            // 
            this.nudItemStockValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudItemStockValue.Enabled = false;
            this.nudItemStockValue.Location = new System.Drawing.Point(1100, 440);
            this.nudItemStockValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudItemStockValue.Name = "nudItemStockValue";
            this.nudItemStockValue.Size = new System.Drawing.Size(412, 33);
            this.nudItemStockValue.TabIndex = 45;
            // 
            // tbxItemCode
            // 
            this.tbxItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxItemCode.Enabled = false;
            this.tbxItemCode.Location = new System.Drawing.Point(1100, 376);
            this.tbxItemCode.MaxLength = 39;
            this.tbxItemCode.Name = "tbxItemCode";
            this.tbxItemCode.Size = new System.Drawing.Size(412, 33);
            this.tbxItemCode.TabIndex = 47;
            // 
            // lblItemCode
            // 
            this.lblItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(1095, 348);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(56, 25);
            this.lblItemCode.TabIndex = 46;
            this.lblItemCode.Text = "Code";
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelItem.ForeColor = System.Drawing.Color.White;
            this.btnCancelItem.Location = new System.Drawing.Point(1387, 479);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(125, 50);
            this.btnCancelItem.TabIndex = 50;
            this.btnCancelItem.Text = "&Cancel";
            this.btnCancelItem.UseVisualStyleBackColor = false;
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveItem.ForeColor = System.Drawing.Color.White;
            this.btnSaveItem.Location = new System.Drawing.Point(1256, 479);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(125, 50);
            this.btnSaveItem.TabIndex = 49;
            this.btnSaveItem.Text = "&Save";
            this.btnSaveItem.UseVisualStyleBackColor = false;
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(1125, 479);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(125, 50);
            this.btnRemoveItem.TabIndex = 48;
            this.btnRemoveItem.Text = "&Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // lblNoSubClassification
            // 
            this.lblNoSubClassification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoSubClassification.AutoSize = true;
            this.lblNoSubClassification.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNoSubClassification.Location = new System.Drawing.Point(1438, 220);
            this.lblNoSubClassification.Name = "lblNoSubClassification";
            this.lblNoSubClassification.Size = new System.Drawing.Size(74, 25);
            this.lblNoSubClassification.TabIndex = 51;
            this.lblNoSubClassification.TabStop = true;
            this.lblNoSubClassification.Text = "No Sub";
            this.lblNoSubClassification.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNoSubClassification_LinkClicked);
            // 
            // tbxItemDescription
            // 
            this.tbxItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxItemDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxItemDescription.Enabled = false;
            this.tbxItemDescription.Location = new System.Drawing.Point(1100, 312);
            this.tbxItemDescription.Name = "tbxItemDescription";
            this.tbxItemDescription.Size = new System.Drawing.Size(412, 33);
            this.tbxItemDescription.TabIndex = 37;
            // 
            // ItemManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1524, 744);
            this.Controls.Add(this.lblNoSubClassification);
            this.Controls.Add(this.btnCancelItem);
            this.Controls.Add(this.btnSaveItem);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.tbxItemCode);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.nudItemStockValue);
            this.Controls.Add(this.lblItemStockValue);
            this.Controls.Add(this.cmbxItemSubClassification);
            this.Controls.Add(this.lblItemSubClassification);
            this.Controls.Add(this.cmbxItemClassification);
            this.Controls.Add(this.lblItemClassification);
            this.Controls.Add(this.tbxItemDescription);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.btnNewItem);
            this.Controls.Add(this.lblItemDescription);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.lblInventoryItems);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ItemManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citicon Inventory | Items Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemStockValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventoryItems;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Label lblItemClassification;
        private System.Windows.Forms.ComboBox cmbxItemClassification;
        private System.Windows.Forms.Label lblItemSubClassification;
        private System.Windows.Forms.ComboBox cmbxItemSubClassification;
        private System.Windows.Forms.Label lblItemStockValue;
        private System.Windows.Forms.NumericUpDown nudItemStockValue;
        private System.Windows.Forms.TextBox tbxItemCode;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Button btnCancelItem;
        private System.Windows.Forms.Button btnSaveItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.LinkLabel lblNoSubClassification;
        private System.Windows.Forms.TextBox tbxItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemsStockValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemsSubClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemsClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
    }
}