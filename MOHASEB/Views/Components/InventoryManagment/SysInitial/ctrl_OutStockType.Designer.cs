namespace MOHASEB.Views.Components.InventoryManagment.SysInitial
{
    partial class ctrl_OutStockType
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
            this.components = new System.ComponentModel.Container();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.entityInstantFeedbackSource1 = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIType_No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIType_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.guna2GroupBox6 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.txt_type_name = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.sysdiagramsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.guna2GroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_type_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysdiagramsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.RoyalBlue;
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(10, 92);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1128, 618);
            this.bunifuCards1.TabIndex = 47;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sysdiagramsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.gridControl1.Location = new System.Drawing.Point(10, 259);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1128, 451);
            this.gridControl1.TabIndex = 22;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // entityInstantFeedbackSource1
            // 
            this.entityInstantFeedbackSource1.DefaultSorting = "OutStockType_No ASC";
            this.entityInstantFeedbackSource1.DesignTimeElementType = typeof(MOHASEB.Model.tbl_Out_Stock_Type);
            this.entityInstantFeedbackSource1.KeyExpression = "OutStockType_No";
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
            this.colIType_No,
            this.colIType_Name});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "أنواع أوامر الصرف";
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
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colIType_No
            // 
            this.colIType_No.AppearanceHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.colIType_No.AppearanceHeader.Options.UseBackColor = true;
            this.colIType_No.Caption = "الرقم";
            this.colIType_No.FieldName = "OutStockType_No";
            this.colIType_No.MinWidth = 25;
            this.colIType_No.Name = "colIType_No";
            this.colIType_No.OptionsColumn.AllowEdit = false;
            this.colIType_No.OptionsColumn.AllowMove = false;
            this.colIType_No.OptionsColumn.AllowSize = false;
            this.colIType_No.OptionsColumn.ReadOnly = true;
            this.colIType_No.Visible = true;
            this.colIType_No.VisibleIndex = 0;
            this.colIType_No.Width = 94;
            // 
            // colIType_Name
            // 
            this.colIType_Name.AppearanceHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.colIType_Name.AppearanceHeader.Options.UseBackColor = true;
            this.colIType_Name.Caption = "إسم النوع";
            this.colIType_Name.FieldName = "OutStockType_Name";
            this.colIType_Name.MinWidth = 25;
            this.colIType_Name.Name = "colIType_Name";
            this.colIType_Name.OptionsColumn.AllowEdit = false;
            this.colIType_Name.OptionsColumn.AllowMove = false;
            this.colIType_Name.OptionsColumn.AllowSize = false;
            this.colIType_Name.OptionsColumn.ReadOnly = true;
            this.colIType_Name.Visible = true;
            this.colIType_Name.VisibleIndex = 1;
            this.colIType_Name.Width = 94;
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
            this.guna2GroupBox6.Location = new System.Drawing.Point(10, 92);
            this.guna2GroupBox6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.guna2GroupBox6.Name = "guna2GroupBox6";
            this.guna2GroupBox6.ShadowDecoration.Parent = this.guna2GroupBox6;
            this.guna2GroupBox6.Size = new System.Drawing.Size(1128, 147);
            this.guna2GroupBox6.TabIndex = 101;
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
            this.layoutControl3.Controls.Add(this.txt_type_name);
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
            this.layoutControl3.Size = new System.Drawing.Size(1128, 147);
            this.layoutControl3.TabIndex = 2;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // txt_type_name
            // 
            this.txt_type_name.Enabled = false;
            this.txt_type_name.Location = new System.Drawing.Point(16, 87);
            this.txt_type_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_type_name.Name = "txt_type_name";
            this.txt_type_name.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txt_type_name.Properties.Appearance.Options.UseForeColor = true;
            this.txt_type_name.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txt_type_name.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txt_type_name.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black;
            this.txt_type_name.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.txt_type_name.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.txt_type_name.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txt_type_name.Size = new System.Drawing.Size(1001, 44);
            this.txt_type_name.StyleController = this.layoutControl3;
            this.txt_type_name.TabIndex = 6;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.emptySpaceItem3});
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1128, 147);
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
            this.layoutControlItem7.Control = this.txt_type_name;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 71);
            this.layoutControlItem7.Name = "layoutControlItem1";
            this.layoutControlItem7.OptionsPrint.AppearanceItem.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem7.OptionsPrint.AppearanceItem.Options.UseForeColor = true;
            this.layoutControlItem7.OptionsPrint.AppearanceItemText.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem7.OptionsPrint.AppearanceItemText.Options.UseForeColor = true;
            this.layoutControlItem7.Size = new System.Drawing.Size(1102, 50);
            this.layoutControlItem7.Text = "إسم النوع";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(79, 26);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem1";
            this.emptySpaceItem3.Size = new System.Drawing.Size(1102, 71);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatorControl1.Location = new System.Drawing.Point(10, 239);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(1128, 20);
            this.separatorControl1.TabIndex = 7;
            // 
            // sysdiagramsBindingSource
            // 
            this.sysdiagramsBindingSource.DataSource = typeof(MOHASEB.Model.sysdiagrams);
            // 
            // ctrl_OutStockType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.guna2GroupBox6);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "ctrl_OutStockType";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1148, 720);
            this.Controls.SetChildIndex(this.bunifuCards1, 0);
            this.Controls.SetChildIndex(this.guna2GroupBox6, 0);
            this.Controls.SetChildIndex(this.separatorControl1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.guna2GroupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_type_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysdiagramsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIType_No;
        private DevExpress.XtraGrid.Columns.GridColumn colIType_Name;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox6;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraEditors.TextEdit txt_type_name;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource entityInstantFeedbackSource1;
        private System.Windows.Forms.BindingSource sysdiagramsBindingSource;
    }
}
