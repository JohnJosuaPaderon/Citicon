using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.Data
{
    public sealed class BankAccount : Sorschia.Data
    {
        private ulong id;
        private Bank bank;
        private string code;
        private string description;
        private uint chequenumber;
        public ulong Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged("BankAccount.Id", value);
                }
            }
        }
        public Bank Bank
        {
            get { return bank; }
            set
            {
                if (bank != value)
                {
                    bank = value;
                    OnPropertyChanged("BankAccount.Bank", bank);
                }
            }
        }
        public string Code
        {
            get { return code; }
            set
            {
                if (code != value)
                {
                    code = value;
                    OnPropertyChanged("BankAccount.Code", value);
                }
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged("BankAccount.Description", value);
                }
            }
        }
        public uint ChequeNumber
        {
            get { return chequenumber; }
            set
            {
                if (chequenumber != value)
                {
                    chequenumber = value;
                    OnPropertyChanged("BankAccount.ChequeNumber", value);
                }
            }
        }
        public static bool operator ==(BankAccount x, BankAccount y)
        {
            return
                x?.bank == y?.bank &&
                x?.code == y?.code &&
                x?.description == y?.description;
        }
        public static bool operator !=(BankAccount x, BankAccount y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is BankAccount) ? (obj as BankAccount).id == id : false;
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
