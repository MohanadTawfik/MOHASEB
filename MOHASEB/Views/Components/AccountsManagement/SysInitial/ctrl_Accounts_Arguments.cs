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
    public partial class ctrl_Accounts_Arguments : XtraUserControl
    {
        tbl_Period_Master period_master;
        EntityOperation.Operation operation;
        bool row_update =false;

        public ctrl_Accounts_Arguments()
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



  

        private void btn_add_Click(object sender, EventArgs e)
        {

            operation = EntityOperation.Operation.Add;


            EnableOperation();

            EnableFields(true);
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
           

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            operation = EntityOperation.Operation.Update;

            EnableOperation();

          
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد التراجع؟ سيتم فقد القيم الحالية", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                operation = EntityOperation.Operation.Nothing;
                LoadData();
            }
        }


    }
}
