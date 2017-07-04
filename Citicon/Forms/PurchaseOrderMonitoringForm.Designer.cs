namespace Citicon.Forms
{
    partial class PurchaseOrderMonitoringForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderMonitoringForm));
            this.PurchaseOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.PurchaseOrderProjectDesignDataGridView = new System.Windows.Forms.DataGridView();
            this.PurchaseOrderProjectDesignColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseOrderProjectDesign_MaximumVolumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseOrderProjectDesign_ConsumedVolumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.PurchaseOrderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseOrder_MaximumCumulativePricePerCubicMeterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseOrder_RunningBalanceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseOrder_ProjectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseOrder_Project_ClientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseOrder_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseOrderProjectDesignDataGridView)).BeginInit();
            this.tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // PurchaseOrderDataGridView
            // 
            this.PurchaseOrderDataGridView.AllowUserToAddRows = false;
            this.PurchaseOrderDataGridView.AllowUserToDeleteRows = false;
            this.PurchaseOrderDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PurchaseOrderDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PurchaseOrderDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PurchaseOrderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PurchaseOrderDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.PurchaseOrderDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PurchaseOrderDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.PurchaseOrderDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PurchaseOrderDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PurchaseOrderDataGridView.ColumnHeadersHeight = 60;
            this.PurchaseOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PurchaseOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseOrderColumn,
            this.PurchaseOrder_MaximumCumulativePricePerCubicMeterColumn,
            this.PurchaseOrder_RunningBalanceColumn,
            this.PurchaseOrder_ProjectColumn,
            this.PurchaseOrder_Project_ClientColumn,
            this.PurchaseOrder_ExtraColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PurchaseOrderDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.PurchaseOrderDataGridView.EnableHeadersVisualStyles = false;
            this.PurchaseOrderDataGridView.GridColor = System.Drawing.Color.Red;
            this.PurchaseOrderDataGridView.Location = new System.Drawing.Point(2, 3);
            this.PurchaseOrderDataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PurchaseOrderDataGridView.MultiSelect = false;
            this.PurchaseOrderDataGridView.Name = "PurchaseOrderDataGridView";
            this.PurchaseOrderDataGridView.ReadOnly = true;
            this.PurchaseOrderDataGridView.RowHeadersVisible = false;
            this.PurchaseOrderDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PurchaseOrderDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.PurchaseOrderDataGridView.RowTemplate.Height = 40;
            this.PurchaseOrderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PurchaseOrderDataGridView.Size = new System.Drawing.Size(420, 787);
            this.PurchaseOrderDataGridView.TabIndex = 109;
            this.PurchaseOrderDataGridView.SelectionChanged += new System.EventHandler(this.PurchaseOrderDataGridView_SelectionChanged);
            // 
            // PurchaseOrderProjectDesignDataGridView
            // 
            this.PurchaseOrderProjectDesignDataGridView.AllowUserToAddRows = false;
            this.PurchaseOrderProjectDesignDataGridView.AllowUserToDeleteRows = false;
            this.PurchaseOrderProjectDesignDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PurchaseOrderProjectDesignDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.PurchaseOrderProjectDesignDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PurchaseOrderProjectDesignDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PurchaseOrderProjectDesignDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.PurchaseOrderProjectDesignDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PurchaseOrderProjectDesignDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.PurchaseOrderProjectDesignDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PurchaseOrderProjectDesignDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.PurchaseOrderProjectDesignDataGridView.ColumnHeadersHeight = 60;
            this.PurchaseOrderProjectDesignDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PurchaseOrderProjectDesignDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseOrderProjectDesignColumn,
            this.PurchaseOrderProjectDesign_MaximumVolumeColumn,
            this.PurchaseOrderProjectDesign_ConsumedVolumeColumn,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PurchaseOrderProjectDesignDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.PurchaseOrderProjectDesignDataGridView.EnableHeadersVisualStyles = false;
            this.PurchaseOrderProjectDesignDataGridView.GridColor = System.Drawing.Color.Red;
            this.PurchaseOrderProjectDesignDataGridView.Location = new System.Drawing.Point(426, 3);
            this.PurchaseOrderProjectDesignDataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PurchaseOrderProjectDesignDataGridView.MultiSelect = false;
            this.PurchaseOrderProjectDesignDataGridView.Name = "PurchaseOrderProjectDesignDataGridView";
            this.PurchaseOrderProjectDesignDataGridView.ReadOnly = true;
            this.PurchaseOrderProjectDesignDataGridView.RowHeadersVisible = false;
            this.PurchaseOrderProjectDesignDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PurchaseOrderProjectDesignDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.PurchaseOrderProjectDesignDataGridView.RowTemplate.Height = 40;
            this.PurchaseOrderProjectDesignDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PurchaseOrderProjectDesignDataGridView.Size = new System.Drawing.Size(420, 787);
            this.PurchaseOrderProjectDesignDataGridView.TabIndex = 110;
            // 
            // PurchaseOrderProjectDesignColumn
            // 
            this.PurchaseOrderProjectDesignColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PurchaseOrderProjectDesignColumn.HeaderText = "DESIGNS";
            this.PurchaseOrderProjectDesignColumn.MinimumWidth = 100;
            this.PurchaseOrderProjectDesignColumn.Name = "PurchaseOrderProjectDesignColumn";
            this.PurchaseOrderProjectDesignColumn.ReadOnly = true;
            // 
            // PurchaseOrderProjectDesign_MaximumVolumeColumn
            // 
            this.PurchaseOrderProjectDesign_MaximumVolumeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PurchaseOrderProjectDesign_MaximumVolumeColumn.HeaderText = "MAX. VOL.";
            this.PurchaseOrderProjectDesign_MaximumVolumeColumn.Name = "PurchaseOrderProjectDesign_MaximumVolumeColumn";
            this.PurchaseOrderProjectDesign_MaximumVolumeColumn.ReadOnly = true;
            this.PurchaseOrderProjectDesign_MaximumVolumeColumn.Width = 86;
            // 
            // PurchaseOrderProjectDesign_ConsumedVolumeColumn
            // 
            this.PurchaseOrderProjectDesign_ConsumedVolumeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PurchaseOrderProjectDesign_ConsumedVolumeColumn.HeaderText = "CONSUMED VOL.";
            this.PurchaseOrderProjectDesign_ConsumedVolumeColumn.Name = "PurchaseOrderProjectDesign_ConsumedVolumeColumn";
            this.PurchaseOrderProjectDesign_ConsumedVolumeColumn.ReadOnly = true;
            this.PurchaseOrderProjectDesign_ConsumedVolumeColumn.Width = 123;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // tlp
            // 
            this.tlp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp.ColumnCount = 2;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.Controls.Add(this.PurchaseOrderDataGridView, 0, 0);
            this.tlp.Controls.Add(this.PurchaseOrderProjectDesignDataGridView, 1, 0);
            this.tlp.Location = new System.Drawing.Point(12, 12);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 1;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.Size = new System.Drawing.Size(848, 793);
            this.tlp.TabIndex = 111;
            // 
            // PurchaseOrderColumn
            // 
            this.PurchaseOrderColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PurchaseOrderColumn.HeaderText = "P.O. NO.";
            this.PurchaseOrderColumn.MinimumWidth = 100;
            this.PurchaseOrderColumn.Name = "PurchaseOrderColumn";
            this.PurchaseOrderColumn.ReadOnly = true;
            // 
            // PurchaseOrder_MaximumCumulativePricePerCubicMeterColumn
            // 
            this.PurchaseOrder_MaximumCumulativePricePerCubicMeterColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PurchaseOrder_MaximumCumulativePricePerCubicMeterColumn.HeaderText = "MAX. CUMULATIVE PRICE/CU.M.";
            this.PurchaseOrder_MaximumCumulativePricePerCubicMeterColumn.Name = "PurchaseOrder_MaximumCumulativePricePerCubicMeterColumn";
            this.PurchaseOrder_MaximumCumulativePricePerCubicMeterColumn.ReadOnly = true;
            this.PurchaseOrder_MaximumCumulativePricePerCubicMeterColumn.Width = 134;
            // 
            // PurchaseOrder_RunningBalanceColumn
            // 
            this.PurchaseOrder_RunningBalanceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "#,##0.00";
            this.PurchaseOrder_RunningBalanceColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.PurchaseOrder_RunningBalanceColumn.HeaderText = "RUNNING BALANCE";
            this.PurchaseOrder_RunningBalanceColumn.Name = "PurchaseOrder_RunningBalanceColumn";
            this.PurchaseOrder_RunningBalanceColumn.ReadOnly = true;
            this.PurchaseOrder_RunningBalanceColumn.Width = 136;
            // 
            // PurchaseOrder_ProjectColumn
            // 
            this.PurchaseOrder_ProjectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PurchaseOrder_ProjectColumn.HeaderText = "PROJECT";
            this.PurchaseOrder_ProjectColumn.Name = "PurchaseOrder_ProjectColumn";
            this.PurchaseOrder_ProjectColumn.ReadOnly = true;
            this.PurchaseOrder_ProjectColumn.Width = 84;
            // 
            // PurchaseOrder_Project_ClientColumn
            // 
            this.PurchaseOrder_Project_ClientColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PurchaseOrder_Project_ClientColumn.HeaderText = "CLIENT";
            this.PurchaseOrder_Project_ClientColumn.Name = "PurchaseOrder_Project_ClientColumn";
            this.PurchaseOrder_Project_ClientColumn.ReadOnly = true;
            this.PurchaseOrder_Project_ClientColumn.Width = 73;
            // 
            // PurchaseOrder_ExtraColumn
            // 
            this.PurchaseOrder_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PurchaseOrder_ExtraColumn.HeaderText = "";
            this.PurchaseOrder_ExtraColumn.Name = "PurchaseOrder_ExtraColumn";
            this.PurchaseOrder_ExtraColumn.ReadOnly = true;
            // 
            // PurchaseOrderMonitoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 817);
            this.Controls.Add(this.tlp);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PurchaseOrderMonitoringForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order Monitoring";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PurchaseOrderMonitoringForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseOrderProjectDesignDataGridView)).EndInit();
            this.tlp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PurchaseOrderDataGridView;
        private System.Windows.Forms.DataGridView PurchaseOrderProjectDesignDataGridView;
        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseOrderProjectDesignColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseOrderProjectDesign_MaximumVolumeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseOrderProjectDesign_ConsumedVolumeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseOrderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseOrder_MaximumCumulativePricePerCubicMeterColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseOrder_RunningBalanceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseOrder_ProjectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseOrder_Project_ClientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseOrder_ExtraColumn;
    }
}