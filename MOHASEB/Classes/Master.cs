using DevExpress.Internal;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOHASEB.Classes
{
   public static class Master
    {
        public class ValueAndID
        {
            public int ID { get; set; }
            public string NAME { get; set; }
        }

        private enum _acc_type
        {
            Master = 1,
            Branch 
        }

        public static List<ValueAndID> Account_Type = new List<ValueAndID>() {
                new ValueAndID() { ID = (int)_acc_type.Master , NAME  = "حساب رئيسي" },
                new ValueAndID() { ID = (int)_acc_type.Branch  , NAME  = "حساب فرعي" },
        };

        private enum _acc_report
        {
            Balance_Sheet = 1,
            Profits_and_Losses
        }    
        
        public static List<ValueAndID> Account_Report = new List<ValueAndID>() {
                new ValueAndID() { ID = (int)_acc_report.Balance_Sheet , NAME  = "الميزانية العمومية" },
                new ValueAndID() { ID = (int)_acc_report.Profits_and_Losses  , NAME  = " الأرباح والخسائر" },
        };

        private enum _acc_related
        {
         General = 1,
         Cash,
         Customer,
         Vender,
         Employee,
         Argument
        }

        public static List<ValueAndID> Acc_Related = new List<ValueAndID>() {
                new ValueAndID() { ID = (int)_acc_related.General , NAME  = "عام" },
                new ValueAndID() { ID = (int)_acc_related.Cash  , NAME  = " صندوق" },
                new ValueAndID() { ID = (int)_acc_related.Customer  , NAME  = " عميل" },
                new ValueAndID() { ID = (int)_acc_related.Vender  , NAME  = " مورد" },
                new ValueAndID() { ID = (int)_acc_related.Employee  , NAME  = " ذمم موظفين" },
                new ValueAndID() { ID = (int)_acc_related.Argument  , NAME  = "  حساب وسيط" },
        };



        public static bool ValidatingData(this TextEdit text)
        {
            if (text.Text == null || string.IsNullOrWhiteSpace(text.Text))
            {
                text.ErrorText = "هذا الحقل مطلوب";
                return false;
            }
            else return true;
        }

        public static void EnableLayoutFeilds(this LayoutControl layout , bool enable)
        {
            if (layout == null) return;
            foreach (var item in layout.Controls)
            {
                if (item is TextEdit) (item as TextEdit).Enabled = enable;
                if (item is DateEdit) (item as DateEdit).Enabled = enable;
                if (item is MemoEdit) (item as MemoEdit).Enabled = enable;
                if (item is CheckEdit) (item as CheckEdit).Enabled = enable;
            }
        }
        
        public static void ClearLayoutFeilds(this LayoutControl layout)
        {
            if (layout == null) return;
            foreach (var item in layout.Controls)
            {
                if (item is TextEdit) (item as TextEdit).Text = string.Empty;
                if (item is DateEdit) (item as DateEdit).Text = string.Empty;
                if (item is MemoEdit) (item as MemoEdit).Text = string.Empty;
                if (item is SpinEdit) (item as SpinEdit).Text = string.Empty;
                //if (item is GridLookUpEdit) (item as GridLookUpEdit).Text = string.Empty;
                if (item is CheckEdit) (item as CheckEdit).Checked = false;
            }
        }

        /// <summary>
        /// دالة لتهيئة اي Gridlookupedit
        /// </summary>
        /// <param name="lkp"></param>
        /// <param name="data_source"></param>
        /// <param name="display_member"></param>
        /// <param name="value_member"></param>
        public static void InitializeData(this GridLookUpEdit lkp, object data_source)
        {
            if (data_source == null) return;
            lkp.Properties.DataSource = data_source;
        }

        /// <summary>
        /// دالة لتهيئة اي lookupedit
        /// </summary>
        /// <param name="lkp"></param>
        /// <param name="data_source"></param>
        /// <param name="display_member"></param>
        /// <param name="value_member"></param>
        public static void InitializeData(this LookUpEdit lkp, object data_source)
        {
            if (data_source == null) return;
            lkp.Properties.DataSource = data_source;           
        }
        
        /// <summary>
        /// دالة لتهيئة اي lookupedit
        /// </summary>
        /// <param name="lkp"></param>
        /// <param name="data_source"></param>
        /// <param name="display_member"></param>
        /// <param name="value_member"></param>
        public static void InitializeData(this LookUpEdit lkp, object data_source, string display_member = null, string value_member = null)
        {
            if (data_source == null) return;
            lkp.Properties.DataSource = data_source;
            lkp.Properties.DisplayMember = display_member;
            lkp.Properties.ValueMember = value_member;
           
        }

        /// <summary>
        /// دالة لتهيئة اي BindingSource
        /// </summary>
        /// <param name="lkp"></param>
        /// <param name="data_source"></param>
        /// <param name="display_member"></param>
        /// <param name="value_member"></param>
        public static void InitializeData(this BindingSource bs, object data_source)
        {
            if (data_source == null) return;
            bs.DataSource = data_source;
        }
    }
}
