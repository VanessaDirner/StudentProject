using DevExpress.XtraEditors;

namespace StudentWindowsFormsApp
{
    partial class EditDepartment
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
            this.lbl_editdeptname = new DevExpress.XtraEditors.LabelControl();
            this.txt_editdeptname = new DevExpress.XtraEditors.TextEdit();
            this.btn_editdepartment = new DevExpress.XtraEditors.SimpleButton();
            this.txt_editdeptabbrv = new DevExpress.XtraEditors.TextEdit();
            this.lbl_deptabbrv = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_editdeptname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_editdeptabbrv.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.txt_editdeptabbrv);
            this.tablePanel1.Controls.Add(this.lbl_deptabbrv);
            this.tablePanel1.Controls.Add(this.btn_editdepartment);
            this.tablePanel1.Controls.Add(this.txt_editdeptname);
            this.tablePanel1.Controls.Add(this.lbl_editdeptname);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F)});
            this.tablePanel1.Size = new System.Drawing.Size(1569, 990);
            this.tablePanel1.TabIndex = 0;
            // 
            // lbl_editdeptname
            // 
            this.tablePanel1.SetColumn(this.lbl_editdeptname, 0);
            this.lbl_editdeptname.Location = new System.Drawing.Point(3, 140);
            this.lbl_editdeptname.Name = "lbl_editdeptname";
            this.tablePanel1.SetRow(this.lbl_editdeptname, 0);
            this.lbl_editdeptname.Size = new System.Drawing.Size(218, 33);
            this.lbl_editdeptname.TabIndex = 0;
            this.lbl_editdeptname.Text = "Department Name";
            // 
            // txt_editdeptname
            // 
            this.tablePanel1.SetColumn(this.txt_editdeptname, 1);
            this.txt_editdeptname.Location = new System.Drawing.Point(788, 133);
            this.txt_editdeptname.Name = "txt_editdeptname";
            this.tablePanel1.SetRow(this.txt_editdeptname, 0);
            this.txt_editdeptname.Size = new System.Drawing.Size(779, 48);
            this.txt_editdeptname.TabIndex = 1;
            // 
            // btn_editdepartment
            // 
            this.tablePanel1.SetColumn(this.btn_editdepartment, 1);
            this.btn_editdepartment.Location = new System.Drawing.Point(788, 780);
            this.btn_editdepartment.Name = "btn_editdepartment";
            this.tablePanel1.SetRow(this.btn_editdepartment, 2);
            this.btn_editdepartment.Size = new System.Drawing.Size(779, 57);
            this.btn_editdepartment.TabIndex = 2;
            this.btn_editdepartment.Text = "Submit changes to this department";
            this.btn_editdepartment.Click += new System.EventHandler(this.btn_editdepartment_Click);
            // 
            // txt_editdeptabbrv
            // 
            this.tablePanel1.SetColumn(this.txt_editdeptabbrv, 1);
            this.txt_editdeptabbrv.Location = new System.Drawing.Point(788, 447);
            this.txt_editdeptabbrv.Name = "txt_editdeptabbrv";
            this.tablePanel1.SetRow(this.txt_editdeptabbrv, 1);
            this.txt_editdeptabbrv.Size = new System.Drawing.Size(779, 48);
            this.txt_editdeptabbrv.TabIndex = 4;
            // 
            // lbl_deptabbrv
            // 
            this.tablePanel1.SetColumn(this.lbl_deptabbrv, 0);
            this.lbl_deptabbrv.Location = new System.Drawing.Point(3, 454);
            this.lbl_deptabbrv.Name = "lbl_deptabbrv";
            this.tablePanel1.SetRow(this.lbl_deptabbrv, 1);
            this.lbl_deptabbrv.Size = new System.Drawing.Size(297, 33);
            this.lbl_deptabbrv.TabIndex = 3;
            this.lbl_deptabbrv.Text = "Department Abbreviation";
            // 
            // EditDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 990);
            this.Controls.Add(this.tablePanel1);
            this.Name = "EditDepartment";
            this.Text = "EditDepartment";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_editdeptname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_editdeptabbrv.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private SimpleButton btn_editdepartment;
        private TextEdit txt_editdeptname;
        private LabelControl lbl_editdeptname;
        private TextEdit txt_editdeptabbrv;
        private LabelControl lbl_deptabbrv;
    }
}