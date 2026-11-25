namespace MOHASEB.Views.PublicCompounent
{
    partial class frm_Notification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Notification));
            this.lbl_message = new Guna.UI.WinForms.GunaLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb_Icon = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.loading = new Guna.UI.WinForms.GunaWinCircleProgressIndicator();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_message
            // 
            this.lbl_message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_message.Font = new System.Drawing.Font("LBC", 12F);
            this.lbl_message.ForeColor = System.Drawing.Color.White;
            this.lbl_message.Location = new System.Drawing.Point(42, 0);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_message.Size = new System.Drawing.Size(158, 70);
            this.lbl_message.TabIndex = 21;
            this.lbl_message.Text = "نص رسالة التنبيه";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_message.Click += new System.EventHandler(this.Close_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(253, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 70);
            this.panel1.TabIndex = 24;
            this.panel1.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pb_Icon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(42, 70);
            this.panel2.TabIndex = 28;
            this.panel2.Click += new System.EventHandler(this.Close_Click);
            // 
            // pb_Icon
            // 
            this.pb_Icon.Image = ((System.Drawing.Image)(resources.GetObject("pb_Icon.Image")));
            this.pb_Icon.Location = new System.Drawing.Point(3, 11);
            this.pb_Icon.Name = "pb_Icon";
            this.pb_Icon.Size = new System.Drawing.Size(37, 48);
            this.pb_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Icon.TabIndex = 24;
            this.pb_Icon.TabStop = false;
            this.pb_Icon.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.loading);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(53, 70);
            this.panel3.TabIndex = 29;
            // 
            // loading
            // 
            this.loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loading.Location = new System.Drawing.Point(1, 10);
            this.loading.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.loading.Name = "loading";
            this.loading.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.loading.Size = new System.Drawing.Size(50, 50);
            this.loading.TabIndex = 31;
            // 
            // frm_Notification
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(260, 70);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Notification";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_Notification_Load);
            this.Resize += new System.EventHandler(this.frm_Notification_Resize);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel lbl_message;
        internal System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb_Icon;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaWinCircleProgressIndicator loading;
    }
}