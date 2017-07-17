namespace Citicon.Forms
{
    partial class DailyTallySheetForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyTallySheetForm));
            this.SelectDateLabel = new System.Windows.Forms.Label();
            this.SelectDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.DeliveryDataGridView = new System.Windows.Forms.DataGridView();
            this.ProjectDesignDataGridView = new System.Windows.Forms.DataGridView();
            this.ProjectDesignColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectDesign_ProjectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectDesign_Project_ClientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectDesign_BlankColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelPrintButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.DeliveryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_LoadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_DeliveryReceiptNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_TransitMixerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_DriverColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_VolumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_PlantLeaveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_PlantArriveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_ServiceEngineerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_BlankColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDesignDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectDateLabel
            // 
            this.SelectDateLabel.AutoSize = true;
            this.SelectDateLabel.Location = new System.Drawing.Point(12, 9);
            this.SelectDateLabel.Name = "SelectDateLabel";
            this.SelectDateLabel.Size = new System.Drawing.Size(73, 17);
            this.SelectDateLabel.TabIndex = 120;
            this.SelectDateLabel.Text = "Select Date";
            // 
            // SelectDateTimePicker
            // 
            this.SelectDateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.SelectDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SelectDateTimePicker.Location = new System.Drawing.Point(15, 29);
            this.SelectDateTimePicker.Name = "SelectDateTimePicker";
            this.SelectDateTimePicker.Size = new System.Drawing.Size(269, 25);
            this.SelectDateTimePicker.TabIndex = 121;
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.Red;
            this.GenerateButton.FlatAppearance.BorderSize = 0;
            this.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.ForeColor = System.Drawing.Color.White;
            this.GenerateButton.Location = new System.Drawing.Point(291, 26);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(100, 35);
            this.GenerateButton.TabIndex = 122;
            this.GenerateButton.Text = "GENERATE";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // DeliveryDataGridView
            // 
            this.DeliveryDataGridView.AllowUserToAddRows = false;
            this.DeliveryDataGridView.AllowUserToDeleteRows = false;
            this.DeliveryDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeliveryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DeliveryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DeliveryDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DeliveryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeliveryDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DeliveryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeliveryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DeliveryDataGridView.ColumnHeadersHeight = 60;
            this.DeliveryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DeliveryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeliveryColumn,
            this.Delivery_LoadColumn,
            this.Delivery_DeliveryReceiptNumber,
            this.Delivery_TransitMixerColumn,
            this.Delivery_DriverColumn,
            this.Delivery_VolumeColumn,
            this.Delivery_PlantLeaveColumn,
            this.Delivery_PlantArriveColumn,
            this.Delivery_ServiceEngineerColumn,
            this.Delivery_BlankColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeliveryDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.DeliveryDataGridView.EnableHeadersVisualStyles = false;
            this.DeliveryDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeliveryDataGridView.Location = new System.Drawing.Point(697, 67);
            this.DeliveryDataGridView.MultiSelect = false;
            this.DeliveryDataGridView.Name = "DeliveryDataGridView";
            this.DeliveryDataGridView.ReadOnly = true;
            this.DeliveryDataGridView.RowHeadersVisible = false;
            this.DeliveryDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.DeliveryDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DeliveryDataGridView.RowTemplate.Height = 40;
            this.DeliveryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeliveryDataGridView.Size = new System.Drawing.Size(650, 681);
            this.DeliveryDataGridView.TabIndex = 123;
            // 
            // ProjectDesignDataGridView
            // 
            this.ProjectDesignDataGridView.AllowUserToAddRows = false;
            this.ProjectDesignDataGridView.AllowUserToDeleteRows = false;
            this.ProjectDesignDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProjectDesignDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ProjectDesignDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProjectDesignDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProjectDesignDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProjectDesignDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectDesignDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ProjectDesignDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectDesignDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ProjectDesignDataGridView.ColumnHeadersHeight = 60;
            this.ProjectDesignDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProjectDesignDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectDesignColumn,
            this.ProjectDesign_ProjectColumn,
            this.ProjectDesign_Project_ClientColumn,
            this.ProjectDesign_BlankColumn});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProjectDesignDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.ProjectDesignDataGridView.EnableHeadersVisualStyles = false;
            this.ProjectDesignDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProjectDesignDataGridView.Location = new System.Drawing.Point(12, 67);
            this.ProjectDesignDataGridView.MultiSelect = false;
            this.ProjectDesignDataGridView.Name = "ProjectDesignDataGridView";
            this.ProjectDesignDataGridView.ReadOnly = true;
            this.ProjectDesignDataGridView.RowHeadersVisible = false;
            this.ProjectDesignDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.ProjectDesignDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ProjectDesignDataGridView.RowTemplate.Height = 40;
            this.ProjectDesignDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProjectDesignDataGridView.Size = new System.Drawing.Size(679, 681);
            this.ProjectDesignDataGridView.TabIndex = 124;
            this.ProjectDesignDataGridView.SelectionChanged += new System.EventHandler(this.ProjectDesignDataGridView_SelectionChanged);
            // 
            // ProjectDesignColumn
            // 
            this.ProjectDesignColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProjectDesignColumn.HeaderText = "DESIGNS";
            this.ProjectDesignColumn.MinimumWidth = 100;
            this.ProjectDesignColumn.Name = "ProjectDesignColumn";
            this.ProjectDesignColumn.ReadOnly = true;
            // 
            // ProjectDesign_ProjectColumn
            // 
            this.ProjectDesign_ProjectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProjectDesign_ProjectColumn.HeaderText = "PROJECT";
            this.ProjectDesign_ProjectColumn.Name = "ProjectDesign_ProjectColumn";
            this.ProjectDesign_ProjectColumn.ReadOnly = true;
            this.ProjectDesign_ProjectColumn.Width = 84;
            // 
            // ProjectDesign_Project_ClientColumn
            // 
            this.ProjectDesign_Project_ClientColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProjectDesign_Project_ClientColumn.HeaderText = "CLIENT";
            this.ProjectDesign_Project_ClientColumn.Name = "ProjectDesign_Project_ClientColumn";
            this.ProjectDesign_Project_ClientColumn.ReadOnly = true;
            this.ProjectDesign_Project_ClientColumn.Width = 73;
            // 
            // ProjectDesign_BlankColumn
            // 
            this.ProjectDesign_BlankColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectDesign_BlankColumn.HeaderText = "";
            this.ProjectDesign_BlankColumn.Name = "ProjectDesign_BlankColumn";
            this.ProjectDesign_BlankColumn.ReadOnly = true;
            // 
            // CancelPrintButton
            // 
            this.CancelPrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelPrintButton.BackColor = System.Drawing.Color.Red;
            this.CancelPrintButton.FlatAppearance.BorderSize = 0;
            this.CancelPrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelPrintButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelPrintButton.ForeColor = System.Drawing.Color.White;
            this.CancelPrintButton.Location = new System.Drawing.Point(1246, 754);
            this.CancelPrintButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelPrintButton.Name = "CancelPrintButton";
            this.CancelPrintButton.Size = new System.Drawing.Size(100, 35);
            this.CancelPrintButton.TabIndex = 125;
            this.CancelPrintButton.Text = "CANCEL";
            this.CancelPrintButton.UseVisualStyleBackColor = false;
            this.CancelPrintButton.Click += new System.EventHandler(this.CancelPrintButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.BackColor = System.Drawing.Color.Red;
            this.ExportButton.FlatAppearance.BorderSize = 0;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.ForeColor = System.Drawing.Color.White;
            this.ExportButton.Location = new System.Drawing.Point(1138, 754);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(100, 35);
            this.ExportButton.TabIndex = 126;
            this.ExportButton.Text = "EXPORT";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // DeliveryColumn
            // 
            this.DeliveryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeliveryColumn.HeaderText = "DESIGNS";
            this.DeliveryColumn.MinimumWidth = 100;
            this.DeliveryColumn.Name = "DeliveryColumn";
            this.DeliveryColumn.ReadOnly = true;
            this.DeliveryColumn.Visible = false;
            // 
            // Delivery_LoadColumn
            // 
            this.Delivery_LoadColumn.HeaderText = "LOAD";
            this.Delivery_LoadColumn.Name = "Delivery_LoadColumn";
            this.Delivery_LoadColumn.ReadOnly = true;
            this.Delivery_LoadColumn.Width = 65;
            // 
            // Delivery_DeliveryReceiptNumber
            // 
            this.Delivery_DeliveryReceiptNumber.HeaderText = "DR NO.";
            this.Delivery_DeliveryReceiptNumber.Name = "Delivery_DeliveryReceiptNumber";
            this.Delivery_DeliveryReceiptNumber.ReadOnly = true;
            this.Delivery_DeliveryReceiptNumber.Width = 70;
            // 
            // Delivery_TransitMixerColumn
            // 
            this.Delivery_TransitMixerColumn.HeaderText = "TRANSIT MIXER";
            this.Delivery_TransitMixerColumn.Name = "Delivery_TransitMixerColumn";
            this.Delivery_TransitMixerColumn.ReadOnly = true;
            this.Delivery_TransitMixerColumn.Width = 113;
            // 
            // Delivery_DriverColumn
            // 
            this.Delivery_DriverColumn.HeaderText = "DRIVER";
            this.Delivery_DriverColumn.Name = "Delivery_DriverColumn";
            this.Delivery_DriverColumn.ReadOnly = true;
            this.Delivery_DriverColumn.Width = 75;
            // 
            // Delivery_VolumeColumn
            // 
            this.Delivery_VolumeColumn.HeaderText = "VOLUME";
            this.Delivery_VolumeColumn.Name = "Delivery_VolumeColumn";
            this.Delivery_VolumeColumn.ReadOnly = true;
            this.Delivery_VolumeColumn.Width = 84;
            // 
            // Delivery_PlantLeaveColumn
            // 
            dataGridViewCellStyle3.Format = "HH:mm";
            this.Delivery_PlantLeaveColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.Delivery_PlantLeaveColumn.HeaderText = "PLANT LEAVE";
            this.Delivery_PlantLeaveColumn.Name = "Delivery_PlantLeaveColumn";
            this.Delivery_PlantLeaveColumn.ReadOnly = true;
            // 
            // Delivery_PlantArriveColumn
            // 
            dataGridViewCellStyle4.Format = "HH:mm";
            this.Delivery_PlantArriveColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.Delivery_PlantArriveColumn.HeaderText = "PLANT ARRIVE";
            this.Delivery_PlantArriveColumn.Name = "Delivery_PlantArriveColumn";
            this.Delivery_PlantArriveColumn.ReadOnly = true;
            this.Delivery_PlantArriveColumn.Width = 106;
            // 
            // Delivery_ServiceEngineerColumn
            // 
            this.Delivery_ServiceEngineerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delivery_ServiceEngineerColumn.HeaderText = "SERVICE ENGINEER";
            this.Delivery_ServiceEngineerColumn.Name = "Delivery_ServiceEngineerColumn";
            this.Delivery_ServiceEngineerColumn.ReadOnly = true;
            this.Delivery_ServiceEngineerColumn.Width = 132;
            // 
            // Delivery_BlankColumn
            // 
            this.Delivery_BlankColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delivery_BlankColumn.HeaderText = "";
            this.Delivery_BlankColumn.Name = "Delivery_BlankColumn";
            this.Delivery_BlankColumn.ReadOnly = true;
            // 
            // DailyTallySheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1359, 801);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.CancelPrintButton);
            this.Controls.Add(this.ProjectDesignDataGridView);
            this.Controls.Add(this.DeliveryDataGridView);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.SelectDateTimePicker);
            this.Controls.Add(this.SelectDateLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DailyTallySheetForm";
            this.Text = "Daily Tally Sheet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDesignDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SelectDateLabel;
        private System.Windows.Forms.DateTimePicker SelectDateTimePicker;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.DataGridView DeliveryDataGridView;
        private System.Windows.Forms.DataGridView ProjectDesignDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDesignColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDesign_ProjectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDesign_Project_ClientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDesign_BlankColumn;
        private System.Windows.Forms.Button CancelPrintButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_LoadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_DeliveryReceiptNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_TransitMixerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_DriverColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_VolumeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_PlantLeaveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_PlantArriveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_ServiceEngineerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_BlankColumn;
    }
}