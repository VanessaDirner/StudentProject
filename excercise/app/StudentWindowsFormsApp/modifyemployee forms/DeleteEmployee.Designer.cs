namespace StudentWindowsFormsApp
{
    partial class DeleteEmployee
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
            this.btn_deleteemployee = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_empemail_todelete = new DevExpress.XtraEditors.LabelControl();
            this.txtbox_empemail_todelete = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.btn_deleteemployee);
            this.tablePanel1.Controls.Add(this.lbl_empemail_todelete);
            this.tablePanel1.Controls.Add(this.txtbox_empemail_todelete);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1812, 1195);
            this.tablePanel1.TabIndex = 0;
            // 
            // btn_deleteemployee
            // 
            this.tablePanel1.SetColumn(this.btn_deleteemployee, 1);
            this.btn_deleteemployee.Location = new System.Drawing.Point(486, 868);
            this.btn_deleteemployee.Name = "btn_deleteemployee";
            this.tablePanel1.SetRow(this.btn_deleteemployee, 1);
            this.btn_deleteemployee.Size = new System.Drawing.Size(1323, 57);
            this.btn_deleteemployee.TabIndex = 5;
            this.btn_deleteemployee.Text = "Delete Employee";
            this.btn_deleteemployee.Click += new System.EventHandler(this.btn_deleteemployee_Click);
            // 
            // lbl_empemail_todelete
            // 
            this.tablePanel1.SetColumn(this.lbl_empemail_todelete, 0);
            this.lbl_empemail_todelete.Location = new System.Drawing.Point(3, 282);
            this.lbl_empemail_todelete.Name = "lbl_empemail_todelete";
            this.tablePanel1.SetRow(this.lbl_empemail_todelete, 0);
            this.lbl_empemail_todelete.Size = new System.Drawing.Size(187, 33);
            this.lbl_empemail_todelete.TabIndex = 4;
            this.lbl_empemail_todelete.Text = "Employee Email";
            // 
            // txtbox_empemail_todelete
            // 
            this.tablePanel1.SetColumn(this.txtbox_empemail_todelete, 1);
            this.txtbox_empemail_todelete.Location = new System.Drawing.Point(486, 279);
            this.txtbox_empemail_todelete.Name = "txtbox_empemail_todelete";
            this.tablePanel1.SetRow(this.txtbox_empemail_todelete, 0);
            this.txtbox_empemail_todelete.Size = new System.Drawing.Size(1323, 40);
            this.txtbox_empemail_todelete.TabIndex = 3;
            // 
            // DeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 1195);
            this.Controls.Add(this.tablePanel1);
            this.Name = "DeleteEmployee";
            this.Text = "DeleteEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton btn_deleteemployee;
        private DevExpress.XtraEditors.LabelControl lbl_empemail_todelete;
        private System.Windows.Forms.TextBox txtbox_empemail_todelete;
    }
}