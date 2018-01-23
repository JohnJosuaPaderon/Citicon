using Citicon.Data;
using System.Windows.Forms;

namespace Citicon.Forms.Dialogs
{
    public partial class AddEditStructureTypeDialog : Form
    {
        public static BillingStructureType Add()
        {
            var dialog = new AddEditStructureTypeDialog(DataDialogMode.Add, new BillingStructureType());
            dialog.ShowDialog();
            return dialog._Controller.StructureType;
        }

        public static BillingStructureType Edit(BillingStructureType structureType)
        {
            var dialog = new AddEditStructureTypeDialog(DataDialogMode.Edit, structureType);
            dialog.ShowDialog();
            return dialog._Controller.StructureType;
        }

        private AddEditStructureTypeDialog(DataDialogMode mode, BillingStructureType structureType)
        {
            InitializeComponent();
            _Controller = new AddEditStructureTypeController(this, mode, structureType);
        }

        private readonly AddEditStructureTypeController _Controller;

        private async void SaveButton_Click(object sender, System.EventArgs e)
        {
            await _Controller.SaveAsync();
        }

        private void CancelFormButton_Click(object sender, System.EventArgs e)
        {
            _Controller.Cancel();
        }
    }
}
