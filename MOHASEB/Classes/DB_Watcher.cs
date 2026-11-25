using MOHASEB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace MOHASEB.Classes
{
    public static class DB_Watcher
    {

        public static SqlTableDependency<tbl_Account> Accounts;

        public static void Accounts_Changed(object sender, RecordChangedEventArgs<tbl_Account> e)
        {

            Application.OpenForms[0].Invoke(new Action(() =>
            {
                if (e.ChangeType == ChangeType.Insert)
                {
                    Session.Accounts.Add(e.Entity);
                }
                else if (e.ChangeType == ChangeType.Update)
                {
                    var index = Session.Accounts.IndexOf(Session.Accounts.Single(x => x.Acc_No == e.Entity.Acc_No));
                    Session.Accounts.Remove(Session.Accounts.Single(x => x.Acc_No == e.Entity.Acc_No));
                    Session.Accounts.Insert(index, e.Entity);
                }
                else if (e.ChangeType == ChangeType.Delete)
                {
                    Session.Accounts.Remove(Session.Accounts.Single(x => x.Acc_No == e.Entity.Acc_No));
                }
            }));
        }


        public static SqlTableDependency<tbl_Currency> Currencies;

        public static void Currencies_Changed(object sender, RecordChangedEventArgs<tbl_Currency> e)
        {

            Application.OpenForms[0].Invoke(new Action(() =>
            {
                if (e.ChangeType == ChangeType.Insert)
                {
                    Session.Currencies.Add(e.Entity);
                }
                else if (e.ChangeType == ChangeType.Update)
                {
                    var index = Session.Currencies.IndexOf(Session.Currencies.Single(x => x.Curr_No == e.Entity.Curr_No));
                    Session.Currencies.Remove(Session.Currencies.Single(x => x.Curr_No == e.Entity.Curr_No));
                    Session.Currencies.Insert(index, e.Entity);
                }
                else if (e.ChangeType == ChangeType.Delete)
                {
                    Session.Currencies.Remove(Session.Currencies.Single(x => x.Curr_No == e.Entity.Curr_No));
                }
            }));
        }
            
        
        public static SqlTableDependency<tbl_Journal_Header> Journal;

        public static void Journal_Changed(object sender, RecordChangedEventArgs<tbl_Journal_Header> e)
        {

            Application.OpenForms[0].Invoke(new Action(() =>
            {
                if (e.ChangeType == ChangeType.Insert)
                {
                    Session.Journal.Add(e.Entity);
                }
                else if (e.ChangeType == ChangeType.Update)
                {
                    var index = Session.Journal.IndexOf(Session.Journal.Single(x => x.J_No == e.Entity.J_No));
                    Session.Journal.Remove(Session.Journal.Single(x => x.J_No == e.Entity.J_No));
                    Session.Journal.Insert(index, e.Entity);
                }
                else if (e.ChangeType == ChangeType.Delete)
                {
                    Session.Journal.Remove(Session.Journal.Single(x => x.J_No == e.Entity.J_No));
                }
            }));
        }
        public static SqlTableDependency<tbl_Journal_Details> Journal_Details;
          public static void Journal_Details_Changed(object sender, RecordChangedEventArgs<tbl_Journal_Details> e)
        {

            Application.OpenForms[0].Invoke(new Action(() =>
            {
                if (e.ChangeType == ChangeType.Insert)
                {
                    Session.Journal_Details.Add(e.Entity);
                }
                else if (e.ChangeType == ChangeType.Update)
                {
                    var index = Session.Journal_Details.IndexOf(Session.Journal_Details.Single(x => x.C_ID == e.Entity.C_ID));
                    Session.Journal_Details.Remove(Session.Journal_Details.Single(x => x.C_ID == e.Entity.C_ID));
                    Session.Journal_Details.Insert(index, e.Entity);
                }
                else if (e.ChangeType == ChangeType.Delete)
                {
                    Session.Journal_Details.Remove(Session.Journal_Details.Single(x => x.C_ID == e.Entity.C_ID));
                }
            }));
        }

         
        public static SqlTableDependency<tbl_Person_tbl_Customer> Customers;

        public static void Customers_Changed(object sender, RecordChangedEventArgs<tbl_Person_tbl_Customer> e)
        {

            Application.OpenForms[0].Invoke(new Action(() =>
            {
                if (e.ChangeType == ChangeType.Insert)
                {
                    Session.Customers.Add(e.Entity);
                }
                else if (e.ChangeType == ChangeType.Update)
                {
                    var index = Session.Customers.IndexOf(Session.Customers.Single(x => x.Person_No == e.Entity.Person_No));
                    Session.Customers.Remove(Session.Customers.Single(x => x.Person_No == e.Entity.Person_No));
                    Session.Customers.Insert(index, e.Entity);
                }
                else if (e.ChangeType == ChangeType.Delete)
                {
                    Session.Customers.Remove(Session.Customers.Single(x => x.Person_No == e.Entity.Person_No));
                }
            }));
        }


        public static SqlTableDependency<tbl_Person_tbl_Vender> Venders;

        public static void Venders_Changed(object sender, RecordChangedEventArgs<tbl_Person_tbl_Vender> e)
        {

            Application.OpenForms[0].Invoke(new Action(() =>
            {
                if (e.ChangeType == ChangeType.Insert)
                {
                    Session.Venders.Add(e.Entity);
                }
                else if (e.ChangeType == ChangeType.Update)
                {
                    var index = Session.Venders.IndexOf(Session.Venders.Single(x => x.Person_No == e.Entity.Person_No));
                    Session.Venders.Remove(Session.Venders.Single(x => x.Person_No == e.Entity.Person_No));
                    Session.Venders.Insert(index, e.Entity);
                }
                else if (e.ChangeType == ChangeType.Delete)
                {
                    Session.Venders.Remove(Session.Venders.Single(x => x.Person_No == e.Entity.Person_No));
                }
            }));
        }

        public static SqlTableDependency<tbl_Accounts_Groups> Accounts_Groups;

        public static void Accounts_Groups_Changed(object sender, RecordChangedEventArgs<tbl_Accounts_Groups> e)
        {

            Application.OpenForms[0].Invoke(new Action(() =>
            {
                if (e.ChangeType == ChangeType.Insert)
                {
                    Session.Accounts_Groups.Add(e.Entity);
                }
                else if (e.ChangeType == ChangeType.Update)
                {
                    var index = Session.Accounts_Groups.IndexOf(Session.Accounts_Groups.Single(x => x.Acc_Group_No == e.Entity.Acc_Group_No));
                    Session.Accounts_Groups.Remove(Session.Accounts_Groups.Single(x => x.Acc_Group_No == e.Entity.Acc_Group_No));
                    Session.Accounts_Groups.Insert(index, e.Entity);
                }
                else if (e.ChangeType == ChangeType.Delete)
                {
                    Session.Accounts_Groups.Remove(Session.Accounts_Groups.Single(x => x.Acc_Group_No == e.Entity.Acc_Group_No));
                }
            }));
        }


    }
}
