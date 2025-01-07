namespace StudentWindowsFormsApp
{
    partial class AssignmentsForm
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
            this.viewAssignments = new System.Windows.Forms.DataGridView();
            this.assignmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifieddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentprojectDataSet00000000layout = new StudentWindowsFormsApp.studentprojectDataSet00000000layout();
            this.Assignments = new System.Windows.Forms.Label();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_addassignment = new DevExpress.XtraBars.BarButtonItem();
            this.btn_editassignment = new DevExpress.XtraBars.BarButtonItem();
            this.btn_deleteassignment = new DevExpress.XtraBars.BarButtonItem();
            this.btn_frmassign_toemp = new DevExpress.XtraBars.BarButtonItem();
            this.btn_frmdassgn_todept = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.assignmentTableAdapter = new StudentWindowsFormsApp.studentprojectDataSet00000000layoutTableAdapters.assignmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewAssignments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentprojectDataSet00000000layout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAssignments
            // 
            this.viewAssignments.AutoGenerateColumns = false;
            this.viewAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assignmentIDDataGridViewTextBoxColumn,
            this.personIDDataGridViewTextBoxColumn,
            this.deptIDDataGridViewTextBoxColumn,
            this.createdbyDataGridViewTextBoxColumn,
            this.createdateDataGridViewTextBoxColumn,
            this.modifiedbyDataGridViewTextBoxColumn,
            this.modifieddateDataGridViewTextBoxColumn});
            this.viewAssignments.DataSource = this.assignmentBindingSource;
            this.viewAssignments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAssignments.Location = new System.Drawing.Point(0, 336);
            this.viewAssignments.Margin = new System.Windows.Forms.Padding(8);
            this.viewAssignments.Name = "viewAssignments";
            this.viewAssignments.RowHeadersWidth = 82;
            this.viewAssignments.Size = new System.Drawing.Size(1975, 741);
            this.viewAssignments.TabIndex = 40;
            // 
            // assignmentIDDataGridViewTextBoxColumn
            // 
            this.assignmentIDDataGridViewTextBoxColumn.DataPropertyName = "assignmentID";
            this.assignmentIDDataGridViewTextBoxColumn.HeaderText = "assignmentID";
            this.assignmentIDDataGridViewTextBoxColumn.Name = "assignmentIDDataGridViewTextBoxColumn";
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "personID";
            this.personIDDataGridViewTextBoxColumn.HeaderText = "personID";
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            // 
            // deptIDDataGridViewTextBoxColumn
            // 
            this.deptIDDataGridViewTextBoxColumn.DataPropertyName = "deptID";
            this.deptIDDataGridViewTextBoxColumn.HeaderText = "deptID";
            this.deptIDDataGridViewTextBoxColumn.Name = "deptIDDataGridViewTextBoxColumn";
            // 
            // createdbyDataGridViewTextBoxColumn
            // 
            this.createdbyDataGridViewTextBoxColumn.DataPropertyName = "createdby";
            this.createdbyDataGridViewTextBoxColumn.HeaderText = "createdby";
            this.createdbyDataGridViewTextBoxColumn.Name = "createdbyDataGridViewTextBoxColumn";
            // 
            // createdateDataGridViewTextBoxColumn
            // 
            this.createdateDataGridViewTextBoxColumn.DataPropertyName = "createdate";
            this.createdateDataGridViewTextBoxColumn.HeaderText = "createdate";
            this.createdateDataGridViewTextBoxColumn.Name = "createdateDataGridViewTextBoxColumn";
            // 
            // modifiedbyDataGridViewTextBoxColumn
            // 
            this.modifiedbyDataGridViewTextBoxColumn.DataPropertyName = "modifiedby";
            this.modifiedbyDataGridViewTextBoxColumn.HeaderText = "modifiedby";
            this.modifiedbyDataGridViewTextBoxColumn.Name = "modifiedbyDataGridViewTextBoxColumn";
            // 
            // modifieddateDataGridViewTextBoxColumn
            // 
            this.modifieddateDataGridViewTextBoxColumn.DataPropertyName = "modifieddate";
            this.modifieddateDataGridViewTextBoxColumn.HeaderText = "modifieddate";
            this.modifieddateDataGridViewTextBoxColumn.Name = "modifieddateDataGridViewTextBoxColumn";
            // 
            // assignmentBindingSource
            // 
            this.assignmentBindingSource.DataMember = "assignment";
            this.assignmentBindingSource.DataSource = this.studentprojectDataSet00000000layout;
            // 
            // studentprojectDataSet00000000layout
            // 
            this.studentprojectDataSet00000000layout.DataSetName = "studentprojectDataSet00000000layout";
            this.studentprojectDataSet00000000layout.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Assignments
            // 
            this.Assignments.AutoSize = true;
            this.Assignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assignments.Location = new System.Drawing.Point(770, 453);
            this.Assignments.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Assignments.Name = "Assignments";
            this.Assignments.Size = new System.Drawing.Size(505, 91);
            this.Assignments.TabIndex = 24;
            this.Assignments.Text = "Assignments";
            this.Assignments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_addassignment,
            this.btn_editassignment,
            this.btn_deleteassignment,
            this.btn_frmassign_toemp,
            this.btn_frmdassgn_todept});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 412;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1975, 336);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btn_addassignment
            // 
            this.btn_addassignment.Caption = "Add";
            this.btn_addassignment.Id = 1;
            this.btn_addassignment.Name = "btn_addassignment";
            this.btn_addassignment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_addassignment_ItemClick);
            // 
            // btn_editassignment
            // 
            this.btn_editassignment.Caption = "Edit";
            this.btn_editassignment.Id = 2;
            this.btn_editassignment.Name = "btn_editassignment";
            this.btn_editassignment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_editassignment_ItemClick);
            // 
            // btn_deleteassignment
            // 
            this.btn_deleteassignment.Caption = "Delete";
            this.btn_deleteassignment.Id = 3;
            this.btn_deleteassignment.Name = "btn_deleteassignment";
            this.btn_deleteassignment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_deleteassignment_ItemClick);
            // 
            // btn_frmassign_toemp
            // 
            this.btn_frmassign_toemp.Caption = "Employees";
            this.btn_frmassign_toemp.Id = 4;
            this.btn_frmassign_toemp.Name = "btn_frmassign_toemp";
            this.btn_frmassign_toemp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_frmassign_toemp_ItemClick);
            // 
            // btn_frmdassgn_todept
            // 
            this.btn_frmdassgn_todept.Caption = "Departments";
            this.btn_frmdassgn_todept.Id = 5;
            this.btn_frmdassgn_todept.Name = "btn_frmdassgn_todept";
            this.btn_frmdassgn_todept.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_frmdassgn_todept_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_addassignment);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_editassignment);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_deleteassignment);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Actions";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_frmassign_toemp);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_frmdassgn_todept);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Switch Page";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 1077);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1975, 65);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // assignmentTableAdapter
            // 
            this.assignmentTableAdapter.ClearBeforeFill = true;
            // 
            // AssignmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1975, 1142);
            this.Controls.Add(this.viewAssignments);
            this.Controls.Add(this.Assignments);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "AssignmentsForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "ManageAssignments";
            this.Load += new System.EventHandler(this.AssignemntsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAssignments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentprojectDataSet00000000layout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewAssignments;
        private System.Windows.Forms.Label Assignments;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btn_addassignment;
        private DevExpress.XtraBars.BarButtonItem btn_editassignment;
        private DevExpress.XtraBars.BarButtonItem btn_deleteassignment;
        private studentprojectDataSet00000000layout studentprojectDataSet00000000layout;
        private System.Windows.Forms.BindingSource assignmentBindingSource;
        private studentprojectDataSet00000000layoutTableAdapters.assignmentTableAdapter assignmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifieddateDataGridViewTextBoxColumn;
        private DevExpress.XtraBars.BarButtonItem btn_frmassign_toemp;
        private DevExpress.XtraBars.BarButtonItem btn_frmdassgn_todept;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}