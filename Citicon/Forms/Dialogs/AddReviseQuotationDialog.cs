using Citicon.Data;
using Citicon.DataManager;
using System;
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
            return dialog.Quotation;
        }

        public static Quotation EditQuotation(Quotation quotation)
        {
            var dialog = new AddReviseQuotationDialog()
            {
                Mode = DataDialogMode.Edit,
                Quotation = quotation ?? throw new ArgumentNullException(nameof(quotation))
            };
            dialog.ShowDialog();
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
        private DataDialogMode Mode { get; set; }

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

        private void SaveQuotationButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelQuotationButton_Click(object sender, EventArgs e)
        {

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
    }
}
