using Citicon.Data;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Citicon.HumanResourceIntegration.Forms
{
    public partial class EmployeeManagementForm : Form
    {
        public EmployeeManagementForm()
        {
            InitializeComponent();
            Employees = new BindingList<Employee>();
            Employees.ListChanged += Employees_ListChanged;
            lbxSearchSuggest.DataSource = Employees;
        }

        public BindingList<Employee> Employees { get; }

        private void Employees_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    break;
                case ListChangedType.ItemDeleted:
                    break;
            }

            if (Employees.Count == 0)
            {
                lbxSearchSuggest.Visible = false;
            }
            else
            {
                lbxSearchSuggest.Visible = true;
                lbxSearchSuggest.Height = Employees.Count <= 10 ? (Employees.Count + 1) * lbxSearchSuggest.ItemHeight : 11 * lbxSearchSuggest.ItemHeight;
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            Employees.Clear();

            foreach (var item in tbxSearch.Text)
            {
                Employees.Add(new Employee()
                {
                    LastName = item.ToString()
                });
            }
        }

        private void lbxSearchSuggest_DoubleClick(object sender, EventArgs e)
        {
            SelectItem();
        }

        private void SelectItem()
        {

        }
    }
}
