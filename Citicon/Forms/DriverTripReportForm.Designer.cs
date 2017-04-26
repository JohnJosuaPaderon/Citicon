namespace Citicon.Forms
{
    partial class DriverTripReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverTripReportForm));
            this.DriverDataGridView = new System.Windows.Forms.DataGridView();
            this.DriverColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeLabel = new System.Windows.Forms.Label();
            this.RangeStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RangeToLabel = new System.Windows.Forms.Label();
            this.RangeEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LoadButton = new System.Windows.Forms.Button();
            this.DeliveryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DriverDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DriverDataGridView
            // 
            this.DriverDataGridView.AllowUserToAddRows = false;
            this.DriverDataGridView.AllowUserToDeleteRows = false;
            this.DriverDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DriverDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DriverDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DriverDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DriverDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DriverDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DriverDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DriverDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DriverDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DriverDataGridView.ColumnHeadersHeight = 60;
            this.DriverDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DriverDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriverColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DriverDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DriverDataGridView.EnableHeadersVisualStyles = false;
            this.DriverDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DriverDataGridView.Location = new System.Drawing.Point(12, 61);
            this.DriverDataGridView.MultiSelect = false;
            this.DriverDataGridView.Name = "DriverDataGridView";
            this.DriverDataGridView.ReadOnly = true;
            this.DriverDataGridView.RowHeadersVisible = false;
            this.DriverDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DriverDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DriverDataGridView.RowTemplate.Height = 40;
            this.DriverDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DriverDataGridView.Size = new System.Drawing.Size(542, 482);
            this.DriverDataGridView.TabIndex = 125;
            // 
            // DriverColumn
            // 
            this.DriverColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DriverColumn.HeaderText = "DRIVERS";
            this.DriverColumn.Name = "DriverColumn";
            this.DriverColumn.ReadOnly = true;
            // 
            // RangeLabel
            // 
            this.RangeLabel.AutoSize = true;
            this.RangeLabel.Location = new System.Drawing.Point(12, 9);
            this.RangeLabel.Name = "RangeLabel";
            this.RangeLabel.Size = new System.Drawing.Size(83, 17);
            this.RangeLabel.TabIndex = 126;
            this.RangeLabel.Text = "Select Range";
            // 
            // RangeStartDateTimePicker
            // 
            this.RangeStartDateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.RangeStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RangeStartDateTimePicker.Location = new System.Drawing.Point(15, 30);
            this.RangeStartDateTimePicker.Name = "RangeStartDateTimePicker";
            this.RangeStartDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.RangeStartDateTimePicker.TabIndex = 127;
            // 
            // RangeToLabel
            // 
            this.RangeToLabel.AutoSize = true;
            this.RangeToLabel.Location = new System.Drawing.Point(221, 36);
            this.RangeToLabel.Name = "RangeToLabel";
            this.RangeToLabel.Size = new System.Drawing.Size(20, 17);
            this.RangeToLabel.TabIndex = 128;
            this.RangeToLabel.Text = "to";
            // 
            // RangeEndDateTimePicker
            // 
            this.RangeEndDateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.RangeEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RangeEndDateTimePicker.Location = new System.Drawing.Point(247, 30);
            this.RangeEndDateTimePicker.Name = "RangeEndDateTimePicker";
            this.RangeEndDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.RangeEndDateTimePicker.TabIndex = 129;
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.Red;
            this.LoadButton.FlatAppearance.BorderSize = 0;
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.ForeColor = System.Drawing.Color.White;
            this.LoadButton.Location = new System.Drawing.Point(454, 20);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(100, 35);
            this.LoadButton.TabIndex = 130;
            this.LoadButton.Text = "LOAD";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // DeliveryDataGridView
            // 
            this.DeliveryDataGridView.AllowUserToAddRows = false;
            this.DeliveryDataGridView.AllowUserToDeleteRows = false;
            this.DeliveryDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeliveryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DeliveryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DeliveryDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DeliveryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeliveryDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DeliveryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeliveryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DeliveryDataGridView.ColumnHeadersHeight = 60;
            this.DeliveryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DeliveryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeliveryDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.DeliveryDataGridView.EnableHeadersVisualStyles = false;
            this.DeliveryDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeliveryDataGridView.Location = new System.Drawing.Point(560, 61);
            this.DeliveryDataGridView.MultiSelect = false;
            this.DeliveryDataGridView.Name = "DeliveryDataGridView";
            this.DeliveryDataGridView.ReadOnly = true;
            this.DeliveryDataGridView.RowHeadersVisible = false;
            this.DeliveryDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.DeliveryDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DeliveryDataGridView.RowTemplate.Height = 40;
            this.DeliveryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeliveryDataGridView.Size = new System.Drawing.Size(711, 482);
            this.DeliveryDataGridView.TabIndex = 131;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "DRIVERS";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DriverTripReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 555);
            this.Controls.Add(this.DeliveryDataGridView);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.RangeEndDateTimePicker);
            this.Controls.Add(this.RangeToLabel);
            this.Controls.Add(this.RangeStartDateTimePicker);
            this.Controls.Add(this.RangeLabel);
            this.Controls.Add(this.DriverDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DriverTripReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trip Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DriverTripReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DriverDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DriverDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverColumn;
        private System.Windows.Forms.Label RangeLabel;
        private System.Windows.Forms.DateTimePicker RangeStartDateTimePicker;
        private System.Windows.Forms.Label RangeToLabel;
        private System.Windows.Forms.DateTimePicker RangeEndDateTimePicker;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.DataGridView DeliveryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}