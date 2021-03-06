﻿using Citicon.Data;
using Citicon.DataManager;
using Citicon.Forms.Dialogs;
using Citicon.WindowsForm;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class RouteManagementForm : Form
    {
        public RouteManagementForm()
        {
            InitializeComponent();
            RouteManager = new DeliveryRouteManager();
        }

        private DeliveryRouteManager RouteManager;

        private Task SaveAsync()
        {
            throw new NotImplementedException();
        }

        private async Task GetRouteListAsync()
        {
            RouteDataGridView.Rows.Clear();

            try
            {
                var routes = await RouteManager.GetListAsync();

                if (routes != null && routes.Any())
                {
                    foreach (var route in routes)
                    {
                        AddToUI(route);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddToUI(DeliveryRoute route)
        {
            RouteDataGridView.Rows.Add(new DataGridViewRow()
                .SetHeight(30)
                .AddTextBoxCell(route)
                .AddTextBoxCell(route.StartPoint)
                .AddTextBoxCell(route.EndPoint)
                .AddTextBoxCell(route.Rate));
        }

        private void CancelDialogButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void SaveRouteButton_Click(object sender, EventArgs e)
        {
            await SaveAsync();
        }

        private async void RouteManagementForm_Load(object sender, EventArgs e)
        {
            await GetRouteListAsync();
        }

        private void RouteDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (RouteDataGridView.SelectedRows.Count == 1)
            {
                SelectedRoutePreview.Route = RouteDataGridView.SelectedRows[0].Cells[RouteColumn.Name].Value as DeliveryRoute;
            }
        }

        private async void AddNewButton_Click(object sender, EventArgs e)
        {
            AddEditRouteDialog.AddRoute();
            await GetRouteListAsync();
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            if (SelectedRoutePreview.Route != null)
            {
                AddEditRouteDialog.EditRoute(SelectedRoutePreview.Route);
                await GetRouteListAsync();
            }
        }
    }
}
