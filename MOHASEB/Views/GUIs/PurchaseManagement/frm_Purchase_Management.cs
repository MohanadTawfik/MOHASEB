using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using MOHASEB.Views.Components.PurchaseManagement.Operations;

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

namespace MOHASEB.Views.GUIs.PurchaseManagement
{
    public partial class frm_Purchase_Management : DevExpress.XtraEditors.XtraForm
    {
        public frm_Purchase_Management()
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
    }
}
