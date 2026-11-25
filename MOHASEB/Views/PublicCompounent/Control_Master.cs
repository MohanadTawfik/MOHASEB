using DevExpress.XtraEditors;
using MOHASEB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOHASEB.Views.PublicCompounent
{
    public partial class Control_Master : XtraUserControl
    {
        public Control_Master()
        {
            InitializeComponent();
            NoOperation();
        }

        #region Methods
        public virtual void New() {
            ClearFields(true);
            GetData();
            EnableOperation();
        }
        public virtual void Edit() {
            EnableOperation();
        }
        public virtual void Delete() {
            EnableOperation();
        }
        public virtual void Return()
        {
            RefreshData();
        }
        public virtual void Save() {
            //new frm_Notification().ShowAlert("تمت العملية بنجاح", frm_Notification.AlertType.success);
            RefreshData();
            //NoOperation();
            //ClearFields(false);
        }
        public virtual void Print() { }
        public virtual void GetData() {
            DesableOperation();
        }
        public virtual void SetData() { }
        public virtual void RefreshData() 
        {
            NoOperation();
            ClearFields(false);
        }
        public virtual bool IsValidData() 
        {
            return true;
        }

        public virtual void EnableFields(bool enable) { }

        public virtual void ClearFields(bool enable)
        {
            EnableFields(enable);
        }


        public void NoOperation()
        {
            btn_add.Enabled = true;
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
            btn_print.Enabled = false;
            btn_save.Enabled = false;
            btn_return.Enabled = false;
        }       
        
       public void DesableOperation()
        {
            btn_add.Enabled = false;
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;

            btn_return.Enabled = true;
            btn_save.Enabled = false;
        }

        public void InitialOperation()
        {
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;

            btn_save.Enabled = false;
            btn_return.Enabled = false;
        }

        public void EnableOperation()
        {

            btn_add.Enabled = false;
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;

            btn_save.Enabled = true;
            btn_return.Enabled = true;
        }


        #endregion


        #region Events
        private void btn_add_Click(object sender, EventArgs e)
        {
            New();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Return();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(IsValidData()) Save();
        }
        #endregion

        private void btn_exit_Click(object sender, EventArgs e)
        {

        }
    }
}
