using Citicon.Data;
using Citicon.DataManager;
using Citicon.DataProcess;
using System;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Citicon.Forms.Controls
{
    public partial class QuotationViewControl : UserControl
    {
        public QuotationViewControl()
        {
            InitializeComponent();
            QuotationChanged += QuotationViewControl_QuotationChanged;
        }

        private async Task GetProjectDesignListAsync()
        {
            ProjectDesignDataGridView.Rows.Clear();
            var projectDesigns = await ProjectDesignManager.GetListByQuotationAsync(Quotation);

            if (projectDesigns != null && projectDesigns.Any())
            {
                foreach (var projectDesign in projectDesigns)
                {
                    AddToUI(projectDesign);
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
                ProjectDesignDataGridView.Rows.Add(projectDesign);
            }
        }

        private async void QuotationViewControl_QuotationChanged(object sender, EventArgs e)
        {
            await GetProjectDesignListAsync();
        }

        public event EventHandler QuotationChanged;

        private Quotation _Quotation;

        public Quotation Quotation
        {
            get { return _Quotation; }
            set
            {
                if (_Quotation != value)
                {
                    _Quotation = value;
                    UpdateUI();
                    OnQuotationChanged();
                }
            }
        }

        protected virtual void OnQuotationChanged()
        {
            QuotationChanged?.Invoke(this, new EventArgs());
        }

        private void UpdateUI()
        {
            QuotationNumberTextBox.Text = Quotation?.ToString();
            QuotationDateTextBox.Text = Quotation?.QuotationDate.ToString("MMMM dd, yyyy");
            StatusTextBox.Text = Quotation?.Status.ToString();

            PrintButton.Enabled = Quotation?.Status == QuotationStatus.Approved;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = QuotationManager.ExportQuotation(Quotation?.Type == QuotationType.Citicon ? ExportQuotation.QuotationReportTemplate.Citicon : ExportQuotation.QuotationReportTemplate.LexCiticoncrete,
                ConfigurationManager.AppSettings["Quotation.TemplatesDirectory"], Quotation, GetProjectDesigns(), ConfigurationManager.AppSettings["Quotation.SaveDirectory"]);

                if (result.Success)
                {
                    MessageBox.Show("Printing the quotation.");
                }
                else
                {
                    MessageBox.Show("Failed to print quotation.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<ProjectDesign> GetProjectDesigns()
        {
            if (ProjectDesignDataGridView.Rows.Count > 0)
            {
                var projectDesigns = new List<ProjectDesign>();

                foreach (DataGridViewRow row in ProjectDesignDataGridView.Rows)
                {
                    projectDesigns.Add(row.Cells[ProjectDesignColumn.Name].Value as ProjectDesign);
                }

                return projectDesigns;
            }

            return null;
        }
    }
}
