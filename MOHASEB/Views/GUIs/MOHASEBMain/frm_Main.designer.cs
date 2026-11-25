namespace MOHASEB.Views.GUIs.Main
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Dashboard = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btn_StockManage = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btn_SalseManage = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btn_AccManage = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btn_PurcheManage = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btn_SysManage = new Guna.UI.WinForms.GunaGradientTileButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerPanel1 = new MOHASEB.Views.PublicCompounent.HeaderPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Dashboard);
            this.panel1.Controls.Add(this.btn_StockManage);
            this.panel1.Controls.Add(this.btn_SalseManage);
            this.panel1.Controls.Add(this.btn_AccManage);
            this.panel1.Controls.Add(this.btn_PurcheManage);
            this.panel1.Controls.Add(this.btn_SysManage);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 650);
            this.panel1.TabIndex = 16;
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Dashboard.Animated = true;
            this.btn_Dashboard.AnimationHoverSpeed = 0.1F;
            this.btn_Dashboard.AnimationSpeed = 0.3F;
            this.btn_Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_Dashboard.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_Dashboard.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btn_Dashboard.BorderColor = System.Drawing.Color.Black;
            this.btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Dashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Dashboard.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_Dashboard.Image = global::MOHASEB.Properties.Resources.dashboard;
            this.btn_Dashboard.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_Dashboard.Location = new System.Drawing.Point(155, 436);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btn_Dashboard.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_Dashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Dashboard.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Dashboard.OnHoverImage = null;
            this.btn_Dashboard.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Dashboard.Radius = 40;
            this.btn_Dashboard.Size = new System.Drawing.Size(300, 150);
            this.btn_Dashboard.TabIndex = 2;
            this.btn_Dashboard.Text = "Dashboard | لوحة التحكم";
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // btn_StockManage
            // 
            this.btn_StockManage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_StockManage.Animated = true;
            this.btn_StockManage.AnimationHoverSpeed = 0.1F;
            this.btn_StockManage.AnimationSpeed = 0.3F;
            this.btn_StockManage.BackColor = System.Drawing.Color.Transparent;
            this.btn_StockManage.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_StockManage.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btn_StockManage.BorderColor = System.Drawing.Color.Black;
            this.btn_StockManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StockManage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_StockManage.FocusedColor = System.Drawing.Color.Empty;
            this.btn_StockManage.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.btn_StockManage.ForeColor = System.Drawing.Color.White;
            this.btn_StockManage.Image = global::MOHASEB.Properties.Resources.price_tag;
            this.btn_StockManage.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_StockManage.Location = new System.Drawing.Point(155, 247);
            this.btn_StockManage.Name = "btn_StockManage";
            this.btn_StockManage.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btn_StockManage.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_StockManage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_StockManage.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_StockManage.OnHoverImage = null;
            this.btn_StockManage.OnPressedColor = System.Drawing.Color.Black;
            this.btn_StockManage.Radius = 40;
            this.btn_StockManage.Size = new System.Drawing.Size(300, 150);
            this.btn_StockManage.TabIndex = 2;
            this.btn_StockManage.Text = "إدارة المخزون والجرد";
            this.btn_StockManage.Click += new System.EventHandler(this.btn_StockManage_Click);
            // 
            // btn_SalseManage
            // 
            this.btn_SalseManage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SalseManage.Animated = true;
            this.btn_SalseManage.AnimationHoverSpeed = 0.1F;
            this.btn_SalseManage.AnimationSpeed = 0.3F;
            this.btn_SalseManage.BackColor = System.Drawing.Color.Transparent;
            this.btn_SalseManage.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_SalseManage.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btn_SalseManage.BorderColor = System.Drawing.Color.Black;
            this.btn_SalseManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SalseManage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_SalseManage.FocusedColor = System.Drawing.Color.Empty;
            this.btn_SalseManage.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.btn_SalseManage.ForeColor = System.Drawing.Color.White;
            this.btn_SalseManage.Image = global::MOHASEB.Properties.Resources.land_sales;
            this.btn_SalseManage.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_SalseManage.Location = new System.Drawing.Point(489, 436);
            this.btn_SalseManage.Name = "btn_SalseManage";
            this.btn_SalseManage.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btn_SalseManage.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_SalseManage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_SalseManage.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_SalseManage.OnHoverImage = null;
            this.btn_SalseManage.OnPressedColor = System.Drawing.Color.Black;
            this.btn_SalseManage.Radius = 40;
            this.btn_SalseManage.Size = new System.Drawing.Size(300, 150);
            this.btn_SalseManage.TabIndex = 2;
            this.btn_SalseManage.Text = "إدارة المبيعات والعملاء";
            this.btn_SalseManage.Click += new System.EventHandler(this.btn_SalseManage_Click);
            // 
            // btn_AccManage
            // 
            this.btn_AccManage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_AccManage.Animated = true;
            this.btn_AccManage.AnimationHoverSpeed = 0.1F;
            this.btn_AccManage.AnimationSpeed = 0.3F;
            this.btn_AccManage.BackColor = System.Drawing.Color.Transparent;
            this.btn_AccManage.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_AccManage.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btn_AccManage.BorderColor = System.Drawing.Color.Black;
            this.btn_AccManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AccManage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_AccManage.FocusedColor = System.Drawing.Color.Empty;
            this.btn_AccManage.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.btn_AccManage.ForeColor = System.Drawing.Color.White;
            this.btn_AccManage.Image = global::MOHASEB.Properties.Resources.accounts;
            this.btn_AccManage.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_AccManage.Location = new System.Drawing.Point(489, 247);
            this.btn_AccManage.Name = "btn_AccManage";
            this.btn_AccManage.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btn_AccManage.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_AccManage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_AccManage.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_AccManage.OnHoverImage = null;
            this.btn_AccManage.OnPressedColor = System.Drawing.Color.Black;
            this.btn_AccManage.Radius = 40;
            this.btn_AccManage.Size = new System.Drawing.Size(300, 150);
            this.btn_AccManage.TabIndex = 2;
            this.btn_AccManage.Text = "إدارة الحسابات";
            this.btn_AccManage.Click += new System.EventHandler(this.btn_AccManage_Click);
            // 
            // btn_PurcheManage
            // 
            this.btn_PurcheManage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_PurcheManage.Animated = true;
            this.btn_PurcheManage.AnimationHoverSpeed = 0.1F;
            this.btn_PurcheManage.AnimationSpeed = 0.3F;
            this.btn_PurcheManage.BackColor = System.Drawing.Color.Transparent;
            this.btn_PurcheManage.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_PurcheManage.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btn_PurcheManage.BorderColor = System.Drawing.Color.Black;
            this.btn_PurcheManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PurcheManage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_PurcheManage.FocusedColor = System.Drawing.Color.Empty;
            this.btn_PurcheManage.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.btn_PurcheManage.ForeColor = System.Drawing.Color.White;
            this.btn_PurcheManage.Image = global::MOHASEB.Properties.Resources.shopping_card;
            this.btn_PurcheManage.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_PurcheManage.Location = new System.Drawing.Point(826, 436);
            this.btn_PurcheManage.Name = "btn_PurcheManage";
            this.btn_PurcheManage.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btn_PurcheManage.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_PurcheManage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_PurcheManage.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_PurcheManage.OnHoverImage = null;
            this.btn_PurcheManage.OnPressedColor = System.Drawing.Color.Black;
            this.btn_PurcheManage.Radius = 40;
            this.btn_PurcheManage.Size = new System.Drawing.Size(300, 150);
            this.btn_PurcheManage.TabIndex = 2;
            this.btn_PurcheManage.Text = "إدارة المشتريات والموردين";
            this.btn_PurcheManage.Click += new System.EventHandler(this.btn_PurcheManage_Click);
            // 
            // btn_SysManage
            // 
            this.btn_SysManage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SysManage.Animated = true;
            this.btn_SysManage.AnimationHoverSpeed = 0.1F;
            this.btn_SysManage.AnimationSpeed = 0.3F;
            this.btn_SysManage.BackColor = System.Drawing.Color.Transparent;
            this.btn_SysManage.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_SysManage.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btn_SysManage.BorderColor = System.Drawing.Color.Black;
            this.btn_SysManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SysManage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_SysManage.FocusedColor = System.Drawing.Color.Empty;
            this.btn_SysManage.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.btn_SysManage.ForeColor = System.Drawing.Color.White;
            this.btn_SysManage.Image = global::MOHASEB.Properties.Resources.settings;
            this.btn_SysManage.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_SysManage.Location = new System.Drawing.Point(826, 247);
            this.btn_SysManage.Name = "btn_SysManage";
            this.btn_SysManage.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btn_SysManage.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_SysManage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_SysManage.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_SysManage.OnHoverImage = null;
            this.btn_SysManage.OnPressedColor = System.Drawing.Color.Black;
            this.btn_SysManage.Radius = 40;
            this.btn_SysManage.Size = new System.Drawing.Size(300, 150);
            this.btn_SysManage.TabIndex = 2;
            this.btn_SysManage.Text = "إدارة النظام";
            this.btn_SysManage.Click += new System.EventHandler(this.btn_SysManag_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(530, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // headerPanel1
            // 
            this.headerPanel1.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.headerPanel1.Appearance.Options.UseFont = true;
            this.headerPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel1.Location = new System.Drawing.Point(0, 0);
            this.headerPanel1.Name = "headerPanel1";
            this.headerPanel1.Size = new System.Drawing.Size(1280, 70);
            this.headerPanel1.TabIndex = 4;
            this.headerPanel1.Titlename = "محاسب | الصفحة الرئيسية";
            // 
            // frm_Main
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerPanel1);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frm_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محاسب | الصفحة الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaGradientTileButton btn_Dashboard;
        private Guna.UI.WinForms.GunaGradientTileButton btn_StockManage;
        private Guna.UI.WinForms.GunaGradientTileButton btn_SalseManage;
        private Guna.UI.WinForms.GunaGradientTileButton btn_AccManage;
        private Guna.UI.WinForms.GunaGradientTileButton btn_PurcheManage;
        private Guna.UI.WinForms.GunaGradientTileButton btn_SysManage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PublicCompounent.HeaderPanel headerPanel1;
    }
}