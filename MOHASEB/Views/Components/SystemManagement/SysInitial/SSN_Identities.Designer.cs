namespace MOHASEB.Views.Components.SystemManagement.SysInitial
{
    partial class SSN_Identities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SSN_Identities));
            this.colIs_Stop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.entityInstantFeedbackSource1 = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSSN_ArName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSSN_EnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bunifuCards12 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_return = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.guna2GroupBox6 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.txt_ssn_en_name = new DevExpress.XtraEditors.TextEdit();
            this.txt_ssn_name = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chk_is_stop = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.bunifuCards12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.guna2GroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ssn_en_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ssn_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.guna2GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // colIs_Stop
            // 
            this.colIs_Stop.AppearanceHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.colIs_Stop.AppearanceHeader.Options.UseBackColor = true;
            this.colIs_Stop.Caption = "موقف";
            this.colIs_Stop.FieldName = "Is_Stop";
            this.colIs_Stop.MinWidth = 24;
            this.colIs_Stop.Name = "colIs_Stop";
            this.colIs_Stop.OptionsColumn.AllowEdit = false;
            this.colIs_Stop.OptionsColumn.AllowFocus = false;
            this.colIs_Stop.OptionsColumn.AllowMove = false;
            this.colIs_Stop.OptionsColumn.AllowShowHide = false;
            this.colIs_Stop.OptionsColumn.ReadOnly = true;
            this.colIs_Stop.Visible = true;
            this.colIs_Stop.VisibleIndex = 3;
            this.colIs_Stop.Width = 287;
            // 
            // entityInstantFeedbackSource1
            // 
            this.entityInstantFeedbackSource1.DefaultSorting = "Id ASC";
            this.entityInstantFeedbackSource1.DesignTimeElementType = typeof(MOHASEB.Model.tbl_SSN_TypeSet);
            this.entityInstantFeedbackSource1.KeyExpression = "Id";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = -1;
            this.gridBand1.Width = 360;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.entityInstantFeedbackSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(960, 325);
            this.gridControl1.TabIndex = 22;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.RoyalBlue;
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridView1.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.DetailTip.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.DetailTip.Options.UseFont = true;
            this.gridView1.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridView1.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Empty.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Empty.Options.UseFont = true;
            this.gridView1.Appearance.Empty.Options.UseTextOptions = true;
            this.gridView1.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.RoyalBlue;
            this.gridView1.Appearance.FixedLine.BorderColor = System.Drawing.Color.RoyalBlue;
            this.gridView1.Appearance.FixedLine.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FixedLine.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FixedLine.Options.UseBorderColor = true;
            this.gridView1.Appearance.FixedLine.Options.UseFont = true;
            this.gridView1.Appearance.FixedLine.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gridView1.Appearance.FocusedCell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupButton.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupButton.Options.UseFont = true;
            this.gridView1.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gridView1.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gridView1.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HorzLine.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HorzLine.Options.UseFont = true;
            this.gridView1.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HotTrackedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.HotTrackedRow.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HotTrackedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HotTrackedRow.Options.UseFont = true;
            this.gridView1.Appearance.HotTrackedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HotTrackedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HotTrackedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.gridView1.Appearance.OddRow.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseFont = true;
            this.gridView1.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView1.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gridView1.Appearance.RowSeparator.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView1.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridView1.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gridView1.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.VertLine.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.VertLine.Options.UseFont = true;
            this.gridView1.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSSN_ArName,
            this.colSSN_EnName,
            this.colIs_Stop});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "جدول أنواع الهويات";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
            this.gridView1.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.gridView1.OptionsMenu.ShowSplitItem = false;
            this.gridView1.OptionsMenu.ShowSummaryItemMode = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colId, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colId
            // 
            this.colId.AppearanceHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.colId.AppearanceHeader.Options.UseBackColor = true;
            this.colId.Caption = "الرقم";
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 24;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.AllowFocus = false;
            this.colId.OptionsColumn.AllowMove = false;
            this.colId.OptionsColumn.AllowShowHide = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 131;
            // 
            // colSSN_ArName
            // 
            this.colSSN_ArName.AppearanceHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.colSSN_ArName.AppearanceHeader.Options.UseBackColor = true;
            this.colSSN_ArName.Caption = "إسم الهوية";
            this.colSSN_ArName.FieldName = "SSN_ArName";
            this.colSSN_ArName.MinWidth = 24;
            this.colSSN_ArName.Name = "colSSN_ArName";
            this.colSSN_ArName.OptionsColumn.AllowEdit = false;
            this.colSSN_ArName.OptionsColumn.AllowFocus = false;
            this.colSSN_ArName.OptionsColumn.AllowMove = false;
            this.colSSN_ArName.OptionsColumn.AllowShowHide = false;
            this.colSSN_ArName.OptionsColumn.ReadOnly = true;
            this.colSSN_ArName.Visible = true;
            this.colSSN_ArName.VisibleIndex = 1;
            this.colSSN_ArName.Width = 274;
            // 
            // colSSN_EnName
            // 
            this.colSSN_EnName.AppearanceHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.colSSN_EnName.AppearanceHeader.Options.UseBackColor = true;
            this.colSSN_EnName.Caption = "الإسم الأجنبي";
            this.colSSN_EnName.FieldName = "SSN_EnName";
            this.colSSN_EnName.MinWidth = 24;
            this.colSSN_EnName.Name = "colSSN_EnName";
            this.colSSN_EnName.OptionsColumn.AllowEdit = false;
            this.colSSN_EnName.OptionsColumn.AllowFocus = false;
            this.colSSN_EnName.OptionsColumn.AllowMove = false;
            this.colSSN_EnName.OptionsColumn.AllowShowHide = false;
            this.colSSN_EnName.OptionsColumn.ReadOnly = true;
            this.colSSN_EnName.Visible = true;
            this.colSSN_EnName.VisibleIndex = 2;
            this.colSSN_EnName.Width = 274;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.RoyalBlue;
            this.bunifuCards1.Controls.Add(this.gridControl1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(20, 275);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(960, 325);
            this.bunifuCards1.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bunifuCards12);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(20, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(960, 79);
            this.panel5.TabIndex = 28;
            // 
            // bunifuCards12
            // 
            this.bunifuCards12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCards12.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCards12.BorderRadius = 7;
            this.bunifuCards12.BottomSahddow = true;
            this.bunifuCards12.color = System.Drawing.Color.RoyalBlue;
            this.bunifuCards12.Controls.Add(this.btn_edit);
            this.bunifuCards12.Controls.Add(this.btn_save);
            this.bunifuCards12.Controls.Add(this.btn_add);
            this.bunifuCards12.Controls.Add(this.btn_delete);
            this.bunifuCards12.Controls.Add(this.btn_print);
            this.bunifuCards12.Controls.Add(this.btn_return);
            this.bunifuCards12.LeftSahddow = true;
            this.bunifuCards12.Location = new System.Drawing.Point(127, 2);
            this.bunifuCards12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuCards12.Name = "bunifuCards12";
            this.bunifuCards12.RightSahddow = true;
            this.bunifuCards12.ShadowDepth = 30;
            this.bunifuCards12.Size = new System.Drawing.Size(677, 66);
            this.bunifuCards12.TabIndex = 100;
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
            this.btn_edit.Location = new System.Drawing.Point(448, 15);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(110, 36);
            this.btn_edit.TabIndex = 1;
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
            this.btn_save.Enabled = false;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_save.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(118, 15);
            this.btn_save.Margin = new System.Windows.Forms.Padding(5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 36);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "حفط";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            this.btn_add.Location = new System.Drawing.Point(558, 15);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 36);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "إظافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delete.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.Appearance.Options.UseForeColor = true;
            this.btn_delete.Enabled = false;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_delete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_delete.Location = new System.Drawing.Point(338, 15);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(110, 36);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_print.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.btn_print.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_print.Appearance.Options.UseFont = true;
            this.btn_print.Appearance.Options.UseForeColor = true;
            this.btn_print.Enabled = false;
            this.btn_print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.ImageOptions.Image")));
            this.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_print.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_print.Location = new System.Drawing.Point(8, 15);
            this.btn_print.Margin = new System.Windows.Forms.Padding(5);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(110, 36);
            this.btn_print.TabIndex = 4;
            this.btn_print.Text = "طباعة";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_return
            // 
            this.btn_return.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_return.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.btn_return.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_return.Appearance.Options.UseFont = true;
            this.btn_return.Appearance.Options.UseForeColor = true;
            this.btn_return.Enabled = false;
            this.btn_return.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_return.ImageOptions.Image")));
            this.btn_return.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_return.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_return.Location = new System.Drawing.Point(228, 15);
            this.btn_return.Margin = new System.Windows.Forms.Padding(5);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(110, 36);
            this.btn_return.TabIndex = 3;
            this.btn_return.Text = "تراجع";
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(20, 99);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.guna2GroupBox6);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.guna2GroupBox4);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(960, 176);
            this.splitContainer2.SplitterDistance = 446;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 45;
            // 
            // guna2GroupBox6
            // 
            this.guna2GroupBox6.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.guna2GroupBox6.BorderRadius = 20;
            this.guna2GroupBox6.Controls.Add(this.layoutControl3);
            this.guna2GroupBox6.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.guna2GroupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox6.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox6.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox6.Location = new System.Drawing.Point(10, 0);
            this.guna2GroupBox6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.guna2GroupBox6.Name = "guna2GroupBox6";
            this.guna2GroupBox6.ShadowDecoration.Parent = this.guna2GroupBox6;
            this.guna2GroupBox6.Size = new System.Drawing.Size(436, 164);
            this.guna2GroupBox6.TabIndex = 100;
            this.guna2GroupBox6.Text = "البيانات الرئيسية";
            this.guna2GroupBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // layoutControl3
            // 
            this.layoutControl3.Appearance.Control.Font = new System.Drawing.Font("LBC", 12F);
            this.layoutControl3.Appearance.Control.ForeColor = System.Drawing.SystemColors.ControlText;
            this.layoutControl3.Appearance.Control.Options.UseFont = true;
            this.layoutControl3.Appearance.Control.Options.UseForeColor = true;
            this.layoutControl3.Appearance.ControlDisabled.Font = new System.Drawing.Font("LBC", 12F);
            this.layoutControl3.Appearance.ControlDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.layoutControl3.Appearance.ControlDisabled.Options.UseFont = true;
            this.layoutControl3.Appearance.ControlDisabled.Options.UseForeColor = true;
            this.layoutControl3.Appearance.ControlDropDown.Font = new System.Drawing.Font("LBC", 12F);
            this.layoutControl3.Appearance.ControlDropDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.layoutControl3.Appearance.ControlDropDown.Options.UseFont = true;
            this.layoutControl3.Appearance.ControlDropDown.Options.UseForeColor = true;
            this.layoutControl3.Appearance.ControlDropDownHeader.Font = new System.Drawing.Font("LBC", 12F);
            this.layoutControl3.Appearance.ControlDropDownHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.layoutControl3.Appearance.ControlDropDownHeader.Options.UseFont = true;
            this.layoutControl3.Appearance.ControlDropDownHeader.Options.UseForeColor = true;
            this.layoutControl3.Appearance.ControlFocused.Font = new System.Drawing.Font("LBC", 12F);
            this.layoutControl3.Appearance.ControlFocused.ForeColor = System.Drawing.SystemColors.ControlText;
            this.layoutControl3.Appearance.ControlFocused.Options.UseFont = true;
            this.layoutControl3.Appearance.ControlFocused.Options.UseForeColor = true;
            this.layoutControl3.Appearance.ControlReadOnly.Font = new System.Drawing.Font("LBC", 12F);
            this.layoutControl3.Appearance.ControlReadOnly.ForeColor = System.Drawing.SystemColors.ControlText;
            this.layoutControl3.Appearance.ControlReadOnly.Options.UseFont = true;
            this.layoutControl3.Appearance.ControlReadOnly.Options.UseForeColor = true;
            this.layoutControl3.Appearance.DisabledLayoutGroupCaption.Font = new System.Drawing.Font("LBC", 12F);
            this.layoutControl3.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.layoutControl3.Appearance.DisabledLayoutGroupCaption.Options.UseFont = true;
            this.layoutControl3.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl3.Appearance.DisabledLayoutItem.Font = new System.Drawing.Font("LBC", 12F);
            this.layoutControl3.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.layoutControl3.Appearance.DisabledLayoutItem.Options.UseFont = true;
            this.layoutControl3.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl3.Controls.Add(this.txt_ssn_en_name);
            this.layoutControl3.Controls.Add(this.txt_ssn_name);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.layoutControl3.Location = new System.Drawing.Point(0, 0);
            this.layoutControl3.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 17, 650, 400);
            this.layoutControl3.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("LBC", 12F);
            this.layoutControl3.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl3.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("LBC", 12F);
            this.layoutControl3.OptionsPrint.AppearanceItem.Options.UseFont = true;
            this.layoutControl3.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("LBC", 12F);
            this.layoutControl3.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
            this.layoutControl3.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("LBC", 12F);
            this.layoutControl3.OptionsPrint.AppearanceItemText.Options.UseFont = true;
            this.layoutControl3.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl3.Root = this.layoutControlGroup2;
            this.layoutControl3.Size = new System.Drawing.Size(436, 164);
            this.layoutControl3.TabIndex = 2;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // txt_ssn_en_name
            // 
            this.txt_ssn_en_name.Enabled = false;
            this.txt_ssn_en_name.Location = new System.Drawing.Point(12, 120);
            this.txt_ssn_en_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ssn_en_name.Name = "txt_ssn_en_name";
            this.txt_ssn_en_name.Size = new System.Drawing.Size(293, 32);
            this.txt_ssn_en_name.StyleController = this.layoutControl3;
            this.txt_ssn_en_name.TabIndex = 7;
            // 
            // txt_ssn_name
            // 
            this.txt_ssn_name.Enabled = false;
            this.txt_ssn_name.Location = new System.Drawing.Point(12, 84);
            this.txt_ssn_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ssn_name.Name = "txt_ssn_name";
            this.txt_ssn_name.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txt_ssn_name.Properties.Appearance.Options.UseForeColor = true;
            this.txt_ssn_name.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txt_ssn_name.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txt_ssn_name.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black;
            this.txt_ssn_name.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.txt_ssn_name.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.txt_ssn_name.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txt_ssn_name.Size = new System.Drawing.Size(293, 32);
            this.txt_ssn_name.StyleController = this.layoutControl3;
            this.txt_ssn_name.TabIndex = 6;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem9,
            this.emptySpaceItem3});
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(436, 164);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("LBC", 12F);
            this.layoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem7.AppearanceItemCaptionDisabled.Font = new System.Drawing.Font("LBC", 12F);
            this.layoutControlItem7.AppearanceItemCaptionDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.layoutControlItem7.AppearanceItemCaptionDisabled.Options.UseFont = true;
            this.layoutControlItem7.AppearanceItemCaptionDisabled.Options.UseForeColor = true;
            this.layoutControlItem7.Control = this.txt_ssn_name;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem7.Name = "layoutControlItem1";
            this.layoutControlItem7.OptionsPrint.AppearanceItem.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem7.OptionsPrint.AppearanceItem.Options.UseForeColor = true;
            this.layoutControlItem7.OptionsPrint.AppearanceItemText.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem7.OptionsPrint.AppearanceItemText.Options.UseForeColor = true;
            this.layoutControlItem7.Size = new System.Drawing.Size(416, 36);
            this.layoutControlItem7.Text = "إسم الهوية";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(107, 26);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Font = new System.Drawing.Font("LBC", 12F);
            this.layoutControlItem9.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem9.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem9.AppearanceItemCaptionDisabled.Font = new System.Drawing.Font("LBC", 12F);
            this.layoutControlItem9.AppearanceItemCaptionDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.layoutControlItem9.AppearanceItemCaptionDisabled.Options.UseFont = true;
            this.layoutControlItem9.AppearanceItemCaptionDisabled.Options.UseForeColor = true;
            this.layoutControlItem9.Control = this.txt_ssn_en_name;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem9.Name = "layoutControlItem2";
            this.layoutControlItem9.Size = new System.Drawing.Size(416, 36);
            this.layoutControlItem9.Text = "الإسم الأجنبي";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(107, 26);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem1";
            this.emptySpaceItem3.Size = new System.Drawing.Size(416, 72);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.guna2GroupBox4.BorderRadius = 20;
            this.guna2GroupBox4.Controls.Add(this.chk_is_stop);
            this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.guna2GroupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox4.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox4.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.ShadowDecoration.Parent = this.guna2GroupBox4;
            this.guna2GroupBox4.Size = new System.Drawing.Size(501, 114);
            this.guna2GroupBox4.TabIndex = 21;
            this.guna2GroupBox4.Text = "إعدادات الهويات";
            this.guna2GroupBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chk_is_stop
            // 
            this.chk_is_stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_is_stop.Animated = true;
            this.chk_is_stop.AutoSize = true;
            this.chk_is_stop.BackColor = System.Drawing.Color.White;
            this.chk_is_stop.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_is_stop.CheckedState.BorderRadius = 3;
            this.chk_is_stop.CheckedState.BorderThickness = 0;
            this.chk_is_stop.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_is_stop.Enabled = false;
            this.chk_is_stop.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_is_stop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk_is_stop.Location = new System.Drawing.Point(273, 57);
            this.chk_is_stop.Margin = new System.Windows.Forms.Padding(5);
            this.chk_is_stop.Name = "chk_is_stop";
            this.chk_is_stop.Size = new System.Drawing.Size(185, 30);
            this.chk_is_stop.TabIndex = 24;
            this.chk_is_stop.Text = "حضر التعامل معها";
            this.chk_is_stop.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_is_stop.UncheckedState.BorderRadius = 3;
            this.chk_is_stop.UncheckedState.BorderThickness = 0;
            this.chk_is_stop.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_is_stop.UseVisualStyleBackColor = false;
            // 
            // SSN_Identities
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.panel5);
            this.Name = "SSN_Identities";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1000, 620);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.bunifuCards12.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.guna2GroupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_ssn_en_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ssn_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.guna2GroupBox4.ResumeLayout(false);
            this.guna2GroupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Data.Linq.EntityInstantFeedbackSource entityInstantFeedbackSource1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSSN_ArName;
        private DevExpress.XtraGrid.Columns.GridColumn colSSN_EnName;
        private DevExpress.XtraGrid.Columns.GridColumn colIs_Stop;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuCards bunifuCards12;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_print;
        private DevExpress.XtraEditors.SimpleButton btn_return;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox6;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraEditors.TextEdit txt_ssn_en_name;
        private DevExpress.XtraEditors.TextEdit txt_ssn_name;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2CheckBox chk_is_stop;
    }
}
