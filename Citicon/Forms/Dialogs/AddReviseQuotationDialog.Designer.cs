namespace Citicon.Forms.Dialogs
{
    partial class AddReviseQuotationDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReviseQuotationDialog));
            this.QuotationNumberLabel = new System.Windows.Forms.Label();
            this.QuotationNumberTextBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.ClientTextBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.ProjectTextBox = new System.Windows.Forms.TextBox();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.ViewClientDetailsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ViewProjectDetailsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AgentComboBox = new System.Windows.Forms.ComboBox();
            this.AgentLabel = new System.Windows.Forms.Label();
            this.EngineerIDLabel = new System.Windows.Forms.Label();
            this.EngineerIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.ProjectDesignDataGridView = new System.Windows.Forms.DataGridView();
            this.ProjectDesignColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TermsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RemoveSelectedDesignButton = new System.Windows.Forms.Button();
            this.EditDesignButton = new System.Windows.Forms.Button();
            this.AddDesignButton = new System.Windows.Forms.Button();
            this.RemoveAllDesignsButton = new System.Windows.Forms.Button();
            this.CancelQuotationButton = new System.Windows.Forms.Button();
            this.SaveQuotationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EngineerIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDesignDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // QuotationNumberLabel
            // 
            this.QuotationNumberLabel.AutoSize = true;
            this.QuotationNumberLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuotationNumberLabel.Location = new System.Drawing.Point(13, 22);
            this.QuotationNumberLabel.Name = "QuotationNumberLabel";
            this.QuotationNumberLabel.Size = new System.Drawing.Size(146, 30);
            this.QuotationNumberLabel.TabIndex = 0;
            this.QuotationNumberLabel.Text = "Quotation No.";
            // 
            // QuotationNumberTextBox
            // 
            this.QuotationNumberTextBox.BackColor = System.Drawing.Color.Black;
            this.QuotationNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuotationNumberTextBox.ForeColor = System.Drawing.Color.Lime;
            this.QuotationNumberTextBox.Location = new System.Drawing.Point(164, 12);
            this.QuotationNumberTextBox.Name = "QuotationNumberTextBox";
            this.QuotationNumberTextBox.Size = new System.Drawing.Size(363, 45);
            this.QuotationNumberTextBox.TabIndex = 1;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(710, 12);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(35, 17);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date";
            // 
            // DateDateTimePicker
            // 
            this.DateDateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateDateTimePicker.Location = new System.Drawing.Point(713, 32);
            this.DateDateTimePicker.Name = "DateDateTimePicker";
            this.DateDateTimePicker.Size = new System.Drawing.Size(171, 25);
            this.DateDateTimePicker.TabIndex = 3;
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(12, 60);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(40, 17);
            this.ClientLabel.TabIndex = 4;
            this.ClientLabel.Text = "Client";
            // 
            // ClientTextBox
            // 
            this.ClientTextBox.BackColor = System.Drawing.Color.White;
            this.ClientTextBox.Location = new System.Drawing.Point(15, 83);
            this.ClientTextBox.Name = "ClientTextBox";
            this.ClientTextBox.ReadOnly = true;
            this.ClientTextBox.Size = new System.Drawing.Size(431, 25);
            this.ClientTextBox.TabIndex = 5;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(533, 12);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(35, 17);
            this.TypeLabel.TabIndex = 6;
            this.TypeLabel.Text = "Type";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(536, 32);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(171, 25);
            this.TypeComboBox.TabIndex = 7;
            // 
            // ProjectTextBox
            // 
            this.ProjectTextBox.BackColor = System.Drawing.Color.White;
            this.ProjectTextBox.Location = new System.Drawing.Point(15, 134);
            this.ProjectTextBox.Name = "ProjectTextBox";
            this.ProjectTextBox.ReadOnly = true;
            this.ProjectTextBox.Size = new System.Drawing.Size(431, 25);
            this.ProjectTextBox.TabIndex = 9;
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Location = new System.Drawing.Point(12, 111);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(48, 17);
            this.ProjectLabel.TabIndex = 8;
            this.ProjectLabel.Text = "Project";
            // 
            // ViewClientDetailsLinkLabel
            // 
            this.ViewClientDetailsLinkLabel.AutoSize = true;
            this.ViewClientDetailsLinkLabel.Location = new System.Drawing.Point(451, 86);
            this.ViewClientDetailsLinkLabel.Name = "ViewClientDetailsLinkLabel";
            this.ViewClientDetailsLinkLabel.Size = new System.Drawing.Size(78, 17);
            this.ViewClientDetailsLinkLabel.TabIndex = 10;
            this.ViewClientDetailsLinkLabel.TabStop = true;
            this.ViewClientDetailsLinkLabel.Text = "View Details";
            // 
            // ViewProjectDetailsLinkLabel
            // 
            this.ViewProjectDetailsLinkLabel.AutoSize = true;
            this.ViewProjectDetailsLinkLabel.Location = new System.Drawing.Point(452, 137);
            this.ViewProjectDetailsLinkLabel.Name = "ViewProjectDetailsLinkLabel";
            this.ViewProjectDetailsLinkLabel.Size = new System.Drawing.Size(78, 17);
            this.ViewProjectDetailsLinkLabel.TabIndex = 11;
            this.ViewProjectDetailsLinkLabel.TabStop = true;
            this.ViewProjectDetailsLinkLabel.Text = "View Details";
            // 
            // AgentComboBox
            // 
            this.AgentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgentComboBox.FormattingEnabled = true;
            this.AgentComboBox.Location = new System.Drawing.Point(536, 83);
            this.AgentComboBox.Name = "AgentComboBox";
            this.AgentComboBox.Size = new System.Drawing.Size(348, 25);
            this.AgentComboBox.TabIndex = 13;
            // 
            // AgentLabel
            // 
            this.AgentLabel.AutoSize = true;
            this.AgentLabel.Location = new System.Drawing.Point(533, 60);
            this.AgentLabel.Name = "AgentLabel";
            this.AgentLabel.Size = new System.Drawing.Size(42, 17);
            this.AgentLabel.TabIndex = 12;
            this.AgentLabel.Text = "Agent";
            // 
            // EngineerIDLabel
            // 
            this.EngineerIDLabel.AutoSize = true;
            this.EngineerIDLabel.Location = new System.Drawing.Point(536, 111);
            this.EngineerIDLabel.Name = "EngineerIDLabel";
            this.EngineerIDLabel.Size = new System.Drawing.Size(75, 17);
            this.EngineerIDLabel.TabIndex = 14;
            this.EngineerIDLabel.Text = "Engineer ID";
            // 
            // EngineerIDNumericUpDown
            // 
            this.EngineerIDNumericUpDown.Location = new System.Drawing.Point(536, 134);
            this.EngineerIDNumericUpDown.Name = "EngineerIDNumericUpDown";
            this.EngineerIDNumericUpDown.Size = new System.Drawing.Size(171, 25);
            this.EngineerIDNumericUpDown.TabIndex = 15;
            // 
            // AmountNumericUpDown
            // 
            this.AmountNumericUpDown.Location = new System.Drawing.Point(713, 134);
            this.AmountNumericUpDown.Name = "AmountNumericUpDown";
            this.AmountNumericUpDown.Size = new System.Drawing.Size(171, 25);
            this.AmountNumericUpDown.TabIndex = 17;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(713, 111);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(53, 17);
            this.AmountLabel.TabIndex = 16;
            this.AmountLabel.Text = "Amount";
            // 
            // ProjectDesignDataGridView
            // 
            this.ProjectDesignDataGridView.AllowUserToAddRows = false;
            this.ProjectDesignDataGridView.AllowUserToDeleteRows = false;
            this.ProjectDesignDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProjectDesignDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProjectDesignDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProjectDesignDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProjectDesignDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProjectDesignDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectDesignDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ProjectDesignDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectDesignDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProjectDesignDataGridView.ColumnHeadersHeight = 60;
            this.ProjectDesignDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProjectDesignDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectDesignColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProjectDesignDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProjectDesignDataGridView.EnableHeadersVisualStyles = false;
            this.ProjectDesignDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProjectDesignDataGridView.Location = new System.Drawing.Point(15, 165);
            this.ProjectDesignDataGridView.MultiSelect = false;
            this.ProjectDesignDataGridView.Name = "ProjectDesignDataGridView";
            this.ProjectDesignDataGridView.ReadOnly = true;
            this.ProjectDesignDataGridView.RowHeadersVisible = false;
            this.ProjectDesignDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.ProjectDesignDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ProjectDesignDataGridView.RowTemplate.Height = 40;
            this.ProjectDesignDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProjectDesignDataGridView.Size = new System.Drawing.Size(515, 502);
            this.ProjectDesignDataGridView.TabIndex = 116;
            // 
            // ProjectDesignColumn
            // 
            this.ProjectDesignColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectDesignColumn.HeaderText = "DESIGNS";
            this.ProjectDesignColumn.MinimumWidth = 100;
            this.ProjectDesignColumn.Name = "ProjectDesignColumn";
            this.ProjectDesignColumn.ReadOnly = true;
            // 
            // TermsRichTextBox
            // 
            this.TermsRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TermsRichTextBox.Location = new System.Drawing.Point(536, 185);
            this.TermsRichTextBox.Name = "TermsRichTextBox";
            this.TermsRichTextBox.Size = new System.Drawing.Size(903, 482);
            this.TermsRichTextBox.TabIndex = 117;
            this.TermsRichTextBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(533, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 118;
            this.label8.Text = "Terms";
            // 
            // RemoveSelectedDesignButton
            // 
            this.RemoveSelectedDesignButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveSelectedDesignButton.BackColor = System.Drawing.Color.Red;
            this.RemoveSelectedDesignButton.FlatAppearance.BorderSize = 0;
            this.RemoveSelectedDesignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSelectedDesignButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelectedDesignButton.ForeColor = System.Drawing.Color.White;
            this.RemoveSelectedDesignButton.Location = new System.Drawing.Point(271, 673);
            this.RemoveSelectedDesignButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RemoveSelectedDesignButton.Name = "RemoveSelectedDesignButton";
            this.RemoveSelectedDesignButton.Size = new System.Drawing.Size(150, 35);
            this.RemoveSelectedDesignButton.TabIndex = 121;
            this.RemoveSelectedDesignButton.Text = "REMOVE SELECTED";
            this.RemoveSelectedDesignButton.UseVisualStyleBackColor = false;
            // 
            // EditDesignButton
            // 
            this.EditDesignButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditDesignButton.BackColor = System.Drawing.Color.Red;
            this.EditDesignButton.FlatAppearance.BorderSize = 0;
            this.EditDesignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditDesignButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditDesignButton.ForeColor = System.Drawing.Color.White;
            this.EditDesignButton.Location = new System.Drawing.Point(163, 673);
            this.EditDesignButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditDesignButton.Name = "EditDesignButton";
            this.EditDesignButton.Size = new System.Drawing.Size(100, 35);
            this.EditDesignButton.TabIndex = 120;
            this.EditDesignButton.Text = "EDIT";
            this.EditDesignButton.UseVisualStyleBackColor = false;
            // 
            // AddDesignButton
            // 
            this.AddDesignButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddDesignButton.BackColor = System.Drawing.Color.Red;
            this.AddDesignButton.FlatAppearance.BorderSize = 0;
            this.AddDesignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDesignButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDesignButton.ForeColor = System.Drawing.Color.White;
            this.AddDesignButton.Location = new System.Drawing.Point(55, 673);
            this.AddDesignButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddDesignButton.Name = "AddDesignButton";
            this.AddDesignButton.Size = new System.Drawing.Size(100, 35);
            this.AddDesignButton.TabIndex = 119;
            this.AddDesignButton.Text = "ADD";
            this.AddDesignButton.UseVisualStyleBackColor = false;
            // 
            // RemoveAllDesignsButton
            // 
            this.RemoveAllDesignsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveAllDesignsButton.BackColor = System.Drawing.Color.Red;
            this.RemoveAllDesignsButton.FlatAppearance.BorderSize = 0;
            this.RemoveAllDesignsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveAllDesignsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveAllDesignsButton.ForeColor = System.Drawing.Color.White;
            this.RemoveAllDesignsButton.Location = new System.Drawing.Point(429, 673);
            this.RemoveAllDesignsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RemoveAllDesignsButton.Name = "RemoveAllDesignsButton";
            this.RemoveAllDesignsButton.Size = new System.Drawing.Size(100, 35);
            this.RemoveAllDesignsButton.TabIndex = 122;
            this.RemoveAllDesignsButton.Text = "REMOVE ALL";
            this.RemoveAllDesignsButton.UseVisualStyleBackColor = false;
            // 
            // CancelQuotationButton
            // 
            this.CancelQuotationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelQuotationButton.BackColor = System.Drawing.Color.Red;
            this.CancelQuotationButton.FlatAppearance.BorderSize = 0;
            this.CancelQuotationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelQuotationButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelQuotationButton.ForeColor = System.Drawing.Color.White;
            this.CancelQuotationButton.Location = new System.Drawing.Point(1339, 673);
            this.CancelQuotationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelQuotationButton.Name = "CancelQuotationButton";
            this.CancelQuotationButton.Size = new System.Drawing.Size(100, 35);
            this.CancelQuotationButton.TabIndex = 124;
            this.CancelQuotationButton.Text = "CANCEL";
            this.CancelQuotationButton.UseVisualStyleBackColor = false;
            // 
            // SaveQuotationButton
            // 
            this.SaveQuotationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveQuotationButton.BackColor = System.Drawing.Color.Red;
            this.SaveQuotationButton.FlatAppearance.BorderSize = 0;
            this.SaveQuotationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveQuotationButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveQuotationButton.ForeColor = System.Drawing.Color.White;
            this.SaveQuotationButton.Location = new System.Drawing.Point(1231, 673);
            this.SaveQuotationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveQuotationButton.Name = "SaveQuotationButton";
            this.SaveQuotationButton.Size = new System.Drawing.Size(100, 35);
            this.SaveQuotationButton.TabIndex = 123;
            this.SaveQuotationButton.Text = "SAVE";
            this.SaveQuotationButton.UseVisualStyleBackColor = false;
            // 
            // AddReviseQuotationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1451, 720);
            this.Controls.Add(this.CancelQuotationButton);
            this.Controls.Add(this.SaveQuotationButton);
            this.Controls.Add(this.RemoveAllDesignsButton);
            this.Controls.Add(this.RemoveSelectedDesignButton);
            this.Controls.Add(this.EditDesignButton);
            this.Controls.Add(this.AddDesignButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TermsRichTextBox);
            this.Controls.Add(this.ProjectDesignDataGridView);
            this.Controls.Add(this.AmountNumericUpDown);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.EngineerIDNumericUpDown);
            this.Controls.Add(this.EngineerIDLabel);
            this.Controls.Add(this.AgentComboBox);
            this.Controls.Add(this.AgentLabel);
            this.Controls.Add(this.ViewProjectDetailsLinkLabel);
            this.Controls.Add(this.ViewClientDetailsLinkLabel);
            this.Controls.Add(this.ProjectTextBox);
            this.Controls.Add(this.ProjectLabel);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.ClientTextBox);
            this.Controls.Add(this.ClientLabel);
            this.Controls.Add(this.DateDateTimePicker);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.QuotationNumberTextBox);
            this.Controls.Add(this.QuotationNumberLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddReviseQuotationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or Revise Quotation";
            this.Load += new System.EventHandler(this.AddReviseQuotationDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EngineerIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDesignDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuotationNumberLabel;
        private System.Windows.Forms.TextBox QuotationNumberTextBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker DateDateTimePicker;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.TextBox ClientTextBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.TextBox ProjectTextBox;
        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.LinkLabel ViewClientDetailsLinkLabel;
        private System.Windows.Forms.LinkLabel ViewProjectDetailsLinkLabel;
        private System.Windows.Forms.ComboBox AgentComboBox;
        private System.Windows.Forms.Label AgentLabel;
        private System.Windows.Forms.Label EngineerIDLabel;
        private System.Windows.Forms.NumericUpDown EngineerIDNumericUpDown;
        private System.Windows.Forms.NumericUpDown AmountNumericUpDown;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.DataGridView ProjectDesignDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDesignColumn;
        private System.Windows.Forms.RichTextBox TermsRichTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button RemoveSelectedDesignButton;
        private System.Windows.Forms.Button EditDesignButton;
        private System.Windows.Forms.Button AddDesignButton;
        private System.Windows.Forms.Button RemoveAllDesignsButton;
        private System.Windows.Forms.Button CancelQuotationButton;
        private System.Windows.Forms.Button SaveQuotationButton;
    }
}