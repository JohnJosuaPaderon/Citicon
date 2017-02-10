namespace Citicon.Data
{
    public sealed class Branch : Sorschia.Data
    {
        private ulong id;
        private string code;
        private string description;
        public ulong Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Branch.Id", value);
            }
        }
        public string Code
        {
            get { return code; }
            set
            {
                code = value;
                OnPropertyChanged("Branch.Code", value);
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Branch.Description", value);
            }
        }
        public static bool operator ==(Branch x, Branch y)
        {
            return
                x?.code == y?.code &&
                x?.description == y?.description;
        }
        public static bool operator !=(Branch x, Branch y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is Branch) ? (obj as Branch).id == id : false;
        }
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
        public override string ToString()
        {
            return description;
        }
    }
}
