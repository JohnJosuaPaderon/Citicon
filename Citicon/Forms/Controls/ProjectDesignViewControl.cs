using Citicon.Data;
using System.Windows.Forms;

namespace Citicon.Forms.Controls
{
    public partial class ProjectDesignViewControl : UserControl
    {
        public ProjectDesignViewControl()
        {
            InitializeComponent();
        }

        private ProjectDesign _ProjectDesign;

        public ProjectDesign ProjectDesign
        {
            get { return _ProjectDesign; }
            set
            {
                _ProjectDesign = value;
                UpdateUI();
            }
        }

        private void UpdateUI()
        {
            PricePerCubicMeterTextBox.Text = (ProjectDesign?.PricePerCubicMeter ?? 0).ToString("#,##0.00");
            MixTypeTextBox.Text = ProjectDesign?.MixType.ToString();
            PSITextBox.Text = (ProjectDesign?.Psi ?? 0).ToString("#,##0.0##");
            AggregateTextBox.Text = ProjectDesign?.Aggregate.ToString();
            StrengthTextBox.Text = ProjectDesign?.Strength.ToString();
            CementFactorTextBox.Text = (ProjectDesign?.CementFactor ?? 0).ToString("#,##0.0##");
        }
    }
}
