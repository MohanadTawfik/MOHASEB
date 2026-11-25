using MOHASEB.Classes;
using MOHASEB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableDependency.SqlClient.Exceptions;

namespace MOHASEB.Classes
{
    public static class Session
    {


        #region Fields
        private static MOHASEB_DBEntities _db;
        private static tbl_Period_Master _period;
        private static BindingList<tbl_Account> _accounts;
        private static BindingList<tbl_Currency> _currency;
        private static BindingList<tbl_Journal_Header> _journal;
        private static BindingList<tbl_Person_tbl_Customer> _customers;
        private static BindingList<tbl_Person_tbl_Vender> _venders;
        private static BindingList<tbl_Accounts_Groups> _accounts_groups;
        private static BindingList<tbl_Journal_Details> _journal_details;
        #endregion



        #region Properties
        public static tbl_Period_Master Period
        {
            get
            {
                if (_period == null)
                {
                    _period = DB.tbl_Period_Master.FirstOrDefault();
                }
                return _period;
            }
        }

        public static BindingList<tbl_Account> Accounts
        {
            get
            {
                if (_accounts == null)
                {
                    _accounts = new BindingList<tbl_Account>(DB.tbl_Account.ToList());
                    try
                    {
                        DB_Watcher.Accounts = new TableDependency.SqlClient.SqlTableDependency<tbl_Account>(Properties.Settings.Default.MOHASEB_ACCOUNTING_DBConnectionString);
                        DB_Watcher.Accounts.OnChanged += DB_Watcher.Accounts_Changed;
                        DB_Watcher.Accounts.Start();
                    }
                    catch (UserWithMissingPermissionException)
                    {
                        DB_Watcher.Accounts = null;
                    }
                }
                return _accounts;
            }
        }

        public static BindingList<tbl_Currency> Currencies
        {
            get
            {
                if (_currency == null)
                {
                    _currency = new BindingList<tbl_Currency>(DB.tbl_Currency.ToList());
                    try
                    {
                        DB_Watcher.Currencies = new TableDependency.SqlClient.SqlTableDependency<tbl_Currency>(Properties.Settings.Default.MOHASEB_ACCOUNTING_DBConnectionString);
                        DB_Watcher.Currencies.OnChanged += DB_Watcher.Currencies_Changed;
                        DB_Watcher.Currencies.Start();
                    }
                    catch (UserWithMissingPermissionException)
                    {
                        DB_Watcher.Currencies = null;
                    }
                }
                return _currency;
            }
        }

        public static BindingList<tbl_Journal_Header> Journal
        {
            get
            {
                if (_journal == null)
                {
                    _journal = new BindingList<tbl_Journal_Header>(DB.tbl_Journal_Header.Where(x => x.Period_No == Period.Year_No).ToList());

                    try
                    {
                        DB_Watcher.Journal = new TableDependency.SqlClient.SqlTableDependency<tbl_Journal_Header>(Properties.Settings.Default.MOHASEB_ACCOUNTING_DBConnectionString);
                        DB_Watcher.Journal.OnChanged += DB_Watcher.Journal_Changed;
                        DB_Watcher.Journal.Start();
                    }
                    catch (UserWithMissingPermissionException)
                    {
                        DB_Watcher.Journal = null;
                    }
                }
                return _journal;
            }
        }     
        
        public static BindingList<tbl_Journal_Details> Journal_Details
        {
            get
            {
                if (_journal_details == null)
                {
                    _journal_details = new BindingList<tbl_Journal_Details>(DB.tbl_Journal_Details.Where(x => x.tbl_Journal_Header.Period_No == Period.Year_No).ToList());

                    try
                    {
                        DB_Watcher.Journal_Details = new TableDependency.SqlClient.SqlTableDependency<tbl_Journal_Details>(Properties.Settings.Default.MOHASEB_ACCOUNTING_DBConnectionString);
                        DB_Watcher.Journal_Details.OnChanged += DB_Watcher.Journal_Details_Changed;
                        DB_Watcher.Journal_Details.Start();
                    }
                    catch (UserWithMissingPermissionException)
                    {
                        DB_Watcher.Journal_Details = null;
                    }
                }
                return _journal_details;
            }
        }

        public static BindingList<tbl_Person_tbl_Customer> Customers
        {
            get
            {
                if (_customers == null)
                {
                    _customers = new BindingList<tbl_Person_tbl_Customer>(DB.tbl_Person_tbl_Customer.ToList());

                    try
                    {
                        DB_Watcher.Customers = new TableDependency.SqlClient.SqlTableDependency<tbl_Person_tbl_Customer>(Properties.Settings.Default.MOHASEB_ACCOUNTING_DBConnectionString);
                        DB_Watcher.Customers.OnChanged += DB_Watcher.Customers_Changed;
                        DB_Watcher.Customers.Start();
                    }
                    catch (UserWithMissingPermissionException)
                    {
                        DB_Watcher.Customers = null;
                    }
                }
                return _customers;
            }
        }

        public static BindingList<tbl_Person_tbl_Vender> Venders
        {
            get
            {
                if (_venders == null)
                {
                    _venders = new BindingList<tbl_Person_tbl_Vender>(DB.tbl_Person_tbl_Vender.ToList());

                    try
                    {
                        DB_Watcher.Venders = new TableDependency.SqlClient.SqlTableDependency<tbl_Person_tbl_Vender>(Properties.Settings.Default.MOHASEB_ACCOUNTING_DBConnectionString);
                        DB_Watcher.Venders.OnChanged += DB_Watcher.Venders_Changed;
                        DB_Watcher.Venders.Start();
                    }
                    catch (UserWithMissingPermissionException)
                    {
                        DB_Watcher.Venders = null;
                    }
                }
                return _venders;
            }
        }
        public static BindingList<tbl_Accounts_Groups> Accounts_Groups
        {
            get
            {
                if (_accounts_groups == null)
                {
                    _accounts_groups = new BindingList<tbl_Accounts_Groups>(DB.tbl_Accounts_Groups.ToList());

                    try
                    {
                        DB_Watcher.Accounts_Groups = new TableDependency.SqlClient.SqlTableDependency<tbl_Accounts_Groups>(Properties.Settings.Default.MOHASEB_ACCOUNTING_DBConnectionString);
                        DB_Watcher.Accounts_Groups.OnChanged += DB_Watcher.Accounts_Groups_Changed;
                        DB_Watcher.Accounts_Groups.Start();
                    }
                    catch (UserWithMissingPermissionException)
                    {
                        DB_Watcher.Accounts_Groups = null;
                    }
                }
                return _accounts_groups;
            }
        }

        public static MOHASEB_DBEntities DB
        {
            get
            {
                if (_db == null)
                    _db = new MOHASEB_DBEntities();
                return _db;
            }
        }

    

        #endregion

    }
}


//Alter DATABASE MOHASEB_ACCOUNTING_DB_V1 SET ENABLE_BROKER

//Alter DATABASE MOHASEB_ACCOUNTING_DB_V1 SET ENABLE_BROKER WITH NO_WAIT;

//Alter DATABASE MOHASEB_ACCOUNTING_DB_V1 SET ENABLE_BROKER WITH ROLLBACK IMMEDIATE

//SELECT is_broker_enabled FROM sys.databases WHERE name = 'MOHASEB_ACCOUNTING_DB_V1';