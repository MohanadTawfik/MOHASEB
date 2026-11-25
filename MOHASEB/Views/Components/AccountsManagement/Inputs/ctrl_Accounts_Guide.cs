using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using MOHASEB.Model;
using MOHASEB.Views.PublicCompounent;
using System.Data.Entity.Migrations;
using DevExpress.XtraRichEdit.Model;
using MOHASEB.Views.Components.AccountsManagement.SysInitial;
using System.Security.AccessControl;
using DevExpress.Utils.MVVM;
using MOHASEB.Views.GUIs.AccountsManagement;
using DevExpress.XtraRichEdit.Fields;
using System.Security.Principal;
using MOHASEB.Views.GUIs.Main;
using MOHASEB.Views.Components.SystemManagement.SysInitial;
using MOHASEB.Classes;
using Guna.UI2.HtmlRenderer.Core.Entities;
using DevExpress.CodeParser;
using DevExpress.XtraTreeList;
using Bunifu.Framework.UI;
using DevExpress.Utils.Extensions;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data.Helpers;
using DevExpress.Mvvm.Native;
using System.Security.Policy;

namespace MOHASEB.Views.Components.AccountsManagement.Inputs
{
    public partial class ctrl_Accounts_Guide : Control_Master
    {
        tbl_Account account;
        bool row_update = false;

        EntityOperation.Operation operation ;

        bool is_curr_enable = true;
        List<tbl_Journal_Details> Journal_Details;

        public ctrl_Accounts_Guide()
        {
            InitializeComponent();

            Session.Accounts.ListChanged += Accounts_ListChanged;
            Session.Journal.ListChanged += Journal_ListChanged;
            Session.Currencies.ListChanged += Currencies_ListChanged;
            Session.Accounts_Groups.ListChanged += Accounts_Groups_ListChanged;
            Session.Journal_Details.ListChanged += Journal_Details_ListChanged;
            operation = EntityOperation.Operation.Nothing;

            RefreshData();
        }

        private void Journal_Details_ListChanged(object sender, ListChangedEventArgs e)
        {
            RefreshData();
        }

        #region Ovveride
        public override void RefreshData()
        {
            base.RefreshData();

            row_update = false;
            operation = EntityOperation.Operation.Nothing;

            treeList1.DataSource = Session.Accounts;
            treeList1.ExpandAll();

            txt_acc_parent.InitializeData(Session.Accounts.Where(x => x.Acc_Type == 1));

            cmb_acc_group.InitializeData(Session.Accounts_Groups);
            cmb_acc_type.InitializeData(Master.Account_Type, "NAME", "ID");
            cmb_acc_releted.InitializeData(Master.Acc_Related, "NAME", "ID");
            cmb_acc_report.InitializeData(Master.Account_Report, "NAME", "ID");

            var currencies = Session.Currencies.Where(x => x.Is_Stop == false);
            if (currencies == null)
            {
                is_curr_enable = false;
                new frm_Notification().ShowAlert("يرجى ادخال عملة واحدة على الأقل للنظام", frm_Notification.AlertType.Warning);
                frm_Main.Accounts_Managment.pages1.AddPage("العملات", new ctrl_Currencies());
            }
            else
            cmb_currency.InitializeData(currencies);

            Journal_Details = new List<tbl_Journal_Details>();
            Journal_Details = Session.Journal_Details.ToList();
            tbl_Journal_DetailsBindingSource.DataSource = new List<tbl_Journal_Details>();


        }

        public override bool IsValidData()
        {
            bool isvalid = false;
            if (operation != EntityOperation.Operation.Delete)
            {
                foreach (var item in layoutControl3.Controls)
                {
                    if (item != txt_acc_en_name
                        && item != cmb_acc_group
                        && item != btn_from_excel
                        && item != txt_max_limit
                        && item != txt_min_limit
                        && item != txt_degit_no
                        && item != txt_stop_date
                        && item != txt_stop_reson
                        && item is TextEdit)
                    {
                        isvalid = (item as TextEdit).ValidatingData();
                    }
                }

                if (Convert.ToInt32(cmb_acc_type.EditValue) == 1 && txt_degit_no.EditValue == null)
                {
                    isvalid = false;
                    txt_degit_no.ErrorText = "حدد عدد الخانات التي يقبلها هذا الحساب من الحسابات الفرعية";
                }


                if (isvalid == false)
                    return false;
                else
                    return base.IsValidData();
            }
            else
            {
                if (txt_acc_no.ValidatingData()) 
                    return base.IsValidData();
                else
                     return false;
            }
        }

