using AForge.Video;
using AForge.Video.DirectShow;
using Citicon.Data;
using Citicon.DataManager;
using Sorschia.Ui.Wpf;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Citicon.TimeLog.ViewModels
{
    internal sealed class LogSummaryViewModel : ViewModelBase
    {
        public LogSummaryViewModel() : base()
        {
            try
            {
                CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                Frame = new VideoCaptureDevice(CaptureDevice[0].MonikerString);
                Frame.NewFrame += Frame_NewFrame;
                Frame.Start();
            }
            catch (Exception)
            {
                Message = "Camera unavailable.";
            }

            DisplayTimer = new Timer(3000);
            DisplayTimer.Elapsed += DisplayTimer_Elapsed;
        }

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice Frame;
        private Timer DisplayTimer;

        private Employee _Employee;

        public Employee Employee
        {
            get { return _Employee; }
            set
            {
                _Employee = value;
                OnPropertyChanged();
            }
        }

        private EmployeeLogin _EmployeeLogin;

        public EmployeeLogin EmployeeLogin
        {
            get { return _EmployeeLogin; }
            set
            {
                if (_EmployeeLogin != value)
                {
                    _EmployeeLogin = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _Message;

        public string Message
        {
            get { return _Message; }
            set
            {
                if (_Message != value)
                {
                    _Message = value;
                    OnPropertyChanged();
                }
            }
        }

        private ImageSource TempAvatar;

        private ImageSource _EmployeeAvatar;

        public ImageSource EmployeeAvatar
        {
            get { return _EmployeeAvatar; }
            set
            {
                if (_EmployeeAvatar != value)
                {
                    _EmployeeAvatar = value;
                    OnPropertyChanged();
                }
            }
        }

        private void Capture()
        {
            if (Employee != null)
            {
                EmployeeAvatar = TempAvatar;
            }
        }

        private void SaveImage(Data.TimeLog timeLog)
        {
            if (EmployeeAvatar != null)
            {
                var logInfoDate = timeLog.Logout == null ? timeLog.Login : timeLog.Logout;
                var directory = Path.Combine(ConfigurationManager.AppSettings["TimeLog.ImagesDirectory"], logInfoDate?.ToString("yyyy"), logInfoDate?.ToString("MM-MMMM"), logInfoDate?.ToString("dd-ddd"));

                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                var filePath = Path.Combine(directory, string.Format("[{0}] {1}.jpg", timeLog.EmployeeLogin.Employee.ToString(), logInfoDate?.ToString("HH_mm_ss")));
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    var encoder = new PngBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create((BitmapSource)EmployeeAvatar));
                    encoder.Save(fileStream);
                }
            }
        }

        private void SendMessage(Data.TimeLog log)
        {
            
        }

        public async Task LogEmployeeAsync(EmployeeLogin loginInfo)
        {
            DisplayTimer.Stop();

            if (loginInfo != null)
            {
                try
                {
                    var timeLog = await EmployeeManager.LogEmployeeAsync(loginInfo);

                    if (timeLog != null)
                    {
                        EmployeeLogin = loginInfo;
                        Employee = loginInfo.Employee;
                        Capture();

                        if (timeLog.Logout == null)
                        {
                            Message = "--IN--"; //string.Format("Logged-in @ {0}", timeLog.Login?.ToString("hh:mm tt"));
                        }
                        else
                        {
                            Message = "--OUT--"; //string.Format("Logged-out @ {0}", timeLog.Logout?.ToString("hh:mm tt"));
                        }

                        SaveImage(timeLog);
                        SendMessage(timeLog);
                    }
                }
                catch (Exception ex)
                {
                    Message = string.Format("Fatal error occured. {0}", ex.GetType().Name);
                }
            }
            else
            {
                Message = "No employee was found!";
            }

            DisplayTimer.Start();
        }

        private BitmapImage BitMapToBitMapImageSource(Bitmap bitMap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitMap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();
                bitmapimage.Freeze();

                return bitmapimage;
            }
        }

        private void Frame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            TempAvatar = BitMapToBitMapImageSource(eventArgs.Frame);
        }

        private void DisplayTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DisplayTimer.Stop();

            Employee = null;
            EmployeeAvatar = null;
            Message = null;
        }

        public void Dispose()
        {
            if (Frame.IsRunning)
            {
                Frame.Stop();
            }
        }
    }
}
