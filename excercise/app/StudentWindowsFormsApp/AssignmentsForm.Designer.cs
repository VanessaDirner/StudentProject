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
            this.btn_assign_submit = new System.Windows.Forms.Button();
            this.lbl_assign_email = new System.Windows.Forms.Label();
            this.txt_assign_email = new System.Windows.Forms.TextBox();
            this.Assignments = new System.Windows.Forms.Label();
            this.lbl_assign_deptName = new System.Windows.Forms.Label();
            this.txt_assign_deptname = new System.Windows.Forms.TextBox();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.studentprojectDataSet00000000layout = new StudentWindowsFormsApp.studentprojectDataSet00000000layout();
            this.assignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentTableAdapter = new StudentWindowsFormsApp.studentprojectDataSet00000000layoutTableAdapters.assignmentTableAdapter();
            this.assignmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifieddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewAssignments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentprojectDataSet00000000layout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).BeginInit();
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
            this.viewAssignments.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.viewAssignments.Name = "viewAssignments";
            this.viewAssignments.RowHeadersWidth = 82;
            this.viewAssignments.Size = new System.Drawing.Size(1975, 741);
            this.viewAssignments.TabIndex = 40;
            // 
            // btn_assign_submit
            // 
            this.btn_assign_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_assign_submit.ForeColor = System.Drawing.Color.Black;
            this.btn_assign_submit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_assign_submit.Location = new System.Drawing.Point(1662, 127);
            this.btn_assign_submit.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btn_assign_submit.Name = "btn_assign_submit";
            this.btn_assign_submit.Size = new System.Drawing.Size(228, 130);
            this.btn_assign_submit.TabIndex = 38;
            this.btn_assign_submit.Text = "Submit Form";
            this.btn_assign_submit.UseVisualStyleBackColor = true;
            this.btn_assign_submit.Click += new System.EventHandler(this.btn_assign_submit_Click);
            // 
            // lbl_assign_email
            // 
            this.lbl_assign_email.AutoSize = true;
            this.lbl_assign_email.Location = new System.Drawing.Point(684, 318);
            this.lbl_assign_email.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_assign_email.Name = "lbl_assign_email";
            this.lbl_assign_email.Size = new System.Drawing.Size(211, 34);
            this.lbl_assign_email.TabIndex = 31;
            this.lbl_assign_email.Text = "Employee Email";
            // 
            // txt_assign_email
            // 
            this.txt_assign_email.Location = new System.Drawing.Point(478, 212);
            this.txt_assign_email.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt_assign_email.Name = "txt_assign_email";
            this.txt_assign_email.Size = new System.Drawing.Size(244, 40);
            this.txt_assign_email.TabIndex = 30;
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
            // lbl_assign_deptName
            // 
            this.lbl_assign_deptName.AutoSize = true;
            this.lbl_assign_deptName.Location = new System.Drawing.Point(940, 176);
            this.lbl_assign_deptName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_assign_deptName.Name = "lbl_assign_deptName";
            this.lbl_assign_deptName.Size = new System.Drawing.Size(244, 34);
            this.lbl_assign_deptName.TabIndex = 42;
            this.lbl_assign_deptName.Text = "Department Name";
            // 
            // txt_assign_deptname
            // 
            this.txt_assign_deptname.Location = new System.Drawing.Point(979, 262);
            this.txt_assign_deptname.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt_assign_deptname.Name = "txt_assign_deptname";
            this.txt_assign_deptname.Size = new System.Drawing.Size(359, 40);
            this.txt_assign_deptname.TabIndex = 41;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 412;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1975, 336);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 1077);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1975, 65);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Add";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Edit";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Delete";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // studentprojectDataSet00000000layout
            // 
            this.studentprojectDataSet00000000layout.DataSetName = "studentprojectDataSet00000000layout";
            this.studentprojectDataSet00000000layout.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // AssignmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1975, 1142);
            this.Controls.Add(this.lbl_assign_deptName);
            this.Controls.Add(this.txt_assign_deptname);
            this.Controls.Add(this.viewAssignments);
            this.Controls.Add(this.btn_assign_submit);
            this.Controls.Add(this.lbl_assign_email);
            this.Controls.Add(this.txt_assign_email);
            this.Controls.Add(this.Assignments);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "AssignmentsForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "ManageAssignments";
            this.Load += new System.EventHandler(this.AssignemntsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAssignments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentprojectDataSet00000000layout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewAssignments;
        private System.Windows.Forms.Button btn_assign_submit;
        private System.Windows.Forms.Label lbl_assign_email;
        private System.Windows.Forms.TextBox txt_assign_email;
        private System.Windows.Forms.Label Assignments;
        private System.Windows.Forms.Label lbl_assign_deptName;
        private System.Windows.Forms.TextBox txt_assign_deptname;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
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
    }
}