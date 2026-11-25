using DevExpress.XtraEditors;
using MOHASEB.Model;
using MOHASEB.Views.PublicCompounent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq.Helpers;
using MOHASEB.Classes;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.ExpressApp;
using DevExpress.Utils;
using DevExpress.XtraRichEdit.Model;
using DevExpress.Utils.Extensions;
using System.Security.AccessControl;
using System.Security.Principal;
using DevExpress.XtraEditors.Repository;
using DevExpress.Mvvm.Xpf;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using System.Collections.ObjectModel;
using DevExpress.Utils.Gesture;

namespace MOHASEB.Views.Components.AccountsManagement.Operations
{
    public partial class ctrl_Journals : Control_Master
    {
        private tbl_Journal_Header Journal;
        private List<tbl_Journal_Header> Journal_list;
        private tbl_Journal_Details details_instance;
        private List<tbl_Journal_Details> Journal_Details;

        private decimal total_credit;
        private decimal total_debit;


        EntityOperation.Operation operation;

        public ctrl_Journals()
        {
            InitializeComponent();

            Session.Accounts.ListChanged += Accounts_ListChanged;
            Session.Journal.ListChanged += Journal_ListChanged;
            Session.Journal_Details.ListChanged += Journal_Details_ListChanged;

            RefreshData();

            NoOperation();
            ClearFields(false);
        }




        #region Ovveride
        public override void RefreshData()
        {
            base.RefreshData();

            operation = EntityOperation.Operation.Nothing;

            Journal_Details = new List<tbl_Journal_Details>();
            Journal_Details = Session.Journal_Details.ToList();

            Journal_list = new List<tbl_Journal_Header>();
            Journal_list = Session.Journal.Where(x => x.Is_Initial_Balance == false).ToList();

            //if (Journal_list.Count() == 0)
            //{
            //    txt_j_no.Enabled = false;
            //}

            tbl_Journal_DetailsBindingSource.DataSource = new List<tbl_Journal_Details>();

            //txt_j_no.InitializeData(Journal_list);

            txt_rejournal_no.InitializeData(Journal_list.Where(x => x.Is_Periodic == true));


            repo_accounts.DataSource = Session.Accounts.Where(x => x.Acc_Type == 2).ToList();
        }


        public override void New()
        {
            operation = EntityOperation.Operation.Add;

            var journal_no = Journal_list.Select(x => x.J_No).MaxOrDefault() + 1;

            Journal = new tbl_Journal_Header()
            {
                J_No = journal_no,
                J_Date = DateTime.Now,
                J_Post = false,
                tbl_Journal_Details = new List<tbl_Journal_Details>(),
                Period_No = Session.Period.Year_No,
                tbl_Period_Master = Session.Period,
                Is_Initial_Balance = false,
                //User_Add= 
            };

            base.New();

            txt_total_balance.Focus();
            //txt_j_no.Enabled = false;
        }

        public override void Edit()
        {
            if (Journal == null)
            {
                new frm_Notification().ShowAlert("لا بيانات لتعديلها", frm_Notification.AlertType.Error);
                return;
            }
            else if (Journal.J_Post == true)
            {
                new frm_Notification().ShowAlert("لا يمكن تعديل القيد المرحل", frm_Notification.AlertType.Error);
                return;
            }

            operation = EntityOperation.Operation.Update;
            EnableFields(true);
            base.Edit();
        }

        public override void Delete()
        {
            if (Journal == null)
            {
                new frm_Notification().ShowAlert("لا بيانات لحذفها", frm_Notification.AlertType.Error);
                return;
            }
            else if (Journal.J_Post == true)
            {
                new frm_Notification().ShowAlert("لا يمكن حذف القيد المرحل", frm_Notification.AlertType.Error);
                return;
            }
            operation = EntityOperation.Operation.Delete;
            base.Delete();
            txt_j_no.Enabled = true;
        }

        public override void EnableFields(bool enable)
        {
            // Enable Texts Boxes
            layout_checkedits.EnableLayoutFeilds(enable);
            layout_periodic.EnableLayoutFeilds(enable);
            main_layout.EnableLayoutFeilds(enable);
            gridControl1.Enabled = enable;
            txt_j_date.Enabled = false;
            chk_is_post.Enabled = false;
            txt_j_no.Enabled = true;
            base.EnableFields(enable);
        }

