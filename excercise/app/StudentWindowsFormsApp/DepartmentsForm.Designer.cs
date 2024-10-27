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
            this.viewDepartments = new System.Windows.Forms.DataGridView();
            this.btnDeptSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_llastname = new System.Windows.Forms.Label();
            this.txt_deptabbr = new System.Windows.Forms.TextBox();
            this.lbl_deptName = new System.Windows.Forms.Label();
            this.txt_deptname = new System.Windows.Forms.TextBox();
            this.Departments = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // viewDepartments
            // 
            this.viewDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDepartments.Location = new System.Drawing.Point(-19, 194);
            this.viewDepartments.Name = "viewDepartments";
            this.viewDepartments.Size = new System.Drawing.Size(842, 256);
            this.viewDepartments.TabIndex = 40;
            // 
            // btnDeptSubmit
            // 
            this.btnDeptSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeptSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnDeptSubmit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeptSubmit.Location = new System.Drawing.Point(688, 55);
            this.btnDeptSubmit.Name = "btnDeptSubmit";
            this.btnDeptSubmit.Size = new System.Drawing.Size(91, 51);
            this.btnDeptSubmit.TabIndex = 38;
            this.btnDeptSubmit.Text = "Submit Form";
            this.btnDeptSubmit.UseVisualStyleBackColor = true;
            this.btnDeptSubmit.Click += new System.EventHandler(this.btnDeptSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 32;
            // 
            // lb_llastname
            // 
            this.lb_llastname.AutoSize = true;
            this.lb_llastname.Location = new System.Drawing.Point(266, 50);
            this.lb_llastname.Name = "lb_llastname";
            this.lb_llastname.Size = new System.Drawing.Size(124, 13);
            this.lb_llastname.TabIndex = 28;
            this.lb_llastname.Text = "Department Abbreviation";
            // 
            // txt_deptabbr
            // 
            this.txt_deptabbr.Location = new System.Drawing.Point(253, 83);
            this.txt_deptabbr.Name = "txt_deptabbr";
            this.txt_deptabbr.Size = new System.Drawing.Size(170, 20);
            this.txt_deptabbr.TabIndex = 27;
            // 
            // lbl_deptName
            // 
            this.lbl_deptName.AutoSize = true;
            this.lbl_deptName.Location = new System.Drawing.Point(12, 50);
            this.lbl_deptName.Name = "lbl_deptName";
            this.lbl_deptName.Size = new System.Drawing.Size(93, 13);
            this.lbl_deptName.TabIndex = 26;
            this.lbl_deptName.Text = "Department Name";
            // 
            // txt_deptname
            // 
            this.txt_deptname.Location = new System.Drawing.Point(12, 83);
            this.txt_deptname.Name = "txt_deptname";
            this.txt_deptname.Size = new System.Drawing.Size(146, 20);
            this.txt_deptname.TabIndex = 25;
            // 
            // Departments
            // 
            this.Departments.AutoSize = true;
            this.Departments.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departments.Location = new System.Drawing.Point(262, 0);
            this.Departments.Name = "Departments";
            this.Departments.Size = new System.Drawing.Size(211, 37);
            this.Departments.TabIndex = 24;
            this.Departments.Text = "Departments";
            this.Departments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewDepartments);
            this.Controls.Add(this.btnDeptSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_llastname);
            this.Controls.Add(this.txt_deptabbr);
            this.Controls.Add(this.lbl_deptName);
            this.Controls.Add(this.txt_deptname);
            this.Controls.Add(this.Departments);
            this.Name = "DepartmentsForm";
            this.Text = "ManageDepartments";
            this.Load += new System.EventHandler(this.DepartmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewDepartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewDepartments;
        private System.Windows.Forms.Button btnDeptSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_llastname;
        private System.Windows.Forms.TextBox txt_deptabbr;
        private System.Windows.Forms.Label lbl_deptName;
        private System.Windows.Forms.TextBox txt_deptname;
        private System.Windows.Forms.Label Departments;
    }
}