using AForge.Video;
using AForge.Video.DirectShow;
using Citicon.Data;
using Citicon.DataManager;
using Citicon.TimeLog.ViewModels;
using Citicon.TimeLog.Views;
using Sorschia.Ui.Wpf;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Timers;

namespace Citicon.TimeLog
{
    internal sealed class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            CurrentDateTimer = new Timer(Convert.ToInt32(ConfigurationManager.AppSettings["CurrentDateTimer.Interval"]));
            CurrentDateTimer.Start();
            CurrentDateTimer.Elapsed += CurrentDateTimer_Elapsed;

            CurrentDate = DateTime.Now;
            GenericManager = new GenericManager();
        }

        private Timer CurrentDateTimer { get; }
        private GenericManager GenericManager { get; }

        private DateTime _CurrentDate;
        
        public DateTime CurrentDate
        {
            get { return _CurrentDate; }
            set
            {
                if (_CurrentDate != value)
                {
                    _CurrentDate = value;
                    OnPropertyChanged();
                }
            }
        }

        private Employee _CurrentEmployee;

        public Employee CurrentEmployee
        {
            get
            {
                return _CurrentEmployee;
            }
            set
            {
                LogSummaryView.CurrentEmployee = value;
                _CurrentEmployee = value;
                OnPropertyChanged();
            }
        }

        public EmployeeLogin LoginInfo { get; private set; }

        public LogSummaryView LogSummaryView { get; set; }

        public async Task GetEmployeeLoginAsync(string loginCode)
        {
            LoginInfo = await EmployeeManager.GetEmployeeLoginByCode(Convert.ToUInt32(loginCode));
            CurrentEmployee = LoginInfo?.Employee;
        }

        private async void CurrentDateTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            CurrentDate = await GenericManager.GetCurrentDateAsync();
        }
    }
}
