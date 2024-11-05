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
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.viewAssignments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAssignments
            // 
            this.viewAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAssignments.Location = new System.Drawing.Point(24, 358);
            this.viewAssignments.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.viewAssignments.Name = "viewAssignments";
            this.viewAssignments.RowHeadersWidth = 82;
            this.viewAssignments.Size = new System.Drawing.Size(1552, 680);
            this.viewAssignments.TabIndex = 40;
            // 
            // btn_assign_submit
            // 
            this.btn_assign_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_assign_submit.ForeColor = System.Drawing.Color.Black;
            this.btn_assign_submit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_assign_submit.Location = new System.Drawing.Point(1330, 115);
            this.btn_assign_submit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_assign_submit.Name = "btn_assign_submit";
            this.btn_assign_submit.Size = new System.Drawing.Size(182, 118);
            this.btn_assign_submit.TabIndex = 38;
            this.btn_assign_submit.Text = "Submit Form";
            this.btn_assign_submit.UseVisualStyleBackColor = true;
            this.btn_assign_submit.Click += new System.EventHandler(this.btn_assign_submit_Click);
            // 
            // lbl_assign_email
            // 
            this.lbl_assign_email.AutoSize = true;
            this.lbl_assign_email.Location = new System.Drawing.Point(547, 289);
            this.lbl_assign_email.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_assign_email.Name = "lbl_assign_email";
            this.lbl_assign_email.Size = new System.Drawing.Size(159, 30);
            this.lbl_assign_email.TabIndex = 31;
            this.lbl_assign_email.Text = "Employee Email";
            // 
            // txt_assign_email
            // 
            this.txt_assign_email.Location = new System.Drawing.Point(382, 193);
            this.txt_assign_email.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_assign_email.Name = "txt_assign_email";
            this.txt_assign_email.Size = new System.Drawing.Size(196, 35);
            this.txt_assign_email.TabIndex = 30;
            // 
            // Assignments
            // 
            this.Assignments.AutoSize = true;
            this.Assignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assignments.Location = new System.Drawing.Point(616, 412);
            this.Assignments.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Assignments.Name = "Assignments";
            this.Assignments.Size = new System.Drawing.Size(411, 73);
            this.Assignments.TabIndex = 24;
            this.Assignments.Text = "Assignments";
            this.Assignments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_assign_deptName
            // 
            this.lbl_assign_deptName.AutoSize = true;
            this.lbl_assign_deptName.Location = new System.Drawing.Point(752, 160);
            this.lbl_assign_deptName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_assign_deptName.Name = "lbl_assign_deptName";
            this.lbl_assign_deptName.Size = new System.Drawing.Size(186, 30);
            this.lbl_assign_deptName.TabIndex = 42;
            this.lbl_assign_deptName.Text = "Department Name";
            // 
            // txt_assign_deptname
            // 
            this.txt_assign_deptname.Location = new System.Drawing.Point(783, 238);
            this.txt_assign_deptname.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_assign_deptname.Name = "txt_assign_deptname";
            this.txt_assign_deptname.Size = new System.Drawing.Size(288, 35);
            this.txt_assign_deptname.TabIndex = 41;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1580, 289);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
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
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 980);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1580, 58);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // AssignmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 1038);
            this.Controls.Add(this.lbl_assign_deptName);
            this.Controls.Add(this.txt_assign_deptname);
            this.Controls.Add(this.viewAssignments);
            this.Controls.Add(this.btn_assign_submit);
            this.Controls.Add(this.lbl_assign_email);
            this.Controls.Add(this.txt_assign_email);
            this.Controls.Add(this.Assignments);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AssignmentsForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "ManageAssignments";
            this.Load += new System.EventHandler(this.AssignemntsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAssignments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
    }
}