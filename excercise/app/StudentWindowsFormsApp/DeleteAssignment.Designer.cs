namespace StudentWindowsFormsApp
{
    partial class DeleteAssignment
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.txt_deptname_todelete = new System.Windows.Forms.TextBox();
            this.txt_empassign_todelete = new System.Windows.Forms.TextBox();
            this.lb_deptname_todelete = new DevExpress.XtraEditors.LabelControl();
            this.lbl_empassign_todelete = new DevExpress.XtraEditors.LabelControl();
            this.btn_delassignment = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Controls.Add(this.lbl_empassign_todelete);
            this.tablePanel1.Controls.Add(this.lb_deptname_todelete);
            this.tablePanel1.Controls.Add(this.btn_delassignment);
            this.tablePanel1.Controls.Add(this.txt_empassign_todelete);
            this.tablePanel1.Controls.Add(this.txt_deptname_todelete);
            this.tablePanel1.Location = new System.Drawing.Point(74, 40);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 55F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(2096, 1366);
            this.tablePanel1.TabIndex = 0;
            // 
            // txt_deptname_todelete
            // 
            this.tablePanel1.SetColumn(this.txt_deptname_todelete, 1);
            this.txt_deptname_todelete.Location = new System.Drawing.Point(1051, 3);
            this.txt_deptname_todelete.Name = "txt_deptname_todelete";
            this.tablePanel1.SetRow(this.txt_deptname_todelete, 0);
            this.txt_deptname_todelete.Size = new System.Drawing.Size(1042, 40);
            this.txt_deptname_todelete.TabIndex = 0;
            // 
            // txt_empassign_todelete
            // 
            this.tablePanel1.SetColumn(this.txt_empassign_todelete, 1);
            this.txt_empassign_todelete.Location = new System.Drawing.Point(1051, 49);
            this.txt_empassign_todelete.Name = "txt_empassign_todelete";
            this.tablePanel1.SetRow(this.txt_empassign_todelete, 1);
            this.txt_empassign_todelete.Size = new System.Drawing.Size(1042, 40);
            this.txt_empassign_todelete.TabIndex = 1;
            // 
            // lb_deptname_todelete
            // 
            this.lb_deptname_todelete.Location = new System.Drawing.Point(3, 6);
            this.lb_deptname_todelete.Name = "lb_deptname_todelete";
            this.lb_deptname_todelete.Size = new System.Drawing.Size(133, 33);
            this.lb_deptname_todelete.TabIndex = 3;
            this.lb_deptname_todelete.Text = "Dept Name";
            // 
            // lbl_empassign_todelete
            // 
            this.lbl_empassign_todelete.Location = new System.Drawing.Point(3, 52);
            this.lbl_empassign_todelete.Name = "lbl_empassign_todelete";
            this.lbl_empassign_todelete.Size = new System.Drawing.Size(187, 33);
            this.lbl_empassign_todelete.TabIndex = 4;
            this.lbl_empassign_todelete.Text = "Employee Email";
            // 
            // btn_delassignment
            // 
            this.tablePanel1.SetColumn(this.btn_delassignment, 1);
            this.btn_delassignment.Location = new System.Drawing.Point(1051, 700);
            this.btn_delassignment.Name = "btn_delassignment";
            this.tablePanel1.SetRow(this.btn_delassignment, 2);
            this.btn_delassignment.Size = new System.Drawing.Size(1042, 57);
            this.btn_delassignment.TabIndex = 2;
            this.btn_delassignment.Text = "Delete Assignment";
            // 
            // DeleteAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2277, 1498);
            this.Controls.Add(this.tablePanel1);
            this.Name = "DeleteAssignment";
            this.Text = "DeleteAssignment";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl lbl_empassign_todelete;
        private DevExpress.XtraEditors.LabelControl lb_deptname_todelete;
        private System.Windows.Forms.TextBox txt_empassign_todelete;
        private System.Windows.Forms.TextBox txt_deptname_todelete;
        private DevExpress.XtraEditors.SimpleButton btn_delassignment;
    }
}