using System.ComponentModel;

namespace Citicon.Data
{
    public class Project : INotifyPropertyChanged
    {
        private ulong _Id;
        private Client _Client;
        private string _Name;
        private string _Location;
        private decimal _TotalCost;
        private bool _Completed;
        private ProjectType _Type;
        private decimal _InitialPayment;
        private double _InitialCement;


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
        public Client Client
        {
            get { return _Client; }
            set
            {
                if (_Client != value)
                {
                    _Client = value;
                    OnPropertyChanged(nameof(Client));
                }
            }
        }
        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public string Location
        {
            get { return _Location; }
            set
            {
                if (_Location != value)
                {
                    _Location = value;
                    OnPropertyChanged(nameof(Location));
                }
            }
        }
        public decimal TotalCost
        {
            get { return _TotalCost; }
            set
            {
                if (_TotalCost != value)
                {
                    _TotalCost = value;
                    OnPropertyChanged(nameof(TotalCost));
                }
            }
        }
        public bool Completed
        {
            get { return _Completed; }
            set
            {
                if (_Completed != value)
                {
                    _Completed = value;
                    OnPropertyChanged(nameof(Completed));
                }
            }
        }
        public ProjectType Type
        {
            get { return _Type; }
            set
            {
                if (_Type != value)
                {
                    _Type = value;
                    OnPropertyChanged(nameof(Type));
                }
            }
        }
        public decimal InitialPayment
        {
            get { return _InitialPayment; }
            set
            {
                if (_InitialPayment != value)
                {
                    _InitialPayment = value;
                    OnPropertyChanged(nameof(InitialPayment));
                }
            }
        }
        public double InitialCement
        {
            get { return _InitialCement; }
            set
            {
                if (_InitialCement != value)
                {
                    _InitialCement = value;
                    OnPropertyChanged(nameof(InitialCement));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static bool operator ==(Project left, Project right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }
        public static bool operator !=(Project left, Project right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Project)
            {
                return (Project)arg == this;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override string ToString()
        {
            return _Name;
        }
    }
}
