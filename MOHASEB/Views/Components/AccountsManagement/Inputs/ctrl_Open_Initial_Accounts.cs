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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Base;

namespace MOHASEB.Views.Components.AccountsManagement.Inputs
{
    public partial class ctrl_Open_Initial_Accounts : XtraUserControl
    {
        private decimal total_credit;
        private decimal total_debit;
        List<tbl_Journal_Details> initial_accounts;
        tbl_Journal_Header Journal;
        private List<tbl_Account> all_accounts;
        tbl_Journal_Details details_instance;

        public ctrl_Open_Initial_Accounts()
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


        #region Methods
        async void RefreshData()
        {
            NoOperation();
            ClearFields(false);
            all_accounts = new List<tbl_Account>();
            all_accounts = Session.Accounts.ToList();

            initial_accounts = new List<tbl_Journal_Details>();
            Journal = new tbl_Journal_Header();

            Journal = Session.Journal.FirstOrDefault(x => x.Is_Initial_Balance == true);

            if (Journal != null)
            {
                initial_accounts = Journal.tbl_Journal_Details.ToList();
            }
            else
            { 
                // عملية الإقفال فشلت ولم يتم فتح ارصدة افتتاحية للسنة الجديدة
                Journal = new tbl_Journal_Header()
                {
                    J_No = 0,
                    Period_No = Session.Period.Year_No,
                    J_Date = DateTime.Now,
                    J_Note = "رصيد إفتتاحي",
                    J_Post = true,
                    Is_Initial_Balance = true,
                };

                await Task.Run(() => Session.DB.tbl_Journal_Header.Add(Journal));
                await Session.DB.SaveChangesAsync();
            }

            tbl_Journal_DetailsBindingSource.DataSource = new List<tbl_Journal_Details>();
        }

        void EnableOperation()
        {
            btn_edit.Enabled = false;
            btn_save.Enabled = true;
            btn_return.Enabled = true;
        }

        void EnableFields(bool enable)
        {
            layoutControl3.EnableLayoutFeilds(enable);

            btn_download.Enabled = enable;
            btn_upload.Enabled = enable;

            gridControl1.Enabled = enable;
        }

        void ClearFields(bool enable)
        {
            layoutControl3.ClearLayoutFeilds();
            EnableFields(enable);

        }

        void GetTotalDeff()
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

        public void Edit()
        {
            // focus 1st text box
            txt_start_account.Focus();

            EnableOperation();

            EnableFields(true);
        }

