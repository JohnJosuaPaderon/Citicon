using Citicon.Data;
using System.Windows;

namespace Citicon.DesktopClient.QuotationApproval.Views
{
    public delegate void ProjectDisplayNextButtonClickEventHandler(object sender, ProjectDisplayNextButtonClickEventArgs e);

    public sealed class ProjectDisplayNextButtonClickEventArgs : RoutedEventArgs
    {
        public ProjectDisplayNextButtonClickEventArgs(Project selectedProject)
        {
            SelectedProject = selectedProject;
        }

        public Project SelectedProject { get; }
    }
}