        public override async void Save()
        {

            SetData();

            if (operation == EntityOperation.Operation.Delete)
            {
                if (account.tbl_Journal_Details.Count > 0)
                {
                    new frm_Notification().ShowAlert("عذراَ .. هذا الحساب تم استخدامة في قيد محاسبي ولا يمكن حذفه", frm_Notification.AlertType.Warning);
                    return;
                }
            }

           await EntityOperation.SqlOperationAsync<tbl_Account>(account, operation);

            base.Save();
        }

        public override void New()
        {
            operation = EntityOperation.Operation.Add;
            int account_id = Session.Accounts.Select(x => x.C_ID).MaxOrDefault() + 1;

            account = new tbl_Account()
            {
                C_ID = account_id,
                Acc_Parent_No = 0,
                Acc_Type = 1,
                Acc_Degit_No= 1,
                Acc_Report = 1,
                Acc_Level= 1,
                Acc_Related= 1,
                Is_Stop = false,
            };

            base.New();

            txt_acc_parent.Focus();
        }

        public override void Edit()
        {
            if (account == null)
            {
                new frm_Notification().ShowAlert("لا بيانات لتعديلها", frm_Notification.AlertType.Error);
                return;
            }

            base.Edit();
            operation = EntityOperation.Operation.Update;
            EnableFields(true);
        }

        public override void GetData()
        {
            txt_acc_no.EditValue = account.Acc_No.ToString();
            txt_acc_parent.EditValue = account.Acc_Parent_No;
            txt_acc_name.EditValue = account.Acc_ArName;
            txt_acc_en_name.EditValue = account.Acc_EnName;
            txt_acc_level.EditValue = account.Acc_Level.ToString();
            cmb_acc_type.EditValue = account.Acc_Type;
            cmb_acc_report.EditValue = account.Acc_Report;
            cmb_acc_group.EditValue = account.Account_Group;
            cmb_acc_releted.EditValue = account.Acc_Related;
            txt_degit_no.EditValue = account.Acc_Degit_No.ToString();
            chk_is_stop.Checked = Convert.ToBoolean(account.Is_Stop);
            txt_stop_date.DateTime = Convert.ToDateTime(account.Stop_Date);
            txt_stop_reson.EditValue = account.Stop_Reson;
            cmb_currency.EditValue = account.Curr_No;
            txt_max_limit.EditValue = account.Max_Limit;
            txt_min_limit.EditValue = account.Min_Limit;


            var list_journal = Journal_Details.Where(y => y.Acc_No == account.C_ID);


            if (list_journal != null)
            {
                decimal total_debit = 0;
                decimal total_credit = 0;

                foreach (var item in list_journal)
                {
                    total_credit += Convert.ToDecimal(item.Credit_Amount);
                    total_debit += Convert.ToDecimal(item.Debit_Amount);
                }

                // الرصيد الإفتتاحي
                var initial = list_journal.FirstOrDefault(y => y.tbl_Journal_Header.Is_Initial_Balance == true);
                decimal result = 0;


                if (initial != null)
                {
                    result = Convert.ToDecimal(initial.Debit_Amount) + Convert.ToDecimal(initial.Credit_Amount);
                    txt_initial_balance.Text = result.ToString();
                }

                // رصيد الحركة
                var total = total_debit - total_credit - result;
                txt_move_balance.Text = (total).ToString();

                // الرصيد الحالي
                txt_current_balance.Text = (result + total).ToString();
            }


            tbl_Journal_DetailsBindingSource.DataSource = list_journal.Where(x => x.tbl_Journal_Header.Is_Initial_Balance == false);


            base.GetData();

        }

        public override void SetData()
        {
            account.Acc_No = Convert.ToInt32(txt_acc_no.Text);
            account.Acc_Parent_No = Convert.ToInt32(txt_acc_parent.EditValue);
            account.Acc_ArName = txt_acc_name.Text;
            account.Acc_EnName = txt_acc_en_name.Text;
            account.Acc_Level = Convert.ToInt32(txt_acc_level.Text);
            account.Acc_Type = Convert.ToInt32(cmb_acc_type.EditValue);
            account.Acc_Report = Convert.ToInt32(cmb_acc_report.EditValue);
            account.Acc_Related = Convert.ToInt32(cmb_acc_releted.EditValue);

            if (cmb_acc_group.EditValue != null)
            {
                account.Account_Group = Convert.ToInt32(cmb_acc_group.EditValue);
            }
            account.Curr_No = Convert.ToInt32(cmb_currency.EditValue);
            account.Max_Limit = Convert.ToDecimal( txt_max_limit.EditValue);
            account.Min_Limit = Convert.ToDecimal( txt_min_limit.EditValue);

            if (chk_is_stop.Checked)
            {
                account.Is_Stop = chk_is_stop.Checked;
                account.Stop_Date = txt_stop_date.DateTime;
                account.Stop_Reson = txt_stop_reson.Text.ToString();
            }
            account.Acc_Degit_No = (Convert.ToInt32(cmb_acc_type.EditValue) == 1) ? Convert.ToInt32(txt_degit_no.EditValue) : 0;

            base.SetData();

        }