        public override void ClearFields(bool enable)
        {
            main_layout.ClearLayoutFeilds();
            layout_periodic.ClearLayoutFeilds();
            layout_checkedits.ClearLayoutFeilds();
            grid_layout.ClearLayoutFeilds();
            base.ClearFields(enable);
        }

        public override void GetData()
        {
            txt_j_no.EditValue = Journal.J_No;
            txt_j_date.DateTime = Convert.ToDateTime(Journal.J_Date);
            chk_is_post.EditValue = Convert.ToBoolean(Journal.J_Post);
            txt_total_balance.Text = Journal.Total_Balance.ToString();
            txt_j_note.Text = Journal.J_Note;

            chk_is_reverse.EditValue = Convert.ToBoolean(Journal.Is_Reverce);
            chk_is_curr_diff.EditValue = Convert.ToBoolean(Journal.Is_Curr_Diff);
            chk_is_periodic.EditValue = Convert.ToBoolean(Journal.Is_Periodic);
            chk_is_wait.EditValue = Convert.ToBoolean(Journal.Is_Wait);

            txt_total_credit.Text = Journal.Total_Credit.ToString();
            txt_total_debit.Text = Journal.Total_Debit.ToString();

            tbl_Journal_DetailsBindingSource.DataSource = Journal.tbl_Journal_Details.ToList();

            calculate_differance();
            base.GetData();
        }

        public override void SetData()
        {
            Journal.J_No = Convert.ToInt32(txt_j_no.EditValue);
            Journal.J_Date = Convert.ToDateTime(txt_j_date.DateTime);

            Journal.Total_Balance = Convert.ToDecimal(txt_total_balance.Text);
            Journal.J_Note = txt_j_note.Text;
            Journal.J_Post = chk_is_post.Checked;
            Journal.Is_Reverce = chk_is_reverse.Checked;
            Journal.Is_Curr_Diff = chk_is_curr_diff.Checked;
            Journal.Is_Periodic = chk_is_periodic.Checked;
            Journal.Is_Wait = chk_is_wait.Checked;

            Journal.Total_Credit = Convert.ToDecimal(txt_total_credit.Text);
            Journal.Total_Debit = Convert.ToDecimal(txt_total_debit.Text);


            Journal.tbl_Journal_Details = tbl_Journal_DetailsBindingSource.DataSource as List<tbl_Journal_Details>;

            base.SetData();
        }

        public override bool IsValidData()
        {
            if (operation == EntityOperation.Operation.Delete)
            {
                return txt_j_no.ValidatingData();
            }
            else
            {

            bool isvalid = false;
                foreach (var item in main_layout.Controls)
                {
                    if (item is TextEdit)
                    {
                        isvalid = (item as TextEdit).ValidatingData();
                    }
                }

                if (gridView1.RowCount == 0)
                {
                    isvalid = false;
                    new frm_Notification().ShowAlert("الرجاء إدخال أطراف القيد المحاسبي", frm_Notification.AlertType.Error);
                }

                if (Convert.ToDecimal(txt_deff.Text) != 0)
                {
                    isvalid = false;
                    txt_deff.ErrorText = "القيد المحاسبي ليس متزناَ";
                    new frm_Notification().ShowAlert("القيد المحاسبي ليس متزناَ", frm_Notification.AlertType.Error);

                }

                if (Convert.ToDecimal(txt_total_credit.Text) != Convert.ToDecimal(txt_total_balance.Text)
                    || Convert.ToDecimal(txt_total_debit.Text) != Convert.ToDecimal(txt_total_balance.Text))
                {
                    isvalid = false;
                    txt_total_balance.ErrorText = "المبلغ لا يساوي مجموع المبلغ في أطراف القيد .. تأكد من المبالغ";
                    new frm_Notification().ShowAlert("المبلغ لا يساوي مجموع المبلغ في أطراف القيد .. تأكد من المبالغ", frm_Notification.AlertType.Error);
                }
            if (isvalid == false)
                return false;
            else
                return base.IsValidData();
            }

        }

