namespace Citicon.Inventory
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.lblIncomingStocks = new System.Windows.Forms.Label();
            this.tcReports = new System.Windows.Forms.TabControl();
            this.tpIncomingStocks = new System.Windows.Forms.TabPage();
            this.IncomingStocksSelection = new System.Windows.Forms.Panel();
            this.panelIncomingStocksSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.lblIncomingStocksSelect = new System.Windows.Forms.Label();
            this.dtpIncomingStocksDailyDate = new System.Windows.Forms.DateTimePicker();
            this.dtpIncomingStocksWeeklyRangeStart = new System.Windows.Forms.DateTimePicker();
            this.lblIncomingStocksWeeklyTo = new System.Windows.Forms.Label();
            this.dtpIncomingStocksWeeklyRangeEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbxIncomingStocksMonthlyMonth = new System.Windows.Forms.ComboBox();
            this.lblIncomingStocksReportType = new System.Windows.Forms.Label();
            this.cmbxIncomingStocksReportType = new System.Windows.Forms.ComboBox();
            this.tpOutgoingStocks = new System.Windows.Forms.TabPage();
            this.tcReports.SuspendLayout();
            this.tpIncomingStocks.SuspendLayout();
            this.IncomingStocksSelection.SuspendLayout();
            this.panelIncomingStocksSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIncomingStocks
            // 
            this.lblIncomingStocks.BackColor = System.Drawing.Color.White;
            this.lblIncomingStocks.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIncomingStocks.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomingStocks.Location = new System.Drawing.Point(0, 0);
            this.lblIncomingStocks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncomingStocks.Name = "lblIncomingStocks";
            this.lblIncomingStocks.Size = new System.Drawing.Size(857, 84);
            this.lblIncomingStocks.TabIndex = 12;
            this.lblIncomingStocks.Text = "Reports";
            this.lblIncomingStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcReports
            // 
            this.tcReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcReports.Controls.Add(this.tpIncomingStocks);
            this.tcReports.Controls.Add(this.tpOutgoingStocks);
            this.tcReports.Location = new System.Drawing.Point(10, 86);
            this.tcReports.Margin = new System.Windows.Forms.Padding(2);
            this.tcReports.Name = "tcReports";
            this.tcReports.Padding = new System.Drawing.Point(20, 10);
            this.tcReports.SelectedIndex = 0;
            this.tcReports.Size = new System.Drawing.Size(838, 405);
            this.tcReports.TabIndex = 13;
            // 
            // tpIncomingStocks
            // 
            this.tpIncomingStocks.Controls.Add(this.IncomingStocksSelection);
            this.tpIncomingStocks.Location = new System.Drawing.Point(4, 44);
            this.tpIncomingStocks.Margin = new System.Windows.Forms.Padding(2);
            this.tpIncomingStocks.Name = "tpIncomingStocks";
            this.tpIncomingStocks.Padding = new System.Windows.Forms.Padding(2);
            this.tpIncomingStocks.Size = new System.Drawing.Size(830, 357);
            this.tpIncomingStocks.TabIndex = 0;
            this.tpIncomingStocks.Text = "Incoming Stocks";
            this.tpIncomingStocks.UseVisualStyleBackColor = true;
            // 
            // IncomingStocksSelection
            // 
            this.IncomingStocksSelection.Controls.Add(this.panelIncomingStocksSettings);
            this.IncomingStocksSelection.Controls.Add(this.lblIncomingStocksReportType);
            this.IncomingStocksSelection.Controls.Add(this.cmbxIncomingStocksReportType);
            this.IncomingStocksSelection.Location = new System.Drawing.Point(6, 6);
            this.IncomingStocksSelection.Margin = new System.Windows.Forms.Padding(2);
            this.IncomingStocksSelection.Name = "IncomingStocksSelection";
            this.IncomingStocksSelection.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.IncomingStocksSelection.Size = new System.Drawing.Size(820, 199);
            this.IncomingStocksSelection.TabIndex = 0;
            // 
            // panelIncomingStocksSettings
            // 
            this.panelIncomingStocksSettings.Controls.Add(this.lblIncomingStocksSelect);
            this.panelIncomingStocksSettings.Controls.Add(this.dtpIncomingStocksDailyDate);
            this.panelIncomingStocksSettings.Controls.Add(this.dtpIncomingStocksWeeklyRangeStart);
            this.panelIncomingStocksSettings.Controls.Add(this.lblIncomingStocksWeeklyTo);
            this.panelIncomingStocksSettings.Controls.Add(this.dtpIncomingStocksWeeklyRangeEnd);
            this.panelIncomingStocksSettings.Controls.Add(this.cmbxIncomingStocksMonthlyMonth);
            this.panelIncomingStocksSettings.Location = new System.Drawing.Point(15, 40);
            this.panelIncomingStocksSettings.Margin = new System.Windows.Forms.Padding(2);
            this.panelIncomingStocksSettings.Name = "panelIncomingStocksSettings";
            this.panelIncomingStocksSettings.Size = new System.Drawing.Size(795, 42);
            this.panelIncomingStocksSettings.TabIndex = 2;
            // 
            // lblIncomingStocksSelect
            // 
            this.lblIncomingStocksSelect.AutoSize = true;
            this.lblIncomingStocksSelect.Location = new System.Drawing.Point(2, 0);
            this.lblIncomingStocksSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncomingStocksSelect.Name = "lblIncomingStocksSelect";
            this.lblIncomingStocksSelect.Size = new System.Drawing.Size(51, 21);
            this.lblIncomingStocksSelect.TabIndex = 0;
            this.lblIncomingStocksSelect.Text = "Select";
            // 
            // dtpIncomingStocksDailyDate
            // 
            this.dtpIncomingStocksDailyDate.CustomFormat = "MMM dd, yyyy";
            this.dtpIncomingStocksDailyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIncomingStocksDailyDate.Location = new System.Drawing.Point(57, 2);
            this.dtpIncomingStocksDailyDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpIncomingStocksDailyDate.Name = "dtpIncomingStocksDailyDate";
            this.dtpIncomingStocksDailyDate.Size = new System.Drawing.Size(129, 29);
            this.dtpIncomingStocksDailyDate.TabIndex = 1;
            this.dtpIncomingStocksDailyDate.Visible = false;
            // 
            // dtpIncomingStocksWeeklyRangeStart
            // 
            this.dtpIncomingStocksWeeklyRangeStart.CustomFormat = "MMM dd, yyyy";
            this.dtpIncomingStocksWeeklyRangeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIncomingStocksWeeklyRangeStart.Location = new System.Drawing.Point(190, 2);
            this.dtpIncomingStocksWeeklyRangeStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpIncomingStocksWeeklyRangeStart.Name = "dtpIncomingStocksWeeklyRangeStart";
            this.dtpIncomingStocksWeeklyRangeStart.Size = new System.Drawing.Size(129, 29);
            this.dtpIncomingStocksWeeklyRangeStart.TabIndex = 2;
            this.dtpIncomingStocksWeeklyRangeStart.Visible = false;
            // 
            // lblIncomingStocksWeeklyTo
            // 
            this.lblIncomingStocksWeeklyTo.AutoSize = true;
            this.lblIncomingStocksWeeklyTo.Location = new System.Drawing.Point(323, 0);
            this.lblIncomingStocksWeeklyTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncomingStocksWeeklyTo.Name = "lblIncomingStocksWeeklyTo";
            this.lblIncomingStocksWeeklyTo.Size = new System.Drawing.Size(24, 21);
            this.lblIncomingStocksWeeklyTo.TabIndex = 3;
            this.lblIncomingStocksWeeklyTo.Text = "to";
            this.lblIncomingStocksWeeklyTo.Visible = false;
            // 
            // dtpIncomingStocksWeeklyRangeEnd
            // 
            this.dtpIncomingStocksWeeklyRangeEnd.CustomFormat = "MMM dd, yyyy";
            this.dtpIncomingStocksWeeklyRangeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIncomingStocksWeeklyRangeEnd.Location = new System.Drawing.Point(351, 2);
            this.dtpIncomingStocksWeeklyRangeEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpIncomingStocksWeeklyRangeEnd.Name = "dtpIncomingStocksWeeklyRangeEnd";
            this.dtpIncomingStocksWeeklyRangeEnd.Size = new System.Drawing.Size(129, 29);
            this.dtpIncomingStocksWeeklyRangeEnd.TabIndex = 4;
            this.dtpIncomingStocksWeeklyRangeEnd.Visible = false;
            // 
            // cmbxIncomingStocksMonthlyMonth
            // 
            this.cmbxIncomingStocksMonthlyMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxIncomingStocksMonthlyMonth.FormattingEnabled = true;
            this.cmbxIncomingStocksMonthlyMonth.Location = new System.Drawing.Point(484, 2);
            this.cmbxIncomingStocksMonthlyMonth.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxIncomingStocksMonthlyMonth.Name = "cmbxIncomingStocksMonthlyMonth";
            this.cmbxIncomingStocksMonthlyMonth.Size = new System.Drawing.Size(193, 29);
            this.cmbxIncomingStocksMonthlyMonth.TabIndex = 5;
            this.cmbxIncomingStocksMonthlyMonth.Visible = false;
            // 
            // lblIncomingStocksReportType
            // 
            this.lblIncomingStocksReportType.AutoSize = true;
            this.lblIncomingStocksReportType.Location = new System.Drawing.Point(10, 9);
            this.lblIncomingStocksReportType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncomingStocksReportType.Name = "lblIncomingStocksReportType";
            this.lblIncomingStocksReportType.Size = new System.Drawing.Size(93, 21);
            this.lblIncomingStocksReportType.TabIndex = 1;
            this.lblIncomingStocksReportType.Text = "Report Type";
            // 
            // cmbxIncomingStocksReportType
            // 
            this.cmbxIncomingStocksReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxIncomingStocksReportType.FormattingEnabled = true;
            this.cmbxIncomingStocksReportType.Location = new System.Drawing.Point(108, 6);
            this.cmbxIncomingStocksReportType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxIncomingStocksReportType.Name = "cmbxIncomingStocksReportType";
            this.cmbxIncomingStocksReportType.Size = new System.Drawing.Size(267, 29);
            this.cmbxIncomingStocksReportType.TabIndex = 0;
            this.cmbxIncomingStocksReportType.SelectedIndexChanged += new System.EventHandler(this.CmbxIncomingStocksReportType_SelectedIndexChanged);
            // 
            // tpOutgoingStocks
            // 
            this.tpOutgoingStocks.Location = new System.Drawing.Point(4, 44);
            this.tpOutgoingStocks.Margin = new System.Windows.Forms.Padding(2);
            this.tpOutgoingStocks.Name = "tpOutgoingStocks";
            this.tpOutgoingStocks.Padding = new System.Windows.Forms.Padding(2);
            this.tpOutgoingStocks.Size = new System.Drawing.Size(830, 357);
            this.tpOutgoingStocks.TabIndex = 1;
            this.tpOutgoingStocks.Text = "Outgoing Stocks";
            this.tpOutgoingStocks.UseVisualStyleBackColor = true;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 502);
            this.Controls.Add(this.tcReports);
            this.Controls.Add(this.lblIncomingStocks);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citicon Inventory | Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tcReports.ResumeLayout(false);
            this.tpIncomingStocks.ResumeLayout(false);
            this.IncomingStocksSelection.ResumeLayout(false);
            this.IncomingStocksSelection.PerformLayout();
            this.panelIncomingStocksSettings.ResumeLayout(false);
            this.panelIncomingStocksSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIncomingStocks;
        private System.Windows.Forms.TabControl tcReports;
        private System.Windows.Forms.TabPage tpIncomingStocks;
        private System.Windows.Forms.TabPage tpOutgoingStocks;
        private System.Windows.Forms.Panel IncomingStocksSelection;
        private System.Windows.Forms.Label lblIncomingStocksReportType;
        private System.Windows.Forms.ComboBox cmbxIncomingStocksReportType;
        private System.Windows.Forms.FlowLayoutPanel panelIncomingStocksSettings;
        private System.Windows.Forms.Label lblIncomingStocksSelect;
        private System.Windows.Forms.DateTimePicker dtpIncomingStocksDailyDate;
        private System.Windows.Forms.DateTimePicker dtpIncomingStocksWeeklyRangeStart;
        private System.Windows.Forms.Label lblIncomingStocksWeeklyTo;
        private System.Windows.Forms.DateTimePicker dtpIncomingStocksWeeklyRangeEnd;
        private System.Windows.Forms.ComboBox cmbxIncomingStocksMonthlyMonth;
    }
}