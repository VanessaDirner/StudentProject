namespace StudentWindowsFormsApp
{
    partial class EditAssignment
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
            this.btn_updatedept = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_empemail_assigned = new DevExpress.XtraEditors.LabelControl();
            this.txt_empemail = new System.Windows.Forms.TextBox();
            this.txt_currentdeptname = new DevExpress.XtraEditors.LabelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_newdeptname = new DevExpress.XtraEditors.LabelControl();
            this.txt_newdeptname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.txt_newdeptname);
            this.tablePanel1.Controls.Add(this.lbl_newdeptname);
            this.tablePanel1.Controls.Add(this.textBox1);
            this.tablePanel1.Controls.Add(this.txt_currentdeptname);
            this.tablePanel1.Controls.Add(this.btn_updatedept);
            this.tablePanel1.Controls.Add(this.lbl_empemail_assigned);
            this.tablePanel1.Controls.Add(this.txt_empemail);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1260, 1105);
            this.tablePanel1.TabIndex = 0;
            // 
            // btn_updatedept
            // 
            this.tablePanel1.SetColumn(this.btn_updatedept, 1);
            this.btn_updatedept.Location = new System.Drawing.Point(339, 938);
            this.btn_updatedept.Name = "btn_updatedept";
            this.tablePanel1.SetRow(this.btn_updatedept, 3);
            this.btn_updatedept.Size = new System.Drawing.Size(918, 57);
            this.btn_updatedept.TabIndex = 5;
            this.btn_updatedept.Text = "Change the department this employee is assigned to";
            this.btn_updatedept.Click += new System.EventHandler(this.btn_updatedept_Click);
            // 
            // lbl_empemail_assigned
            // 
            this.lbl_empemail_assigned.Location = new System.Drawing.Point(3, 167);
            this.lbl_empemail_assigned.Name = "lbl_empemail_assigned";
            this.lbl_empemail_assigned.Size = new System.Drawing.Size(187, 33);
            this.lbl_empemail_assigned.TabIndex = 4;
            this.lbl_empemail_assigned.Text = "Employee Email";
            // 
            // txt_empemail
            // 
            this.txt_empemail.Location = new System.Drawing.Point(339, 164);
            this.txt_empemail.Name = "txt_empemail";
            this.txt_empemail.Size = new System.Drawing.Size(918, 40);
            this.txt_empemail.TabIndex = 3;
            // 
            // txt_currentdeptname
            // 
            this.tablePanel1.SetColumn(this.txt_currentdeptname, 0);
            this.txt_currentdeptname.Location = new System.Drawing.Point(3, 397);
            this.txt_currentdeptname.Name = "txt_currentdeptname";
            this.tablePanel1.SetRow(this.txt_currentdeptname, 1);
            this.txt_currentdeptname.Size = new System.Drawing.Size(315, 33);
            this.txt_currentdeptname.TabIndex = 6;
            this.txt_currentdeptname.Text = "Current Department Name";
            // 
            // textBox1
            // 
            this.tablePanel1.SetColumn(this.textBox1, 1);
            this.textBox1.Location = new System.Drawing.Point(339, 394);
            this.textBox1.Name = "textBox1";
            this.tablePanel1.SetRow(this.textBox1, 1);
            this.textBox1.Size = new System.Drawing.Size(918, 40);
            this.textBox1.TabIndex = 7;
            // 
            // lbl_newdeptname
            // 
            this.tablePanel1.SetColumn(this.lbl_newdeptname, 0);
            this.lbl_newdeptname.Location = new System.Drawing.Point(3, 673);
            this.lbl_newdeptname.Name = "lbl_newdeptname";
            this.tablePanel1.SetRow(this.lbl_newdeptname, 2);
            this.lbl_newdeptname.Size = new System.Drawing.Size(278, 33);
            this.lbl_newdeptname.TabIndex = 8;
            this.lbl_newdeptname.Text = "New Department Name";
            // 
            // txt_newdeptname
            // 
            this.tablePanel1.SetColumn(this.txt_newdeptname, 1);
            this.txt_newdeptname.Location = new System.Drawing.Point(339, 670);
            this.txt_newdeptname.Name = "txt_newdeptname";
            this.tablePanel1.SetRow(this.txt_newdeptname, 2);
            this.txt_newdeptname.Size = new System.Drawing.Size(918, 40);
            this.txt_newdeptname.TabIndex = 9;
            // 
            // EditAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 1105);
            this.Controls.Add(this.tablePanel1);
            this.Name = "EditAssignment";
            this.Text = "EditAssignment";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton btn_updatedept;
        private DevExpress.XtraEditors.LabelControl lbl_empemail_assigned;
        private System.Windows.Forms.TextBox txt_empemail;
        private System.Windows.Forms.TextBox txt_newdeptname;
        private DevExpress.XtraEditors.LabelControl lbl_newdeptname;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl txt_currentdeptname;
    }
}