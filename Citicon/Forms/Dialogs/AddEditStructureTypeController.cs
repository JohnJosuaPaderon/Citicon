using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Threading.Tasks;

namespace Citicon.Forms.Dialogs
{
    internal sealed class AddEditStructureTypeController : FormControllerBase<AddEditStructureTypeDialog>
    {
        public AddEditStructureTypeController(AddEditStructureTypeDialog form, DataDialogMode mode, BillingStructureType structureType) : base(form)
        {
            Mode = mode;
            StructureType = structureType;

            switch (Mode)
            {
                case DataDialogMode.Add:
                    _Form.Text = "Add new Structure Type";
                    break;
                case DataDialogMode.Edit:
                    _Form.Text = "Edit Structure Type";
                    break;
            }
        }

        public DataDialogMode Mode { get; }
        public BillingStructureType StructureType { get; private set; }

        public async Task SaveAsync()
        {

            if (StructureType == null)
            {
                _MessageDisplay.Error("Invalid Structure Type.");
                return;
            }
            else
            {
                StructureType.Name = _Form.DescriptionTextBox.Text;
            }

            if (await BillingStructureTypeManager.ExistsAsync(StructureType))
            {
                _MessageDisplay.Error("Structure Type already exists.");
                return;
            }

            switch (Mode)
            {
                case DataDialogMode.Add:
                    await AddAsync();
                    break;
                case DataDialogMode.Edit:
                    await EditAsync();
                    break;
            }
        }

        private async Task AddAsync()
        {
            try
            {
                StructureType = await BillingStructureTypeManager.InsertAsync(StructureType);
                _Form.Close();
            }
            catch (Exception ex)
            {
                _MessageDisplay.Exception(ex);
                StructureType = null;
            }
        }

        private async Task EditAsync()
        {
            try
            {
                StructureType = await BillingStructureTypeManager.UpdateAsync(StructureType);
            }
            catch (Exception ex)
            {
                _MessageDisplay.Exception(ex);
                StructureType = null;
            }
        }

        public void Cancel()
        {
            StructureType = null;
            _Form.Close();
        }
    }
}