        public override async void Save()
        {
            gridView1.UpdateCurrentRow();
            SetData();


            if (operation == EntityOperation.Operation.Delete)
            {

              await Task.Run(() => Session.DB.tbl_Journal_Details.RemoveRange(Journal.tbl_Journal_Details));
              await Session.DB.SaveChangesAsync();

            

            }
                // add, update or delete Journal Header
                await EntityOperation.SqlOperationAsync<tbl_Journal_Header>(Journal, operation);

            if (operation != EntityOperation.Operation.Delete)
            {

                var list = tbl_Journal_DetailsBindingSource.DataSource as List<tbl_Journal_Details>;

                foreach (var item in list)
                {
                    item.J_No = Journal.J_No;
                    item.tbl_Journal_Header = Journal;
                }


                foreach (var item in list)
                {
                    await Task.Run(() => Session.DB.tbl_Journal_Details.AddOrUpdate(item));
                }

                await Session.DB.SaveChangesAsync();
                //new frm_Notification().ShowAlert("تمت العملية بنجاح", frm_Notification.AlertType.success);
            }

            base.Save();
        }


        public override void Return()
        {
            if (MessageBox.Show("هل تريد التراجع؟ سيتم فقد القيم الحالية", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                operation = EntityOperation.Operation.Nothing;
                base.Return();
            }
        }

        void calculate_differance()
        {
            if (!string.IsNullOrEmpty(txt_total_credit.Text) && !string.IsNullOrEmpty(txt_total_debit.Text))
            {
                txt_deff.Text = (Convert.ToDecimal(txt_total_debit.Text) - Convert.ToDecimal(txt_total_credit.Text)).ToString();
                if (Convert.ToDouble(txt_deff.Text) == 0)
                {
                    txt_deff.Properties.Appearance.ForeColor = Color.RoyalBlue;
                    txt_deff.Properties.AppearanceDisabled.ForeColor = Color.RoyalBlue;
                    txt_deff.Properties.AppearanceFocused.ForeColor = Color.RoyalBlue;
                    txt_deff.Properties.AppearanceReadOnly.ForeColor = Color.RoyalBlue;
                }
                else
                {
                    txt_deff.Properties.Appearance.ForeColor = Color.LightCoral;
                    txt_deff.Properties.AppearanceDisabled.ForeColor = Color.LightCoral;
                    txt_deff.Properties.AppearanceFocused.ForeColor = Color.LightCoral;
                    txt_deff.Properties.AppearanceReadOnly.ForeColor = Color.LightCoral;
                }
            }
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

        private void Journal_Details_ListChanged(object sender, ListChangedEventArgs e)
        {
            RefreshData();
        }

        private void txt_total_debit_credit_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_total_credit.Text) && string.IsNullOrEmpty(txt_total_debit.Text)) return;
            calculate_differance();
        }

