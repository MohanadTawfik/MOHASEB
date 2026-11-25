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
using DevExpress.Utils.Extensions;

namespace MOHASEB.Views.Components.AccountsManagement.SysInitial
{
    public partial class ctrl_Accounts_Groups : Control_Master
    {
        tbl_Accounts_Groups group;

       EntityOperation.Operation operation;

        public ctrl_Accounts_Groups()
        {
            InitializeComponent();
            Session.Accounts_Groups.ListChanged += Accounts_Groups_ListChanged;
            RefreshData();
           
        }

        private void Accounts_Groups_ListChanged(object sender, ListChangedEventArgs e)
        {
            RefreshData();
        }

        public override void RefreshData()
        {

            gridControl1.DataSource = Session.Accounts_Groups;
            base.RefreshData();
        }

        public override void EnableFields(bool enable)
        {
            layoutControl1.EnableLayoutFeilds(enable);
            base.EnableFields(enable);
        }

        public override void ClearFields(bool enable)
        {
            layoutControl1.ClearLayoutFeilds();

            base.ClearFields(enable);
        }

        public override void New()
        {
            operation = EntityOperation.Operation.Add;
            var max_no = Session.Accounts_Groups.Select(x => x.Acc_Group_No).MaxOrDefault() + 1;

            group = new tbl_Accounts_Groups()
            {
                Acc_Group_No = max_no,
            };


            base.New();
            txt_group_name.Focus();
        }

        public override async void Save()
        {
            SetData();

            await EntityOperation.SqlOperationAsync<tbl_Accounts_Groups>(group, operation);
            base.Save();
        }



        public override bool IsValidData()
        {
            bool isvalid = false;
            foreach (var item in layoutControl1.Controls)
            {
                if (item is TextEdit)
                {
                    isvalid = (item as TextEdit).ValidatingData();
                }
            }

            if (isvalid == false)
                return false;
            else
                return base.IsValidData();
        }

        public override void SetData()
        {
            group.Acc_Group_No = Convert.ToInt32(txt_group_no.EditValue);
            group.Acc_Group_Name = txt_group_name.Text;

            base.SetData();
        }

        public override void Return()
        {
            if (MessageBox.Show("هل تريد التراجع؟ سيتم التغير في القيم الحالية", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                operation = EntityOperation.Operation.Nothing;
            }
            base.Return();
        }


        public override void Edit()
        {
            if (group == null)
            {
                new frm_Notification().ShowAlert("لا بيانات لتعديلها", frm_Notification.AlertType.Error);
                return;
            }

            operation = EntityOperation.Operation.Update;
            EnableFields(true);
            base.Edit();
        }

        public override void GetData()
        {
            txt_group_no.EditValue = group.Acc_Group_No;
            txt_group_name.EditValue = group.Acc_Group_Name;

            base.GetData();
        }

        public override void Delete()
        {
            if (group == null)
            {
                new frm_Notification().ShowAlert("لا بيانات لحذفها", frm_Notification.AlertType.Error);
                return;
            }

            operation = EntityOperation.Operation.Delete;
            EnableFields(true);
            base.Delete();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.ImageIndex = -1;
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            group = gridView1.GetFocusedRow() as tbl_Accounts_Groups;
            GetData();
        }
    }
}
