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
    public partial class HeaderPanel : DevExpress.XtraEditors.XtraUserControl
    {
        private string _titlename;



        public HeaderPanel()
        {
            InitializeComponent();
        }

        public string Titlename
        {
            get
            {
                return _titlename;
            }

            set
            {
                _titlename = value;
                HeaderTitle.Text = value;
            }
        }

        private void btn_ShutDown_Click(object sender, EventArgs e)
        {
           ParentForm.Close();
        }
    }
}
