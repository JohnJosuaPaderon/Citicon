using System.ComponentModel;

namespace Citicon.Data
{
    public class Client : INotifyPropertyChanged
    {
        private ulong _Id;
        private string _CompanyName;
        private string _Address;
        private string _EmailAddress;
        private string _ContactNumber;
        private string _Tin;
        private string _Position;
        private string _Title;
        private string _FirstName;
        private string _MiddleName;
        private string _LastName;
        private string _PhotoPath;
        private string _PresidentName;
        private string _PresidentTelephoneNumber;
        private string _PresidentMobileNumber;
        private string _Designation;
        private Employee _Employee;


        public ulong Id
        {
            get { return _Id; }
            set
            {
                if (_Id != value)
                {
                    _Id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }
        public string CompanyName
        {
            get { return _CompanyName; }
            set
            {
                if (_CompanyName != value)
                {
                    _CompanyName = value;
                    OnPropertyChanged(nameof(CompanyName));
                }
            }
        }
        public string Address
        {
            get { return _Address; }
            set
            {
                if (_Address != value)
                {
                    _Address = value;
                    OnPropertyChanged(nameof(Address));
                }
            }
        }
        public string EmailAddress
        {
            get { return _EmailAddress; }
            set
            {
                if (_EmailAddress != value)
                {
                    _EmailAddress = value;
                    OnPropertyChanged(nameof(EmailAddress));
                }
            }
        }
        public string ContactNumber
        {
            get { return _ContactNumber; }
            set
            {
                if (_ContactNumber != value)
                {
                    _ContactNumber = value;
                    OnPropertyChanged(nameof(ContactNumber));
                }
            }
        }
        public string Tin
        {
            get { return _Tin; }
            set
            {
                if (_Tin != value)
                {
                    _Tin = value;
                    OnPropertyChanged(nameof(Tin));
                }
            }
        }
        public string Position
        {
            get { return _Position; }
            set
            {
                if (_Position != value)
                {
                    _Position = value;
                    OnPropertyChanged(nameof(Position));
                }
            }
        }
        public string Title
        {
            get { return _Title; }
            set
            {
                if (_Title != value)
                {
                    _Title = value;
                    OnPropertyChanged(nameof(Title));
                }
            }
        }
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (_FirstName != value)
                {
                    _FirstName = value;
                    OnPropertyChanged(nameof(FirstName));
                }
            }
        }
        public string MiddleName
        {
            get { return _MiddleName; }
            set
            {
                if (_MiddleName != value)
                {
                    _MiddleName = value;
                    OnPropertyChanged(nameof(MiddleName));
                }
            }
        }
        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (_LastName != value)
                {
                    _LastName = value;
                    OnPropertyChanged(nameof(LastName));
                }
            }
        }
        public string PhotoPath
        {
            get { return _PhotoPath; }
            set
            {
                if (_PhotoPath != value)
                {
                    _PhotoPath = value;
                    OnPropertyChanged(nameof(PhotoPath));
                }
            }
        }
        public string PresidentName
        {
            get { return _PresidentName; }
            set
            {
                if (_PresidentName != value)
                {
                    _PresidentName = value;
                    OnPropertyChanged(nameof(PresidentName));
                }
            }
        }
        public string PresidentTelephoneNumber
        {
            get { return _PresidentTelephoneNumber; }
            set
            {
                if (_PresidentTelephoneNumber != value)
                {
                    _PresidentTelephoneNumber = value;
                    OnPropertyChanged(nameof(PresidentTelephoneNumber));
                }
            }
        }
        public string PresidentMobileNumber
        {
            get { return _PresidentMobileNumber; }
            set
            {
                if (_PresidentMobileNumber != value)
                {
                    _PresidentMobileNumber = value;
                    OnPropertyChanged(nameof(PresidentMobileNumber));
                }
            }
        }
        public string Designation
        {
            get { return _Designation; }
            set
            {
                if (_Designation != value)
                {
                    _Designation = value;
                    OnPropertyChanged(nameof(Designation));
                }
            }
        }
        public Employee Employee
        {
            get { return _Employee; }
            set
            {
                if (_Employee != value)
                {
                    _Employee = value;
                    OnPropertyChanged(nameof(Employee));
                }
            }
        }
        public bool Legitimate { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static bool operator ==(Client left, Client right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }
        public static bool operator !=(Client left, Client right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Client)
            {
                return (Client)arg == this;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override string ToString()
        {
            return _CompanyName;
        }
    }
}
