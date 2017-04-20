namespace Citicon.Forms.Controls
{
    partial class TransitMixerManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TransitMixerDataGridView = new System.Windows.Forms.DataGridView();
            this.DetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.PlateNumberLabel = new System.Windows.Forms.Label();
            this.PlateNumberTextBox = new System.Windows.Forms.TextBox();
            this.VolumeCapacityTextBox = new System.Windows.Forms.TextBox();
            this.VolumeCapacityLabel = new System.Windows.Forms.Label();
            this.PhysicalNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhysicalNumberLabel = new System.Windows.Forms.Label();
            this.TransitMixer_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransitMixer_PlateNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransitMixer_VolumeCapacityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransitMixer_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TransitMixerDataGridView)).BeginInit();
            this.DetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransitMixerDataGridView
            // 
            this.TransitMixerDataGridView.AllowUserToAddRows = false;
            this.TransitMixerDataGridView.AllowUserToDeleteRows = false;
            this.TransitMixerDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TransitMixerDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.TransitMixerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransitMixerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TransitMixerDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.TransitMixerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransitMixerDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.TransitMixerDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransitMixerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.TransitMixerDataGridView.ColumnHeadersHeight = 60;
            this.TransitMixerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TransitMixerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransitMixer_Column,
            this.TransitMixer_PlateNumberColumn,
            this.TransitMixer_VolumeCapacityColumn,
            this.TransitMixer_ExtraColumn});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TransitMixerDataGridView.DefaultCellStyle = dataGridViewCellStyle29;
            this.TransitMixerDataGridView.EnableHeadersVisualStyles = false;
            this.TransitMixerDataGridView.GridColor = System.Drawing.Color.Red;
            this.TransitMixerDataGridView.Location = new System.Drawing.Point(3, 3);
            this.TransitMixerDataGridView.MultiSelect = false;
            this.TransitMixerDataGridView.Name = "TransitMixerDataGridView";
            this.TransitMixerDataGridView.ReadOnly = true;
            this.TransitMixerDataGridView.RowHeadersVisible = false;
            this.TransitMixerDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            this.TransitMixerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.TransitMixerDataGridView.RowTemplate.Height = 40;
            this.TransitMixerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransitMixerDataGridView.Size = new System.Drawing.Size(555, 517);
            this.TransitMixerDataGridView.TabIndex = 116;
            this.TransitMixerDataGridView.SelectionChanged += new System.EventHandler(this.TransitMixerDataGridView_SelectionChanged);
            // 
            // DetailsGroupBox
            // 
            this.DetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsGroupBox.Controls.Add(this.PhysicalNumberTextBox);
            this.DetailsGroupBox.Controls.Add(this.PhysicalNumberLabel);
            this.DetailsGroupBox.Controls.Add(this.VolumeCapacityTextBox);
            this.DetailsGroupBox.Controls.Add(this.VolumeCapacityLabel);
            this.DetailsGroupBox.Controls.Add(this.PlateNumberTextBox);
            this.DetailsGroupBox.Controls.Add(this.PlateNumberLabel);
            this.DetailsGroupBox.Location = new System.Drawing.Point(565, 44);
            this.DetailsGroupBox.Name = "DetailsGroupBox";
            this.DetailsGroupBox.Size = new System.Drawing.Size(368, 172);
            this.DetailsGroupBox.TabIndex = 117;
            this.DetailsGroupBox.TabStop = false;
            this.DetailsGroupBox.Text = "DETAILS";
            // 
            // PlateNumberLabel
            // 
            this.PlateNumberLabel.AutoSize = true;
            this.PlateNumberLabel.Location = new System.Drawing.Point(6, 69);
            this.PlateNumberLabel.Name = "PlateNumberLabel";
            this.PlateNumberLabel.Size = new System.Drawing.Size(61, 17);
            this.PlateNumberLabel.TabIndex = 0;
            this.PlateNumberLabel.Text = "Plate No.";
            // 
            // PlateNumberTextBox
            // 
            this.PlateNumberTextBox.BackColor = System.Drawing.Color.White;
            this.PlateNumberTextBox.Location = new System.Drawing.Point(9, 89);
            this.PlateNumberTextBox.Name = "PlateNumberTextBox";
            this.PlateNumberTextBox.ReadOnly = true;
            this.PlateNumberTextBox.Size = new System.Drawing.Size(353, 25);
            this.PlateNumberTextBox.TabIndex = 1;
            // 
            // VolumeCapacityTextBox
            // 
            this.VolumeCapacityTextBox.BackColor = System.Drawing.Color.White;
            this.VolumeCapacityTextBox.Location = new System.Drawing.Point(9, 137);
            this.VolumeCapacityTextBox.Name = "VolumeCapacityTextBox";
            this.VolumeCapacityTextBox.ReadOnly = true;
            this.VolumeCapacityTextBox.Size = new System.Drawing.Size(353, 25);
            this.VolumeCapacityTextBox.TabIndex = 3;
            // 
            // VolumeCapacityLabel
            // 
            this.VolumeCapacityLabel.AutoSize = true;
            this.VolumeCapacityLabel.Location = new System.Drawing.Point(6, 117);
            this.VolumeCapacityLabel.Name = "VolumeCapacityLabel";
            this.VolumeCapacityLabel.Size = new System.Drawing.Size(104, 17);
            this.VolumeCapacityLabel.TabIndex = 2;
            this.VolumeCapacityLabel.Text = "Volume Capacity";
            // 
            // PhysicalNumberTextBox
            // 
            this.PhysicalNumberTextBox.BackColor = System.Drawing.Color.White;
            this.PhysicalNumberTextBox.Location = new System.Drawing.Point(9, 41);
            this.PhysicalNumberTextBox.Name = "PhysicalNumberTextBox";
            this.PhysicalNumberTextBox.ReadOnly = true;
            this.PhysicalNumberTextBox.Size = new System.Drawing.Size(353, 25);
            this.PhysicalNumberTextBox.TabIndex = 5;
            // 
            // PhysicalNumberLabel
            // 
            this.PhysicalNumberLabel.AutoSize = true;
            this.PhysicalNumberLabel.Location = new System.Drawing.Point(6, 21);
            this.PhysicalNumberLabel.Name = "PhysicalNumberLabel";
            this.PhysicalNumberLabel.Size = new System.Drawing.Size(58, 17);
            this.PhysicalNumberLabel.TabIndex = 4;
            this.PhysicalNumberLabel.Text = "T.M. No.";
            // 
            // TransitMixer_Column
            // 
            this.TransitMixer_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TransitMixer_Column.HeaderText = "TRANSIT MIXERS";
            this.TransitMixer_Column.MinimumWidth = 150;
            this.TransitMixer_Column.Name = "TransitMixer_Column";
            this.TransitMixer_Column.ReadOnly = true;
            this.TransitMixer_Column.Width = 150;
            // 
            // TransitMixer_PlateNumberColumn
            // 
            this.TransitMixer_PlateNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TransitMixer_PlateNumberColumn.HeaderText = "PLATE NO.";
            this.TransitMixer_PlateNumberColumn.MinimumWidth = 150;
            this.TransitMixer_PlateNumberColumn.Name = "TransitMixer_PlateNumberColumn";
            this.TransitMixer_PlateNumberColumn.ReadOnly = true;
            this.TransitMixer_PlateNumberColumn.Width = 150;
            // 
            // TransitMixer_VolumeCapacityColumn
            // 
            this.TransitMixer_VolumeCapacityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle28.Format = "#,##0.0##";
            this.TransitMixer_VolumeCapacityColumn.DefaultCellStyle = dataGridViewCellStyle28;
            this.TransitMixer_VolumeCapacityColumn.HeaderText = "VOL. CAPACITY";
            this.TransitMixer_VolumeCapacityColumn.MinimumWidth = 150;
            this.TransitMixer_VolumeCapacityColumn.Name = "TransitMixer_VolumeCapacityColumn";
            this.TransitMixer_VolumeCapacityColumn.ReadOnly = true;
            this.TransitMixer_VolumeCapacityColumn.Width = 150;
            // 
            // TransitMixer_ExtraColumn
            // 
            this.TransitMixer_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TransitMixer_ExtraColumn.HeaderText = "";
            this.TransitMixer_ExtraColumn.Name = "TransitMixer_ExtraColumn";
            this.TransitMixer_ExtraColumn.ReadOnly = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(781, 3);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 35);
            this.DeleteButton.TabIndex = 120;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackColor = System.Drawing.Color.Red;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(673, 3);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(100, 35);
            this.EditButton.TabIndex = 119;
            this.EditButton.Text = "EDIT";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewButton.BackColor = System.Drawing.Color.Red;
            this.AddNewButton.FlatAppearance.BorderSize = 0;
            this.AddNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewButton.ForeColor = System.Drawing.Color.White;
            this.AddNewButton.Location = new System.Drawing.Point(565, 3);
            this.AddNewButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(100, 35);
            this.AddNewButton.TabIndex = 118;
            this.AddNewButton.Text = "ADD NEW";
            this.AddNewButton.UseVisualStyleBackColor = false;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // TransitMixerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.DetailsGroupBox);
            this.Controls.Add(this.TransitMixerDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TransitMixerManagement";
            this.Size = new System.Drawing.Size(936, 523);
            this.Load += new System.EventHandler(this.TransitMixerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransitMixerDataGridView)).EndInit();
            this.DetailsGroupBox.ResumeLayout(false);
            this.DetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TransitMixerDataGridView;
        private System.Windows.Forms.GroupBox DetailsGroupBox;
        private System.Windows.Forms.Label PlateNumberLabel;
        private System.Windows.Forms.TextBox PlateNumberTextBox;
        private System.Windows.Forms.TextBox VolumeCapacityTextBox;
        private System.Windows.Forms.Label VolumeCapacityLabel;
        private System.Windows.Forms.TextBox PhysicalNumberTextBox;
        private System.Windows.Forms.Label PhysicalNumberLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransitMixer_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransitMixer_PlateNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransitMixer_VolumeCapacityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransitMixer_ExtraColumn;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddNewButton;
    }
}
