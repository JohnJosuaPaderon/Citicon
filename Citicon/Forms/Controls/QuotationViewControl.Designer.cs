namespace Citicon.Forms.Controls
{
    partial class QuotationViewControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.QuotationDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.ViewInWordButton = new System.Windows.Forms.Button();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QuotationDateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QuotationNumberTextBox = new System.Windows.Forms.TextBox();
            this.QuotationNumberLabel = new System.Windows.Forms.Label();
            this.ProjectDesignDataGridView = new System.Windows.Forms.DataGridView();
            this.ProjectDesignColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintButton = new System.Windows.Forms.Button();
            this.QuotationDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDesignDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // QuotationDetailsGroupBox
            // 
            this.QuotationDetailsGroupBox.Controls.Add(this.PrintButton);
            this.QuotationDetailsGroupBox.Controls.Add(this.ViewInWordButton);
            this.QuotationDetailsGroupBox.Controls.Add(this.StatusTextBox);
            this.QuotationDetailsGroupBox.Controls.Add(this.label2);
            this.QuotationDetailsGroupBox.Controls.Add(this.QuotationDateTextBox);
            this.QuotationDetailsGroupBox.Controls.Add(this.label1);
            this.QuotationDetailsGroupBox.Controls.Add(this.QuotationNumberTextBox);
            this.QuotationDetailsGroupBox.Controls.Add(this.QuotationNumberLabel);
            this.QuotationDetailsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.QuotationDetailsGroupBox.Name = "QuotationDetailsGroupBox";
            this.QuotationDetailsGroupBox.Size = new System.Drawing.Size(379, 210);
            this.QuotationDetailsGroupBox.TabIndex = 0;
            this.QuotationDetailsGroupBox.TabStop = false;
            this.QuotationDetailsGroupBox.Text = "Quotation Details";
            // 
            // ViewInWordButton
            // 
            this.ViewInWordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewInWordButton.BackColor = System.Drawing.Color.Red;
            this.ViewInWordButton.FlatAppearance.BorderSize = 0;
            this.ViewInWordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewInWordButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewInWordButton.ForeColor = System.Drawing.Color.White;
            this.ViewInWordButton.Location = new System.Drawing.Point(247, 168);
            this.ViewInWordButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ViewInWordButton.Name = "ViewInWordButton";
            this.ViewInWordButton.Size = new System.Drawing.Size(125, 35);
            this.ViewInWordButton.TabIndex = 3;
            this.ViewInWordButton.Text = "VIEW IN WORD";
            this.ViewInWordButton.UseVisualStyleBackColor = false;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.BackColor = System.Drawing.Color.White;
            this.StatusTextBox.Location = new System.Drawing.Point(9, 137);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.Size = new System.Drawing.Size(364, 25);
            this.StatusTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
            // 
            // QuotationDateTextBox
            // 
            this.QuotationDateTextBox.BackColor = System.Drawing.Color.White;
            this.QuotationDateTextBox.Location = new System.Drawing.Point(9, 89);
            this.QuotationDateTextBox.Name = "QuotationDateTextBox";
            this.QuotationDateTextBox.ReadOnly = true;
            this.QuotationDateTextBox.Size = new System.Drawing.Size(364, 25);
            this.QuotationDateTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // QuotationNumberTextBox
            // 
            this.QuotationNumberTextBox.BackColor = System.Drawing.Color.White;
            this.QuotationNumberTextBox.Location = new System.Drawing.Point(9, 41);
            this.QuotationNumberTextBox.Name = "QuotationNumberTextBox";
            this.QuotationNumberTextBox.ReadOnly = true;
            this.QuotationNumberTextBox.Size = new System.Drawing.Size(364, 25);
            this.QuotationNumberTextBox.TabIndex = 0;
            // 
            // QuotationNumberLabel
            // 
            this.QuotationNumberLabel.AutoSize = true;
            this.QuotationNumberLabel.Location = new System.Drawing.Point(6, 21);
            this.QuotationNumberLabel.Name = "QuotationNumberLabel";
            this.QuotationNumberLabel.Size = new System.Drawing.Size(91, 17);
            this.QuotationNumberLabel.TabIndex = 0;
            this.QuotationNumberLabel.Text = "Quotation No.";
            // 
            // ProjectDesignDataGridView
            // 
            this.ProjectDesignDataGridView.AllowUserToAddRows = false;
            this.ProjectDesignDataGridView.AllowUserToDeleteRows = false;
            this.ProjectDesignDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProjectDesignDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ProjectDesignDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectDesignDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProjectDesignDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProjectDesignDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectDesignDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ProjectDesignDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectDesignDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ProjectDesignDataGridView.ColumnHeadersHeight = 60;
            this.ProjectDesignDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProjectDesignDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectDesignColumn});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProjectDesignDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.ProjectDesignDataGridView.EnableHeadersVisualStyles = false;
            this.ProjectDesignDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProjectDesignDataGridView.Location = new System.Drawing.Point(3, 219);
            this.ProjectDesignDataGridView.MultiSelect = false;
            this.ProjectDesignDataGridView.Name = "ProjectDesignDataGridView";
            this.ProjectDesignDataGridView.ReadOnly = true;
            this.ProjectDesignDataGridView.RowHeadersVisible = false;
            this.ProjectDesignDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.ProjectDesignDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.ProjectDesignDataGridView.RowTemplate.Height = 40;
            this.ProjectDesignDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProjectDesignDataGridView.Size = new System.Drawing.Size(379, 186);
            this.ProjectDesignDataGridView.TabIndex = 4;
            // 
            // ProjectDesignColumn
            // 
            this.ProjectDesignColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectDesignColumn.HeaderText = "DESIGNS";
            this.ProjectDesignColumn.MinimumWidth = 100;
            this.ProjectDesignColumn.Name = "ProjectDesignColumn";
            this.ProjectDesignColumn.ReadOnly = true;
            // 
            // PrintButton
            // 
            this.PrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintButton.BackColor = System.Drawing.Color.Red;
            this.PrintButton.Enabled = false;
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.Color.White;
            this.PrintButton.Location = new System.Drawing.Point(114, 168);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(125, 35);
            this.PrintButton.TabIndex = 5;
            this.PrintButton.Text = "PRINT";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // QuotationViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ProjectDesignDataGridView);
            this.Controls.Add(this.QuotationDetailsGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuotationViewControl";
            this.Size = new System.Drawing.Size(385, 408);
            this.QuotationDetailsGroupBox.ResumeLayout(false);
            this.QuotationDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDesignDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox QuotationDetailsGroupBox;
        private System.Windows.Forms.Label QuotationNumberLabel;
        private System.Windows.Forms.TextBox QuotationNumberTextBox;
        private System.Windows.Forms.TextBox QuotationDateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewInWordButton;
        private System.Windows.Forms.DataGridView ProjectDesignDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDesignColumn;
        private System.Windows.Forms.Button PrintButton;
    }
}
