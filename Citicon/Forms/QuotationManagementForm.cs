using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class QuotationManagementForm : Form
    {
        public QuotationManagementForm(Project project)
        {
            InitializeComponent();
            Project = project ?? throw new ArgumentNullException(nameof(project));
        }

        public Project Project { get; }

        private async Task GetQuotationListAsync()
        {
            QuotationDataGridView.Rows.Clear();
            var quotations = await QuotationManager.GetListByProjectAsync(Project);

            if (quotations != null && quotations.Any())
            {
                foreach (var quotation in quotations)
                {
                    AddToUI(quotation);
                }
            }
        }

        private void AddToUI(Quotation quotation)
        {
            if (quotation != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };

                row.Cells.Add(new DataGridViewTextBoxCell { Value = quotation });
                QuotationDataGridView.Rows.Add(row);
            }
        }

        private void UpdateUI()
        {
            ClientTextBox.Text = Project?.Client?.ToString();
            ProjectTextBox.Text = Project?.ToString();
        }

        private async void QuotationManagementForm_Load(object sender, EventArgs e)
        {
            UpdateUI();
            await GetQuotationListAsync();
        }
    }
}
