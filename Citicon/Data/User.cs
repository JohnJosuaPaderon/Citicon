using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.Data
{
    public sealed class User : Sorschia.Data
    {
        public static User CurrentUser;
        private ulong id;
        private string username;
        private string password;
        private bool active;
        private bool admin;
        private string displayname;
        private Module module;
        public ulong Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("User.Id", value);
            }
        }
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged("User.Username", value);
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("User.Password", value);
            }
        }
        public bool Active
        {
            get { return active; }
            set
            {
                active = value;
                OnPropertyChanged("User.Active", value);
            }
        }
        public bool Admin
        {
            get { return admin; }
            set
            {
                admin = value;
                OnPropertyChanged("User.Admin", value);
            }
        }
        public string DisplayName
        {
            get { return displayname; }
            set
            {
                displayname = value;
                OnPropertyChanged("User.DisplayName", value);
            }
        }
        public Module Module
        {
            get { return module; }
            set
            {
                module = value;
                OnPropertyChanged("User.Module", value);
            }
        }
        public static bool operator ==(User x, User y)
        {
            return
                x?.username == y?.username &&
                x?.password == y?.password;
        }
        public static bool operator !=(User x, User y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is User) ? (obj as User).id == id : false;
        }
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
        public override string ToString()
        {
            return displayname;
        }
    }
}
