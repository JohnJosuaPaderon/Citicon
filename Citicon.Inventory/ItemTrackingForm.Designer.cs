namespace Citicon.Inventory
{
    partial class ItemTrackingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblIventoryItemsTracking = new System.Windows.Forms.Label();
            this.dgvItemTrackings = new System.Windows.Forms.DataGridView();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.tbxItemDescription = new System.Windows.Forms.TextBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.tbxItemCode = new System.Windows.Forms.TextBox();
            this.colTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrackDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrackLastStockValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrackStockValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrackAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemTrackings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIventoryItemsTracking
            // 
            this.lblIventoryItemsTracking.BackColor = System.Drawing.Color.White;
            this.lblIventoryItemsTracking.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIventoryItemsTracking.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIventoryItemsTracking.Location = new System.Drawing.Point(0, 0);
            this.lblIventoryItemsTracking.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIventoryItemsTracking.Name = "lblIventoryItemsTracking";
            this.lblIventoryItemsTracking.Size = new System.Drawing.Size(1560, 100);
            this.lblIventoryItemsTracking.TabIndex = 12;
            this.lblIventoryItemsTracking.Text = "Inventory Item Tracking";
            this.lblIventoryItemsTracking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvItemTrackings
            // 
            this.dgvItemTrackings.AllowUserToAddRows = false;
            this.dgvItemTrackings.AllowUserToDeleteRows = false;
            this.dgvItemTrackings.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvItemTrackings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemTrackings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemTrackings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvItemTrackings.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvItemTrackings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItemTrackings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvItemTrackings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemTrackings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemTrackings.ColumnHeadersHeight = 50;
            this.dgvItemTrackings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItemTrackings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrack,
            this.colTrackDate,
            this.colCompany,
            this.colBranch,
            this.colTrackLastStockValue,
            this.colTrackStockValue,
            this.colTrackAction});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemTrackings.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItemTrackings.EnableHeadersVisualStyles = false;
            this.dgvItemTrackings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvItemTrackings.Location = new System.Drawing.Point(11, 150);
            this.dgvItemTrackings.MultiSelect = false;
            this.dgvItemTrackings.Name = "dgvItemTrackings";
            this.dgvItemTrackings.ReadOnly = true;
            this.dgvItemTrackings.RowHeadersVisible = false;
            this.dgvItemTrackings.RowTemplate.Height = 40;
            this.dgvItemTrackings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemTrackings.Size = new System.Drawing.Size(1537, 487);
            this.dgvItemTrackings.TabIndex = 13;
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.Location = new System.Drawing.Point(6, 105);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(150, 25);
            this.lblItemDescription.TabIndex = 14;
            this.lblItemDescription.Text = "Item Description";
            // 
            // tbxItemDescription
            // 
            this.tbxItemDescription.BackColor = System.Drawing.Color.White;
            this.tbxItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxItemDescription.Location = new System.Drawing.Point(162, 103);
            this.tbxItemDescription.Name = "tbxItemDescription";
            this.tbxItemDescription.ReadOnly = true;
            this.tbxItemDescription.Size = new System.Drawing.Size(613, 33);
            this.tbxItemDescription.TabIndex = 15;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(781, 105);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(98, 25);
            this.lblItemCode.TabIndex = 16;
            this.lblItemCode.Text = "Item Code";
            // 
            // tbxItemCode
            // 
            this.tbxItemCode.BackColor = System.Drawing.Color.White;
            this.tbxItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxItemCode.Location = new System.Drawing.Point(885, 103);
            this.tbxItemCode.Name = "tbxItemCode";
            this.tbxItemCode.ReadOnly = true;
            this.tbxItemCode.Size = new System.Drawing.Size(523, 33);
            this.tbxItemCode.TabIndex = 17;
            // 
            // colTrack
            // 
            this.colTrack.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTrack.HeaderText = "TRACK";
            this.colTrack.Name = "colTrack";
            this.colTrack.ReadOnly = true;
            this.colTrack.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTrack.Visible = false;
            // 
            // colTrackDate
            // 
            this.colTrackDate.HeaderText = "Date & Time";
            this.colTrackDate.Name = "colTrackDate";
            this.colTrackDate.ReadOnly = true;
            this.colTrackDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colTrackDate.Width = 141;
            // 
            // colCompany
            // 
            this.colCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCompany.HeaderText = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.ReadOnly = true;
            this.colCompany.Width = 116;
            // 
            // colBranch
            // 
            this.colBranch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colBranch.HeaderText = "Branch";
            this.colBranch.Name = "colBranch";
            this.colBranch.ReadOnly = true;
            this.colBranch.Width = 95;
            // 
            // colTrackLastStockValue
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTrackLastStockValue.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTrackLastStockValue.HeaderText = "Last Stock Value";
            this.colTrackLastStockValue.Name = "colTrackLastStockValue";
            this.colTrackLastStockValue.ReadOnly = true;
            this.colTrackLastStockValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTrackLastStockValue.Width = 153;
            // 
            // colTrackStockValue
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTrackStockValue.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTrackStockValue.HeaderText = "Stock Value";
            this.colTrackStockValue.Name = "colTrackStockValue";
            this.colTrackStockValue.ReadOnly = true;
            this.colTrackStockValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTrackStockValue.Width = 115;
            // 
            // colTrackAction
            // 
            this.colTrackAction.HeaderText = "Action";
            this.colTrackAction.Name = "colTrackAction";
            this.colTrackAction.ReadOnly = true;
            this.colTrackAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTrackAction.Width = 71;
            // 
            // ItemTrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1560, 649);
            this.Controls.Add(this.tbxItemCode);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.tbxItemDescription);
            this.Controls.Add(this.lblItemDescription);
            this.Controls.Add(this.dgvItemTrackings);
            this.Controls.Add(this.lblIventoryItemsTracking);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ItemTrackingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citicon Iventory | Item Tracking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemTrackingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemTrackings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIventoryItemsTracking;
        private System.Windows.Forms.DataGridView dgvItemTrackings;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.TextBox tbxItemDescription;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.TextBox tbxItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrackAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrackStockValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrackLastStockValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrackDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrack;
    }
}