using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Citicon.DesktopClient.QuotationApproval.Views
{
    /// <summary>
    /// Interaction logic for ProjectDisplayControl.xaml
    /// </summary>
    public partial class ProjectDisplayControl : UserControl
    {
        public ProjectDisplayControl()
        {
            InitializeComponent();
        }

        #region SelectedClient
        public Client SelectedClient
        {
            get { return (Client)GetValue(SelectedClientProperty); }
            set
            {
                Dispatcher.Invoke(() =>
                {
                    tbxClient_CompanyName.Text = string.Empty;
                    tbxClient_Address.Text = string.Empty;
                    tbxClient_Executive.Text = string.Empty;
                    tbxClient_ExecutivePosition.Text = string.Empty;
                    tbxClient_Representative.Text = string.Empty;
                    tbxClient_RepresentativePosition.Text = string.Empty;
                    dgvProjectList.Items.Clear();

                    if (value != null)
                    {
                        tbxClient_CompanyName.Text = value.CompanyName;
                        tbxClient_Address.Text = value.Address;
                        tbxClient_Executive.Text = value.PresidentName;
                        tbxClient_ExecutivePosition.Text = value.Designation;
                        tbxClient_Representative.Text = $"{value.Title} {value.FirstName} {value.LastName}";
                        tbxClient_RepresentativePosition.Text = value.Position;
                    }

                    SetValue(SelectedClientProperty, value);
                });

                if (value != null)
                {
                    Task.WaitAll(LoadProjectListAsync());
                }
            }
        }

        // Using a DependencyProperty as the backing store for SelectedClient.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedClientProperty =
            DependencyProperty.Register("SelectedClient", typeof(Client), typeof(ProjectDisplayControl), new PropertyMetadata(null));
        #endregion

        #region SelectedProject
        public Project SelectedProject
        {
            get { return (Project)GetValue(MyPropertyProperty); }
            private set
            {
                Dispatcher.Invoke(() =>
                {
                    tbxGeneral_Name.Text = string.Empty;
                    tbxGeneral_Location.Text = string.Empty;
                    dgvProjectDesignList.Items.Clear();

                    if (value != null)
                    {
                        tbxGeneral_Name.Text = value.Name;
                        tbxGeneral_Location.Text = value.Location;
                    }

                    SetValue(MyPropertyProperty, value);
                });

                if (value != null)
                {
                    Task.WaitAll(LoadProjectDesignListAsync());
                }
            }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty", typeof(Project), typeof(ProjectDisplayControl), new PropertyMetadata(null));
        #endregion

        public event RoutedEventHandler PreviousButtonClick;
        public event ProjectDisplayNextButtonClickEventHandler NextButtonClick;

        private async Task LoadProjectListAsync()
        {
            //var task = ProjectManager.GetListWithQuotationForApprovalByClientAsync(SelectedClient);
            //task.ContinueWith(DisplayProjectList);

            try
            {
                var projects = await ProjectManager.GetListWithQuotationForApprovalByClientAsync(SelectedClient);

                Dispatcher.Invoke(() => dgvProjectList.Items.Clear());

                if (projects != null)
                {
                    foreach (Project project in projects)
                    {
                        Dispatcher.Invoke(() => dgvProjectList.Items.Add(project));
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        private async Task LoadProjectDesignListAsync()
        {
            //var task = ProjectDesignManager.GetListByProjectAsync(SelectedProject);
            //task.ContinueWith(DisplayProjectDesignList);

            try
            {
                var projectDesigns = await ProjectDesignManager.GetListByProjectAsync(SelectedProject);

                Dispatcher.Invoke(() => dgvProjectDesignList.Items.Clear());

                if (projectDesigns != null)
                {
                    foreach (ProjectDesign projectDesign in projectDesigns)
                    {
                        Dispatcher.Invoke(() => dgvProjectDesignList.Items.Add(projectDesign));
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void DisplayProjectDesignList(Task<IEnumerable<ProjectDesign>> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                if (task.Result != null)
                {
                    foreach (ProjectDesign projectDesign in task.Result)
                    {
                        Dispatcher.Invoke(() => dgvProjectDesignList.Items.Add(projectDesign));
                    }
                }
            }
        }

        private void DisplayProjectList(Task<IEnumerable<Project>> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                if (task.Result != null)
                {
                    foreach (Project project in task.Result)
                    {
                        Dispatcher.Invoke(() => dgvProjectList.Items.Add(project));
                    }
                }
            }
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            PreviousButtonClick?.Invoke(this, new RoutedEventArgs());
        }

        private void dgvProjectList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedProject = (Project)dgvProjectList.SelectedItem;
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            NextButtonClick?.Invoke(this, new ProjectDisplayNextButtonClickEventArgs(SelectedProject));
        }

        private async void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            dgvProjectList.Items.Clear();
            await LoadProjectListAsync();
        }
    }
}