        public override void Delete()
        {
            if (account == null)
            {
                new frm_Notification().ShowAlert("لا بيانات لحذفها", frm_Notification.AlertType.Error);
                return;
            }
            operation = EntityOperation.Operation.Delete;
            base.Delete();
        }

        public override void Return()
        {
            if (MessageBox.Show("هل تريد التراجع؟ سيتم التغير في القيم الحالية", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                operation = EntityOperation.Operation.Nothing;
                base.Return();
            }
        }

        public override void EnableFields(bool enable)
        {
            // Enable Texts Boxes
            layoutControl3.EnableLayoutFeilds(enable);
            if (is_curr_enable == false) cmb_currency.Enabled = false;
            txt_acc_level.Enabled = false;
            txt_acc_no.Enabled = false;
            base.EnableFields(enable);
        }

        public override void ClearFields(bool enable)
        {
            layoutControl3.ClearLayoutFeilds();
            txt_acc_parent.Clear();
            cmb_acc_group.Clear();
            cmb_acc_releted.Clear();
            cmb_acc_report.Clear();
            cmb_currency.Clear();
            cmb_acc_type.Clear();
            txt_degit_no.Clear();
            base.ClearFields(enable);
        }

        #endregion


        #region Events

        private void Journal_ListChanged(object sender, ListChangedEventArgs e)
        {
            RefreshData();
        }
        private void Accounts_ListChanged(object sender, ListChangedEventArgs e)
        {
            RefreshData();
        }
        private void Currencies_ListChanged(object sender, ListChangedEventArgs e)
        {
            RefreshData();
        }
        private void Accounts_Groups_ListChanged(object sender, ListChangedEventArgs e)
        {
            RefreshData();
        }
       
        private void treeList1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void cmb_acc_type_EditValueChanged(object sender, EventArgs e)
        {
            if (cmb_acc_type.EditValue != null && Convert.ToInt32(cmb_acc_type.EditValue) == 1) // حساب رئيسي
            {
                layout_degit_no.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                txt_degit_no.EditValue = account.Acc_Degit_No;
            }
            else if (cmb_acc_type.EditValue != null && Convert.ToInt32(cmb_acc_type.EditValue) == 2)
            {
                cmb_currency.Clear();

                txt_degit_no.EditValue = null;
                layout_degit_no.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }

        }

        private void chk_is_stop_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_is_stop.Checked == true)
            {
                layout_stop_date.Visibility = layout_stop_reson.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                txt_stop_date.DateTime = DateTime.Now;
                txt_stop_date.Enabled = false;
            }
            else
            {
                layout_stop_date.Visibility = layout_stop_reson.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void txt_acc_parent_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_acc_parent.EditValue != null && txt_acc_parent.EditValue.ToString() != string.Empty)
            {
                // level
                var level = Session.Accounts
                    .FirstOrDefault(acc => acc.Acc_No == Convert.ToInt32(txt_acc_parent.EditValue));

                if (level != null)
                {
                    txt_acc_level.EditValue = level.Acc_Level + 1;
                    cmb_acc_report.EditValue = level.Acc_Report;
                }


                // account_no

                if (operation == EntityOperation.Operation.Add)
                {

                    // لا يوجد اي حساب رئيسي
                    // => الحساب الاب صفر

                    int child_no = Session.Accounts
                        .Where(acc => acc.Acc_Parent_No == Convert.ToInt32(txt_acc_parent.EditValue))
                        .Select(x => x.Acc_No).MaxOrDefault();

                    if (Convert.ToInt32(txt_acc_parent.EditValue) == 0)
                    {
                        txt_acc_no.EditValue = child_no + 1;
                    }

                    // يوجد حساب رئيسي ليس لديه ابناء
                    // => اول حساب فرعي يكون رقم حسابه = Acc_Parent_No + (Acc_Degit-1)*0 + 1
                    // acc_no == 0
                    else if (child_no == 0)
                    {
                        var parent_degit = Session.Accounts
                     .FirstOrDefault(x => x.Acc_No == Convert.ToInt32(txt_acc_parent.EditValue))
                     .Acc_Degit_No.ToString();

                        string parent_no = txt_acc_parent.EditValue.ToString();
                        for (int i = 0; i < Convert.ToInt32(parent_degit) - 1; i++)
                        {
                            parent_no += "0";
                        }
                        parent_no += "1";

                        txt_acc_no.EditValue = parent_no;
                    }

                    // يوجد حساب رئيسي لديه ابناء
                    // => الحساب الفرعي رقمه = اخر حساب فرعي + 1
                    // acc_no != 0
                    else if (child_no != 0)
                    {

                        var parent_degit = Session.Accounts
                       .FirstOrDefault(x => x.Acc_No == Convert.ToInt32(txt_acc_parent.EditValue))
                       .Acc_Degit_No.ToString();

                        string parent_no = txt_acc_parent.EditValue.ToString();

                        string max_no = "";
                        for (int i = 0; i < Convert.ToInt32(parent_degit); i++)
                        {
                            max_no += "9";
                        }

                        var max_child = parent_no + max_no;


                        if (Convert.ToInt32(child_no) <= Convert.ToInt32(max_child))
                        {

                            txt_acc_no.EditValue = Convert.ToInt32(child_no) + 1;
                        }
                    }
                }
            }
        }

