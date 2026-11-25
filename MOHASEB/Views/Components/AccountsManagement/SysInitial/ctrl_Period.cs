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

namespace MOHASEB.Views.Components.AccountsManagement.SysInitial
{
    public partial class ctrl_Period : XtraUserControl
    {
        tbl_Period_Master period_master;
        EntityOperation.Operation operation;
        bool row_update =false;

        public ctrl_Period()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            period_master = Session.Period;

            if (period_master != null && period_master.tbl_Period_Details != null)
            {
                tbl_Period_DetailsBindingSource.DataSource = period_master.tbl_Period_Details;
                btn_add.Enabled = false;
            }

            ClearFields();

            btn_edit.Enabled = true;
            btn_save.Enabled = false;
        }


        void EnableOperation()
        {
            btn_add.Enabled = false;
            btn_edit.Enabled = false;
            btn_save.Enabled = true;
        }

        void EnableFields(bool enable)
        {
            // Enable Texts Boxes
            foreach (var text in layoutControl3.Controls)
            {
                if (text is TextEdit)
                {
                    (text as TextEdit).Enabled = enable;
                }
            }
            gridControl1.Enabled = enable;
        }

        void ClearFields()
        {
            foreach (var text in layoutControl3.Controls)
            {
                if (text is TextEdit)
                {
                    (text as TextEdit).Text = string.Empty;
                }
            }
            EnableFields(false);
        }



        List<tbl_Period_Details> InitializeTable()
        {
            if (!string.IsNullOrWhiteSpace(txt_start_month.Text)
             && !string.IsNullOrWhiteSpace(txt_end_month.Text))
            {

                DateTime start_date = Convert.ToDateTime(txt_start_month.Text);
                DateTime end_date = Convert.ToDateTime(txt_end_month.Text);

                List<tbl_Period_Details> period_details = new List<tbl_Period_Details>();

                for (int i = 1; i <= 12; i++)
                {
                    if (start_date > end_date)
                    {
                        break;
                    }
                    period_details.Add(new tbl_Period_Details
                    {
                        Period_Master_No = period_master.Year_No,
                        Period_Month = start_date,
                        Is_Stoped = false,
                        Is_Closed = false,
                    });
                    start_date = start_date.AddMonths(1);
                }
                return period_details;
            }
            else
            {
                return null;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            operation = EntityOperation.Operation.Add;

            // focus 1st text box
            txt_start_month.Focus();

            EnableOperation();

            EnableFields(true);
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_start_month.Text) 
                && string.IsNullOrWhiteSpace(txt_end_month.Text)
                && operation != EntityOperation.Operation.Update)
            {
                new frm_Notification().ShowAlert("حدد الأشهر أولاَ", frm_Notification.AlertType.Warning);
                return;
            }

            if (period_master == null)
            {
                new frm_Notification().ShowAlert("لا توجد سنة مالية مفتوحة", frm_Notification.AlertType.Warning);
                return;
            }

            var list = InitializeTable();

            if (list != null && operation == EntityOperation.Operation.Add)
            {
                await Task.Run(() => Session.DB.tbl_Period_Details.AddRange(list));
                await Session.DB.SaveChangesAsync();
            }
            if (operation == EntityOperation.Operation.Update && row_update == true)
                await Session.DB.SaveChangesAsync();

            LoadData();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            operation = EntityOperation.Operation.Update;

            EnableOperation();

            gridControl1.Enabled = true;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد التراجع؟ سيتم فقد القيم الحالية", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridControl1.DataSource = null;
                operation = EntityOperation.Operation.Nothing;
                LoadData();
            }
        }


        private void txt_start_month_Validating(object sender, CancelEventArgs e)
        {
            if (txt_start_month.Text != null && !string.IsNullOrWhiteSpace(txt_start_month.Text))
            {
                DateTime start_date = Convert.ToDateTime(txt_start_month.Text);
                start_date = start_date.AddMonths(11);
                txt_end_month.EditValue = start_date.ToString("MM / yyyy");
            }
        }

        private void txt_end_month_Validating(object sender, CancelEventArgs e)
        {
            tbl_Period_DetailsBindingSource.DataSource = InitializeTable();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            row_update = true;
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.ImageIndex = -1;
            }
        }
    }
}
