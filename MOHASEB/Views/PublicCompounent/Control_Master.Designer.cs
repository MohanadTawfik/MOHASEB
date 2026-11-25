namespace MOHASEB.Views.PublicCompounent
{
    partial class Control_Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Master));
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.buttons_master_card = new Bunifu.Framework.UI.BunifuCards();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_return = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.buttons_master_panal = new System.Windows.Forms.Panel();
            this.buttons_master_card.SuspendLayout();
            this.buttons_master_panal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.Appearance.Options.UseForeColor = true;
            this.btn_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_add.ImageOptions.SvgImage")));
            this.btn_add.Location = new System.Drawing.Point(585, 11);
            this.btn_add.Margin = new System.Windows.Forms.Padding(6);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 39);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "إظافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // buttons_master_card
            // 
            this.buttons_master_card.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttons_master_card.BackColor = System.Drawing.SystemColors.Control;
            this.buttons_master_card.BorderRadius = 7;
            this.buttons_master_card.BottomSahddow = true;
            this.buttons_master_card.color = System.Drawing.Color.RoyalBlue;
            this.buttons_master_card.Controls.Add(this.btn_edit);
            this.buttons_master_card.Controls.Add(this.btn_save);
            this.buttons_master_card.Controls.Add(this.btn_add);
            this.buttons_master_card.Controls.Add(this.btn_delete);
            this.buttons_master_card.Controls.Add(this.btn_return);
            this.buttons_master_card.Controls.Add(this.btn_print);
            this.buttons_master_card.LeftSahddow = true;
            this.buttons_master_card.Location = new System.Drawing.Point(202, 2);
            this.buttons_master_card.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttons_master_card.Name = "buttons_master_card";
            this.buttons_master_card.RightSahddow = true;
            this.buttons_master_card.ShadowDepth = 30;
            this.buttons_master_card.Size = new System.Drawing.Size(704, 57);
            this.buttons_master_card.TabIndex = 26;
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_edit.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.btn_edit.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_edit.Appearance.Options.UseFont = true;
            this.btn_edit.Appearance.Options.UseForeColor = true;
            this.btn_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.Image")));
            this.btn_edit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_edit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_edit.Location = new System.Drawing.Point(471, 11);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(105, 39);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_save.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.btn_save.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.Appearance.Options.UseForeColor = true;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_save.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(15, 11);
            this.btn_save.Margin = new System.Windows.Forms.Padding(6);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(105, 39);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "حفط";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delete.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.Appearance.Options.UseForeColor = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_delete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_delete.Location = new System.Drawing.Point(357, 11);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(105, 39);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_return
            // 
            this.btn_return.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_return.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.btn_return.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_return.Appearance.Options.UseFont = true;
            this.btn_return.Appearance.Options.UseForeColor = true;
            this.btn_return.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_return.ImageOptions.Image")));
            this.btn_return.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_return.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_return.Location = new System.Drawing.Point(243, 11);
            this.btn_return.Margin = new System.Windows.Forms.Padding(6);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(105, 39);
            this.btn_return.TabIndex = 3;
            this.btn_return.Text = "تراجع";
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_print.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.btn_print.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_print.Appearance.Options.UseFont = true;
            this.btn_print.Appearance.Options.UseForeColor = true;
            this.btn_print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.ImageOptions.Image")));
            this.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_print.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_print.Location = new System.Drawing.Point(129, 11);
            this.btn_print.Margin = new System.Windows.Forms.Padding(6);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(105, 39);
            this.btn_print.TabIndex = 4;
            this.btn_print.Text = "طباعة";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // buttons_master_panal
            // 
            this.buttons_master_panal.Controls.Add(this.buttons_master_card);
            this.buttons_master_panal.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttons_master_panal.Location = new System.Drawing.Point(20, 20);
            this.buttons_master_panal.Name = "buttons_master_panal";
            this.buttons_master_panal.Size = new System.Drawing.Size(1108, 60);
            this.buttons_master_panal.TabIndex = 30;
            // 
            // Control_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttons_master_panal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1148, 68);
            this.Name = "Control_Master";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1148, 101);
            this.buttons_master_card.ResumeLayout(false);
            this.buttons_master_panal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_print;
        private DevExpress.XtraEditors.SimpleButton btn_return;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private Bunifu.Framework.UI.BunifuCards buttons_master_card;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private System.Windows.Forms.Panel buttons_master_panal;
    }
}
