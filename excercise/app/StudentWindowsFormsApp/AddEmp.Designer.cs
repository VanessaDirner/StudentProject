﻿namespace StudentWindowsFormsApp
{
    partial class AddEmp
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
            this.btnEmpSubmit = new System.Windows.Forms.Button();
            this.chkbox_activate = new System.Windows.Forms.CheckBox();
            this.dateTime_startdate = new System.Windows.Forms.DateTimePicker();
            this.dateTime_enddate = new System.Windows.Forms.DateTimePicker();
            this.lbl_enddate = new System.Windows.Forms.Label();
            this.lbl_startdate = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lb_llastname = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_phonenum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55.6F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 24.4F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.txt_phonenum);
            this.tablePanel1.Controls.Add(this.lbl_firstname);
            this.tablePanel1.Controls.Add(this.btnEmpSubmit);
            this.tablePanel1.Controls.Add(this.chkbox_activate);
            this.tablePanel1.Controls.Add(this.dateTime_startdate);
            this.tablePanel1.Controls.Add(this.dateTime_enddate);
            this.tablePanel1.Controls.Add(this.lbl_enddate);
            this.tablePanel1.Controls.Add(this.lbl_startdate);
            this.tablePanel1.Controls.Add(this.lbl_email);
            this.tablePanel1.Controls.Add(this.txt_email);
            this.tablePanel1.Controls.Add(this.lbl_phone);
            this.tablePanel1.Controls.Add(this.lb_llastname);
            this.tablePanel1.Controls.Add(this.txt_lastname);
            this.tablePanel1.Controls.Add(this.txt_firstname);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 132.8F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 168.2F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 207.2001F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 273.3999F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(2117, 1223);
            this.tablePanel1.TabIndex = 0;
            // 
            // btnEmpSubmit
            // 
            this.btnEmpSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tablePanel1.SetColumn(this.btnEmpSubmit, 6);
            this.btnEmpSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnEmpSubmit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpSubmit.Location = new System.Drawing.Point(1799, 976);
            this.btnEmpSubmit.Name = "btnEmpSubmit";
            this.tablePanel1.SetRow(this.btnEmpSubmit, 4);
            this.btnEmpSubmit.Size = new System.Drawing.Size(315, 51);
            this.btnEmpSubmit.TabIndex = 36;
            this.btnEmpSubmit.Text = "Submit Form";
            this.btnEmpSubmit.UseVisualStyleBackColor = true;
            this.btnEmpSubmit.Click += new System.EventHandler(this.btnEmpSubmit_Click);
            // 
            // chkbox_activate
            // 
            this.chkbox_activate.AutoSize = true;
            this.chkbox_activate.Checked = true;
            this.chkbox_activate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tablePanel1.SetColumn(this.chkbox_activate, 4);
            this.chkbox_activate.Location = new System.Drawing.Point(1158, 983);
            this.chkbox_activate.Name = "chkbox_activate";
            this.tablePanel1.SetRow(this.chkbox_activate, 4);
            this.chkbox_activate.Size = new System.Drawing.Size(259, 38);
            this.chkbox_activate.TabIndex = 35;
            this.chkbox_activate.Text = "Activate Account";
            this.chkbox_activate.UseVisualStyleBackColor = true;
            // 
            // dateTime_startdate
            // 
            this.tablePanel1.SetColumn(this.dateTime_startdate, 2);
            this.dateTime_startdate.Location = new System.Drawing.Point(516, 384);
            this.dateTime_startdate.Name = "dateTime_startdate";
            this.tablePanel1.SetRow(this.dateTime_startdate, 2);
            this.dateTime_startdate.Size = new System.Drawing.Size(315, 40);
            this.dateTime_startdate.TabIndex = 34;
            // 
            // dateTime_enddate
            // 
            this.tablePanel1.SetColumn(this.dateTime_enddate, 4);
            this.dateTime_enddate.Location = new System.Drawing.Point(1158, 384);
            this.dateTime_enddate.Name = "dateTime_enddate";
            this.tablePanel1.SetRow(this.dateTime_enddate, 2);
            this.dateTime_enddate.Size = new System.Drawing.Size(315, 40);
            this.dateTime_enddate.TabIndex = 33;
            // 
            // lbl_enddate
            // 
            this.lbl_enddate.AutoSize = true;
            this.tablePanel1.SetColumn(this.lbl_enddate, 3);
            this.lbl_enddate.Location = new System.Drawing.Point(837, 387);
            this.lbl_enddate.Name = "lbl_enddate";
            this.tablePanel1.SetRow(this.lbl_enddate, 2);
            this.lbl_enddate.Size = new System.Drawing.Size(129, 34);
            this.lbl_enddate.TabIndex = 32;
            this.lbl_enddate.Text = "End Date";
            // 
            // lbl_startdate
            // 
            this.lbl_startdate.AutoSize = true;
            this.tablePanel1.SetColumn(this.lbl_startdate, 0);
            this.lbl_startdate.Location = new System.Drawing.Point(3, 387);
            this.lbl_startdate.Name = "lbl_startdate";
            this.tablePanel1.SetRow(this.lbl_startdate, 2);
            this.lbl_startdate.Size = new System.Drawing.Size(141, 34);
            this.lbl_startdate.TabIndex = 31;
            this.lbl_startdate.Text = "Start Date";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.tablePanel1.SetColumn(this.lbl_email, 3);
            this.lbl_email.Location = new System.Drawing.Point(837, 200);
            this.lbl_email.Name = "lbl_email";
            this.tablePanel1.SetRow(this.lbl_email, 1);
            this.lbl_email.Size = new System.Drawing.Size(82, 34);
            this.lbl_email.TabIndex = 30;
            this.lbl_email.Text = "Email";
            // 
            // txt_email
            // 
            this.tablePanel1.SetColumn(this.txt_email, 4);
            this.txt_email.Location = new System.Drawing.Point(1158, 197);
            this.txt_email.Name = "txt_email";
            this.tablePanel1.SetRow(this.txt_email, 1);
            this.txt_email.Size = new System.Drawing.Size(315, 40);
            this.txt_email.TabIndex = 29;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.tablePanel1.SetColumn(this.lbl_phone, 5);
            this.lbl_phone.Location = new System.Drawing.Point(1478, 49);
            this.lbl_phone.Name = "lbl_phone";
            this.tablePanel1.SetRow(this.lbl_phone, 0);
            this.lbl_phone.Size = new System.Drawing.Size(200, 34);
            this.lbl_phone.TabIndex = 28;
            this.lbl_phone.Text = "Phone Number";
            // 
            // lb_llastname
            // 
            this.lb_llastname.AutoSize = true;
            this.tablePanel1.SetColumn(this.lb_llastname, 3);
            this.lb_llastname.Location = new System.Drawing.Point(837, 49);
            this.lb_llastname.Name = "lb_llastname";
            this.tablePanel1.SetRow(this.lb_llastname, 0);
            this.lb_llastname.Size = new System.Drawing.Size(148, 34);
            this.lb_llastname.TabIndex = 27;
            this.lb_llastname.Text = "Last Name";
            // 
            // txt_lastname
            // 
            this.tablePanel1.SetColumn(this.txt_lastname, 4);
            this.txt_lastname.Location = new System.Drawing.Point(1158, 46);
            this.txt_lastname.Name = "txt_lastname";
            this.tablePanel1.SetRow(this.txt_lastname, 0);
            this.txt_lastname.Size = new System.Drawing.Size(315, 40);
            this.txt_lastname.TabIndex = 26;
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.tablePanel1.SetColumn(this.lbl_firstname, 0);
            this.lbl_firstname.Location = new System.Drawing.Point(3, 49);
            this.lbl_firstname.Name = "lbl_firstname";
            this.tablePanel1.SetRow(this.lbl_firstname, 0);
            this.lbl_firstname.Size = new System.Drawing.Size(150, 34);
            this.lbl_firstname.TabIndex = 25;
            this.lbl_firstname.Text = "First Name";
            // 
            // txt_firstname
            // 
            this.tablePanel1.SetColumn(this.txt_firstname, 2);
            this.txt_firstname.Location = new System.Drawing.Point(516, 46);
            this.txt_firstname.Name = "txt_firstname";
            this.tablePanel1.SetRow(this.txt_firstname, 0);
            this.txt_firstname.Size = new System.Drawing.Size(315, 40);
            this.txt_firstname.TabIndex = 24;
            // 
            // txt_phonenum
            // 
            this.tablePanel1.SetColumn(this.txt_phonenum, 6);
            this.txt_phonenum.Location = new System.Drawing.Point(1799, 46);
            this.txt_phonenum.Name = "txt_phonenum";
            this.tablePanel1.SetRow(this.txt_phonenum, 0);
            this.txt_phonenum.Size = new System.Drawing.Size(315, 40);
            this.txt_phonenum.TabIndex = 37;
            // 
            // AddEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2117, 1223);
            this.Controls.Add(this.tablePanel1);
            this.Name = "AddEmp";
            this.Text = "AddEmp";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Button btnEmpSubmit;
        private System.Windows.Forms.CheckBox chkbox_activate;
        private System.Windows.Forms.DateTimePicker dateTime_startdate;
        private System.Windows.Forms.DateTimePicker dateTime_enddate;
        private System.Windows.Forms.Label lbl_enddate;
        private System.Windows.Forms.Label lbl_startdate;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lb_llastname;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_phonenum;
    }
}