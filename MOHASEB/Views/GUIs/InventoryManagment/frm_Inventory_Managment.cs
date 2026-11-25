using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using MOHASEB.Views.Components.InventoryManagment.Operations;
using MOHASEB.Views.Components.InventoryManagment.Opration;
using MOHASEB.Views.Components.InventoryManagment.SysInitial;
using MOHASEB.Views.Components.SystemManagement.SysInitial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOHASEB.Views.GUIs.InventoryManagment
{
    public partial class frm_Inventory_Managment : DevExpress.XtraEditors.XtraForm
    {
        public frm_Inventory_Managment()
        {
            InitializeComponent();
        }

       
        private void Element_Click(object sender, EventArgs e)
        {
            AccordionControlElement element = sender as AccordionControlElement;
            if (element != null)
            {
                var ins = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == element.Tag.ToString());
                if (ins != null)
                {
                    var control = Activator.CreateInstance(ins) as XtraUserControl;
                    pages1.AddPage(element.Text.ToString(), control);
                }
            }
        }

        private void pages1_Load(object sender, EventArgs e)
        {

        }
    }
}
