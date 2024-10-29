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
            ((System.ComponentModel.ISupportInitialize)(this.viewAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAssignments
            // 
            this.viewAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAssignments.Location = new System.Drawing.Point(24, 298);
            this.viewAssignments.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.viewAssignments.Name = "viewAssignments";
            this.viewAssignments.RowHeadersWidth = 82;
            this.viewAssignments.Size = new System.Drawing.Size(1552, 567);
            this.viewAssignments.TabIndex = 40;
            // 
            // btn_assign_submit
            // 
            this.btn_assign_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_assign_submit.ForeColor = System.Drawing.Color.Black;
            this.btn_assign_submit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_assign_submit.Location = new System.Drawing.Point(1330, 96);
            this.btn_assign_submit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_assign_submit.Name = "btn_assign_submit";
            this.btn_assign_submit.Size = new System.Drawing.Size(182, 98);
            this.btn_assign_submit.TabIndex = 38;
            this.btn_assign_submit.Text = "Submit Form";
            this.btn_assign_submit.UseVisualStyleBackColor = true;
            this.btn_assign_submit.Click += new System.EventHandler(this.btn_assign_submit_Click);
            // 
            // lbl_assign_email
            // 
            this.lbl_assign_email.AutoSize = true;
            this.lbl_assign_email.Location = new System.Drawing.Point(166, 96);
            this.lbl_assign_email.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_assign_email.Name = "lbl_assign_email";
            this.lbl_assign_email.Size = new System.Drawing.Size(332, 50);
            this.lbl_assign_email.TabIndex = 31;
            this.lbl_assign_email.Text = "Employee Email";
            // 
            // txt_assign_email
            // 
            this.txt_assign_email.Location = new System.Drawing.Point(144, 156);
            this.txt_assign_email.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_assign_email.Name = "txt_assign_email";
            this.txt_assign_email.Size = new System.Drawing.Size(196, 31);
            this.txt_assign_email.TabIndex = 30;
            // 
            // Assignments
            // 
            this.Assignments.AutoSize = true;
            this.Assignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assignments.Location = new System.Drawing.Point(450, 0);
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
            this.lbl_assign_deptName.Location = new System.Drawing.Point(516, 96);
            this.lbl_assign_deptName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_assign_deptName.Name = "lbl_assign_deptName";
            this.lbl_assign_deptName.Size = new System.Drawing.Size(185, 25);
            this.lbl_assign_deptName.TabIndex = 42;
            this.lbl_assign_deptName.Text = "Department Name";
            // 
            // txt_assign_deptname
            // 
            this.txt_assign_deptname.Location = new System.Drawing.Point(516, 160);
            this.txt_assign_deptname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_assign_deptname.Name = "txt_assign_deptname";
            this.txt_assign_deptname.Size = new System.Drawing.Size(288, 31);
            this.txt_assign_deptname.TabIndex = 41;
            // 
            // AssignmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.lbl_assign_deptName);
            this.Controls.Add(this.txt_assign_deptname);
            this.Controls.Add(this.viewAssignments);
            this.Controls.Add(this.btn_assign_submit);
            this.Controls.Add(this.lbl_assign_email);
            this.Controls.Add(this.txt_assign_email);
            this.Controls.Add(this.Assignments);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AssignmentsForm";
            this.Text = "ManageAssignments";
            this.Load += new System.EventHandler(this.AssignemntsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAssignments)).EndInit();
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
    }
}