using DevExpress.XtraRichEdit.Model;
using MOHASEB.Views.PublicCompounent;
using MOHASEB.Views.GUIs.AccountsManagement;
using MOHASEB.Views.GUIs.InventoryManagment;
using MOHASEB.Views.GUIs.PurchaseManagement;
using MOHASEB.Views.GUIs.SalesManagement;
using MOHASEB.Views.GUIs.SystemManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOHASEB.Views.GUIs.Main
{
    public partial class frm_Main : DevExpress.XtraEditors.XtraForm
    {

        static public frm_Accounts_Managment Accounts_Managment;
        static public Frm_System_Management System_Management;
        static public frm_Purchase_Management Purchase_Management;
        static public frm_Inventory_Managment Inventory_Managment;
        static public frm_Sales_Management Sales_Management;

        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_ShutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_SysManag_Click(object sender, EventArgs e)
        {
            System_Management =  new Frm_System_Management();
            System_Management.Show();
        }

        private void btn_PurcheManage_Click(object sender, EventArgs e)
        {
            Purchase_Management = new frm_Purchase_Management();
            Purchase_Management.Show();
        }

        private void btn_StockManage_Click(object sender, EventArgs e)
        {
            Inventory_Managment=   new frm_Inventory_Managment();
            Inventory_Managment.Show();
        }

        private void btn_SalseManage_Click(object sender, EventArgs e)
        {
            Sales_Management = new frm_Sales_Management();
            Sales_Management.Show();
        }

        private void btn_AccManage_Click(object sender, EventArgs e)
        {
            Accounts_Managment = new frm_Accounts_Managment();
            Accounts_Managment.Show();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            new frm_Notification().ShowAlert("سيتم إتاحة هذا القسم في الإصدارات المستقبلية..", frm_Notification.AlertType.Info);
        }
    }
}
