namespace MOHASEB.Views.PublicCompounent
{
    partial class pages
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPages = new DevExpress.XtraTab.XtraTabControl();
            this.main = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabPages)).BeginInit();
            this.tabPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPages
            // 
            this.tabPages.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.tabPages.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.tabPages.Appearance.Options.UseBackColor = true;
            this.tabPages.Appearance.Options.UseFont = true;
            this.tabPages.AppearancePage.Header.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.tabPages.AppearancePage.Header.Options.UseFont = true;
            this.tabPages.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.tabPages.AppearancePage.HeaderActive.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.tabPages.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.tabPages.AppearancePage.HeaderActive.Options.UseFont = true;
            this.tabPages.AppearancePage.HeaderDisabled.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.tabPages.AppearancePage.HeaderDisabled.Options.UseFont = true;
            this.tabPages.AppearancePage.HeaderHotTracked.BackColor = System.Drawing.Color.White;
            this.tabPages.AppearancePage.HeaderHotTracked.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.tabPages.AppearancePage.HeaderHotTracked.Options.UseBackColor = true;
            this.tabPages.AppearancePage.HeaderHotTracked.Options.UseFont = true;
            this.tabPages.AppearancePage.PageClient.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.tabPages.AppearancePage.PageClient.Options.UseFont = true;
            this.tabPages.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.tabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPages.HeaderButtons = DevExpress.XtraTab.TabButtons.None;
            this.tabPages.Location = new System.Drawing.Point(0, 0);
            this.tabPages.Margin = new System.Windows.Forms.Padding(4);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedTabPage = this.main;
            this.tabPages.Size = new System.Drawing.Size(1060, 647);
            this.tabPages.TabIndex = 24;
            this.tabPages.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.main});
            this.tabPages.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.True;
            this.tabPages.CloseButtonClick += new System.EventHandler(this.tabPages_CloseButtonClick);
            // 
            // main
            // 
            this.main.AllowTouchScroll = true;
            this.main.FireScrollEventOnMouseWheel = true;
            this.main.InvertTouchScroll = true;
            this.main.Margin = new System.Windows.Forms.Padding(4);
            this.main.Name = "main";
            this.main.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.main.Size = new System.Drawing.Size(1058, 607);
            this.main.Text = "الرئيسية";
            this.main.Tooltip = "الصفحة الرئيسية";
            this.main.TooltipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // pages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPages);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "pages";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1060, 647);
            ((System.ComponentModel.ISupportInitialize)(this.tabPages)).EndInit();
            this.tabPages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabPage main;
        internal DevExpress.XtraTab.XtraTabControl tabPages;
    }
}
