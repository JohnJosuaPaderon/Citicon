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
        private SubClassificationManager subClassificationManager;
        private ItemManager itemManager;

        private Classification[] classifications;
        private SubClassification[] subClassifications;
        private Item[] items;
        private Item currentItem;

        int index;
        DataGridViewRow row;

        public ItemManagerForm()
        {
            InitializeComponent();
            classificationManager = new ClassificationManager();
            subClassificationManager = new SubClassificationManager();
            itemManager = new ItemManager();

            classificationManager.ExceptionCatched += ExceptionCatched;
            subClassificationManager.ExceptionCatched += ExceptionCatched;
            itemManager.ExceptionCatched += ExceptionCatched;

            classificationManager.NewItemGenerated += ClassificationManager_NewItemGenerated;
            subClassificationManager.NewItemGenerated += SubClassificationManager_NewItemGenerated;
            itemManager.NewItemGenerated += ItemManager_NewItemGenerated;

            itemManager.Added += ItemManager_Added;
            itemManager.AddedUnsuccessful += ItemManager_AddedUnsuccessful;
            itemManager.Updated += ItemManager_Updated;
        }

        private void ItemManager_Updated(Item e)
        {
            MessageBox.Show("Item has been updated successfully!");
            dgvItems.Rows.Insert(index, e, e.Code, e.Classification, e.SubClassification, e.StockValue.ToString("#,##0"));
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
            dgvItems.Rows.Add(e, e.Code, e.Classification, e.SubClassification, e.StockValue.ToString("#,##0"));
            currentItem = null;
            displayCurrentItem();
            enableItemFields(false, false);
        }

        private void displayCurrentItem()
        {
            tbxItemCode.Text = string.Empty;
            tbxItemDescription.Text = string.Empty;
            cmbxItemClassification.SelectedItem = null;
            cmbxItemSubClassification.SelectedItem = null;
            nudItemStockValue.Value = 0;
            if (currentItem != null)
            {
                cmbxItemClassification.SelectedItem = currentItem.Classification;
                cmbxItemSubClassification.SelectedItem = currentItem.SubClassification;
                tbxItemCode.Text = currentItem.Code;
                tbxItemDescription.Text = currentItem.Description;
                nudItemStockValue.Value = currentItem.StockValue;
                index = dgvItems.SelectedRows[0].Index;
            }
        }

        private void ItemManager_NewItemGenerated(Item e)
        {
            Invoke(new Action(() => dgvItems.Rows.Add(e, e.Code, e.Classification, e.SubClassification, e.StockValue.ToString("#,##0"))));
        }

        private void SubClassificationManager_NewItemGenerated(SubClassification e)
        {
            Invoke(new Action(() => cmbxItemSubClassification.Items.Add(e)));
        }

        private void ClassificationManager_NewItemGenerated(Classification e)
        {
            Invoke(new Action(() => cmbxItemClassification.Items.Add(e)));
        }

        private void ExceptionCatched(Exception ex)
        {
            if (Supports.DebugMode) MessageBox.Show(ex.Message);
        }

        private async Task loadClassifications()
        {
            cmbxItemClassification.Items.Clear();
            classifications = (await classificationManager.GetListAsync());
        }

        private async Task loadSubClassifications()
        {
            cmbxItemSubClassification.Items.Clear();
            subClassifications = (await subClassificationManager.GetListAsync());
        }

        private async Task loadItems()
        {
            dgvItems.Rows.Clear();
            items = (await itemManager.GetListAsync());
        }
        
        private void btnNewItem_Click(object sender, EventArgs e)
        {
            checkChanges();
            currentItem = null;
            displayCurrentItem();
            enableItemFields(true, true);
        }

        private void enableItemFields(bool enabled, bool newItem)
        {
            tbxItemCode.Enabled = enabled;
            tbxItemDescription.Enabled = enabled;
            cmbxItemClassification.Enabled = enabled;
            cmbxItemSubClassification.Enabled = enabled;
            nudItemStockValue.Enabled = newItem;
            dgvItems.Enabled = !enabled;
        }

        private void lblNoSubClassification_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            setClassification();
        }

        private async void ItemManagerForm_Load(object sender, EventArgs e)
        {
            await loadItems();
            await loadClassifications();
            await loadSubClassifications();
        }

        private void cmbxItemClassification_SelectedIndexChanged(object sender, EventArgs e)
        {
            setClassification();
            generateItemCode();
        }
        private bool itemHasChanges()
        {
            var classification = (Classification)cmbxItemClassification.SelectedItem;
            var code = tbxItemCode.Text.Trim();
            var description = tbxItemDescription.Text.Trim();
            var stockValue = (uint)nudItemStockValue.Value;
            var subClassification = (SubClassification)cmbxItemSubClassification.SelectedItem;
            if (currentItem != null)
            {
                if (classification != currentItem.Classification) return true;
                if (code != currentItem.Code) return true;
                if (description != currentItem.Description) return true;
                if (stockValue != currentItem.StockValue) return true;
                if (subClassification != currentItem.SubClassification) return true;
            }
            return false;
        }

        private void insertCurrentItem()
        {
            if (index < 0) index = dgvItems.Rows.Count - 1;
            dgvItems.Rows.Insert(index, currentItem, currentItem.Code, currentItem.Classification, currentItem.SubClassification, currentItem.StockValue.ToString("#,##0"));
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

        private void setClassification()
        {
            if (cmbxItemClassification.SelectedItem != null)
            {
                var classification = (Classification)cmbxItemClassification.SelectedItem;
                cmbxItemSubClassification.Items.Clear();
                cmbxItemSubClassification.Items.AddRange(subClassifications.Where(x => x.Classification == classification).ToArray());
                tbxItemDescription.Text = ((Classification)cmbxItemClassification.SelectedItem).Description;
            }
        }

        private void cmbxItemSubClassification_SelectedIndexChanged(object sender, EventArgs e)
        {
            generateItemCode();
            if (cmbxItemSubClassification.SelectedItem != null)
            {
                tbxItemDescription.Text += $" {((SubClassification)cmbxItemSubClassification.SelectedItem).Description}";
            }
        }

        private void generateItemCode()
        {
            var classification = (Classification)cmbxItemClassification.SelectedItem;
            var subClassification = (SubClassification)cmbxItemSubClassification.SelectedItem;
            List<uint> rawCodes = new List<uint>();
            if (dgvItems.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    var tempClassification = (Classification)row.Cells[colItemsClassification.Name].Value;
                    var tempSubClassification = (SubClassification)row.Cells[colItemsSubClassification.Name].Value;
                    if (classification == tempClassification && subClassification == tempSubClassification)
                    {
                        var code = (string)row.Cells[colItemCode.Name].Value;
                        rawCodes.Add(uint.Parse(code.Substring(code.Length - 4)));
                    }
                    
                }
                for (int i = 1; i < 10000; i++)
                {
                    if (!exists(rawCodes, (uint)i))
                    {
                        extractItemCode(classification, subClassification, i);
                        return;
                    }
                }
            }
            else extractItemCode(classification, subClassification, 1);
        }

        private void extractItemCode(Classification classification, SubClassification subClassification, int i)
        {
            string code = string.Empty;
            if (classification != null)
                code += subClassification != null ? subClassification.Code : classification.Code;
            else code = $"{Supports.CodePrefixes.Classification}-0000-{Supports.CodePrefixes.SubClassification}-0000";
            tbxItemCode.Text = $"{code}-{Supports.CodePrefixes.Item}-{i.ToString("0000")}";
        }

        private bool exists(List<uint> list, uint x)
        {
            foreach (uint i in list) if (x == i) return true;
            return false;
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
                dgvItems.Rows.Remove(row);
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
            var subClassification = (SubClassification)cmbxItemSubClassification.SelectedItem;
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
            if (stockValue == 0)
            {
                if (currentItem == null)
                {
                    if (ask("Do you want to leave stock value to zero(0)?") == DialogResult.No) return false;
                }
            }
            bool asked = false;
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                var item = (Item)row.Cells[colItem.Name].Value;
                
                if (item.Code == code)
                {
                    displayError("Item code already in use!");
                    return false;
                }
                if (item.Classification == classification && item.SubClassification == subClassification && !asked)
                {
                    asked = true;
                    if (ask("Item with the same Classification, Sub-Classification and Supplier is already in the list, Do you want to continue?") == DialogResult.No) return false;
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
                var subClassification = (SubClassification)cmbxItemSubClassification.SelectedItem;

                if (currentItem == null)
                {
                    currentItem = new Item
                    {
                        Classification = classification,
                        Code = code,
                        Description = description,
                        StockValue = stockValue,
                        SubClassification = subClassification
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
                        currentItem.SubClassification = subClassification;
                        itemManager.Update(currentItem);
                    }
                    else displayError("No changes detected!");
                }
                currentItem = null;
            }
        }

        private void dgvItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }
    }
}
