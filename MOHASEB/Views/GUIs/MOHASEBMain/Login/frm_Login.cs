using MOHASEB.Views.PublicCompounent;
using MOHASEB.Views.GUIs.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOHASEB.Views.GUIs.MOHASEBMain.Login
{
    public partial class frm_Login : Form
    {
        #region 
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );
        #endregion

         Model.MOHASEB_DBEntities db = new Model.MOHASEB_DBEntities();
        public frm_Login()
        {
            InitializeComponent();        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            // rounded border
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }

        private void btn_ShutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode == )
            //{
            //    e.Handled = false; return;
            //}
        }

        private  void btn_Login_Click(object sender, EventArgs e)
        {
            var islogin = db.tbl_User.FirstOrDefault(x => x.U_Username == txt_username.Text && x.U_Password == txt_password.Text);
            if (islogin != null)
            {
                new frm_Main().Show();
                this.Hide();
            }
            else
            {
                new frm_Notification().ShowAlert("إسم المستخدم او كلمة المرور غير صحيحة",frm_Notification.AlertType.Error);
            }
        }
    }
}
