namespace StudentWindowsFormsApp
{
    partial class EmployeeForm
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
            this.Employees = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lb_llastname = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_startdate = new System.Windows.Forms.Label();
            this.lbl_enddate = new System.Windows.Forms.Label();
            this.dateTime_enddate = new System.Windows.Forms.DateTimePicker();
            this.dateTime_startdate = new System.Windows.Forms.DateTimePicker();
            this.chkbox_activate = new System.Windows.Forms.CheckBox();
            this.btnEmpSubmit = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.viewEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // Employees
            // 
            this.Employees.AutoSize = true;
            this.Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees.Location = new System.Drawing.Point(311, 19);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(182, 37);
            this.Employees.TabIndex = 1;
            this.Employees.Text = "Employees";
            this.Employees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(32, 102);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(146, 20);
            this.txt_firstname.TabIndex = 2;
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Location = new System.Drawing.Point(27, 69);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(57, 13);
            this.lbl_firstname.TabIndex = 3;
            this.lbl_firstname.Text = "First Name";
            // 
            // lb_llastname
            // 
            this.lb_llastname.AutoSize = true;
            this.lb_llastname.Location = new System.Drawing.Point(222, 69);
            this.lb_llastname.Name = "lb_llastname";
            this.lb_llastname.Size = new System.Drawing.Size(58, 13);
            this.lb_llastname.TabIndex = 5;
            this.lb_llastname.Text = "Last Name";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(218, 102);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(170, 20);
            this.txt_lastname.TabIndex = 4;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(49, 136);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(78, 13);
            this.lbl_phone.TabIndex = 7;
            this.lbl_phone.Text = "Phone Number";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(256, 136);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 9;
            this.lbl_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(241, 167);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 11;
            // 
            // lbl_startdate
            // 
            this.lbl_startdate.AutoSize = true;
            this.lbl_startdate.Location = new System.Drawing.Point(428, 136);
            this.lbl_startdate.Name = "lbl_startdate";
            this.lbl_startdate.Size = new System.Drawing.Size(55, 13);
            this.lbl_startdate.TabIndex = 13;
            this.lbl_startdate.Text = "Start Date";
            // 
            // lbl_enddate
            // 
            this.lbl_enddate.AutoSize = true;
            this.lbl_enddate.Location = new System.Drawing.Point(479, 70);
            this.lbl_enddate.Name = "lbl_enddate";
            this.lbl_enddate.Size = new System.Drawing.Size(52, 13);
            this.lbl_enddate.TabIndex = 16;
            this.lbl_enddate.Text = "End Date";
            // 
            // dateTime_enddate
            // 
            this.dateTime_enddate.Location = new System.Drawing.Point(429, 98);
            this.dateTime_enddate.Name = "dateTime_enddate";
            this.dateTime_enddate.Size = new System.Drawing.Size(199, 20);
            this.dateTime_enddate.TabIndex = 17;
            // 
            // dateTime_startdate
            // 
            this.dateTime_startdate.Location = new System.Drawing.Point(429, 164);
            this.dateTime_startdate.Name = "dateTime_startdate";
            this.dateTime_startdate.Size = new System.Drawing.Size(211, 20);
            this.dateTime_startdate.TabIndex = 18;
            // 
            // chkbox_activate
            // 
            this.chkbox_activate.AutoSize = true;
            this.chkbox_activate.Checked = true;
            this.chkbox_activate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbox_activate.Location = new System.Drawing.Point(732, 89);
            this.chkbox_activate.Name = "chkbox_activate";
            this.chkbox_activate.Size = new System.Drawing.Size(108, 17);
            this.chkbox_activate.TabIndex = 19;
            this.chkbox_activate.Text = "Activate Account";
            this.chkbox_activate.UseVisualStyleBackColor = true;
            // 
            // btnEmpSubmit
            // 
            this.btnEmpSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmpSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnEmpSubmit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpSubmit.Location = new System.Drawing.Point(759, 144);
            this.btnEmpSubmit.Name = "btnEmpSubmit";
            this.btnEmpSubmit.Size = new System.Drawing.Size(91, 51);
            this.btnEmpSubmit.TabIndex = 20;
            this.btnEmpSubmit.Text = "Submit Form";
            this.btnEmpSubmit.UseVisualStyleBackColor = true;
            this.btnEmpSubmit.Click += new System.EventHandler(this.btnEmpSubmit_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(52, 160);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 22;
            // 
            // viewEmployees
            // 
            this.viewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewEmployees.Location = new System.Drawing.Point(30, 213);
            this.viewEmployees.Name = "viewEmployees";
            this.viewEmployees.Size = new System.Drawing.Size(842, 256);
            this.viewEmployees.TabIndex = 23;
            // 
            // EmployeeForm
            // 
            this.ClientSize = new System.Drawing.Size(896, 518);
            this.Controls.Add(this.viewEmployees);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnEmpSubmit);
            this.Controls.Add(this.chkbox_activate);
            this.Controls.Add(this.dateTime_startdate);
            this.Controls.Add(this.dateTime_enddate);
            this.Controls.Add(this.lbl_enddate);
            this.Controls.Add(this.lbl_startdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lb_llastname);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.lbl_firstname);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.Employees);
            this.Name = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource assignmentBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource studentprojectdbDataSetBindingSource;
        private System.Windows.Forms.BindingSource studentprojectdbDataSetBindingSource1;
        private System.Windows.Forms.Label Employees;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Label lb_llastname;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_startdate;
        private System.Windows.Forms.Label lbl_enddate;
        private System.Windows.Forms.DateTimePicker dateTime_enddate;
        private System.Windows.Forms.DateTimePicker dateTime_startdate;
        private System.Windows.Forms.CheckBox chkbox_activate;
        private System.Windows.Forms.Button btnEmpSubmit;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridView viewEmployees;
    }
}

