using Citicon.Data;
using Citicon.DataProcess;
using MySql.Data.MySqlClient;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class UserManager : DataManager<User>, IDataManager<User>
    {
        public static async Task<User> InsertAsync(User user)
        {
            using (var process = new InsertUser(user))
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<User> InsertAsync(User user, MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var process = new InsertUser(user))
            {
                return await process.ExecuteAsync(connection, transaction);
            }
        }

        public void Add(User data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_users_add"))
            {
                query.AddParameter("@_UserId");
                query.AddParameter("@_Active", data.Active);
                query.AddParameter("@_Admin", data.Admin);
                query.AddParameter("@_DisplayName", data.DisplayName);
                query.AddParameter("@_Password", Supports.Encrypt(data.Password));
                query.AddParameter("@_Username", Supports.Encrypt(data.Username));
                query.AddParameter("@_ModuleId", data.Module?.Id);
                query.AddParameter("@_Inventory_OutgoingOnly", data.Inventory_OutgoingStocksOnly);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1)
                {
                    data.Id = query.ParameterValues.GetUInt64("@_UserId");
                    OnAdded(data);
                }
                else OnAddedUnsuccessful(data);
            }
        }

        public Task AddAsync(User data)
        {
            return Task.Factory.StartNew(() => Add(data));
        }

        public bool Exists(string username, string password)
        {
            bool exists = false;
            using (var query = new MySqlQuery(Supports.ConnectionString, "SELECT _users_exists(@_Username,@_Password)", System.Data.CommandType.Text))
            {
                query.AddParameter("@_Username", Supports.Encrypt(username));
                query.AddParameter("@_Password", Supports.Encrypt(password));
                query.ExceptionCatched += OnExceptionCatched;
                exists = Convert.ToBoolean(query.GetValue());
            }
            return exists;
        }

        public User ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                return new User
                {
                    Active = dictionary.GetBoolean("Active"),
                    Admin = dictionary.GetBoolean("Admin"),
                    DisplayName = dictionary.GetString("DisplayName"),
                    Id = dictionary.GetUInt64("UserId"),
                    Password = Supports.Decrypt(dictionary.GetString("Password")),
                    Username = Supports.Decrypt(dictionary.GetString("Username")),
                    Module = (new ModuleManager()).GetById(dictionary.GetUInt64("ModuleId")),
                    Inventory_OutgoingStocksOnly = dictionary.GetBoolean("Inventory_OutgoingOnly")
                };
            }
            return null;
        }

        public User GetById(ulong id)
        {
            if (id != 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "_users_getbyid"))
                {
                    query.AddParameter("@_UserId", id);
                    query.ExceptionCatched += OnExceptionCatched;
                    return ExtractFromDictionary(query.GetRecord());
                }
            }
            return null;
        }

        public Task<User> GetByIdAsync(ulong id)
        {
            return Task.Factory.StartNew(() => GetById(id));
        }

        public User[] GetList()
        {
            List<User> paymentTerms = null;
            using (var query = new MySqlQuery(Supports.ConnectionString, "_users_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var result = query.GetResult();
                if (result != null)
                {
                    paymentTerms = new List<User>();
                    foreach (var item in result)
                    {
                        paymentTerms.Add(ExtractFromDictionary(item));
                    }
                }
            }
            return paymentTerms?.ToArray();
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemGenerated(ExtractFromDictionary(e));
        }

        public Task<User[]> GetListAsync()
        {
            return Task.Factory.StartNew(GetList);
        }

        public void LoginCurrent(string username, string password)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_users_login"))
            {
                query.AddParameter("@_Username", Supports.Encrypt(username));
                query.AddParameter("@_Password", Supports.Encrypt(password));
                query.ExceptionCatched += OnExceptionCatched;
                User.CurrentUser = ExtractFromDictionary(query.GetRecord());
            }
        }

        public User Login(string username, string password)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_users_login"))
            {
                query.AddParameter("@_Username", Supports.Encrypt(username));
                query.AddParameter("@_Password", Supports.Encrypt(password));
                query.ExceptionCatched += OnExceptionCatched;
                return ExtractFromDictionary(query.GetRecord());
            }
        }

        public void Remove(User data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_users_remove"))
            {
                query.AddParameter("@_UserId", data.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnRemoved(data);
                else OnRemovedUnsuccessful(data);
            }
        }

        public Task RemoveAsync(User data)
        {
            return Task.Factory.StartNew(() => Remove(data));
        }

        public void Update(User data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_users_update"))
            {
                query.AddParameter("@_UserId", data.Id);
                query.AddParameter("@_Active", data.Active);
                query.AddParameter("@_Admin", data.Admin);
                query.AddParameter("@_DisplayName", data.DisplayName);
                query.AddParameter("@_Password", Supports.Encrypt(data.Password));
                query.AddParameter("@_Username", Supports.Encrypt(data.Username));
                query.AddParameter("@_ModuleId", data.Module?.Id);
                query.AddParameter("@_Inventory_OutgoingOnly", data.Inventory_OutgoingStocksOnly);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.Execute();
                if (query.AffectedRows == 1) OnUpdated(data);
                else OnUpdatedUnsuccessful(data);
            }
        }

        public Task UpdateAsync(User data)
        {
            return Task.Factory.StartNew(() => Update(data));
        }
    }
}
