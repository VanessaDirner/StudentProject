namespace StudentWindowsFormsApp
{
    partial class DepartmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentsForm));
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentprojectDataSet00000000layout = new StudentWindowsFormsApp.studentprojectDataSet00000000layout();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barbtn_deptedit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_departments_add = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn_dept_delete = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.barBtn_frmdept_toempl = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_frmdept_toreport = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.assignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentTableAdapter = new StudentWindowsFormsApp.studentprojectDataSet00000000layoutTableAdapters.assignmentTableAdapter();
            this.departmentTableAdapter = new StudentWindowsFormsApp.studentprojectDataSet00000000layoutTableAdapters.departmentTableAdapter();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.fKassignmendeptI4316F928BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.employeeTableAdapter = new StudentWindowsFormsApp.studentprojectDataSet00000000layoutTableAdapters.employeeTableAdapter();
            this.departmentBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.departmentgridcontrol = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentprojectDataSet00000000layout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKassignmendeptI4316F928BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource2)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentgridcontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.studentprojectDataSet00000000layout;
            // 
            // studentprojectDataSet00000000layout
            // 
            this.studentprojectDataSet00000000layout.DataSetName = "studentprojectDataSet00000000layout";
            this.studentprojectDataSet00000000layout.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barbtn_deptedit,
            this.barButtonItem2,
            this.btn_departments_add,
            this.barbtn_dept_delete,
            this.barEditItem1,
            this.barBtn_frmdept_toempl,
            this.barBtn_frmdept_toreport});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(30720, 32440, 30720, 32440);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 3374080;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(2841, 336);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barbtn_deptedit
            // 
            this.barbtn_deptedit.Caption = "Edit";
            this.barbtn_deptedit.Id = 1;
            this.barbtn_deptedit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtn_deptedit.ImageOptions.Image")));
            this.barbtn_deptedit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtn_deptedit.ImageOptions.LargeImage")));
            this.barbtn_deptedit.Name = "barbtn_deptedit";
            this.barbtn_deptedit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_deptedit_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btn_departments_add
            // 
            this.btn_departments_add.Caption = "Add";
            this.btn_departments_add.Id = 3;
            this.btn_departments_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_departments_add.ImageOptions.Image")));
            this.btn_departments_add.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_departments_add.ImageOptions.LargeImage")));
            this.btn_departments_add.Name = "btn_departments_add";
            this.btn_departments_add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_departments_add_ItemClick);
            // 
            // barbtn_dept_delete
            // 
            this.barbtn_dept_delete.Caption = "Delete";
            this.barbtn_dept_delete.Id = 4;
            this.barbtn_dept_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtn_dept_delete.ImageOptions.Image")));
            this.barbtn_dept_delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtn_dept_delete.ImageOptions.LargeImage")));
            this.barbtn_dept_delete.Name = "barbtn_dept_delete";
            this.barbtn_dept_delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_dept_delete_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemLookUpEdit1;
            this.barEditItem1.Id = 5;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // barBtn_frmdept_toempl
            // 
            this.barBtn_frmdept_toempl.Caption = "Employees";
            this.barBtn_frmdept_toempl.Id = 6;
            this.barBtn_frmdept_toempl.Name = "barBtn_frmdept_toempl";
            this.barBtn_frmdept_toempl.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_frmdept_toempl_ItemClick);
            // 
            // barBtn_frmdept_toreport
            // 
            this.barBtn_frmdept_toreport.Caption = "Reports";
            this.barBtn_frmdept_toreport.Id = 7;
            this.barBtn_frmdept_toreport.Name = "barBtn_frmdept_toreport";
            this.barBtn_frmdept_toreport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_frmdept_toreport_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Department";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_departments_add);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtn_deptedit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtn_dept_delete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Actions";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtn_frmdept_toempl);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtn_frmdept_toreport);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Switch ";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 1970);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(30720, 32440, 30720, 32440);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(2841, 65);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Edit Departments";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // assignmentBindingSource
            // 
            this.assignmentBindingSource.DataMember = "assignment";
            this.assignmentBindingSource.DataSource = this.studentprojectDataSet00000000layout;
            // 
            // assignmentTableAdapter
            // 
            this.assignmentTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "department";
            this.departmentBindingSource1.DataSource = this.studentprojectDataSet00000000layout;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 336);
            this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(4);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(500, 1634);
            this.dataLayoutControl1.TabIndex = 50;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(500, 1634);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // fKassignmendeptI4316F928BindingSource
            // 
            this.fKassignmendeptI4316F928BindingSource.DataMember = "FK__assignmen__deptI__4316F928";
            this.fKassignmendeptI4316F928BindingSource.DataSource = this.departmentBindingSource3;
            // 
            // departmentBindingSource3
            // 
            this.departmentBindingSource3.DataMember = "department";
            this.departmentBindingSource3.DataSource = this.studentprojectDataSet00000000layout;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.studentprojectDataSet00000000layout;
            // 
            // departmentBindingSource4
            // 
            this.departmentBindingSource4.DataMember = "department";
            this.departmentBindingSource4.DataSource = this.studentprojectDataSet00000000layout;
            // 
            // departmentBindingSource2
            // 
            this.departmentBindingSource2.DataMember = "department";
            this.departmentBindingSource2.DataSource = this.studentprojectDataSet00000000layout;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(500, 336);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(2341, 48);
            this.fillByToolStrip.TabIndex = 54;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(90, 45);
            this.fillByToolStripButton.Text = "FillBy";
             // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // departmentBindingSource5
            // 
            this.departmentBindingSource5.DataMember = "department";
            this.departmentBindingSource5.DataSource = this.studentprojectDataSet00000000layout;
            // 
            // departmentBindingSource7
            // 
            this.departmentBindingSource7.DataMember = "department";
            this.departmentBindingSource7.DataSource = this.studentprojectDataSet00000000layout;
            // 
            // departmentBindingSource6
            // 
            this.departmentBindingSource6.DataMember = "department";
            this.departmentBindingSource6.DataSource = this.studentprojectDataSet00000000layout;
            // 
            // departmentgridcontrol
            // 
            this.departmentgridcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentgridcontrol.Location = new System.Drawing.Point(500, 384);
            this.departmentgridcontrol.MainView = this.gridView1;
            this.departmentgridcontrol.MenuManager = this.ribbonControl1;
            this.departmentgridcontrol.Name = "departmentgridcontrol";
            this.departmentgridcontrol.Size = new System.Drawing.Size(2341, 1586);
            this.departmentgridcontrol.TabIndex = 60;
            this.departmentgridcontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.departmentgridcontrol;
            this.gridView1.Name = "gridView1";
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2841, 2035);
            this.Controls.Add(this.departmentgridcontrol);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "DepartmentsForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Manage Departments";
            this.Load += new System.EventHandler(this.DepartmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentprojectDataSet00000000layout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKassignmendeptI4316F928BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource2)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentgridcontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barbtn_deptedit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btn_departments_add;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private studentprojectDataSet00000000layout studentprojectDataSet00000000layout;
        private System.Windows.Forms.BindingSource assignmentBindingSource;
        private studentprojectDataSet00000000layoutTableAdapters.assignmentTableAdapter assignmentTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private studentprojectDataSet00000000layoutTableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource departmentBindingSource2;
        private System.Windows.Forms.BindingSource departmentBindingSource3;
        private System.Windows.Forms.BindingSource departmentBindingSource4;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private studentprojectDataSet00000000layoutTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource fKassignmendeptI4316F928BindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource5;
        private System.Windows.Forms.BindingSource departmentBindingSource6;
        private DevExpress.XtraBars.BarButtonItem barbtn_dept_delete;
        private DevExpress.XtraBars.BarButtonItem barBtn_frmdept_toempl;
        private DevExpress.XtraBars.BarButtonItem barBtn_frmdept_toreport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.BindingSource departmentBindingSource7;
        private DevExpress.XtraGrid.GridControl departmentgridcontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}