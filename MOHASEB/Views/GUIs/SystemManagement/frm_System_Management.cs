using DevExpress.Utils.CodedUISupport;
using DevExpress.XtraPrinting.Export.Pdf;
using DevExpress.XtraTab;
using MOHASEB.Views.Components.SystemManagement.SysInitial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOHASEB.Views.GUIs.SystemManagement
{
    public partial class Frm_System_Management : DevExpress.XtraEditors.XtraForm
    {



        public Frm_System_Management()
        {
            InitializeComponent();
        }
        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
        }

        private void accordionControlElement46_Click(object sender, EventArgs e)
        {
           pages1.AddPage(accordionControlElement46.Text,new ctrl_Currencies());
        }

        private void accordionControlElement54_Click(object sender, EventArgs e)
        {
            pages1.AddPage(accordionControlElement54.Text, new SSN_Identities());
        }

        private void accordionControlElement59_Click(object sender, EventArgs e)
        {
            pages1.AddPage(accordionControlElement59.Text, new Company());
        }

        private void accordionControlElement56_Click(object sender, EventArgs e)
        {
            pages1.AddPage(accordionControlElement56.Text, new Customers());
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_System_Management_Load(object sender, EventArgs e)
        {
           
        }
    }
}
