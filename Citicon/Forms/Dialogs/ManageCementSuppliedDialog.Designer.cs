namespace Citicon.Forms.Dialogs
{
    partial class ManageCementSuppliedDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCementSuppliedDialog));
            this.DeliveryGroupBox = new System.Windows.Forms.GroupBox();
            this.Delivery_DeliveryReceiptNumberLabel = new System.Windows.Forms.Label();
            this.Delivery_DeliveryReceiptNumberTextBox = new System.Windows.Forms.TextBox();
            this.Delivery_ProjectDesignTextBox = new System.Windows.Forms.TextBox();
            this.Delivery_ProjectDesignLabel = new System.Windows.Forms.Label();
            this.Delivery_DateTextBox = new System.Windows.Forms.TextBox();
            this.Delivery_DateLabel = new System.Windows.Forms.Label();
            this.Delivery_VolumeTextBox = new System.Windows.Forms.TextBox();
            this.Delivery_VolumeLabel = new System.Windows.Forms.Label();
            this.CementSuppliedDataGridView = new System.Windows.Forms.DataGridView();
            this.CementSuppliedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CementSupplied_VolumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CementSupplied_DeliveryDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CementSupplied_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CementSupplied_VolumeTextBox = new System.Windows.Forms.TextBox();
            this.CementSupplied_VolumeLabel = new System.Windows.Forms.Label();
            this.CementSupplied_DeliveryDateTextBox = new System.Windows.Forms.TextBox();
            this.CementSupplied_DeliveryDateLabel = new System.Windows.Forms.Label();
            this.CemenSupplied_ConsumedLabel = new System.Windows.Forms.Label();
            this.CementSupplied_ConsumedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveCementSuppliedConsumedButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DeliveryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CementSuppliedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CementSupplied_ConsumedNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DeliveryGroupBox
            // 
            this.DeliveryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryGroupBox.Controls.Add(this.Delivery_VolumeTextBox);
            this.DeliveryGroupBox.Controls.Add(this.Delivery_VolumeLabel);
            this.DeliveryGroupBox.Controls.Add(this.Delivery_DateTextBox);
            this.DeliveryGroupBox.Controls.Add(this.Delivery_DateLabel);
            this.DeliveryGroupBox.Controls.Add(this.Delivery_ProjectDesignTextBox);
            this.DeliveryGroupBox.Controls.Add(this.Delivery_ProjectDesignLabel);
            this.DeliveryGroupBox.Controls.Add(this.Delivery_DeliveryReceiptNumberTextBox);
            this.DeliveryGroupBox.Controls.Add(this.Delivery_DeliveryReceiptNumberLabel);
            this.DeliveryGroupBox.Location = new System.Drawing.Point(13, 13);
            this.DeliveryGroupBox.Name = "DeliveryGroupBox";
            this.DeliveryGroupBox.Size = new System.Drawing.Size(1010, 126);
            this.DeliveryGroupBox.TabIndex = 0;
            this.DeliveryGroupBox.TabStop = false;
            this.DeliveryGroupBox.Text = "Delivery Details";
            // 
            // Delivery_DeliveryReceiptNumberLabel
            // 
            this.Delivery_DeliveryReceiptNumberLabel.AutoSize = true;
            this.Delivery_DeliveryReceiptNumberLabel.Location = new System.Drawing.Point(6, 21);
            this.Delivery_DeliveryReceiptNumberLabel.Name = "Delivery_DeliveryReceiptNumberLabel";
            this.Delivery_DeliveryReceiptNumberLabel.Size = new System.Drawing.Size(50, 17);
            this.Delivery_DeliveryReceiptNumberLabel.TabIndex = 0;
            this.Delivery_DeliveryReceiptNumberLabel.Text = "DR No.";
            // 
            // Delivery_DeliveryReceiptNumberTextBox
            // 
            this.Delivery_DeliveryReceiptNumberTextBox.Location = new System.Drawing.Point(9, 41);
            this.Delivery_DeliveryReceiptNumberTextBox.Name = "Delivery_DeliveryReceiptNumberTextBox";
            this.Delivery_DeliveryReceiptNumberTextBox.ReadOnly = true;
            this.Delivery_DeliveryReceiptNumberTextBox.Size = new System.Drawing.Size(352, 25);
            this.Delivery_DeliveryReceiptNumberTextBox.TabIndex = 1;
            // 
            // Delivery_ProjectDesignTextBox
            // 
            this.Delivery_ProjectDesignTextBox.Location = new System.Drawing.Point(9, 89);
            this.Delivery_ProjectDesignTextBox.Name = "Delivery_ProjectDesignTextBox";
            this.Delivery_ProjectDesignTextBox.ReadOnly = true;
            this.Delivery_ProjectDesignTextBox.Size = new System.Drawing.Size(352, 25);
            this.Delivery_ProjectDesignTextBox.TabIndex = 3;
            // 
            // Delivery_ProjectDesignLabel
            // 
            this.Delivery_ProjectDesignLabel.AutoSize = true;
            this.Delivery_ProjectDesignLabel.Location = new System.Drawing.Point(6, 69);
            this.Delivery_ProjectDesignLabel.Name = "Delivery_ProjectDesignLabel";
            this.Delivery_ProjectDesignLabel.Size = new System.Drawing.Size(48, 17);
            this.Delivery_ProjectDesignLabel.TabIndex = 2;
            this.Delivery_ProjectDesignLabel.Text = "Design";
            // 
            // Delivery_DateTextBox
            // 
            this.Delivery_DateTextBox.Location = new System.Drawing.Point(367, 41);
            this.Delivery_DateTextBox.Name = "Delivery_DateTextBox";
            this.Delivery_DateTextBox.ReadOnly = true;
            this.Delivery_DateTextBox.Size = new System.Drawing.Size(352, 25);
            this.Delivery_DateTextBox.TabIndex = 5;
            // 
            // Delivery_DateLabel
            // 
            this.Delivery_DateLabel.AutoSize = true;
            this.Delivery_DateLabel.Location = new System.Drawing.Point(364, 21);
            this.Delivery_DateLabel.Name = "Delivery_DateLabel";
            this.Delivery_DateLabel.Size = new System.Drawing.Size(85, 17);
            this.Delivery_DateLabel.TabIndex = 4;
            this.Delivery_DateLabel.Text = "Delivery Date";
            // 
            // Delivery_VolumeTextBox
            // 
            this.Delivery_VolumeTextBox.Location = new System.Drawing.Point(367, 89);
            this.Delivery_VolumeTextBox.Name = "Delivery_VolumeTextBox";
            this.Delivery_VolumeTextBox.ReadOnly = true;
            this.Delivery_VolumeTextBox.Size = new System.Drawing.Size(352, 25);
            this.Delivery_VolumeTextBox.TabIndex = 7;
            // 
            // Delivery_VolumeLabel
            // 
            this.Delivery_VolumeLabel.AutoSize = true;
            this.Delivery_VolumeLabel.Location = new System.Drawing.Point(364, 69);
            this.Delivery_VolumeLabel.Name = "Delivery_VolumeLabel";
            this.Delivery_VolumeLabel.Size = new System.Drawing.Size(51, 17);
            this.Delivery_VolumeLabel.TabIndex = 6;
            this.Delivery_VolumeLabel.Text = "Volume";
            // 
            // CementSuppliedDataGridView
            // 
            this.CementSuppliedDataGridView.AllowUserToAddRows = false;
            this.CementSuppliedDataGridView.AllowUserToDeleteRows = false;
            this.CementSuppliedDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.CementSuppliedDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CementSuppliedDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CementSuppliedDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CementSuppliedDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.CementSuppliedDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CementSuppliedDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CementSuppliedDataGridView.ColumnHeadersHeight = 45;
            this.CementSuppliedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CementSuppliedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CementSuppliedColumn,
            this.CementSupplied_VolumeColumn,
            this.CementSupplied_DeliveryDateColumn,
            this.CementSupplied_ExtraColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CementSuppliedDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.CementSuppliedDataGridView.EnableHeadersVisualStyles = false;
            this.CementSuppliedDataGridView.GridColor = System.Drawing.Color.Red;
            this.CementSuppliedDataGridView.Location = new System.Drawing.Point(13, 144);
            this.CementSuppliedDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.CementSuppliedDataGridView.MultiSelect = false;
            this.CementSuppliedDataGridView.Name = "CementSuppliedDataGridView";
            this.CementSuppliedDataGridView.ReadOnly = true;
            this.CementSuppliedDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CementSuppliedDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.CementSuppliedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CementSuppliedDataGridView.Size = new System.Drawing.Size(581, 626);
            this.CementSuppliedDataGridView.TabIndex = 5;
            this.CementSuppliedDataGridView.SelectionChanged += new System.EventHandler(this.CementSuppliedDataGridView_SelectionChanged);
            // 
            // CementSuppliedColumn
            // 
            this.CementSuppliedColumn.HeaderText = "~";
            this.CementSuppliedColumn.Name = "CementSuppliedColumn";
            this.CementSuppliedColumn.ReadOnly = true;
            this.CementSuppliedColumn.Visible = false;
            // 
            // CementSupplied_VolumeColumn
            // 
            this.CementSupplied_VolumeColumn.HeaderText = "Supplied Cements";
            this.CementSupplied_VolumeColumn.Name = "CementSupplied_VolumeColumn";
            this.CementSupplied_VolumeColumn.ReadOnly = true;
            // 
            // CementSupplied_DeliveryDateColumn
            // 
            this.CementSupplied_DeliveryDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "MMMM d, yyyy";
            this.CementSupplied_DeliveryDateColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.CementSupplied_DeliveryDateColumn.HeaderText = "Delivery Date";
            this.CementSupplied_DeliveryDateColumn.Name = "CementSupplied_DeliveryDateColumn";
            this.CementSupplied_DeliveryDateColumn.ReadOnly = true;
            // 
            // CementSupplied_ExtraColumn
            // 
            this.CementSupplied_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CementSupplied_ExtraColumn.HeaderText = "";
            this.CementSupplied_ExtraColumn.Name = "CementSupplied_ExtraColumn";
            this.CementSupplied_ExtraColumn.ReadOnly = true;
            // 
            // CementSupplied_VolumeTextBox
            // 
            this.CementSupplied_VolumeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CementSupplied_VolumeTextBox.Location = new System.Drawing.Point(602, 164);
            this.CementSupplied_VolumeTextBox.Name = "CementSupplied_VolumeTextBox";
            this.CementSupplied_VolumeTextBox.ReadOnly = true;
            this.CementSupplied_VolumeTextBox.Size = new System.Drawing.Size(421, 25);
            this.CementSupplied_VolumeTextBox.TabIndex = 7;
            // 
            // CementSupplied_VolumeLabel
            // 
            this.CementSupplied_VolumeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CementSupplied_VolumeLabel.AutoSize = true;
            this.CementSupplied_VolumeLabel.Location = new System.Drawing.Point(599, 144);
            this.CementSupplied_VolumeLabel.Name = "CementSupplied_VolumeLabel";
            this.CementSupplied_VolumeLabel.Size = new System.Drawing.Size(51, 17);
            this.CementSupplied_VolumeLabel.TabIndex = 6;
            this.CementSupplied_VolumeLabel.Text = "Volume";
            // 
            // CementSupplied_DeliveryDateTextBox
            // 
            this.CementSupplied_DeliveryDateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CementSupplied_DeliveryDateTextBox.Location = new System.Drawing.Point(602, 212);
            this.CementSupplied_DeliveryDateTextBox.Name = "CementSupplied_DeliveryDateTextBox";
            this.CementSupplied_DeliveryDateTextBox.ReadOnly = true;
            this.CementSupplied_DeliveryDateTextBox.Size = new System.Drawing.Size(421, 25);
            this.CementSupplied_DeliveryDateTextBox.TabIndex = 9;
            // 
            // CementSupplied_DeliveryDateLabel
            // 
            this.CementSupplied_DeliveryDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CementSupplied_DeliveryDateLabel.AutoSize = true;
            this.CementSupplied_DeliveryDateLabel.Location = new System.Drawing.Point(599, 192);
            this.CementSupplied_DeliveryDateLabel.Name = "CementSupplied_DeliveryDateLabel";
            this.CementSupplied_DeliveryDateLabel.Size = new System.Drawing.Size(85, 17);
            this.CementSupplied_DeliveryDateLabel.TabIndex = 8;
            this.CementSupplied_DeliveryDateLabel.Text = "Delivery Date";
            // 
            // CemenSupplied_ConsumedLabel
            // 
            this.CemenSupplied_ConsumedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CemenSupplied_ConsumedLabel.AutoSize = true;
            this.CemenSupplied_ConsumedLabel.Location = new System.Drawing.Point(599, 240);
            this.CemenSupplied_ConsumedLabel.Name = "CemenSupplied_ConsumedLabel";
            this.CemenSupplied_ConsumedLabel.Size = new System.Drawing.Size(70, 17);
            this.CemenSupplied_ConsumedLabel.TabIndex = 10;
            this.CemenSupplied_ConsumedLabel.Text = "Consumed";
            // 
            // CementSupplied_ConsumedNumericUpDown
            // 
            this.CementSupplied_ConsumedNumericUpDown.DecimalPlaces = 2;
            this.CementSupplied_ConsumedNumericUpDown.Location = new System.Drawing.Point(602, 260);
            this.CementSupplied_ConsumedNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.CementSupplied_ConsumedNumericUpDown.Name = "CementSupplied_ConsumedNumericUpDown";
            this.CementSupplied_ConsumedNumericUpDown.Size = new System.Drawing.Size(421, 25);
            this.CementSupplied_ConsumedNumericUpDown.TabIndex = 11;
            this.CementSupplied_ConsumedNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CementSupplied_ConsumedNumericUpDown.ThousandsSeparator = true;
            // 
            // SaveCementSuppliedConsumedButton
            // 
            this.SaveCementSuppliedConsumedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveCementSuppliedConsumedButton.BackColor = System.Drawing.Color.Red;
            this.SaveCementSuppliedConsumedButton.FlatAppearance.BorderSize = 0;
            this.SaveCementSuppliedConsumedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCementSuppliedConsumedButton.ForeColor = System.Drawing.Color.White;
            this.SaveCementSuppliedConsumedButton.Location = new System.Drawing.Point(841, 290);
            this.SaveCementSuppliedConsumedButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveCementSuppliedConsumedButton.Name = "SaveCementSuppliedConsumedButton";
            this.SaveCementSuppliedConsumedButton.Size = new System.Drawing.Size(89, 40);
            this.SaveCementSuppliedConsumedButton.TabIndex = 22;
            this.SaveCementSuppliedConsumedButton.Text = "Save";
            this.SaveCementSuppliedConsumedButton.UseVisualStyleBackColor = false;
            this.SaveCementSuppliedConsumedButton.Click += new System.EventHandler(this.SaveCementSuppliedConsumedButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(934, 290);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(89, 40);
            this.CloseButton.TabIndex = 23;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ManageCementSuppliedDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 781);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveCementSuppliedConsumedButton);
            this.Controls.Add(this.CementSupplied_ConsumedNumericUpDown);
            this.Controls.Add(this.CemenSupplied_ConsumedLabel);
            this.Controls.Add(this.CementSupplied_DeliveryDateTextBox);
            this.Controls.Add(this.CementSupplied_DeliveryDateLabel);
            this.Controls.Add(this.CementSupplied_VolumeTextBox);
            this.Controls.Add(this.CementSupplied_VolumeLabel);
            this.Controls.Add(this.CementSuppliedDataGridView);
            this.Controls.Add(this.DeliveryGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageCementSuppliedDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Cement Supplied";
            this.Load += new System.EventHandler(this.ManageCementSuppliedDialog_Load);
            this.DeliveryGroupBox.ResumeLayout(false);
            this.DeliveryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CementSuppliedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CementSupplied_ConsumedNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DeliveryGroupBox;
        private System.Windows.Forms.Label Delivery_DeliveryReceiptNumberLabel;
        private System.Windows.Forms.TextBox Delivery_DeliveryReceiptNumberTextBox;
        private System.Windows.Forms.TextBox Delivery_ProjectDesignTextBox;
        private System.Windows.Forms.Label Delivery_ProjectDesignLabel;
        private System.Windows.Forms.TextBox Delivery_DateTextBox;
        private System.Windows.Forms.Label Delivery_DateLabel;
        private System.Windows.Forms.TextBox Delivery_VolumeTextBox;
        private System.Windows.Forms.Label Delivery_VolumeLabel;
        private System.Windows.Forms.DataGridView CementSuppliedDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CementSuppliedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CementSupplied_VolumeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CementSupplied_DeliveryDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CementSupplied_ExtraColumn;
        private System.Windows.Forms.TextBox CementSupplied_VolumeTextBox;
        private System.Windows.Forms.Label CementSupplied_VolumeLabel;
        private System.Windows.Forms.TextBox CementSupplied_DeliveryDateTextBox;
        private System.Windows.Forms.Label CementSupplied_DeliveryDateLabel;
        private System.Windows.Forms.Label CemenSupplied_ConsumedLabel;
        private System.Windows.Forms.NumericUpDown CementSupplied_ConsumedNumericUpDown;
        private System.Windows.Forms.Button SaveCementSuppliedConsumedButton;
        private System.Windows.Forms.Button CloseButton;
    }
}