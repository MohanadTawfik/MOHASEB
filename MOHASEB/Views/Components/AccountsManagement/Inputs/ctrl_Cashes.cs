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
using MOHASEB.Classes;
using MOHASEB.Views.Components.SystemManagement.SysInitial;
using MOHASEB.Views.GUIs.Main;
using DevExpress.XtraEditors.Filtering.Templates;
using Guna.UI2.HtmlRenderer.Core.Entities;
using DevExpress.Mvvm.Native;
using DevExpress.XtraRichEdit.Model;
using DevExpress.Utils.Extensions;
using System.Security.Principal;
using DevExpress.DataAccess.Sql.DataApi;
using DevExpress.ExpressApp;
using DevExpress.Utils.Gesture;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace MOHASEB.Views.Components.AccountsManagement.Inputs
{
    public partial class ctrl_Cashes : Control_Master
    { 
        tbl_Cash cash;
        EntityOperation.Operation operation ;
        List<tbl_Journal_Details> Journal_Details;

        public ctrl_Cashes()
        {
            InitializeComponent();

            Session.Accounts.ListChanged += Accounts_ListChanged;
            Session.Journal_Details.ListChanged += Journal_Details_ListChanged;

            RefreshData();

        }

        private void Journal_Details_ListChanged(object sender, ListChangedEventArgs e)
        {
            RefreshData();
        }

        private void Accounts_ListChanged(object sender, ListChangedEventArgs e)
        {
            RefreshData();
        }

      

        // load data 
        public override void RefreshData()
        {
            base.RefreshData();

          
            operation = EntityOperation.Operation.Nothing;

            tbl_AccountBindingSource.DataSource = new List<tbl_Account>();

            var repoaccounts = Session.Accounts.Where(x => x.Acc_Related == 2 && x.Is_Stop == false).ToList();

            if (repoaccounts.Count > 0)
                repo_accounts.DataSource = repoaccounts;
            else
            {
                frm_Main.Accounts_Managment.pages1.AddPage("الدليل المحاسبي", new ctrl_Accounts_Guide());
                new frm_Notification().ShowAlert("لا يوجد اي حسابات تنتمي لمجموعة الصناديق", frm_Notification.AlertType.Error);
            }

            txt_userno.InitializeData(Session.DB.tbl_User.ToList());

            Journal_Details = new List<tbl_Journal_Details>();
            Journal_Details = Session.Journal_Details.ToList();
            tbl_Journal_DetailsBindingSource.DataSource = new List<tbl_Journal_Details>();

        }

        public override void GetData()
        {
            txt_cash_no.EditValue = cash.Cash_No.ToString();
            txt_cash_name.EditValue = cash.C_ArName;
            txt_cash_en_name.EditValue = cash.C_EnName;
            chk_is_stop.EditValue = cash.Is_Stop;

            if (cash.Is_Stop == true)
            {
                txt_stop_date.DateTime = Convert.ToDateTime( cash.Stope_date);
                txt_stop_reson.Text = cash.Stope_Cause;
            }
            
            chk_is_sale_point.EditValue = cash.Is_Sale_Point;
            if (cash.Is_Sale_Point == true)
            {
                txt_userno.EditValue = cash.User_No;
            }

            tbl_AccountBindingSource.DataSource = cash.tbl_Account;

            if (cash.tbl_Account.Count > 0)
            {
                var list_journal = Journal_Details
               .Where(y => cash.tbl_Account.Contains(y.tbl_Account)).ToList();


                if (list_journal != null)
                {
                    decimal total_debit = 0;
                    decimal total_credit = 0;

                    foreach (var item in list_journal)
                    {
                        total_credit += Convert.ToDecimal(item.Credit_Amount);
                        total_debit += Convert.ToDecimal(item.Debit_Amount);
                    }

                 
                    var initial = list_journal.Where(y => y.tbl_Journal_Header.Is_Initial_Balance == true);
                    decimal result = 0;


                    if (initial != null)
                    {
                        foreach (var item in initial)
                        {
                            result += Convert.ToDecimal(item.Debit_Amount) + Convert.ToDecimal(item.Credit_Amount);
                        }
                        // الرصيد الإفتتاحي
                        txt_initial_balance.Text = result.ToString();
                    }

                    // رصيد الحركة
                    var total = total_debit - total_credit - result;
                    txt_move_balance.Text = (total).ToString();

                    // الرصيد الحالي
                    txt_current_balance.Text = (result + total).ToString();
                }

            tbl_Journal_DetailsBindingSource.DataSource = 
                    list_journal.Where(x => x.tbl_Journal_Header.Is_Initial_Balance == false);

            }





            base.GetData();
        }





        public override void EnableFields(bool enable)
        {
            layoutControl3.EnableLayoutFeilds(enable);
            gridControl1.Enabled = enable;
            base.EnableFields(enable);

            txt_cash_no.Enabled = true;
            txt_cash_name.Focus();
        }

        public override void ClearFields(bool enable)
        {
            layoutControl3.ClearLayoutFeilds();
            base.ClearFields(enable);
        }

        public override void New()
        {
            operation = EntityOperation.Operation.Add;
            var max_no = Session.DB.tbl_Cash.Select(x => x.Cash_No).MaxOrDefault() + 1;

            cash = new tbl_Cash()
            {
                Cash_No = max_no,
                Is_Sale_Point = false,
                Is_Stop = false,
                tbl_Account= new List<tbl_Account>(),
                
            };

            // focus 1st text box
            txt_cash_name.Focus();

            base.New();

        }

        public override void Save()
        {
            SetData();

            if (operation == EntityOperation.Operation.Delete)
            {
                foreach (var item in cash.tbl_Account)
                {
                    if (item.tbl_Journal_Details.Count > 0)
                    {
                        new frm_Notification().ShowAlert("عذراَ .. هذا الصندوق تم استخدامة في قيد محاسبي ولا يمكن حذفه", frm_Notification.AlertType.Warning);
                        return;
                    }
                }
            }

            EntityOperation.SqlOperationAsync<tbl_Cash>(cash, operation);
            base.Save();
        }


        public override bool IsValidData()
        {
            bool isvalid = false;
            // Enable Texts Boxes
            foreach (var item in layoutControl3.Controls)
            {
                if (item != txt_stop_date
                    && item != txt_stop_reson
                    && item != txt_userno
                    && item != txt_cash_en_name
                    && item != chk_is_stop
                    && item != chk_is_sale_point
                    && item is TextEdit
                    )
                {
                    isvalid = (item as TextEdit).ValidatingData();
                }
            }


            if (chk_is_sale_point.Checked
                && txt_userno.EditValue != null
                && Convert.ToInt32(txt_userno.EditValue) <= 0)
            {
                txt_userno.ErrorText = "يجب تحديد المستخدم لنقطة البيع";
                isvalid = false;
            }

            if (isvalid == false)
                return false;
            else
                return base.IsValidData();
        }

        public override void SetData()
        {
            cash.Cash_No = int.Parse(txt_cash_no.Text);
            cash.C_ArName = txt_cash_name.Text;
            cash.C_EnName = txt_cash_en_name.Text;
            cash.Is_Stop = chk_is_stop.Checked;
            cash.Is_Sale_Point = chk_is_sale_point.Checked;

            // صندوق نقطة بيع
            if (chk_is_sale_point.Checked == true)
            {
                cash.User_No = int.Parse(txt_userno.Text);
            }

            // صندوق موقف
            if (chk_is_stop.Checked == true)
            {
                cash.Stope_date = txt_stop_date.DateTime;
                cash.Stope_Cause = txt_stop_reson.Text;
            }

            cash.tbl_Account = (ICollection<tbl_Account>)tbl_AccountBindingSource.DataSource;

            base.SetData();
        }


        public override void Edit()
        {
            operation = EntityOperation.Operation.Update;
            EnableFields(true);
            base.Edit();
        }

        public override void Return()
        {
            if (MessageBox.Show("هل تريد التراجع؟ سيتم فقد القيم الحالية", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                operation = EntityOperation.Operation.Nothing;
                base.Return();
            }
        }

        public override void Delete()
        {
            operation = EntityOperation.Operation.Delete;
            base.Delete();
        }

        private void txt_cash_no_Validating(object sender, CancelEventArgs e)
        {
            if (txt_cash_no.Text != null && !string.IsNullOrWhiteSpace(txt_cash_no.Text))
            {
                var result = Session.DB.tbl_Cash.Where(x => x.Cash_No.ToString() == txt_cash_no.Text).FirstOrDefault();
                if (result != null)
                {
                    if (operation == EntityOperation.Operation.Add)
                    {
                        new frm_Notification().ShowAlert($"يوجد بالفعل صندوق يحمل الرقم {txt_cash_no.Text}...", frm_Notification.AlertType.Error);
                        txt_cash_no.Focus();
                        return;
                    }
                    else
                    {
                        cash = result;
                        GetData();
                    }
                }
            }
        }

        private void chk_is_sale_point_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_is_sale_point.Checked == true)
            {
                layout_userno.Visibility  = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                layout_userno.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void chk_is_stop_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_is_stop.Checked == true)
            {
                layout_stop_date.Visibility = layout_stop_reson.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                txt_stop_date.DateTime = DateTime.Now;
            }
            else
            {
                layout_stop_date.Visibility = layout_stop_reson.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }


        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var row = gridView1.GetRow(e.RowHandle) as tbl_Account;
            if (row == null || row.Acc_No == 0) return;

            if (e.Column.FieldName == "Acc_No")
            {
                var account = Session.Accounts.FirstOrDefault(x => x.Acc_No == row.Acc_No);
                if (account.tbl_CashCash_No == null)
                {
                    if (!tbl_AccountBindingSource.Contains(account))
                    {
                        gridView1.DeleteRow(e.RowHandle);
                        tbl_AccountBindingSource.Add(account);

                        var relation = (List<tbl_Journal_Details>)tbl_Journal_DetailsBindingSource.DataSource;

                        var acc_relatian = Session.Journal_Details.FirstOrDefault(y => y.Acc_No == account.C_ID);
                        relation.Add(acc_relatian);

                        tbl_Journal_DetailsBindingSource.DataSource = relation;
                    }
                    else
                    {
                        new frm_Notification().ShowAlert("هذا الحساب موجود .. إختر حساب آخر", frm_Notification.AlertType.Warning);
                        gridView1.DeleteRow(e.RowHandle);
                    }
                }
                else
                {
                    new frm_Notification().ShowAlert("هذا الحساب مرتبط مع صندوق آخر ", frm_Notification.AlertType.Warning);
                    gridView1.DeleteRow(e.RowHandle);
                }
            }
        }


        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var row = e.Row as tbl_Account;
            if (e.Row == null || row.Acc_No == 0)
            {
                e.Valid = false;
            }
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (e.Row == null || (e.Row as tbl_Account).Acc_No == 0)
            {
                gridView1.DeleteRow(e.RowHandle);
            }
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore;
        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            GridControl control = sender as GridControl;
            if (control == null) return;
            GridView view = control.FocusedView as GridView;
            if (view == null) return;
            if (view.FocusedColumn == null) return;
            if (e.KeyCode == Keys.Return)
            {
                if (view.FocusedColumn.FieldName == "Acc_No")
                {
                    if (view.FocusedRowHandle < 0)
                    {
                        gridControl1_ProcessGridKey(sender,new  KeyEventArgs(Keys.Down));
                    }
                }
            }
        }


        private void gridView2_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            //if (e.Item == null) return;

            //int summary_id = Convert.ToInt32((e.Item as GridSummaryItem).Tag);

            //if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            //{
            //    switch (summary_id)
            //    {
            //        case 1: // total_debit
            //            total_debit = 0;
            //            break;
            //        case 2: // total_credit
            //            total_credit = 0;
            //            break;
            //    }
            //}

            //if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            //{
            //    switch (summary_id)
            //    {
            //        case 1: // total_debit
            //            total_debit += Convert.ToDecimal(e.FieldValue);
            //            break;
            //        case 2: // total_credit
            //            total_credit += Convert.ToDecimal(e.FieldValue);
            //            break;
            //    }
            //}

            //if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            //{
            //    switch (summary_id)
            //    {
            //        case 1:
            //            e.TotalValue = total_debit;
            //            break;
            //        case 2:
            //            //txt_move_balance.Text = total_credit.ToString("N");
            //            e.TotalValue = total_credit;
            //            break;
            //        default:
            //            break;
            //    }
            //}
        }

        private void txt_total_debit_credit_EditValueChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_move_balance.Text) && string.IsNullOrEmpty(txt_total_debit.Text)) return;
            //GetTotalDeff();
        }

        void GetTotalDeff()
        {
            //if (!string.IsNullOrEmpty(txt_move_balance.Text) && !string.IsNullOrEmpty(txt_total_debit.Text))
            //{
            //    txt_initial_balance.Text = (Convert.ToDecimal(txt_total_debit.Text) - Convert.ToDecimal(txt_move_balance.Text)).ToString();
            //    if (Convert.ToDouble(txt_initial_balance.Text) == 0)
            //    {
            //        txt_initial_balance.Properties.Appearance.ForeColor = Color.RoyalBlue;
            //        txt_initial_balance.Properties.AppearanceDisabled.ForeColor = Color.RoyalBlue;
            //        txt_initial_balance.Properties.AppearanceFocused.ForeColor = Color.RoyalBlue;
            //        txt_initial_balance.Properties.AppearanceReadOnly.ForeColor = Color.RoyalBlue;
            //    }
            //    else
            //    {
            //        txt_initial_balance.Properties.Appearance.ForeColor = Color.LightCoral;
            //        txt_initial_balance.Properties.AppearanceDisabled.ForeColor = Color.LightCoral;
            //        txt_initial_balance.Properties.AppearanceFocused.ForeColor = Color.LightCoral;
            //        txt_initial_balance.Properties.AppearanceReadOnly.ForeColor = Color.LightCoral;
            //    }
            //}
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //GridView view = sender as GridView;
            //if (e.Column.FieldName == "Credit_Amount_F")
            //{
            //    var value = e.Value;
            //    if (value != null)
            //    {
            //        //var currency = view.GetRow(e.RowHandle) as tbl_Relation_Accounts_Periods;

            //        //decimal price = Convert.ToDecimal(currency.tbl_Account.tbl_Currency.Curr_Exchange);
            //        //decimal Credit_Amount = Convert.ToDecimal(e.Value) * price;
            //        //view.SetRowCellValue(e.RowHandle, view.Columns["Credit_Amount"], Credit_Amount);
            //    }
            //}
            //else if (e.Column.FieldName == "Debit_Amount_F")
            //{
            //    var value = e.Value;
            //    if (value != null)
            //    {
            //        //var currency = view.GetRow(e.RowHandle) as tbl_Relation_Accounts_Periods;

            //        //decimal price = Convert.ToDecimal(currency.tbl_Account.tbl_Currency.Curr_Exchange);
            //        //decimal Debit_Amount = Convert.ToDecimal(e.Value) * price;
            //        //view.SetRowCellValue(e.RowHandle, view.Columns["Debit_Amount"], Debit_Amount);
            //    }
            //}
            //else return;
        }

        private void gridView2_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.ImageIndex = -1;
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.ImageIndex = -1;
            }
        }
    }
}
