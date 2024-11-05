namespace StudentWindowsFormsApp.Views.employeeView {
    partial class employeeView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		 #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroupLayout = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiCustomize = new DevExpress.XtraBars.BarButtonItem();
						this.assignmentsGridControl = new DevExpress.XtraGrid.GridControl();
			this.assignmentsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.assignmentsBarManager = new DevExpress.XtraBars.BarManager();
			this.assignmentsBar = new DevExpress.XtraBars.Bar();
			this.assignmentsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.assignmentsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiassignmentsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiassignmentsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiassignmentsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiassignmentsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.assignmentsBarManager)).BeginInit();
						 
			this.SuspendLayout();
			// 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
			this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.bbiCustomize});
            this.mainRibbonControl.Name = "mainRibbonControl";
			this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
						DevExpress.XtraBars.BarButtonItem bbiSave = new DevExpress.XtraBars.BarButtonItem();
			bbiSave.Caption = "Save";
			bbiSave.Name = "bbiSave";
			bbiSave.ImageUri.Uri = "Save";
			this.mainRibbonControl.Items.Add(bbiSave);
						DevExpress.XtraBars.BarButtonItem bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
			bbiSaveAndClose.Caption = "Save And Close";
			bbiSaveAndClose.Name = "bbiSaveAndClose";
			bbiSaveAndClose.ImageUri.Uri = "SaveAndClose";
			this.mainRibbonControl.Items.Add(bbiSaveAndClose);
						DevExpress.XtraBars.BarButtonItem bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
			bbiSaveAndNew.Caption = "Save And New";
			bbiSaveAndNew.Name = "bbiSaveAndNew";
			bbiSaveAndNew.ImageUri.Uri = "SaveAndNew";
			this.mainRibbonControl.Items.Add(bbiSaveAndNew);
						DevExpress.XtraBars.BarButtonItem bbiReset = new DevExpress.XtraBars.BarButtonItem();
			bbiReset.Caption = "Reset Changes";
			bbiReset.Name = "bbiReset";
			bbiReset.ImageUri.Uri = "Reset";
			this.mainRibbonControl.Items.Add(bbiReset);
						DevExpress.XtraBars.BarButtonItem bbiDelete = new DevExpress.XtraBars.BarButtonItem();
			bbiDelete.Caption = "Delete";
			bbiDelete.Name = "bbiDelete";
			bbiDelete.ImageUri.Uri = "Delete";
			this.mainRibbonControl.Items.Add(bbiDelete);
						DevExpress.XtraBars.BarButtonItem bbiClose = new DevExpress.XtraBars.BarButtonItem();
			bbiClose.Caption = "Close";
			bbiClose.Name = "bbiClose";
			bbiClose.ImageUri.Uri = "Close";
			this.mainRibbonControl.Items.Add(bbiClose);
						DevExpress.XtraBars.BarButtonItem bbiSaveLayout = new DevExpress.XtraBars.BarButtonItem();
			bbiSaveLayout.Caption = "Save Layout";
			bbiSaveLayout.Name = "bbiSaveLayout";
			bbiSaveLayout.ImageUri.Uri = "Save";
			this.mainRibbonControl.Items.Add(bbiSaveLayout);
						DevExpress.XtraBars.BarButtonItem bbiResetLayout = new DevExpress.XtraBars.BarButtonItem();
			bbiResetLayout.Caption = "Reset Layout";
			bbiResetLayout.Name = "bbiResetLayout";
			bbiResetLayout.ImageUri.Uri = "Reset";
			this.mainRibbonControl.Items.Add(bbiResetLayout);
			            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup,
            this.ribbonPageGroupLayout});
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Home";
			this.mainRibbonPage.MergeOrder = 0;
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
						this.mainRibbonPageGroup.ItemLinks.Add(bbiSave);
						this.mainRibbonPageGroup.ItemLinks.Add(bbiSaveAndClose);
						this.mainRibbonPageGroup.ItemLinks.Add(bbiSaveAndNew);
						this.mainRibbonPageGroup.ItemLinks.Add(bbiReset);
						this.mainRibbonPageGroup.ItemLinks.Add(bbiDelete);
						this.mainRibbonPageGroup.ItemLinks.Add(bbiClose);
			            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "employee Tasks";
			// 
            // ribbonPageGroupLayout
            //
			this.ribbonPageGroupLayout.AllowTextClipping = false; 
			this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiCustomize);
						this.ribbonPageGroupLayout.ItemLinks.Add(bbiSaveLayout);
						this.ribbonPageGroupLayout.ItemLinks.Add(bbiResetLayout);
			            this.ribbonPageGroupLayout.Name = "ribbonPageGroupLayout";
            this.ribbonPageGroupLayout.Text = "Layout";
			// 
            // bbiCustomize
            // 
            this.bbiCustomize.Caption = "Customize";
            this.bbiCustomize.ImageUri.Uri = "Customization";
            this.bbiCustomize.Name = "bbiCustomize";
			// 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.TextVisible = false;
			// 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
			this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataLayoutControl1.Root = this.layoutControlGroup1;
			this.employeeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.employeeViewBindingSource.DataSource = typeof(StudentWindowsFormsApp.employee);
			this.dataLayoutControl1.DataSource = employeeViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
			parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
           				//
			//assignmentsGridControl
			//
			this.assignmentsGridControl.MainView = this.assignmentsGridView;
			this.assignmentsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignmentsGridControl.MenuManager = this.mainRibbonControl;
            this.assignmentsGridControl.Name = "assignmentsGridControl";
            this.assignmentsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.assignmentsGridView});
			//
			//assignmentsGridView
			//
            this.assignmentsGridView.GridControl = this.assignmentsGridControl;
            this.assignmentsGridView.Name = "assignmentsGridView";
            this.assignmentsGridView.OptionsBehavior.Editable = false;
            this.assignmentsGridView.OptionsBehavior.ReadOnly = true;
			//
			//assignmentsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters assignmentsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters departmentassignmentsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            departmentassignmentsChildPopulateColumnParameters_NotVisible.FieldName = "department";
		    departmentassignmentsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			assignmentsPopulateColumnsParameters.CustomColumnParameters.Add(departmentassignmentsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters employeeassignmentsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            employeeassignmentsChildPopulateColumnParameters_NotVisible.FieldName = "employee";
		    employeeassignmentsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			assignmentsPopulateColumnsParameters.CustomColumnParameters.Add(employeeassignmentsChildPopulateColumnParameters_NotVisible);
							
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters assignmentsassignmentsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            assignmentsassignmentsChildPopulateColumnParameters.FieldName = "assignmentsassignments";
            assignmentsassignmentsChildPopulateColumnParameters.Path = "assignments.createdby";
			assignmentsPopulateColumnsParameters.CustomColumnParameters.Add(assignmentsassignmentsChildPopulateColumnParameters);
			 
		    this.assignmentsGridView.PopulateColumns(typeof(StudentWindowsFormsApp.assignment),assignmentsPopulateColumnsParameters);
			//
			//assignmentsBindingSource
			//
			System.Windows.Forms.BindingSource assignmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			assignmentsBindingSource.DataSource = typeof(StudentWindowsFormsApp.assignment);
            this.assignmentsGridControl.DataSource = assignmentsBindingSource;
			//
			//assignmentsXtraUserControl
			//
            this.assignmentsXtraUserControl.Controls.Add(assignmentsGridControl);
			this.assignmentsXtraUserControl.Name = "assignmentsXtraUserControl";
			this.assignmentsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//assignmentsNew
			//
			this.bbiassignmentsNew.Caption = "New";
			this.bbiassignmentsNew.Name = "bbiassignmentsNew";
			this.bbiassignmentsNew.ImageUri.Uri = "New";
			this.bbiassignmentsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.assignmentsBarManager.Items.Add(this.bbiassignmentsNew);
			this.assignmentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiassignmentsNew));
			this.assignmentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiassignmentsNew));
						//
			//assignmentsEdit
			//
			this.bbiassignmentsEdit.Caption = "Edit";
			this.bbiassignmentsEdit.Name = "bbiassignmentsEdit";
			this.bbiassignmentsEdit.ImageUri.Uri = "Edit";
			this.bbiassignmentsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.assignmentsBarManager.Items.Add(this.bbiassignmentsEdit);
			this.assignmentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiassignmentsEdit));
			this.assignmentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiassignmentsEdit));
						//
			//assignmentsDelete
			//
			this.bbiassignmentsDelete.Caption = "Delete";
			this.bbiassignmentsDelete.Name = "bbiassignmentsDelete";
			this.bbiassignmentsDelete.ImageUri.Uri = "Delete";
			this.bbiassignmentsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.assignmentsBarManager.Items.Add(this.bbiassignmentsDelete);
			this.assignmentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiassignmentsDelete));
			this.assignmentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiassignmentsDelete));
						//
			//assignmentsRefresh
			//
			this.bbiassignmentsRefresh.Caption = "Refresh";
			this.bbiassignmentsRefresh.Name = "bbiassignmentsRefresh";
			this.bbiassignmentsRefresh.ImageUri.Uri = "Refresh";
			this.bbiassignmentsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.assignmentsBarManager.Items.Add(this.bbiassignmentsRefresh);
			this.assignmentsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiassignmentsRefresh));
			this.assignmentsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiassignmentsRefresh));
						//
			//assignmentsBar
			//
			this.assignmentsBar.BarName = "assignments";
            this.assignmentsBar.DockCol = 0;
            this.assignmentsBar.DockRow = 0;
            this.assignmentsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.assignmentsBar.OptionsBar.AllowQuickCustomization = false;
            this.assignmentsBar.OptionsBar.DrawDragBorder = false;
            this.assignmentsBar.Text = "assignments";
			//
			//assignmentsBarManager
			//
			this.assignmentsBarManager.AllowCustomization = false;
            this.assignmentsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.assignmentsBar});
            this.assignmentsBarManager.Form = assignmentsXtraUserControl;
            this.assignmentsBarManager.MainMenu = this.assignmentsBar;
			// 
            // assignmentsPopUpMenu
            // 
            this.assignmentsPopUpMenu.Manager = this.assignmentsBarManager;
            this.assignmentsPopUpMenu.Name = "assignmentsPopUpMenu";
			//
			//assignmentsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters assignmentsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            assignmentsRetriveFieldParameters.FieldName = "assignments";
            assignmentsRetriveFieldParameters.ControlForField = assignmentsXtraUserControl;
			assignmentsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(assignmentsRetriveFieldParameters);
						 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(StudentWindowsFormsApp.ViewModels.employeeViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(StudentWindowsFormsApp.ViewModels.employeeViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(StudentWindowsFormsApp.ViewModels.employeeViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(StudentWindowsFormsApp.ViewModels.employeeViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(StudentWindowsFormsApp.ViewModels.employeeViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(StudentWindowsFormsApp.ViewModels.employeeViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(StudentWindowsFormsApp.ViewModels.employeeViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(StudentWindowsFormsApp.ViewModels.employeeViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(StudentWindowsFormsApp.ViewModels.employeeViewModel), "ResetLayout", bbiResetLayout));
						this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//employeeView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "employeeView";
						((System.ComponentModel.ISupportInitialize)(this.assignmentsBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
		private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
		private DevExpress.XtraBars.BarButtonItem bbiCustomize;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupLayout;
		private System.Windows.Forms.BindingSource employeeViewBindingSource;
				private DevExpress.XtraGrid.GridControl assignmentsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView assignmentsGridView;
		private DevExpress.XtraBars.BarManager assignmentsBarManager;
		private DevExpress.XtraBars.Bar assignmentsBar;
		private DevExpress.XtraEditors.XtraUserControl assignmentsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu assignmentsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiassignmentsNew;
				private DevExpress.XtraBars.BarButtonItem bbiassignmentsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiassignmentsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiassignmentsRefresh;
						 
	}
}
