namespace StudentWindowsFormsApp
{
    partial class DeleteDepartment
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
            this.lbl_deptname_todelete = new DevExpress.XtraEditors.LabelControl();
            this.btn_deletedept = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26.8F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33.2F)});
            this.tablePanel1.Controls.Add(this.btn_deletedept);
            this.tablePanel1.Controls.Add(this.lbl_deptname_todelete);
            this.tablePanel1.Controls.Add(this.txt_deptname_todelete);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 309.9999F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1666, 1148);
            this.tablePanel1.TabIndex = 0;
            // 
            // txt_deptname_todelete
            // 
            this.tablePanel1.SetColumn(this.txt_deptname_todelete, 1);
            this.txt_deptname_todelete.Location = new System.Drawing.Point(747, 135);
            this.txt_deptname_todelete.Name = "txt_deptname_todelete";
            this.tablePanel1.SetRow(this.txt_deptname_todelete, 0);
            this.txt_deptname_todelete.Size = new System.Drawing.Size(916, 40);
            this.txt_deptname_todelete.TabIndex = 0;
            // 
            // lbl_deptname_todelete
            // 
            this.tablePanel1.SetColumn(this.lbl_deptname_todelete, 0);
            this.lbl_deptname_todelete.Location = new System.Drawing.Point(3, 138);
            this.lbl_deptname_todelete.Name = "lbl_deptname_todelete";
            this.tablePanel1.SetRow(this.lbl_deptname_todelete, 0);
            this.lbl_deptname_todelete.Size = new System.Drawing.Size(218, 33);
            this.lbl_deptname_todelete.TabIndex = 1;
            this.lbl_deptname_todelete.Text = "Department Name";
            // 
            // btn_deletedept
            // 
            this.tablePanel1.SetColumn(this.btn_deletedept, 1);
            this.btn_deletedept.Location = new System.Drawing.Point(747, 700);
            this.btn_deletedept.Name = "btn_deletedept";
            this.tablePanel1.SetRow(this.btn_deletedept, 1);
            this.btn_deletedept.Size = new System.Drawing.Size(916, 57);
            this.btn_deletedept.TabIndex = 2;
            this.btn_deletedept.Text = "Delete Department";
            this.btn_deletedept.Click += new System.EventHandler(this.btn_deletedept_Click);
            // 
            // DeleteDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 1148);
            this.Controls.Add(this.tablePanel1);
            this.Name = "DeleteDepartment";
            this.Text = "DeleteDepartment";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton btn_deletedept;
        private DevExpress.XtraEditors.LabelControl lbl_deptname_todelete;
        private System.Windows.Forms.TextBox txt_deptname_todelete;
    }
}