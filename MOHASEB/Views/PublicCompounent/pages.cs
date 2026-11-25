using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOHASEB.Views.PublicCompounent
{
    public partial class pages : XtraUserControl
    {
        public pages()
        {
            InitializeComponent();
        }

     

        private void tabPages_CloseButtonClick(object sender, EventArgs e)
        {
            // عند أغلاق الصفحة يتم تحديد الصفحة الأخيرة ونريد أن يتم تحديد الصفحة التي كانت محددة قبل فتح الجديدة
            if (tabPages.SelectedTabPage != main)
            {
                tabPages.TabPages.Remove(tabPages.SelectedTabPage);
                tabPages.SelectedTabPage = tabPages.TabPages.Last();
            }
        }

        public void AddPage(string pagetext, XtraUserControl control)
        {
           foreach (XtraTabPage page1 in tabPages.TabPages)
            {
                if(page1.Text == pagetext)
                {
                    tabPages.SelectedTabPage = page1;
                    return;
                }
            }
            XtraTabPage page = new XtraTabPage { Text = pagetext };
            control.Dock = DockStyle.Fill;
            page.Controls.Add(control);
            tabPages.SelectedTabPage = page;
            tabPages.TabPages.Add(page);
        }
    }
}
