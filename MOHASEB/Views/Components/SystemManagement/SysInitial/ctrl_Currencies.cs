using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using MOHASEB.Classes;
using MOHASEB.Model;
using MOHASEB.Views.PublicCompounent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOHASEB.Views.Components.SystemManagement.SysInitial
{
    public partial class ctrl_Currencies : DevExpress.XtraEditors.XtraUserControl
    {
        private MOHASEB_DBEntities db;
        private tbl_Currency currency;
        EntityOperation.Operation operation;
        private int id;

        public ctrl_Currencies()
        {
            InitializeComponent();

            LoadData();


        }

        #region
        public void LoadData()
        {
            // Instantiate a new DataContext
            db = new MOHASEB.Model.MOHASEB_DBEntities();
            db.tbl_Currency.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                tbl_CurrencyBindingSource.DataSource = db.tbl_Currency.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            clearText();
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_delete.Enabled = false;
            btn_save.Enabled = false;
        }
      
        void enableTexts(bool enable)
        {
            // Enable Texts Boxes
            foreach (var text in layoutControl3.Controls)
            {
                if (text is TextEdit)
                {
                    (text as TextEdit).Enabled = enable;
                }
            }

            foreach (var text in layoutControl4.Controls)
            {
                if (text is TextEdit)
                {
                    (text as TextEdit).Enabled = enable;
                }
            }

            rdo_foriegn.Enabled = enable;
            rdo_local.Enabled = enable;
            chk_default.Enabled = enable;
            chk_is_stop.Enabled = enable;

        }

        void clearText()
        {
            foreach (var text in layoutControl3.Controls)
            {
                if (text is TextEdit)
                {
                    (text as TextEdit).Text = string.Empty;
                }
            }

            foreach (var text in layoutControl4.Controls)
            {
                if (text is TextEdit)
                {
                    (text as TextEdit).Text = string.Empty;
                }
            }

            enableTexts(false);

        }



        private async void btn_add_Click(object sender, EventArgs e)
        {

            enableTexts(true);
            operation = EntityOperation.Operation.Add;

            bool isLocal = await Task.Run(() => db.tbl_Currency.Any(x => x.Is_Local == true));
            if (isLocal) rdo_foriegn.Checked = true;

            // focus 1st text box
            txt_curr_name.Focus();

            btn_save.Enabled = true;
            btn_return.Enabled = true;

        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            // Enable Texts Boxes
            foreach (var item in layoutControl3.Controls)
            {
                if (item is TextEdit)
                {
                    if (((TextEdit) item).Text == String.Empty)
                    {
                        new frm_Notification().ShowAlert("هناك حقل فارغ", frm_Notification.AlertType.Warning);
                        return;
                    }
                }
            }

            foreach (var item in layoutControl4.Controls)
            {
                if (item is TextEdit)
                {
                    if (((TextEdit)item).Text == String.Empty)
                    {
                        new frm_Notification().ShowAlert("هناك حقل فارغ", frm_Notification.AlertType.Warning);
                        return;
                    }
                }
            }

            bool isLocal = await Task.Run(() => db.tbl_Currency.Any(x => x.Is_Local == true));
            if (isLocal == true && rdo_local.Checked)
            {
                new frm_Notification().ShowAlert("هناك بالفعل عملة محلية", frm_Notification.AlertType.Warning);
                return;
            }

            if (operation == EntityOperation.Operation.Add)
            {
                currency = new tbl_Currency
                {
                    Curr_ArName = txt_curr_name.Text,
                    Curr_EnName = txt_curr_en_name.Text,
                    Curr_Part = txt_curr_part.Text,
                    Curr_Symbol = txt_curr_symbol.Text,
                    Curr_Exchange = Convert.ToDecimal(txt_curr_exchange.Text),
                    Curr_Max_Exchange = Convert.ToDecimal(txt_curr_max_exchange.Text),
                    Curr_Min_Exchange = Convert.ToDecimal(txt_curr_min_exchange.Text),
                    Is_Local = rdo_local.Checked,
                    Is_Stop = chk_is_stop.Checked ? true : false

                };
            }
            else
            {
                currency = new tbl_Currency
                {
                    Curr_No = id,
                    Curr_ArName = txt_curr_name.Text,
                    Curr_EnName = txt_curr_en_name.Text,
                    Curr_Part = txt_curr_part.Text,
                    Curr_Symbol = txt_curr_symbol.Text,
                    Curr_Exchange = Convert.ToDecimal(txt_curr_exchange.Text),
                    Curr_Max_Exchange = Convert.ToDecimal(txt_curr_max_exchange.Text),
                    Curr_Min_Exchange = Convert.ToDecimal(txt_curr_min_exchange.Text),
                    Is_Local = rdo_local.Checked,
                    Is_Stop = chk_is_stop.Checked ? true : false
                };
            }

            await EntityOperation.SqlOperationAsync<tbl_Currency>(currency, operation);
            LoadData();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد التراجع؟ سيتم التغير في القيم الحالية", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //var changed = db.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).ToList();
                //foreach (var obj in changed)
                //{
                //    switch (obj.State)
                //    {
                //        case EntityState.Modified:
                //            obj.CurrentValues.SetValues(obj.OriginalValues);
                //            obj.State = EntityState.Unchanged;
                //            break;
                //        case EntityState.Added:
                //            obj.State = EntityState.Detached;
                //            break;
                //        case EntityState.Deleted:
                //            obj.State = EntityState.Unchanged;
                //            break;
                //    }
                //}
                LoadData();
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {

        }


        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            getDate();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            getDate();
        }

        void getDate()
        {
            operation = EntityOperation.Operation.Update;

            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Curr_No"));
            txt_curr_name.Text = gridView1.GetFocusedRowCellValue("Curr_ArName").ToString();
            txt_curr_en_name.Text = gridView1.GetFocusedRowCellValue("Curr_EnName").ToString();
            txt_curr_symbol.Text = gridView1.GetFocusedRowCellValue("Curr_Symbol").ToString();
            txt_curr_part.Text = gridView1.GetFocusedRowCellValue("Curr_Part").ToString();
            txt_curr_exchange.Text = gridView1.GetFocusedRowCellValue("Curr_Exchange").ToString();
            txt_curr_max_exchange.Text = gridView1.GetFocusedRowCellValue("Curr_Max_Exchange").ToString();
            txt_curr_min_exchange.Text = gridView1.GetFocusedRowCellValue("Curr_Min_Exchange").ToString();
            if (gridView1.GetFocusedRowCellValue("Curr_Type").ToString() == "1")
                rdo_local.Checked = true;
            else
                rdo_foriegn.Checked = true;
            chk_is_stop.Checked = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("Is_Stop")) == true ? true : false;

            btn_add.Enabled = false;
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;
            btn_save.Enabled = true;
            btn_return.Enabled = true;

            enableTexts(true);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف؟ ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EntityOperation.SqlOperationAsync<tbl_Currency>(new tbl_Currency { Curr_No = id }, EntityOperation.Operation.Delete);
                LoadData();
            }
        }

        #endregion

       
    }
}
