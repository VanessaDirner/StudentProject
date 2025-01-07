namespace StudentWindowsFormsApp
{
    partial class AddAssignment
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
            this.tablelayout_toassign = new DevExpress.Utils.Layout.TablePanel();
            this.btn_addassignment = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_empemail_assign = new DevExpress.XtraEditors.LabelControl();
            this.txt_emp_email = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_deptname_toassign = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tablelayout_toassign)).BeginInit();
            this.tablelayout_toassign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_deptname_toassign.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablelayout_toassign
            // 
            this.tablelayout_toassign.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablelayout_toassign.Controls.Add(this.lbl_deptname_toassign);
            this.tablelayout_toassign.Controls.Add(this.labelControl1);
            this.tablelayout_toassign.Controls.Add(this.btn_addassignment);
            this.tablelayout_toassign.Controls.Add(this.lbl_empemail_assign);
            this.tablelayout_toassign.Controls.Add(this.txt_emp_email);
            this.tablelayout_toassign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablelayout_toassign.Location = new System.Drawing.Point(0, 0);
            this.tablelayout_toassign.Name = "tablelayout_toassign";
            this.tablelayout_toassign.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.tablelayout_toassign.Size = new System.Drawing.Size(1892, 1255);
            this.tablelayout_toassign.TabIndex = 0;
            // 
            // btn_addassignment
            // 
            this.tablelayout_toassign.SetColumn(this.btn_addassignment, 1);
            this.btn_addassignment.Location = new System.Drawing.Point(949, 1017);
            this.btn_addassignment.Name = "btn_addassignment";
            this.tablelayout_toassign.SetRow(this.btn_addassignment, 2);
            this.btn_addassignment.Size = new System.Drawing.Size(940, 57);
            this.btn_addassignment.TabIndex = 5;
            this.btn_addassignment.Text = "Assign employee to department";
            this.btn_addassignment.Click += new System.EventHandler(this.btn_addassignment_Click);
            // 
            // lbl_empemail_assign
            // 
            this.tablelayout_toassign.SetColumn(this.lbl_empemail_assign, 0);
            this.lbl_empemail_assign.Location = new System.Drawing.Point(3, 192);
            this.lbl_empemail_assign.Name = "lbl_empemail_assign";
            this.tablelayout_toassign.SetRow(this.lbl_empemail_assign, 0);
            this.lbl_empemail_assign.Size = new System.Drawing.Size(187, 33);
            this.lbl_empemail_assign.TabIndex = 4;
            this.lbl_empemail_assign.Text = "Employee Email";
            // 
            // txt_emp_email
            // 
            this.tablelayout_toassign.SetColumn(this.txt_emp_email, 1);
            this.txt_emp_email.Location = new System.Drawing.Point(949, 189);
            this.txt_emp_email.Name = "txt_emp_email";
            this.tablelayout_toassign.SetRow(this.txt_emp_email, 0);
            this.txt_emp_email.Size = new System.Drawing.Size(940, 40);
            this.txt_emp_email.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.tablelayout_toassign.SetColumn(this.labelControl1, 0);
            this.labelControl1.Location = new System.Drawing.Point(3, 610);
            this.labelControl1.Name = "labelControl1";
            this.tablelayout_toassign.SetRow(this.labelControl1, 1);
            this.labelControl1.Size = new System.Drawing.Size(218, 33);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Department Name";
            // 
            // lbl_deptname_toassign
            // 
            this.tablelayout_toassign.SetColumn(this.lbl_deptname_toassign, 1);
            this.lbl_deptname_toassign.Location = new System.Drawing.Point(949, 603);
            this.lbl_deptname_toassign.Name = "lbl_deptname_toassign";
            this.tablelayout_toassign.SetRow(this.lbl_deptname_toassign, 1);
            this.lbl_deptname_toassign.Size = new System.Drawing.Size(940, 48);
            this.lbl_deptname_toassign.TabIndex = 7;
            // 
            // AddAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1892, 1255);
            this.Controls.Add(this.tablelayout_toassign);
            this.Name = "AddAssignment";
            this.Text = "AddAssignment";
            ((System.ComponentModel.ISupportInitialize)(this.tablelayout_toassign)).EndInit();
            this.tablelayout_toassign.ResumeLayout(false);
            this.tablelayout_toassign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_deptname_toassign.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablelayout_toassign;
        private DevExpress.XtraEditors.SimpleButton btn_addassignment;
        private DevExpress.XtraEditors.LabelControl lbl_empemail_assign;
        private System.Windows.Forms.TextBox txt_emp_email;
        private DevExpress.XtraEditors.TextEdit lbl_deptname_toassign;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}