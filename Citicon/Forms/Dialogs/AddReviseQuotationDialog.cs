using Citicon.Data;
using Citicon.DataManager;
using Citicon.DataProcess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms.Dialogs
{
    public partial class AddReviseQuotationDialog : Form
    {
        private AddReviseQuotationDialog()
        {
            InitializeComponent();
            DeletedProjectDesigns = new List<ProjectDesign>();
        }

        public static Quotation AddQuotation(Project project)
        {
            var dialog = new AddReviseQuotationDialog()
            {
                Mode = DataDialogMode.Add,
                Quotation = new Quotation()
                {
                    Project = project
                }
            };
            dialog.ShowDialog();
            dialog.Dispose();
            return dialog.Quotation;
        }

        public static Quotation EditQuotation(Quotation quotation)
        {
            var tempQuotation = Supports.Clone(quotation);
            quotation.RevisionNumber++;
            var dialog = new AddReviseQuotationDialog()
            {
                Mode = DataDialogMode.Edit,
                Quotation = quotation ?? throw new ArgumentNullException(nameof(quotation)),
                TempQuotation = tempQuotation
            };
            dialog.ShowDialog();
            dialog.Dispose();
            return dialog.Quotation;
        }

        private async void AddReviseQuotationDialog_Load(object sender, EventArgs e)
        {
            LoadQuotationTypes();
            LoadAgents();
            UpdateUI();
            await GetProjectDesignsAsync();
        }

        private Quotation Quotation { get; set; }
        private Quotation TempQuotation { get; set; }
        private DataDialogMode Mode { get; set; }
        private List<ProjectDesign> DeletedProjectDesigns { get; }

        private void UpdateUI()
        {
            QuotationNumberTextBox.Text = Quotation?.ToString();
            DateDateTimePicker.Value = Quotation?.QuotationDate != default(DateTime) ? Quotation.QuotationDate : DateTime.Now;
            AgentComboBox.SelectedItem = Quotation?.Agent;
            EngineerIDNumericUpDown.Value = Quotation?.EngineerId ?? 0;
            AmountNumericUpDown.Value = Quotation?.EngineerAmount ?? 0;
            ClientTextBox.Text = Quotation?.Project?.Client?.ToString();
            ProjectTextBox.Text = Quotation?.Project?.ToString();
            TermsRichTextBox.Rtf = Quotation?.NoteDetails;
            TypeComboBox.SelectedItem = Quotation?.Type;
        }

        private void LoadQuotationTypes()
        {
            TypeComboBox.Items.Clear();
            TypeComboBox.Items.Add(QuotationType.Citicon);
            TypeComboBox.Items.Add(QuotationType.Lex);
        }

        private void LoadAgents()
        {
            AgentComboBox.Items.Clear();
            var agents = EmployeeManager.GetAgent();

            if (agents != null && agents.Any())
            {
                AgentComboBox.Items.AddRange(agents.ToArray());
            }
        }

        private async Task GetProjectDesignsAsync()
        {
            ProjectDesignDataGridView.Rows.Clear();

            if (Quotation != null)
            {
                var projectDesigns = await ProjectDesignManager.GetListByQuotationAsync(Quotation);

                if (projectDesigns != null && projectDesigns.Any())
                {
                    foreach (var projectDesign in projectDesigns)
                    {
                        AddToUI(projectDesign);
                    }
                }
            }
        }

        private void AddDesignButton_Click(object sender, EventArgs e)
        {
            var projectDesign = AddEditProjectDesignDialog.ShowAddDialog(false);
            AddToUI(projectDesign);
        }

        private async Task GenerateQuotationNumberByTypeAsync()
        {
            if (Mode == DataDialogMode.Add)
            {
                if (Quotation != null)
                {
                    Quotation.Number = await QuotationManager.GenerateNumberByTypeAsync(Quotation.Type);
                    UpdateUI();
                }
            }
        }

        private void AddToUI(ProjectDesign projectDesign)
        {
            if (projectDesign != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign });
                ProjectDesignDataGridView.Rows.Add(row);
            }
        }

        private async Task AddAsync(QuotationTransaction quotationTransaction)
        {
            try
            {
                await GenerateQuotationNumberByTypeAsync();
                quotationTransaction = await QuotationManager.InsertTransactionAsync(quotationTransaction);
                await DeleteProjectDesignsAsync();

                if (quotationTransaction != null)
                {
                    MessageBox.Show("Quotation has been added successfully.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ExportQuotationToExcel(quotationTransaction);
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to add quotation.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ReviseAsync(QuotationTransaction quotationTransaction)
        {
            try
            {
                Quotation = await QuotationManager.UpdateAsync(quotationTransaction.Quotation);

                foreach (var item in quotationTransaction.Designs)
                {
                    item.Project = Quotation.Project;
                    item.Quotation = Quotation;
                    await ProjectDesignManager.UpdateAsync(item);
                }

                await DeleteProjectDesignsAsync();

                if (Quotation != null)
                {
                    MessageBox.Show("Quotation has been revised successfully.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ExportQuotationToExcel(quotationTransaction);
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to revise quotation.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportQuotationToExcel(QuotationTransaction quotationTransaction)
        {
            try
            {
                QuotationManager.ExportQuotation(
                quotationTransaction.Quotation.Type == QuotationType.Citicon ? ExportQuotation.QuotationReportTemplate.Citicon : ExportQuotation.QuotationReportTemplate.LexCiticoncrete,
                ConfigurationManager.AppSettings["Quotation.TemplatesDirectory"], quotationTransaction.Quotation, quotationTransaction.Designs, ConfigurationManager.AppSettings["Quotation.SaveDirectory"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task SaveQuotationAsync()
        {
            if (Quotation != null)
            {
                Quotation.Status = QuotationStatus.UnderNegotiation;
                if (ProjectDesignDataGridView.Rows.Count > 0)
                {
                    var quotationTransaction = new QuotationTransaction(Quotation);

                    foreach (DataGridViewRow row in ProjectDesignDataGridView.Rows)
                    {
                        quotationTransaction.Designs.Add(row.Cells[ProjectDesignColumn.Name].Value as ProjectDesign);
                    }

                    switch (Mode)
                    {
                        case DataDialogMode.None:
                            MessageBox.Show("Nothing to be done.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case DataDialogMode.Add:
                            await AddAsync(quotationTransaction);
                            break;
                        case DataDialogMode.Edit:
                            await ReviseAsync(quotationTransaction);
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("Quotation should include atleast one design.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid quotation.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task DeleteProjectDesignsAsync()
        {
            if (DeletedProjectDesigns.Count > 0)
            {
                foreach (var projectDesign in DeletedProjectDesigns)
                {
                    await ProjectDesignManager.DeleteAsync(projectDesign);
                }
            }
        }

        private async void SaveQuotationButton_Click(object sender, EventArgs e)
        {
            await SaveQuotationAsync();
        }

        private void CancelQuotationButton_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure, do you want to cancel?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes)
            {
                if (Mode == DataDialogMode.Add)
                {
                    Quotation = null;
                }
                else if (Mode == DataDialogMode.Edit)
                {
                    Quotation = Supports.Clone(TempQuotation);
                }

                Close();
            }
        }

        private async void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Quotation != null)
            {
                if (Mode == DataDialogMode.Add)
                {
                    Quotation.Type = (QuotationType)TypeComboBox.SelectedItem;
                    await GenerateQuotationNumberByTypeAsync();
                }
                else
                {
                    TypeComboBox.SelectedItem = Quotation.Type;
                }
            }
        }

        private void EditDesignButton_Click(object sender, EventArgs e)
        {
            if (ProjectDesignDataGridView.SelectedRows.Count == 1)
            {
                var projectDesign = ProjectDesignDataGridView.SelectedRows[0].Cells[ProjectDesignColumn.Name].Value as ProjectDesign;
                AddEditProjectDesignDialog.ShowEditDialog(projectDesign, false);

                ProjectDesignDataGridView.Rows[ProjectDesignDataGridView.SelectedRows[0].Index].Cells[ProjectDesignColumn.Name].Value = projectDesign;
                ProjectDesignDataGridView.Refresh();
            }
        }

        private void AddReviseQuotationDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void RemoveSelectedDesignButton_Click(object sender, EventArgs e)
        {
            if (ProjectDesignDataGridView.SelectedRows.Count == 1)
            {
                var row = ProjectDesignDataGridView.SelectedRows[0];

                if (row.Cells[ProjectDesignColumn.Name].Value is ProjectDesign projectDesign && projectDesign.Id > 0)
                {
                    DeletedProjectDesigns.Add(projectDesign);
                }

                ProjectDesignDataGridView.Rows.Remove(row);
            }
        }

        private void RemoveAllDesignsButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ProjectDesignDataGridView.Rows)
            {
                if (row.Cells[ProjectDesignColumn.Name].Value is ProjectDesign projectDesign && projectDesign.Id > 0)
                {
                    DeletedProjectDesigns.Add(projectDesign);
                }
            }

            ProjectDesignDataGridView.Rows.Clear();
        }

        private void EngineerIDNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Quotation != null)
            {
                Quotation.EngineerId = (ulong)EngineerIDNumericUpDown.Value;
            }
        }

        private void AmountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Quotation != null)
            {
                Quotation.EngineerAmount = AmountNumericUpDown.Value;
            }
        }

        private void DateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (Quotation != null)
            {
                Quotation.QuotationDate = DateDateTimePicker.Value;
            }
        }

        private void AgentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Quotation != null)
            {
                Quotation.Agent = (Employee)AgentComboBox.SelectedItem;
            }
        }

        private void TermsRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Quotation != null)
            {
                Quotation.NoteDetails = TermsRichTextBox.Rtf;
            }
        }
    }
}