        private void chk_is_from_rejournal_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_is_from_rejournal.Checked)
                layoutitem_rej_no.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            else
                layoutitem_rej_no.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }


        private void txt_rejournal_no_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_rejournal_no.Text != null && !string.IsNullOrWhiteSpace(txt_rejournal_no.Text))
            {
                var journal = Journal_list.FirstOrDefault(x => x.J_No .ToString()== txt_rejournal_no.Text.ToString());
                if (journal != null)
                {

                    Journal.Total_Balance = Convert.ToDecimal(journal.Total_Balance);
                    Journal.J_Note = journal.J_Note;
                    Journal.Is_Reverce = journal.Is_Reverce;
                    Journal.Is_Curr_Diff = journal.Is_Curr_Diff;
                    Journal.Is_Periodic = journal.Is_Periodic;
                    Journal.Is_Wait = journal.Is_Wait;

                    Journal.Total_Credit = Convert.ToDecimal(journal.Total_Credit);
                    Journal.Total_Debit = Convert.ToDecimal(journal.Total_Debit);

                    var list = Journal_Details.Where(x => x.J_No.ToString() == journal.J_No.ToString()).ToList();

                    foreach (var item in list)
                    {
                        Journal.tbl_Journal_Details.Add(new tbl_Journal_Details()
                        {
                            Acc_No = item.Acc_No,
                            Curr_No = item.Curr_No,
                            tbl_Account = item.tbl_Account,
                            tbl_Currency = item.tbl_Currency,
                            Credit_Amount = item.Credit_Amount,
                            Credit_Amount_F = item.Credit_Amount_F,
                            Curr_Exchange = item.Curr_Exchange,
                            Debit_Amount = item.Debit_Amount,
                            Debit_Amount_F = item.Debit_Amount_F,
                            Note= item.Note,
                        });
                    }

                    GetData();

                    base.EnableOperation();
                }
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var row = gridView1.GetRow(e.RowHandle) as tbl_Journal_Details;
            if (row == null ) return;

            if (row.Acc_No == null || row.Acc_No == 0) return;

            if (e.Column.FieldName == nameof(details_instance.Acc_No))
            {
                var account = Session.Accounts.FirstOrDefault(x => x.C_ID == row.Acc_No);
                if (account != null)
                {
                    if (!tbl_Journal_DetailsBindingSource.Contains(account))
                    {
                        gridView1.DeleteRow(e.RowHandle);
                        tbl_Journal_DetailsBindingSource.Add(new tbl_Journal_Details()
                        {
                            Acc_No = account.C_ID,
                            tbl_Account = account,
                            tbl_Currency = account.tbl_Currency,
                            Curr_No = account.Curr_No,
                            Curr_Exchange = account.tbl_Currency.Curr_Exchange,
                        });
                    }
                    else
                    {
                        new frm_Notification().ShowAlert("عذراَ لا يمكن تكرار نفس طرف القيد ..!", frm_Notification.AlertType.Error);
                        gridView1.DeleteRow(e.RowHandle);
                    }
                }
            }
            else
            {

                GridView view = sender as GridView;
                switch (e.Column.FieldName)
                {
                    case nameof(details_instance.Curr_No):
                        // اذا كانت العملة محلية
                        if (row.tbl_Currency.Is_Local == true)
                        {
                            // نصفر المدين الأجنبي
                            view.SetRowCellValue( e.RowHandle, gridView1.Columns[nameof(details_instance.Debit_Amount_F)], null);
                            // نصفر الدائن الأجنبي
                            view.SetRowCellValue( e.RowHandle, gridView1.Columns[nameof(details_instance.Credit_Amount_F)], null);
                        }
                        // العملة اجنبية
                        else if (row.tbl_Currency.Is_Local == false)
                        {
                            if (row.Debit_Amount_F != null)
                            {
                                view.SetRowCellValue(e.RowHandle, gridView1.Columns[nameof(details_instance.Debit_Amount)], row.Debit_Amount_F * row.Curr_Exchange);
                            }
                            if (row.Credit_Amount_F != null)
                            {
                                view.SetRowCellValue(e.RowHandle, gridView1.Columns[nameof(details_instance.Credit_Amount)], row.Credit_Amount_F * row.Curr_Exchange);
                            }
                        }
                        break;

                    case nameof(details_instance.Credit_Amount_F):
                        // عند التغير في الدائن الاجنبي
                        if (e.Value != null)
                        {
                            view.SetRowCellValue(e.RowHandle, view.Columns[nameof(details_instance.Credit_Amount)], Convert.ToDecimal(e.Value) * Convert.ToDecimal(row.Curr_Exchange));
                        }
                        break;

                    case nameof(details_instance.Debit_Amount_F):
                        // عند التغير في المدين الأجنبي
                        if (e.Value != null)
                        {
                            view.SetRowCellValue(e.RowHandle, view.Columns[nameof(details_instance.Debit_Amount)], Convert.ToDecimal(e.Value) * Convert.ToDecimal(row.Curr_Exchange));
                        }

                        break;

                    case nameof(details_instance.Curr_Exchange):
                        // التأكد من ان سعر التحويل المدخل ظمن حدود التحويل
                        if (e.Value != null && Convert.ToDecimal(e.Value) > row.tbl_Currency.Curr_Max_Exchange)
                        {
                            gridView1.SetColumnError(gridView1.Columns[nameof(details_instance.Curr_Exchange)], "سعر التحويل أكبر من الحد المسموح به لأعلى سعر تحويل لهذه العملة", errorType: DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
                            return;
                        }
                        if (e.Value != null && Convert.ToDecimal(e.Value) < row.tbl_Currency.Curr_Min_Exchange)
                        {
                            gridView1.SetColumnError(gridView1.Columns[nameof(details_instance.Curr_Exchange)], "سعر التحويل أقل من الحد المسموح به لادنى سعر تحويل لهذه العملة", errorType: DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
                            return;
                        }

                        if (row.Debit_Amount_F != null)
                        {
                            view.SetRowCellValue(e.RowHandle, view.Columns[nameof(details_instance.Debit_Amount)], Convert.ToDecimal(e.Value) * Convert.ToDecimal(row.Debit_Amount_F));
                        }
                        if (row.Credit_Amount_F != null)
                        {
                            view.SetRowCellValue(e.RowHandle, view.Columns[nameof(details_instance.Credit_Amount)], Convert.ToDecimal(e.Value) * Convert.ToDecimal(row.Credit_Amount_F));
                        }
                        break;
                    default:
                        break;
                }
            }

        }

        private void gridView1_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            var obj = e.Row as tbl_Journal_Details;
            if (obj == null) return;

            // التاكد من اختيار حساب لطرف القيد
            if (obj.Acc_No == null || obj.Acc_No == 0)
            {
                e.Valid = false;
                e.ErrorText = "يرجى إختيار حساب طرف القيد";
                gridView1.SetColumnError(gridView1.Columns[nameof(details_instance.Acc_No)], "يرجى إختيار حساب طرف القيد", errorType: DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
                return;
            }


            ////// التأكد من ادخال مبلغ للقيد
            ////if (obj.Credit_Amount == null && obj.Debit_Amount == null)
            ////{
            ////    e.Valid = false;
            ////    e.ErrorText = "يرجى إدخال مبلغ القيد";
            ////    if (obj.Credit_Amount == null)
            ////        gridView1.SetColumnError(gridView1.Columns[nameof(details_instance.Credit_Amount)], "يرجى إدخال مبلغ القيد", errorType: DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
            ////    if (obj.Debit_Amount == null)
            ////        gridView1.SetColumnError(gridView1.Columns[nameof(details_instance.Debit_Amount)], "يرجى إدخال مبلغ القيد", errorType: DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
            ////}


            //var currency = Session.Currencies.FirstOrDefault(c => c.Curr_No == obj.Curr_No);
            //if (currency == null) return;

            //// التأكد من ان سعر التحويل المدخل ظمن حدود التحويل
            //if (obj.Curr_Exchange > currency.Curr_Max_Exchange)
            //{
            //    e.Valid = false;
            //    e.ErrorText = "سعر التحويل أكبر من الحد المسموح به لأعلى سعر تحويل لهذه العملة";
            //    gridView1.SetColumnError(gridView1.Columns[nameof(details_instance.Curr_Exchange)], "سعر التحويل أكبر من الحد المسموح به لأعلى سعر تحويل لهذه العملة", errorType: DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
            //}
            //if (obj.Curr_Exchange < currency.Curr_Min_Exchange)
            //{
            //    e.Valid = false;
            //    e.ErrorText = "سعر التحويل أقل من الحد المسموح به لادنى سعر تحويل لهذه العملة";
            //    gridView1.SetColumnError(gridView1.Columns[nameof(details_instance.Curr_Exchange)], "سعر التحويل أقل من الحد المسموح به لادنى سعر تحويل لهذه العملة", errorType: DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
            //}

        }

        private void gridView1_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            if (e.Row == null || (e.Row as tbl_Journal_Details).Acc_No == 0)
            {
                gridView1.DeleteRow(e.RowHandle);
            }
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore;
        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            GridControl grid = sender as GridControl;
            if (grid == null) return;
            GridView view = grid.FocusedView as GridView;
            if (view == null) return;
            if (view.FocusedColumn == null) return;
            if (e.KeyCode == Keys.Return)
            {
                if (view.FocusedColumn.FieldName == "Acc_No")
                {
                    if (view.FocusedRowHandle < 0)
                    {
                        view.SetRowCellValue(view.FocusedRowHandle, gridView1.Columns["Acc_No"], view.EditingValue);
                        gridControl1_ProcessGridKey(sender, new KeyEventArgs(Keys.Down));
                    }
                }
            }
            //if (e.KeyCode == Keys.Return)
            //{
            //    if (view.FocusedColumn.FieldName == "Acc_No")
            //    {
            //        gridControl1_ProcessGridKey(sender, new KeyEventArgs(Keys.Tab));
            //    }
            //    if (view.FocusedRowHandle < 0)
            //    {
            //        view.AddNewRow();
            //        view.FocusedColumn = view.Columns["Acc_No"];
            //    }
            //    e.Handled = true;

            //}
            //else if (e.KeyCode == Keys.Tab)
            //{
            //    view.FocusedColumn = view.VisibleColumns[view.FocusedColumn.VisibleIndex - 1];
            //    e.Handled = true;

            //}
            if (e.KeyCode == Keys.Delete)
            {
                if (XtraMessageBox.Show("هل انت متاكد من حذف طرف القيد هذا..؟", "حذف طرف قيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    view.DeleteSelectedRows();
                }
            }
        }

        private void gridView1_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            var row = gridView1.GetRow(e.RowHandle) as tbl_Journal_Details;
            if (row == null) return;


            var currency_type = Session.Currencies.FirstOrDefault(x => x.Curr_No == row.Curr_No);
            if (currency_type != null)
            {
                // اذا كانت العملة محلية يتم تعطيل التركيز على المدين والدائن الاجنبي والعكس

                switch (e.Column.FieldName)
                {
                    case nameof(details_instance.Debit_Amount_F):
                        if (currency_type.Is_Local == true)
                            e.Column.OptionsColumn.AllowFocus = false;
                        else
                            e.Column.OptionsColumn.AllowFocus = true;
                        break;
                    case nameof(details_instance.Credit_Amount_F):
                        if (currency_type.Is_Local == true)
                            e.Column.OptionsColumn.AllowFocus = false;
                        else
                            e.Column.OptionsColumn.AllowFocus = true;
                        break;

                    case nameof(details_instance.Debit_Amount):
                        if (currency_type.Is_Local == true)
                            e.Column.OptionsColumn.AllowFocus = true;
                        else
                            e.Column.OptionsColumn.AllowFocus = false;
                        break;
                    case nameof(details_instance.Credit_Amount):
                        if (currency_type.Is_Local == true)
                            e.Column.OptionsColumn.AllowFocus = true;
                        else
                            e.Column.OptionsColumn.AllowFocus = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            if (e.Item == null) return;

            int summary_id = Convert.ToInt32((e.Item as GridSummaryItem).Tag);

            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
                switch (summary_id)
                {
                    case 1: // total_debit
                        total_debit = 0;
                        break;
                    case 2: // total_credit
                        total_credit = 0;
                        break;
                }
            }

            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            {
                switch (summary_id)
                {
                    case 1: // total_debit
                        total_debit += Convert.ToDecimal(e.FieldValue);
                        break;
                    case 2: // total_credit
                        total_credit += Convert.ToDecimal(e.FieldValue);
                        break;
                }
            }

            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
                switch (summary_id)
                {
                    case 1:
                        txt_total_debit.Text = total_debit.ToString("N");
                        e.TotalValue = total_debit;
                        break;
                    case 2:
                        txt_total_credit.Text = total_credit.ToString("N");
                        e.TotalValue = total_credit;
                        break;
                    default:
                        break;
                }
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


        private void bandedGridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.ImageIndex = -1;
            }
        }

        private void txt_j_no_Validating(object sender, CancelEventArgs e)
        {
            if (txt_j_no.Text != null && !string.IsNullOrWhiteSpace(txt_j_no.Text))
            {
                var journal = Journal_list.FirstOrDefault(x => x.J_No.ToString() == txt_j_no.Text.ToString());
                if (journal != null)
                {
                    if (operation != EntityOperation.Operation.Add)
                    {
                        Journal = new tbl_Journal_Header();
                        Journal = journal;
                        Journal.tbl_Journal_Details = Journal_Details.Where(x => x.J_No.ToString() == journal.J_No.ToString()).ToList();
                        GetData();
                    }
                    else
                    {
                        new frm_Notification().ShowAlert($"يوجد بالفعل قيد يحمل الرقم {txt_j_no.Text}...", frm_Notification.AlertType.Error);
                        txt_j_no.Focus();
                        return;
                    }
                }
            }
        }


        #endregion

        //private void txt_j_no_AutoSearch(object sender, DevExpress.XtraEditors.Controls.LookUpEditAutoSearchEventArgs e)
        //{
        //    //if (operation != EntityOperation.Operation.Add)
        //    //{
        //    //    string[] fields = new string[] { "J_No", "J_Date", "J_Note" };
        //    //    e.SetParameters(fields, e.Text, DevExpress.Data.Filtering.FindPanelParserKind.And, DevExpress.Data.Filtering.FilterCondition.Contains);
        //    //}
        //    //else
        //    //{
        //    //    txt_j_no_ProcessNewValue(sender,new DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs(e.Text));
        //    //}
        //}


        //private void txt_j_no_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        //{
        //    //if (!string.IsNullOrWhiteSpace(e.DisplayValue.ToString()) && e.DisplayValue.ToString().Trim() != string.Empty)
        //    //{

        //    //    if (e.DisplayValue is int && e.DisplayValue.ToString() == Journal.J_No.ToString())
        //    //    {
        //    //        ((List<tbl_Journal_Header>)txt_j_no.Properties.DataSource).Add(Journal);
        //    //        //((List<tbl_Journal_Header>)((LookUpEdit)sender).Properties.DataSource).Add(Journal);
        //    //        e.Handled = true;
        //    //    }
        //    //}
        //}


    }
}