        private void txt_degit_no_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_degit_no.EditValue) != 0 
                && txt_acc_no.EditValue.ToString() != string.Empty
                && Convert.ToInt32(cmb_acc_type.EditValue) == 1)
            {
                if (account.Acc_Degit_No == Convert.ToInt32(txt_degit_no.EditValue)) return;

                 var child_accounts = Session.Accounts.Where(x => x.Acc_Parent_No == account.Acc_No).ToList();
                string parent_no = account.Acc_No.ToString();

                if (account.Acc_Degit_No < Convert.ToInt32(txt_degit_no.EditValue))  // old less than new
                {
                    var zero = "";
                    for (int i = Convert.ToInt32(account.Acc_Degit_No); i < Convert.ToInt32(txt_degit_no.EditValue); i++)
                    {
                        zero += "0";
                    }
               
                    foreach (var item in child_accounts)
                    {
                        var new_acc = item.Acc_No.ToString().Insert(parent_no.Length, zero);
                        item.Acc_No = Convert.ToInt32(new_acc);
                    }

                }

                #region TODO
                ///
                //else if(account.Acc_Degit_No > Convert.ToInt32(txt_degit_no.EditValue))  // new less than old
                //{
                //    int child_no_max = child_accounts.Select(x => x.Acc_No).MaxOrDefault();

                //    string max_no = "";
                //    for (int i = 0; i < Convert.ToInt32(txt_degit_no.EditValue); i++)
                //    {
                //        max_no += "9";
                //    }

                //    var max_child = parent_no + max_no;



                //    if (Convert.ToInt32(child_no_max) <= Convert.ToInt32(max_child))
                //    {

                //        var zero = 0;
                //        for (int i = Convert.ToInt32(txt_degit_no.EditValue); i < Convert.ToInt32(account.Acc_Degit_No); i++)
                //        {
                //            zero += 1;
                //        }

                //        foreach (var item in child_accounts)
                //        {
                //            var new_acc = item.Acc_No.ToString().Remove(parent_no.Length, zero);
                //            item.Acc_No = Convert.ToInt32(new_acc);
                //        }
                //    }
                //}
                #endregion
            }
        }

        private void cmb_currency_EditValueChanged(object sender, EventArgs e)
        {
            if (cmb_currency.EditValue != null && Convert.ToInt32(cmb_currency.EditValue) != 0)
            {
                layout_max_limit.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layout_min_limit.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                layout_max_limit.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layout_min_limit.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            row_update = true;
        }



        #endregion

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.ImageIndex = -1;
            }
        }

        private void treeList1_RowClick(object sender, RowClickEventArgs e)
        {
            if (operation != EntityOperation.Operation.Nothing)
            {
                new frm_Notification().ShowAlert("للتعديل .. يرجى التراجع عن العملية السابقة", frm_Notification.AlertType.Warning);
                return;
            }
            else
            {
                account = treeList1.GetFocusedRow() as tbl_Account;
                GetData();
            }
        }
    }
}
