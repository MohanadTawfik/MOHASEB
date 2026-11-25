using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Filtering.Templates;
using DevExpress.XtraRichEdit.Fields;
using MOHASEB.Model;
using MOHASEB.Views.PublicCompounent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOHASEB.Views.Components.SystemManagement.SysInitial
{
    public partial class Price : DevExpress.XtraEditors.XtraUserControl
    {
        private MOHASEB_DBEntities db;
        private tbl_Company company;
        bool state = false;

        int id = 0;

        public Price()
        {
            InitializeComponent();
        }

        

     

        #region
        public void LoadData()
        {
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

            //chk_is_main.Enabled = enable;
          
            //txt_cmp_no.Enabled = false;

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

            enableTexts(false);

        }



        private void btn_add_Click(object sender, EventArgs e)
        {

            enableTexts(true);
            //bool isLocal = await Task.Run(() => db.tbl_Company.Any(x => x. == "محلية"));
            //if (isLocal) rdo_foriegn.Checked = true;

            // focus 1st text box
            //txt_cmp_name.Focus();
            //txt_cmp_year.Text = "2023";

            btn_save.Enabled = true;
            btn_return.Enabled = true;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Enable Texts Boxes
            foreach (var item in layoutControl3.Controls)
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

         
            var memory = new MemoryStream();
          

            if (id == 0)
            {
                company = new tbl_Company
                {
                    //C_ArName = txt_cmp_name.Text,
                    //C_EnName = txt_cmp_en_name.Text,
                    //C_ArAddress = txt_cmp_address.Text,
                    //C_EnAddress = txt_cmp_en_address.Text,
                    //C_Email = txt_cmp_email.Text,
                    //C_Fax = txt_cmp_fax.Text,
                    //C_Phone = txt_cmp_phone.Text,
                    //C_Website = txt_cmp_website.Text,
                    //C_Logo = memory.ToArray(),
                };
            }
            else
            {
                company = new tbl_Company
                {
                    //C_No = id,
                    //C_ArName = txt_cmp_name.Text,
                    //C_EnName = txt_cmp_en_name.Text,
                    //C_ArAddress = txt_cmp_address.Text,
                    //C_EnAddress = txt_cmp_en_address.Text,
                    //C_Email = txt_cmp_email.Text,
                    //C_Fax = txt_cmp_fax.Text,
                    //C_Phone = txt_cmp_phone.Text,
                    //C_Website = txt_cmp_website.Text,
                    //C_Logo = memory.ToArray(),
                };
            }

            AddOrUpdate(company);
        }

        async void AddOrUpdate(tbl_Company company)
        {
            try
            {
                await Task.Run(() => db.tbl_Company.AddOrUpdate(company));
                state = true;
                await db.SaveChangesAsync();

                if (state == true)
                {
                    new frm_Notification().ShowAlert("تمت العملية بنجاح", frm_Notification.AlertType.success);
                    LoadData();
                }
                else
                {
                    new frm_Notification().ShowAlert("هناك مشكلة في في إجراء العملية", frm_Notification.AlertType.Warning);
                }
            }
            catch
            {
                new frm_Notification().ShowAlert(" هناك مشكلة في الإتصال بالسيرفر", frm_Notification.AlertType.Warning);
            }

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد التراجع؟ سيتم التغير في القيم الحالية", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var changed = db.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).ToList();
                foreach (var obj in changed)
                {
                    switch (obj.State)
                    {
                        case EntityState.Modified:
                            obj.CurrentValues.SetValues(obj.OriginalValues);
                            obj.State = EntityState.Unchanged;
                            break;
                        case EntityState.Added:
                            obj.State = EntityState.Detached;
                            break;
                        case EntityState.Deleted:
                            obj.State = EntityState.Unchanged;
                            break;
                    }
                }
                LoadData();
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {

        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف؟ ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    db = new MOHASEB_DBEntities();
                    await Task.Run(() => db.Entry(new tbl_Company { C_No = id }).State = EntityState.Deleted);
                    state = true;
                    await db.SaveChangesAsync();

                    if (state == true)
                    {
                        new frm_Notification().ShowAlert("تمت العملية بنجاح", frm_Notification.AlertType.success);
                        LoadData();
                    }
                    else
                    {
                        new frm_Notification().ShowAlert("هناك مشكلة في في إجراء العملية", frm_Notification.AlertType.Warning);
                    }
                }
                catch
                {
                    new frm_Notification().ShowAlert(" هناك مشكلة في الإتصال بالسيرفر", frm_Notification.AlertType.Warning);
                }
            }
        }


        #endregion

        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
