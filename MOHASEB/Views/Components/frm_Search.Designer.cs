namespace MOHASEB.Views.Components
{
    partial class frm_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Search));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.entityInstantFeedbackSource1 = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAcc_No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcc_ArName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.RoyalBlue;
            this.bunifuCards1.Controls.Add(this.gridControl);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(598, 462);
            this.bunifuCards1.TabIndex = 24;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.entityInstantFeedbackSource1;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(598, 462);
            this.gridControl.TabIndex = 22;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // entityInstantFeedbackSource1
            // 
            this.entityInstantFeedbackSource1.DefaultSorting = "Acc_No ASC";
            this.entityInstantFeedbackSource1.DesignTimeElementType = typeof(MOHASEB.Model.tbl_Account);
            this.entityInstantFeedbackSource1.KeyExpression = "Acc_No";
            // 
            // gridView
            // 
            this.gridView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.gridView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.RoyalBlue;
            this.gridView.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridView.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridView.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridView.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridView.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.DetailTip.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.DetailTip.Options.UseFont = true;
            this.gridView.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridView.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.Empty.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.Empty.Options.UseFont = true;
            this.gridView.Appearance.Empty.Options.UseTextOptions = true;
            this.gridView.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridView.Appearance.EvenRow.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView.Appearance.EvenRow.Options.UseFont = true;
            this.gridView.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridView.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridView.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridView.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.FilterPanel.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.FixedLine.BackColor = System.Drawing.Color.RoyalBlue;
            this.gridView.Appearance.FixedLine.BorderColor = System.Drawing.Color.RoyalBlue;
            this.gridView.Appearance.FixedLine.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.FixedLine.ForeColor = System.Drawing.Color.White;
            this.gridView.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView.Appearance.FixedLine.Options.UseBorderColor = true;
            this.gridView.Appearance.FixedLine.Options.UseFont = true;
            this.gridView.Appearance.FixedLine.Options.UseForeColor = true;
            this.gridView.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridView.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView.Appearance.FocusedCell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView.Appearance.FocusedCell.Options.UseBorderColor = true;
            this.gridView.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.White;
            this.gridView.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gridView.Appearance.FocusedRow.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.FooterPanel.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.GroupButton.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.GroupButton.Options.UseFont = true;
            this.gridView.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridView.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.GroupFooter.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.GroupPanel.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gridView.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gridView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gridView.Appearance.GroupRow.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView.Appearance.GroupRow.Options.UseFont = true;
            this.gridView.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridView.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.HorzLine.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.HorzLine.Options.UseFont = true;
            this.gridView.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.HotTrackedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.gridView.Appearance.HotTrackedRow.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.HotTrackedRow.Options.UseBackColor = true;
            this.gridView.Appearance.HotTrackedRow.Options.UseFont = true;
            this.gridView.Appearance.HotTrackedRow.Options.UseTextOptions = true;
            this.gridView.Appearance.HotTrackedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.HotTrackedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.gridView.Appearance.OddRow.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView.Appearance.OddRow.Options.UseFont = true;
            this.gridView.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridView.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.Preview.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.Preview.Options.UseFont = true;
            this.gridView.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.Row.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.Row.Options.UseFont = true;
            this.gridView.Appearance.Row.Options.UseTextOptions = true;
            this.gridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gridView.Appearance.RowSeparator.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridView.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.TopNewRow.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.VertLine.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.VertLine.Options.UseFont = true;
            this.gridView.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridView.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Cairo", 11.89565F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAcc_No,
            this.colAcc_ArName});
            this.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupPanelText = " ";
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsDetail.EnableMasterViewMode = false;
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Search;
            this.gridView.OptionsFind.Condition = DevExpress.Data.Filtering.FilterCondition.Contains;
            this.gridView.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView.OptionsFind.FindNullPrompt = "بحث";
            this.gridView.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gridView.OptionsFind.HighlightFindResults = false;
            this.gridView.OptionsFind.SearchInPreview = true;
            this.gridView.OptionsFind.ShowFindButton = false;
            this.gridView.OptionsMenu.EnableColumnMenu = false;
            this.gridView.OptionsMenu.EnableFooterMenu = false;
            this.gridView.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
            this.gridView.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.gridView.OptionsMenu.ShowSplitItem = false;
            this.gridView.OptionsMenu.ShowSummaryItemMode = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView.OptionsView.EnableAppearanceOddRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_RowClick);
            // 
            // colAcc_No
            // 
            this.colAcc_No.AppearanceHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.colAcc_No.AppearanceHeader.Options.UseBackColor = true;
            this.colAcc_No.Caption = "رقم الحساب";
            this.colAcc_No.FieldName = "Acc_No";
            this.colAcc_No.Name = "colAcc_No";
            this.colAcc_No.OptionsColumn.AllowEdit = false;
            this.colAcc_No.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAcc_No.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colAcc_No.OptionsColumn.AllowMove = false;
            this.colAcc_No.OptionsColumn.AllowShowHide = false;
            this.colAcc_No.OptionsColumn.AllowSize = false;
            this.colAcc_No.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAcc_No.OptionsColumn.ReadOnly = true;
            this.colAcc_No.OptionsFilter.AllowAutoFilter = false;
            this.colAcc_No.OptionsFilter.AllowFilter = false;
            this.colAcc_No.Visible = true;
            this.colAcc_No.VisibleIndex = 0;
            // 
            // colAcc_ArName
            // 
            this.colAcc_ArName.AppearanceHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.colAcc_ArName.AppearanceHeader.Options.UseBackColor = true;
            this.colAcc_ArName.Caption = "إسم الحساب";
            this.colAcc_ArName.FieldName = "Acc_ArName";
            this.colAcc_ArName.Name = "colAcc_ArName";
            this.colAcc_ArName.OptionsColumn.AllowEdit = false;
            this.colAcc_ArName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAcc_ArName.OptionsColumn.AllowMove = false;
            this.colAcc_ArName.OptionsColumn.AllowShowHide = false;
            this.colAcc_ArName.OptionsColumn.AllowSize = false;
            this.colAcc_ArName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAcc_ArName.OptionsColumn.ReadOnly = true;
            this.colAcc_ArName.OptionsFilter.AllowAutoFilter = false;
            this.colAcc_ArName.OptionsFilter.AllowFilter = false;
            this.colAcc_ArName.Visible = true;
            this.colAcc_ArName.VisibleIndex = 1;
            // 
            // frm_Search
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 462);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("LBC", 12F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frm_Search.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "frm_Search";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بحث";
            this.TopMost = true;
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource entityInstantFeedbackSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colAcc_No;
        private DevExpress.XtraGrid.Columns.GridColumn colAcc_ArName;
        public DevExpress.XtraGrid.GridControl gridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView;
    }
}