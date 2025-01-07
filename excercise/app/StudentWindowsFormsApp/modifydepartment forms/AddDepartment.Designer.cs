namespace StudentWindowsFormsApp
{
    partial class AddDepartment
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_deptName = new System.Windows.Forms.Label();
            this.lbl_deptabbr = new System.Windows.Forms.Label();
            this.txt_deptName = new System.Windows.Forms.TextBox();
            this.txt_deptabbrv = new System.Windows.Forms.TextBox();
            this.btn_add_dept_submit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_deptName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_deptabbr, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_deptName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_deptabbrv, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_add_dept_submit, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(65, 98);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1072, 697);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_deptName
            // 
            this.lbl_deptName.AutoSize = true;
            this.lbl_deptName.Location = new System.Drawing.Point(3, 0);
            this.lbl_deptName.Name = "lbl_deptName";
            this.lbl_deptName.Size = new System.Drawing.Size(245, 32);
            this.lbl_deptName.TabIndex = 21;
            this.lbl_deptName.Text = "Department Name";
            // 
            // lbl_deptabbr
            // 
            this.lbl_deptabbr.AutoSize = true;
            this.lbl_deptabbr.Location = new System.Drawing.Point(3, 174);
            this.lbl_deptabbr.Name = "lbl_deptabbr";
            this.lbl_deptabbr.Size = new System.Drawing.Size(330, 32);
            this.lbl_deptabbr.TabIndex = 18;
            this.lbl_deptabbr.Text = "Department Abbreviation";
            // 
            // txt_deptName
            // 
            this.txt_deptName.Location = new System.Drawing.Point(539, 3);
            this.txt_deptName.Name = "txt_deptName";
            this.txt_deptName.Size = new System.Drawing.Size(170, 38);
            this.txt_deptName.TabIndex = 19;
            // 
            // txt_deptabbrv
            // 
            this.txt_deptabbrv.Location = new System.Drawing.Point(539, 177);
            this.txt_deptabbrv.Name = "txt_deptabbrv";
            this.txt_deptabbrv.Size = new System.Drawing.Size(146, 38);
            this.txt_deptabbrv.TabIndex = 17;
            // 
            // btn_add_dept_submit
            // 
            this.btn_add_dept_submit.Location = new System.Drawing.Point(539, 351);
            this.btn_add_dept_submit.Name = "btn_add_dept_submit";
            this.btn_add_dept_submit.Size = new System.Drawing.Size(210, 124);
            this.btn_add_dept_submit.TabIndex = 22;
            this.btn_add_dept_submit.Text = "Create Department";
            this.btn_add_dept_submit.UseVisualStyleBackColor = true;
            this.btn_add_dept_submit.Click += new System.EventHandler(this.btn_add_dept_submit_Click);
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 874);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddDepartment";
            this.Text = "AddDepartment";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_deptName;
        private System.Windows.Forms.Label lbl_deptabbr;
        private System.Windows.Forms.TextBox txt_deptName;
        private System.Windows.Forms.TextBox txt_deptabbrv;
        private System.Windows.Forms.Button btn_add_dept_submit;
    }
}