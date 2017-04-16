namespace Citicon.PayrollIntegration.Forms
{
    partial class HolidayManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HolidayManagementForm));
            this.HolidayDataGridView = new System.Windows.Forms.DataGridView();
            this.HolidayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Holiday_DateOccurColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Holiday_TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Holiday_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HolidayFilterComboBox = new System.Windows.Forms.ComboBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CloseFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HolidayDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HolidayDataGridView
            // 
            this.HolidayDataGridView.AllowUserToAddRows = false;
            this.HolidayDataGridView.AllowUserToDeleteRows = false;
            this.HolidayDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HolidayDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.HolidayDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HolidayDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.HolidayDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.HolidayDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HolidayDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.HolidayDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HolidayDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.HolidayDataGridView.ColumnHeadersHeight = 60;
            this.HolidayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.HolidayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HolidayColumn,
            this.Holiday_DateOccurColumn,
            this.Holiday_TypeColumn,
            this.Holiday_ExtraColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HolidayDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.HolidayDataGridView.EnableHeadersVisualStyles = false;
            this.HolidayDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HolidayDataGridView.Location = new System.Drawing.Point(12, 43);
            this.HolidayDataGridView.MultiSelect = false;
            this.HolidayDataGridView.Name = "HolidayDataGridView";
            this.HolidayDataGridView.ReadOnly = true;
            this.HolidayDataGridView.RowHeadersVisible = false;
            this.HolidayDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.HolidayDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.HolidayDataGridView.RowTemplate.Height = 40;
            this.HolidayDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HolidayDataGridView.Size = new System.Drawing.Size(538, 668);
            this.HolidayDataGridView.TabIndex = 106;
            // 
            // HolidayColumn
            // 
            this.HolidayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HolidayColumn.HeaderText = "HOLIDAYS";
            this.HolidayColumn.MinimumWidth = 100;
            this.HolidayColumn.Name = "HolidayColumn";
            this.HolidayColumn.ReadOnly = true;
            // 
            // Holiday_DateOccurColumn
            // 
            this.Holiday_DateOccurColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "MMMM dd, yyyy";
            this.Holiday_DateOccurColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.Holiday_DateOccurColumn.HeaderText = "DATE";
            this.Holiday_DateOccurColumn.Name = "Holiday_DateOccurColumn";
            this.Holiday_DateOccurColumn.ReadOnly = true;
            this.Holiday_DateOccurColumn.Width = 62;
            // 
            // Holiday_TypeColumn
            // 
            this.Holiday_TypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Holiday_TypeColumn.HeaderText = "TYPE";
            this.Holiday_TypeColumn.Name = "Holiday_TypeColumn";
            this.Holiday_TypeColumn.ReadOnly = true;
            this.Holiday_TypeColumn.Width = 60;
            // 
            // Holiday_ExtraColumn
            // 
            this.Holiday_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Holiday_ExtraColumn.HeaderText = "";
            this.Holiday_ExtraColumn.Name = "Holiday_ExtraColumn";
            this.Holiday_ExtraColumn.ReadOnly = true;
            // 
            // HolidayFilterComboBox
            // 
            this.HolidayFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HolidayFilterComboBox.FormattingEnabled = true;
            this.HolidayFilterComboBox.Location = new System.Drawing.Point(12, 12);
            this.HolidayFilterComboBox.Name = "HolidayFilterComboBox";
            this.HolidayFilterComboBox.Size = new System.Drawing.Size(292, 25);
            this.HolidayFilterComboBox.TabIndex = 107;
            this.HolidayFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.HolidayFilterComboBox_SelectedIndexChanged);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackColor = System.Drawing.Color.Red;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(159, 717);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(125, 35);
            this.EditButton.TabIndex = 123;
            this.EditButton.Text = "EDIT SELECTED";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewButton.BackColor = System.Drawing.Color.Red;
            this.AddNewButton.FlatAppearance.BorderSize = 0;
            this.AddNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewButton.ForeColor = System.Drawing.Color.White;
            this.AddNewButton.Location = new System.Drawing.Point(51, 717);
            this.AddNewButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(100, 35);
            this.AddNewButton.TabIndex = 122;
            this.AddNewButton.Text = "ADD NEW";
            this.AddNewButton.UseVisualStyleBackColor = false;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(292, 717);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 35);
            this.DeleteButton.TabIndex = 124;
            this.DeleteButton.Text = "DELETE SELECTED";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseFormButton.BackColor = System.Drawing.Color.White;
            this.CloseFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseFormButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseFormButton.ForeColor = System.Drawing.Color.Red;
            this.CloseFormButton.Location = new System.Drawing.Point(450, 717);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(100, 35);
            this.CloseFormButton.TabIndex = 125;
            this.CloseFormButton.Text = "CLOSE";
            this.CloseFormButton.UseVisualStyleBackColor = false;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // HolidayManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 764);
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.HolidayFilterComboBox);
            this.Controls.Add(this.HolidayDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HolidayManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Holidays";
            this.Load += new System.EventHandler(this.HolidayManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HolidayDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView HolidayDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn HolidayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Holiday_DateOccurColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Holiday_TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Holiday_ExtraColumn;
        private System.Windows.Forms.ComboBox HolidayFilterComboBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CloseFormButton;
    }
}