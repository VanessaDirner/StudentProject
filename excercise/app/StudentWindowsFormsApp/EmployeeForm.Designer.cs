namespace StudentWindowsFormsApp
{
    partial class EmployeeForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barbtn_addemp = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn_editemp = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_deleteemp = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barBtn_fromemp_todept = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_frmemp_toreport = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.viewEmployees = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 34);
            this.label5.TabIndex = 11;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barbtn_addemp,
            this.barbtn_editemp,
            this.barBtn_deleteemp,
            this.barButtonItem4,
            this.barBtn_fromemp_todept,
            this.barBtn_frmemp_toreport});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.barButtonItem4);
            this.ribbonControl1.Size = new System.Drawing.Size(1649, 336);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barbtn_addemp
            // 
            this.barbtn_addemp.Caption = "Add";
            this.barbtn_addemp.Id = 1;
            this.barbtn_addemp.Name = "barbtn_addemp";
            this.barbtn_addemp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_addemp_ItemClick);
            // 
            // barbtn_editemp
            // 
            this.barbtn_editemp.Caption = "Edit";
            this.barbtn_editemp.Id = 3;
            this.barbtn_editemp.Name = "barbtn_editemp";
            this.barbtn_editemp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn_editemp_ItemClick);
            // 
            // barBtn_deleteemp
            // 
            this.barBtn_deleteemp.Caption = "Delete";
            this.barBtn_deleteemp.Id = 4;
            this.barBtn_deleteemp.Name = "barBtn_deleteemp";
            this.barBtn_deleteemp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_deleteemp_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.ActAsDropDown = true;
            this.barButtonItem4.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem4.Caption = "jsdf";
            this.barButtonItem4.DropDownControl = this.popupMenu1;
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl1;
            // 
            // barBtn_fromemp_todept
            // 
            this.barBtn_fromemp_todept.Caption = "Departments";
            this.barBtn_fromemp_todept.Id = 7;
            this.barBtn_fromemp_todept.Name = "barBtn_fromemp_todept";
            this.barBtn_fromemp_todept.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_fromemp_todept_ItemClick);
            // 
            // barBtn_frmemp_toreport
            // 
            this.barBtn_frmemp_toreport.Caption = "Reports";
            this.barBtn_frmemp_toreport.Id = 8;
            this.barBtn_frmemp_toreport.Name = "barBtn_frmemp_toreport";
            this.barBtn_frmemp_toreport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_frmemp_toreport_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Employees";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtn_addemp);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtn_editemp);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtn_deleteemp);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Actions";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtn_fromemp_todept);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtn_frmemp_toreport);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Change Page";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 1233);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1649, 65);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // viewEmployees
            // 
            this.viewEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewEmployees.Location = new System.Drawing.Point(0, 336);
            this.viewEmployees.MainView = this.gridView1;
            this.viewEmployees.MenuManager = this.ribbonControl1;
            this.viewEmployees.Name = "viewEmployees";
            this.viewEmployees.Size = new System.Drawing.Size(1649, 897);
            this.viewEmployees.TabIndex = 26;
            this.viewEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.viewEmployees;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // EmployeeForm
            // 
            this.ClientSize = new System.Drawing.Size(1649, 1298);
            this.Controls.Add(this.viewEmployees);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "EmployeeForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Manage Employees";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource assignmentBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource studentprojectdbDataSetBindingSource;
        private System.Windows.Forms.BindingSource studentprojectdbDataSetBindingSource1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barbtn_addemp;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barbtn_editemp;
        private DevExpress.XtraBars.BarButtonItem barBtn_deleteemp;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barBtn_fromemp_todept;
        private DevExpress.XtraBars.BarButtonItem barBtn_frmemp_toreport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraGrid.GridControl viewEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