        public void Return()
        {
            if (MessageBox.Show("هل تريد التراجع؟ سيتم فقد القيم الحالية", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RefreshData();
            }
        }

        public virtual async void Save()
        {

            gridView1.UpdateCurrentRow();

            var list = tbl_Journal_DetailsBindingSource.DataSource as List<tbl_Journal_Details>;

            foreach (var item in list)
            {
                await Task.Run(() => Session.DB.tbl_Journal_Details.AddOrUpdate(item));
            }

            await Session.DB.SaveChangesAsync();
            new frm_Notification().ShowAlert("تمت العملية بنجاح", frm_Notification.AlertType.success);

            RefreshData();
        }

        void GetData(int start_account = 0, int end_account = 0)
        {
            var accounts = all_accounts.Where(x => x.Acc_Type == 2);
            if (start_account != 0 && end_account != 0)
                accounts = accounts.Where(x => x.Acc_No >= start_account && x.Acc_No <= end_account).ToList();

            List<tbl_Journal_Details> list = new List<tbl_Journal_Details>();

            foreach (var item in accounts)
            {
                var journal_det = initial_accounts.FirstOrDefault(x => x.Acc_No == item.C_ID);
                if (journal_det != null)
                {
                    list.Add(new tbl_Journal_Details()
                    {
                        Acc_No = journal_det.tbl_Account.C_ID,
                        tbl_Account = journal_det.tbl_Account,
                        J_No = journal_det.J_No,
                        Note = journal_det.Note,
                        Curr_No = journal_det.Curr_No,
                        tbl_Currency = journal_det.tbl_Currency,
                        Curr_Exchange = journal_det.tbl_Currency.Curr_Exchange,
                        tbl_Journal_Header = journal_det.tbl_Journal_Header,
                        Credit_Amount = journal_det.Credit_Amount,
                        Debit_Amount = journal_det.Debit_Amount, 
                        Credit_Amount_F = journal_det.Credit_Amount_F,
                        Debit_Amount_F = journal_det.Debit_Amount_F,
                        C_ID = journal_det.C_ID,
                    });
                }
                else
                {
                    list.Add(new tbl_Journal_Details()
                    {
                        Acc_No = item.C_ID,
                        tbl_Account = item,
                        Note = "رصيد إفتتاحي",
                        Curr_No = item.Curr_No,
                        tbl_Currency = item.tbl_Currency,
                        Curr_Exchange = item.tbl_Currency.Curr_Exchange,
                        tbl_Journal_Header = Journal,
                        J_No = Journal.J_No,
                    });
                }

            }

            tbl_Journal_DetailsBindingSource.DataSource = list;

            GetTotalDeff();
        }

        void NoOperation()
        {
            btn_edit.Enabled = true;
            btn_save.Enabled = false;
            btn_return.Enabled = false;
        }

        #endregion

        #region Events

        private void Accounts_ListChanged(object sender, ListChangedEventArgs e)
        {
            RefreshData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Return();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private async void btn_upload_Click(object sender, EventArgs e)
        {

            List<tbl_Journal_Details> list = new List<tbl_Journal_Details>();

            foreach (var item in all_accounts)
            {
                var journal_det = initial_accounts.FirstOrDefault(x => x.Acc_No == item.C_ID);
                if (journal_det != null)
                {
                    list.Add(new tbl_Journal_Details()
                    {
                        Acc_No = journal_det.tbl_Account.C_ID,
                        tbl_Account = journal_det.tbl_Account,
                        J_No = journal_det.J_No,
                        Note = journal_det.Note,
                        Curr_No = journal_det.Curr_No,
                        tbl_Currency = journal_det.tbl_Currency,
                        Curr_Exchange = journal_det.tbl_Currency.Curr_Exchange,
                        tbl_Journal_Header = journal_det.tbl_Journal_Header,
                        Credit_Amount = journal_det.Credit_Amount,
                        Debit_Amount = journal_det.Debit_Amount,
                        Credit_Amount_F = journal_det.Credit_Amount_F,
                        Debit_Amount_F = journal_det.Debit_Amount_F,
                        C_ID = journal_det.C_ID,
                    });
                }
                else
                {
                    list.Add(new tbl_Journal_Details()
                    {
                        Acc_No = item.C_ID,
                        tbl_Account = item,
                        Note = "رصيد إفتتاحي",
                        Curr_No = item.Curr_No,
                        tbl_Currency = item.tbl_Currency,
                        Curr_Exchange = item.tbl_Currency.Curr_Exchange,
                        tbl_Journal_Header = Journal,
                        J_No = Journal.J_No,
                    });
                }

            }


            int maxlevel = list.Select(x => x.tbl_Account.Acc_Level).Max();

            for (int i = maxlevel; i >= 1; i--)
            {
                var level = list.Where(x => x.tbl_Account.Acc_Level == i).ToList();
                foreach (var item in level)
                {
                    if (item.tbl_Account.Acc_Type == 1)
                    {
                        int acc_no = item.tbl_Account.Acc_No;

                        decimal credit = 0;
                        decimal debit = 0;

                        var child_accounts = list.Where(x => x.tbl_Account.Acc_Parent_No == acc_no).ToList();

                        if (child_accounts != null)
                        {
                            foreach (var child in child_accounts)
                            {
                                credit += Convert.ToDecimal(child.Credit_Amount);
                                debit += Convert.ToDecimal(child.Debit_Amount);
                            }

                            item.Credit_Amount = credit;
                            item.Debit_Amount = debit;
                        }
                    }
                }
            }

            foreach (var item in list)
            {
                await Task.Run(() => Session.DB.tbl_Journal_Details.AddOrUpdate(item));
            }

            await Session.DB.SaveChangesAsync();
            new frm_Notification().ShowAlert("تم التصعيد بنجاح", frm_Notification.AlertType.success);
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_start_account.Text)
              && !string.IsNullOrWhiteSpace(txt_end_account.Text)
              )
            {
                GetData(int.Parse(txt_start_account.Text), int.Parse(txt_end_account.Text));
            }
            else
            {
                GetData();
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

        private void txt_total_debit_credit_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_total_credit.Text) && string.IsNullOrEmpty(txt_total_debit.Text)) return;
            GetTotalDeff();
        }


        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var row = gridView1.GetRow(e.RowHandle) as tbl_Journal_Details;
            if (row == null) return;

            GridView view = sender as GridView;
            switch (e.Column.FieldName)
            {
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
                default:
                    break;
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
                    case nameof(details_instance.Credit_Amount_F):
                        if (currency_type.Is_Local == true)
                        {
                            e.Column.OptionsColumn.AllowFocus = false;
                            e.Column.OptionsColumn.AllowEdit = false;
                            e.Column.OptionsColumn.ReadOnly = true;
                        }
                        else
                        {
                            e.Column.OptionsColumn.AllowFocus = true;
                            e.Column.OptionsColumn.AllowEdit = true;
                            e.Column.OptionsColumn.ReadOnly = false;
                        }
                        break;
                    case nameof(details_instance.Debit_Amount):
                    case nameof(details_instance.Credit_Amount):
                        if (currency_type.Is_Local == true)
                        {
                            e.Column.OptionsColumn.AllowFocus = true;
                            e.Column.OptionsColumn.AllowEdit = true;
                            e.Column.OptionsColumn.ReadOnly = false;
                        }
                        else
                        {
                            e.Column.OptionsColumn.AllowFocus = false;
                            e.Column.OptionsColumn.AllowEdit = false;
                            e.Column.OptionsColumn.ReadOnly = true;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

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
