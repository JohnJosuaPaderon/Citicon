using Citicon.Data;
using Citicon.DataManager;
using Citicon.Inventory.Data;
using Citicon.Inventory.DataManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Inventory
{
    public partial class ItemManagerForm : Form
    {
        private ClassificationManager classificationManager;
        private MeasurementUnitManager measurementUnitManager;
        private ItemManager itemManager;

        private Classification[] classifications;
        private MeasurementUnit[] measurementUnits;
        private Item[] items;
        private Item currentItem;

        int index;
        DataGridViewRow row;

        public ItemManagerForm()
        {
            InitializeComponent();
            classificationManager = new ClassificationManager();
            measurementUnitManager = new MeasurementUnitManager();
            itemManager = new ItemManager();

            classificationManager.ExceptionCatched += ExceptionCatched;
            itemManager.ExceptionCatched += ExceptionCatched;
            measurementUnitManager.ExceptionCatched += ExceptionCatched;

            classificationManager.NewItemGenerated += ClassificationManager_NewItemGenerated;
            itemManager.NewItemGenerated += ItemManager_NewItemGenerated;
            measurementUnitManager.NewItemGenerated += MeasurementUnitManager_NewItemGenerated;
            itemManager.Added += ItemManager_Added;
            itemManager.AddedUnsuccessful += ItemManager_AddedUnsuccessful;
            itemManager.Updated += ItemManager_Updated;
            itemManager.Removed += ItemManager_Removed;
        }

        private void ItemManager_Removed(Item e)
        {
            dgvItems.Rows.Remove(row);
            currentItem = null;
            displayCurrentItem();
            enableItemFields(false, false);
            tbxItemDescription.AutoCompleteCustomSource.Remove(e.Description);
            MessageBox.Show("item successfully removed!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MeasurementUnitManager_NewItemGenerated(MeasurementUnit e)
        {
            //Invoke(new Action(() => cmbxMeasurementUnit.Items.Add(e)));
        }

        private void ItemManager_Updated(Item e)
        {
            MessageBox.Show("Item has been updated successfully!");
            row.Cells[colItem.Name].Value = e;
            row.Cells[colItemCode.Name].Value = e.Code;
            row.Cells[colItemsClassification.Name].Value = e.Classification;
            row.Cells[colItemsStockValue.Name].Value = e.StockValue.ToString("#,##0.00");
            //dgvItems.Rows.Insert(index, e, e.Code, e.Classification, e.SubClassification, e.StockValue.ToString("#,##0"));
            currentItem = null;
            displayCurrentItem();
            enableItemFields(false, false);
        }

        private void ItemManager_AddedUnsuccessful(Item e)
        {
            displayError("Item was not saved!");
        }

        private void ItemManager_Added(Item e)
        {
            MessageBox.Show("Item was successfully added!");
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                Action<int> insert = (index) => { dgvItems.Rows.Insert(index, e, e.Code, e.Classification, e.StockValue.ToString("#,##0.00")); };
                var upper = (Item)row.Cells[colItem.Name].Value;
                var lowerIndex = row.Index + 1;
                var lower = lowerIndex < dgvItems.Rows.Count ? (Item)dgvItems.Rows[lowerIndex].Cells[colItem.Name].Value : null;
                if (lower != null)
                {
                    if (string.Compare(upper.Description, e.Description) == -1 && string.Compare(lower.Description, e.Description) == 1)
                    {
                        insert(lowerIndex);   
                        break;
                    }
                }
                else
                {
                    insert(row.Index + 1);
                    break;
                }
            }
            currentItem = null;
            displayCurrentItem();
            enableItemFields(false, false);
            tbxItemDescription.AutoCompleteCustomSource.Add(e.Description);
        }

        private void displayCurrentItem()
        {
            tbxItemCode.Text = string.Empty;
            tbxItemDescription.Text = string.Empty;
            cmbxItemClassification.SelectedItem = null;
            cmbxMeasurementUnit.SelectedItem = null;
            nudItemStockValue.Value = 0;
            ckbxCementSupplied.Checked = false;
            if (currentItem != null)
            {
                cmbxItemClassification.SelectedItem = currentItem.Classification;
                cmbxMeasurementUnit.SelectedItem = currentItem.MeasurementUnit;
                tbxItemCode.Text = currentItem.Code;
                tbxItemDescription.Text = currentItem.Description;
                nudItemStockValue.Value = currentItem.StockValue;
                ckbxCementSupplied.Checked = currentItem.CementSupplied;
                index = dgvItems.SelectedRows[0].Index;
            }
        }

        private void ItemManager_NewItemGenerated(Item e)
        {
            //Invoke(new Action(() =>
            //{
            //    dgvItems.Rows.Add(e, e.Code, e.Classification, e.SubClassification, e.StockValue.ToString("#,##0"));
            //    tbxItemDescription.AutoCompleteCustomSource.Add(e.Description);
            //}));
        }
        
        private void ClassificationManager_NewItemGenerated(Classification e)
        {
            //Invoke(new Action(() => cmbxItemClassification.Items.Add(e)));
        }

        private void ExceptionCatched(Exception ex)
        {
            if (Supports.DebugMode) MessageBox.Show(ex.Message);
        }

        private async Task loadClassifications()
        {
            cmbxItemClassification.Items.Clear();
            classifications = await classificationManager.GetListAsync();
        }

        private void displayClassifications()
        {
            cmbxItemClassification.Items.AddRange(classifications);
        }
        
        private async Task loadItems()
        {
            dgvItems.Rows.Clear();
            tbxItemDescription.AutoCompleteCustomSource.Clear();
            items = await itemManager.GetListAsync();
        }
        
        private void displayItems()
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            List<string> autoCompleteCustomSource = new List<string>();
            foreach (Item item in items)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Code });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Classification });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.StockValue.ToString("#,##0.00") });
                autoCompleteCustomSource.Add(item.Description);
                rows.Add(row);
            }
            dgvItems.Rows.AddRange(rows.ToArray());
            tbxItemDescription.AutoCompleteCustomSource.AddRange(autoCompleteCustomSource.ToArray());
        }

        private async Task loadMeasurementUnits()
        {
            cmbxMeasurementUnit.Items.Clear();
            measurementUnits = await measurementUnitManager.GetListAsync();
        }

        private void displayMeasurementUnits()
        {
            cmbxMeasurementUnit.Items.AddRange(measurementUnits);
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            checkChanges();
            currentItem = null;
            displayCurrentItem();
            enableItemFields(true, true);
            cmbxItemClassification.Focus();
        }

        private void enableItemFields(bool enabled, bool newItem)
        {
            tbxItemCode.Enabled = enabled;
            tbxItemDescription.Enabled = enabled;
            cmbxItemClassification.Enabled = enabled;
            cmbxMeasurementUnit.Enabled = enabled;
            nudItemStockValue.Enabled = newItem;
            dgvItems.Enabled = !enabled;
        }
        
        private void enableFields(bool enabled)
        {
            btnCancelItem.Enabled = enabled;
            btnEditItem.Enabled = enabled;
            btnNewItem.Enabled = enabled;
            btnRemoveItem.Enabled = enabled;
            btnSaveItem.Enabled = enabled;
            tbxItemCode.Enabled = enabled;
            tbxItemDescription.Enabled = enabled;
            cmbxItemClassification.Enabled = enabled;
            cmbxMeasurementUnit.Enabled = enabled;
            ckbxCementSupplied.Enabled = enabled;
            btnViewPriceHistory.Enabled = enabled;
        }

        private void displayMessage(string message)
        {
            Invoker(() => lblMessage.Text = message);
        }

        private void ItemManagerForm_Load(object sender, EventArgs e)
        {
            enableFields(false);
            displayMessage("Initializing...");
            List<Task> tasks = new List<Task>();
            tasks.Add(loadClassifications());
            tasks.Add(loadMeasurementUnits());
            tasks.Add(loadItems());
            var task = Task.WhenAll(tasks.ToArray());
            task.ContinueWith(x =>
            {
                displayMessage("Displaying data...");
                Invoker(() => {
                    displayClassifications();
                    displayMeasurementUnits();
                    displayItems();
                    enableFields(true);
                });
                displayMessage("");
            });
        }

        private void Invoker(Action method)
        {
            Invoke(method);
        }

        private void cmbxItemClassification_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxItemClassification.SelectedItem != null)
                tbxItemCode.Text = itemManager.GenerateCode((Classification)cmbxItemClassification.SelectedItem);
        }

        private bool itemHasChanges()
        {
            var classification = (Classification)cmbxItemClassification.SelectedItem;
            var code = tbxItemCode.Text.Trim();
            var description = tbxItemDescription.Text.Trim();
            var stockValue = (uint)nudItemStockValue.Value;
            var measurementUnit = (MeasurementUnit)cmbxMeasurementUnit.SelectedItem;
            if (currentItem != null)
            {
                if (classification != currentItem.Classification) return true;
                if (code != currentItem.Code) return true;
                if (description != currentItem.Description) return true;
                if (stockValue != currentItem.StockValue) return true;
                if (measurementUnit != currentItem.MeasurementUnit) return true;
                if (ckbxCementSupplied.Checked != currentItem.CementSupplied) return true;
            }
            return false;
        }

        private void insertCurrentItem()
        {
            if (index < 0) index = dgvItems.Rows.Count - 1;
            dgvItems.Rows.Insert(index, currentItem, currentItem.Code, currentItem.Classification, currentItem.StockValue.ToString("#,##0"));
            currentItem = null;
            row = null;
            index = -1;
            displayCurrentItem();
            enableItemFields(false, false);
        }

        private void checkChanges()
        {
            if (currentItem != null)
            {
                if (itemHasChanges())
                {
                    if (ask("Changes have been detected, Do you want to save this first before continue?") == DialogResult.Yes)
                        saveItem();
                    else insertCurrentItem();
                }
                else insertCurrentItem();
            }
            displayCurrentItem();
            enableItemFields(false, false);
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 1)
            {
                checkChanges();
                row = dgvItems.SelectedRows[0];
                index = row.Index;
                currentItem = (Item)row.Cells[colItem.Name].Value;
                displayCurrentItem();
                enableItemFields(true, false);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 1)
            {
                checkChanges();
                row = dgvItems.SelectedRows[0];
                index = row.Index;
                currentItem = (Item)row.Cells[colItem.Name].Value;
                if (ask($"Are you sure, you want to remove {currentItem}?") == DialogResult.Yes)
                {
                    itemManager.Remove(currentItem);
                }
                currentItem = null;
            }
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            enableItemFields(false, false);
        }

        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            checkChanges();
        }

        private bool validate()
        {
            var classification = (Classification)cmbxItemClassification.SelectedItem;
            var code = tbxItemCode.Text.Trim();
            var description = tbxItemDescription.Text.Trim();
            var stockValue = (uint)nudItemStockValue.Value;
            var measurementUnit = (MeasurementUnit)cmbxMeasurementUnit.SelectedItem;
            if (classification == null)
            {
                displayError("Classification must be valid!");
                return false;
            }
            if (code == string.Empty)
            {
                displayError("Item code must be valid!");
                return false;
            }
            if (description == string.Empty)
            {
                displayError("Item description must be valid!");
                return false;
            }
            if (stockValue > 0)
            {
                if (currentItem == null)
                {
                    if (ask("Do you want to leave stock value to less than zero(0)?") == DialogResult.No) return false;
                }
            }
            if (measurementUnit == null)
            {
                displayError("Measurement unit must be valid!"); return false;
            }
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                var item = (Item)row.Cells[colItem.Name].Value;
                
                if (item.Code == code && row.Index != this.row.Index)
                {
                    displayError("Item code already in use!");
                    return false;
                }
                if (item.Description == description)
                {
                    if (ask("Description already exists! Do you want to continue?") == DialogResult.No) return false;
                }
            }
            return true;
        }

        private void displayError(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private DialogResult ask(string message)
        {
            return MessageBox.Show(message, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            saveItem();
        }

        private void saveItem()
        {   
            if (validate())
            {
                var classification = (Classification)cmbxItemClassification.SelectedItem;
                var code = tbxItemCode.Text.Trim();
                var description = tbxItemDescription.Text.Trim();
                var stockValue = (uint)nudItemStockValue.Value;
                var measurementUnit = (MeasurementUnit)cmbxMeasurementUnit.SelectedItem;
                if (currentItem == null)
                {
                    currentItem = new Item
                    {
                        Classification = classification,
                        Code = code,
                        Description = description,
                        StockValue = stockValue,
                        MeasurementUnit = measurementUnit,
                        CementSupplied = ckbxCementSupplied.Checked
                    };
                    itemManager.Add(currentItem);
                }
                else
                {
                    if (itemHasChanges())
                    {
                        currentItem.Classification = classification;
                        currentItem.Code = code;
                        currentItem.Description = description;
                        currentItem.StockValue = stockValue;
                        currentItem.MeasurementUnit = measurementUnit;
                        currentItem.CementSupplied = ckbxCementSupplied.Checked;
                        itemManager.Update(currentItem);
                    }
                    else displayError("No changes detected!");
                }
                currentItem = null;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                var item = (Item)row.Cells[colItem.Name].Value;
                if (item.Description.StartsWith(tbxSearch.Text.Trim(), StringComparison.CurrentCultureIgnoreCase))
                {
                    row.Selected = true;
                    dgvItems.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void searchableComboBox(object sender, MouseEventArgs e)
        {
            if (e?.Button == MouseButtons.Right && sender is ComboBox)
            {
                var cmbx = (ComboBox)sender;
                cmbx.DropDownStyle = ComboBoxStyle.DropDown;
                cmbx.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbx.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cmbx.AutoCompleteCustomSource.Clear();
                var list = new List<string>();
                foreach (var item in cmbx.Items)
                    list.Add(item.ToString());
                cmbx.AutoCompleteCustomSource.AddRange(list.ToArray());
            }
        }

        private void cmbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changeComboBoxStyleToDropDownList((ComboBox)sender);
            }
        }

        private void changeComboBoxStyleToDropDownList(ComboBox cmbx)
        {
            if (cmbx.DropDownStyle != ComboBoxStyle.DropDownList) cmbx.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnViewPriceHistory_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 1)
            {
                PriceHistoryForm form = new PriceHistoryForm((Item)dgvItems.SelectedRows[0].Cells[colItem.Name].Value);
                form.ShowDialog();
            }
        }
    }
}
