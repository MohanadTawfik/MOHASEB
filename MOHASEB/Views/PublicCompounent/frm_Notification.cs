using MOHASEB.Properties;
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

namespace MOHASEB.Views.PublicCompounent
{
    public partial class frm_Notification : DevExpress.XtraEditors.XtraForm
    {
        
        
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

        public frm_Notification()
        {
            // blur background
            //BlurEffect.EnableBlur(this);
            //BackColor = Color.Azure;
            //TransparencyKey = Color.Azure;
            InitializeComponent();
            //guna2ShadowForm.SetShadowForm( this );

            this.Width = lbl_message.Width * 2 + 10 + panel2.Width + panel3.Width + panel1.Width ;
        }

       


        // show and close Alert
        public enum AlertAction 
        {
            Start,
            Wait,
            Close
        }    
        public enum AlertType
        {
            success,
            Error,
            Warning,
            Info
        }


        private AlertAction action;
        private int x, y;
        public void ShowAlert(string message , AlertType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 0; i < 10; i++)
            {
                fname = "Notification" + i.ToString();
                frm_Notification notification = (frm_Notification)Application.OpenForms[fname];

                if(notification == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - 100 - this.Height * i - 5 * i;

                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case AlertType.success:
                    pb_Icon.Image = Resources.success;
                    break;
                case AlertType.Error:
                    pb_Icon.Image = Resources.error;
                    break;
                case AlertType.Warning:
                    pb_Icon.Image = Resources.warning;
                    break;
                case AlertType.Info:
                    pb_Icon.Image = Resources.info;
                    break;
                default:
                    break;
            }

            this.lbl_message.Text = message;
            this.Show();
            this.action = AlertAction.Start;

            this.timer.Interval = 1;
            this.timer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case AlertAction.Start:
                    this.timer.Interval = 1;
                    this.Opacity += 0.1;
                    if(this.x < this.Location.X) 
                    {
                        this.Left--;
                    }
                    else
                    {
                        if(this.Opacity == 1.0)
                        {
                            this.action = AlertAction.Wait;
                        }
                    }
                    break;
                case AlertAction.Wait:
                    this.timer.Interval = 3000;
                    this.action = AlertAction.Close;
                    break;
                case AlertAction.Close:
                    this.timer.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if(base.Opacity == 0.0)
                    {

                        this.Close();
                    }
                    break;
                default:
                    break;
            }
        }

        private void frm_Notification_Load(object sender, EventArgs e)
        {
            // rounded border
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }

        private void frm_Notification_Resize(object sender, EventArgs e)
        {
            // rounded border
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }

        private void Close_Click(object sender, EventArgs e)
        {
            timer.Interval = 1;
            action = AlertAction.Close;
        }

    }
}
