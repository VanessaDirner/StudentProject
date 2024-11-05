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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentsForm));
            this.viewDepartments = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_llastname = new System.Windows.Forms.Label();
            this.lbl_deptName = new System.Windows.Forms.Label();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barbtn_deptedit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.Delete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.btndeptsubmit = new DevExpress.XtraEditors.SimpleButton();
            this.txtdeptabbr = new DevExpress.XtraEditors.TextEdit();
            this.txt_deptname = new DevExpress.XtraEditors.TextEdit();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.viewDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdeptabbr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_deptname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // viewDepartments
            // 
            this.viewDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.viewDepartments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.viewDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDepartments.Location = new System.Drawing.Point(42, 371);
            this.viewDepartments.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.viewDepartments.Name = "viewDepartments";
            this.viewDepartments.RowHeadersWidth = 82;
            this.viewDepartments.Size = new System.Drawing.Size(1504, 621);
            this.viewDepartments.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(646, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 30);
            this.label5.TabIndex = 32;
            // 
            // lb_llastname
            // 
            this.lb_llastname.AutoSize = true;
            this.lb_llastname.Location = new System.Drawing.Point(906, 128);
            this.lb_llastname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_llastname.Name = "lb_llastname";
            this.lb_llastname.Size = new System.Drawing.Size(248, 30);
            this.lb_llastname.TabIndex = 28;
            this.lb_llastname.Text = "Department Abbreviation";
            // 
            // lbl_deptName
            // 
            this.lbl_deptName.AutoSize = true;
            this.lbl_deptName.Location = new System.Drawing.Point(540, 128);
            this.lbl_deptName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_deptName.Name = "lbl_deptName";
            this.lbl_deptName.Size = new System.Drawing.Size(186, 30);
            this.lbl_deptName.TabIndex = 26;
            this.lbl_deptName.Text = "Department Name";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barbtn_deptedit,
            this.barButtonItem2,
            this.barButtonItem3,
            this.Delete});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1580, 289);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barbtn_deptedit
            // 
            this.barbtn_deptedit.Caption = "Edit";
            this.barbtn_deptedit.Id = 1;
            this.barbtn_deptedit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtn_deptedit.ImageOptions.Image")));
            this.barbtn_deptedit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtn_deptedit.ImageOptions.LargeImage")));
            this.barbtn_deptedit.Name = "barbtn_deptedit";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Add";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // Delete
            // 
            this.Delete.Caption = "Delete";
            this.Delete.Id = 4;
            this.Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Delete.ImageOptions.Image")));
            this.Delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Delete.ImageOptions.LargeImage")));
            this.Delete.Name = "Delete";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Department";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtn_deptedit);
            this.ribbonPageGroup1.ItemLinks.Add(this.Delete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
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
            // btndeptsubmit
            // 
            this.btndeptsubmit.Location = new System.Drawing.Point(1290, 128);
            this.btndeptsubmit.Name = "btndeptsubmit";
            this.btndeptsubmit.Size = new System.Drawing.Size(242, 120);
            this.btndeptsubmit.TabIndex = 43;
            this.btndeptsubmit.Text = "Submit Form";
            // 
            // txtdeptabbr
            // 
            this.txtdeptabbr.Location = new System.Drawing.Point(911, 204);
            this.txtdeptabbr.MenuManager = this.ribbonControl1;
            this.txtdeptabbr.Name = "txtdeptabbr";
            this.txtdeptabbr.Size = new System.Drawing.Size(200, 44);
            this.txtdeptabbr.TabIndex = 44;
            // 
            // txt_deptname
            // 
            this.txt_deptname.Location = new System.Drawing.Point(526, 203);
            this.txt_deptname.MenuManager = this.ribbonControl1;
            this.txt_deptname.Name = "txt_deptname";
            this.txt_deptname.Size = new System.Drawing.Size(200, 44);
            this.txt_deptname.TabIndex = 45;
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
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 1038);
            this.Controls.Add(this.txt_deptname);
            this.Controls.Add(this.txtdeptabbr);
            this.Controls.Add(this.btndeptsubmit);
            this.Controls.Add(this.viewDepartments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_llastname);
            this.Controls.Add(this.lbl_deptName);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "DepartmentsForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "ManageDepartments";
            this.Load += new System.EventHandler(this.DepartmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdeptabbr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_deptname.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewDepartments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_llastname;
        private System.Windows.Forms.Label lbl_deptName;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraEditors.SimpleButton btndeptsubmit;
        private DevExpress.XtraEditors.TextEdit txtdeptabbr;
        private DevExpress.XtraEditors.TextEdit txt_deptname;
        private DevExpress.XtraBars.BarButtonItem barbtn_deptedit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem Delete;
    }
}