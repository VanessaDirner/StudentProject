namespace StudentWindowsFormsApp
{
    partial class EditEmployee
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
            this.tblpanel_addemp = new DevExpress.Utils.Layout.TablePanel();
            this.txt_editphonenum = new System.Windows.Forms.TextBox();
            this.lbl_editfirstname = new System.Windows.Forms.Label();
            this.btnEmpEditSubmit = new System.Windows.Forms.Button();
            this.chkbox_editactivate = new System.Windows.Forms.CheckBox();
            this.dateTime_editstartdate = new System.Windows.Forms.DateTimePicker();
            this.dateTime_editenddate = new System.Windows.Forms.DateTimePicker();
            this.lbl_editenddate = new System.Windows.Forms.Label();
            this.lbl_editstartdate = new System.Windows.Forms.Label();
            this.lbl_editemail = new System.Windows.Forms.Label();
            this.txt_editemail = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lb_editllastname = new System.Windows.Forms.Label();
            this.txt_editlastname = new System.Windows.Forms.TextBox();
            this.txt_editfirstname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblpanel_addemp)).BeginInit();
            this.tblpanel_addemp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpanel_addemp
            // 
            this.tblpanel_addemp.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55.6F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 24.4F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tblpanel_addemp.Controls.Add(this.txt_editphonenum);
            this.tblpanel_addemp.Controls.Add(this.lbl_editfirstname);
            this.tblpanel_addemp.Controls.Add(this.btnEmpEditSubmit);
            this.tblpanel_addemp.Controls.Add(this.chkbox_editactivate);
            this.tblpanel_addemp.Controls.Add(this.dateTime_editstartdate);
            this.tblpanel_addemp.Controls.Add(this.dateTime_editenddate);
            this.tblpanel_addemp.Controls.Add(this.lbl_editenddate);
            this.tblpanel_addemp.Controls.Add(this.lbl_editstartdate);
            this.tblpanel_addemp.Controls.Add(this.lbl_editemail);
            this.tblpanel_addemp.Controls.Add(this.txt_editemail);
            this.tblpanel_addemp.Controls.Add(this.lbl_phone);
            this.tblpanel_addemp.Controls.Add(this.lb_editllastname);
            this.tblpanel_addemp.Controls.Add(this.txt_editlastname);
            this.tblpanel_addemp.Controls.Add(this.txt_editfirstname);
            this.tblpanel_addemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpanel_addemp.Location = new System.Drawing.Point(0, 0);
            this.tblpanel_addemp.Name = "tblpanel_addemp";
            this.tblpanel_addemp.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 132.8F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 168.2F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 207.2001F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 273.3999F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tblpanel_addemp.Size = new System.Drawing.Size(1829, 1263);
            this.tblpanel_addemp.TabIndex = 1;
            // 
            // txt_editphonenum
            // 
            this.tblpanel_addemp.SetColumn(this.txt_editphonenum, 6);
            this.txt_editphonenum.Location = new System.Drawing.Point(1555, 46);
            this.txt_editphonenum.Name = "txt_editphonenum";
            this.tblpanel_addemp.SetRow(this.txt_editphonenum, 0);
            this.txt_editphonenum.Size = new System.Drawing.Size(271, 40);
            this.txt_editphonenum.TabIndex = 37;
            // 
            // lbl_editfirstname
            // 
            this.lbl_editfirstname.AutoSize = true;
            this.tblpanel_addemp.SetColumn(this.lbl_editfirstname, 0);
            this.lbl_editfirstname.Location = new System.Drawing.Point(3, 49);
            this.lbl_editfirstname.Name = "lbl_editfirstname";
            this.tblpanel_addemp.SetRow(this.lbl_editfirstname, 0);
            this.lbl_editfirstname.Size = new System.Drawing.Size(150, 34);
            this.lbl_editfirstname.TabIndex = 25;
            this.lbl_editfirstname.Text = "First Name";
            // 
            // btnEmpEditSubmit
            // 
            this.btnEmpEditSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tblpanel_addemp.SetColumn(this.btnEmpEditSubmit, 6);
            this.btnEmpEditSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnEmpEditSubmit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpEditSubmit.Location = new System.Drawing.Point(1555, 996);
            this.btnEmpEditSubmit.Name = "btnEmpEditSubmit";
            this.tblpanel_addemp.SetRow(this.btnEmpEditSubmit, 4);
            this.btnEmpEditSubmit.Size = new System.Drawing.Size(271, 51);
            this.btnEmpEditSubmit.TabIndex = 36;
            this.btnEmpEditSubmit.Text = "Submit Form";
            this.btnEmpEditSubmit.UseVisualStyleBackColor = true;
            // 
            // chkbox_editactivate
            // 
            this.chkbox_editactivate.AutoSize = true;
            this.chkbox_editactivate.Checked = true;
            this.chkbox_editactivate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tblpanel_addemp.SetColumn(this.chkbox_editactivate, 4);
            this.chkbox_editactivate.Location = new System.Drawing.Point(1001, 1003);
            this.chkbox_editactivate.Name = "chkbox_editactivate";
            this.tblpanel_addemp.SetRow(this.chkbox_editactivate, 4);
            this.chkbox_editactivate.Size = new System.Drawing.Size(259, 38);
            this.chkbox_editactivate.TabIndex = 35;
            this.chkbox_editactivate.Text = "Activate Account";
            this.chkbox_editactivate.UseVisualStyleBackColor = true;
            // 
            // dateTime_editstartdate
            // 
            this.tblpanel_addemp.SetColumn(this.dateTime_editstartdate, 2);
            this.dateTime_editstartdate.Location = new System.Drawing.Point(446, 384);
            this.dateTime_editstartdate.Name = "dateTime_editstartdate";
            this.tblpanel_addemp.SetRow(this.dateTime_editstartdate, 2);
            this.dateTime_editstartdate.Size = new System.Drawing.Size(271, 40);
            this.dateTime_editstartdate.TabIndex = 34;
            // 
            // dateTime_editenddate
            // 
            this.tblpanel_addemp.SetColumn(this.dateTime_editenddate, 4);
            this.dateTime_editenddate.Location = new System.Drawing.Point(1001, 384);
            this.dateTime_editenddate.Name = "dateTime_editenddate";
            this.tblpanel_addemp.SetRow(this.dateTime_editenddate, 2);
            this.dateTime_editenddate.Size = new System.Drawing.Size(271, 40);
            this.dateTime_editenddate.TabIndex = 33;
            // 
            // lbl_editenddate
            // 
            this.lbl_editenddate.AutoSize = true;
            this.tblpanel_addemp.SetColumn(this.lbl_editenddate, 3);
            this.lbl_editenddate.Location = new System.Drawing.Point(724, 387);
            this.lbl_editenddate.Name = "lbl_editenddate";
            this.tblpanel_addemp.SetRow(this.lbl_editenddate, 2);
            this.lbl_editenddate.Size = new System.Drawing.Size(129, 34);
            this.lbl_editenddate.TabIndex = 32;
            this.lbl_editenddate.Text = "End Date";
            // 
            // lbl_editstartdate
            // 
            this.lbl_editstartdate.AutoSize = true;
            this.tblpanel_addemp.SetColumn(this.lbl_editstartdate, 0);
            this.lbl_editstartdate.Location = new System.Drawing.Point(3, 387);
            this.lbl_editstartdate.Name = "lbl_editstartdate";
            this.tblpanel_addemp.SetRow(this.lbl_editstartdate, 2);
            this.lbl_editstartdate.Size = new System.Drawing.Size(141, 34);
            this.lbl_editstartdate.TabIndex = 31;
            this.lbl_editstartdate.Text = "Start Date";
            // 
            // lbl_editemail
            // 
            this.lbl_editemail.AutoSize = true;
            this.tblpanel_addemp.SetColumn(this.lbl_editemail, 3);
            this.lbl_editemail.Location = new System.Drawing.Point(724, 200);
            this.lbl_editemail.Name = "lbl_editemail";
            this.tblpanel_addemp.SetRow(this.lbl_editemail, 1);
            this.lbl_editemail.Size = new System.Drawing.Size(82, 34);
            this.lbl_editemail.TabIndex = 30;
            this.lbl_editemail.Text = "Email";
            // 
            // txt_editemail
            // 
            this.tblpanel_addemp.SetColumn(this.txt_editemail, 4);
            this.txt_editemail.Location = new System.Drawing.Point(1001, 197);
            this.txt_editemail.Name = "txt_editemail";
            this.tblpanel_addemp.SetRow(this.txt_editemail, 1);
            this.txt_editemail.Size = new System.Drawing.Size(271, 40);
            this.txt_editemail.TabIndex = 29;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.tblpanel_addemp.SetColumn(this.lbl_phone, 5);
            this.lbl_phone.Location = new System.Drawing.Point(1278, 49);
            this.lbl_phone.Name = "lbl_phone";
            this.tblpanel_addemp.SetRow(this.lbl_phone, 0);
            this.lbl_phone.Size = new System.Drawing.Size(200, 34);
            this.lbl_phone.TabIndex = 28;
            this.lbl_phone.Text = "Phone Number";
            // 
            // lb_editllastname
            // 
            this.lb_editllastname.AutoSize = true;
            this.tblpanel_addemp.SetColumn(this.lb_editllastname, 3);
            this.lb_editllastname.Location = new System.Drawing.Point(724, 49);
            this.lb_editllastname.Name = "lb_editllastname";
            this.tblpanel_addemp.SetRow(this.lb_editllastname, 0);
            this.lb_editllastname.Size = new System.Drawing.Size(148, 34);
            this.lb_editllastname.TabIndex = 27;
            this.lb_editllastname.Text = "Last Name";
            // 
            // txt_editlastname
            // 
            this.tblpanel_addemp.SetColumn(this.txt_editlastname, 4);
            this.txt_editlastname.Location = new System.Drawing.Point(1001, 46);
            this.txt_editlastname.Name = "txt_editlastname";
            this.tblpanel_addemp.SetRow(this.txt_editlastname, 0);
            this.txt_editlastname.Size = new System.Drawing.Size(271, 40);
            this.txt_editlastname.TabIndex = 26;
            // 
            // txt_editfirstname
            // 
            this.tblpanel_addemp.SetColumn(this.txt_editfirstname, 2);
            this.txt_editfirstname.Location = new System.Drawing.Point(446, 46);
            this.txt_editfirstname.Name = "txt_editfirstname";
            this.tblpanel_addemp.SetRow(this.txt_editfirstname, 0);
            this.txt_editfirstname.Size = new System.Drawing.Size(271, 40);
            this.txt_editfirstname.TabIndex = 24;
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1829, 1263);
            this.Controls.Add(this.tblpanel_addemp);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.tblpanel_addemp)).EndInit();
            this.tblpanel_addemp.ResumeLayout(false);
            this.tblpanel_addemp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tblpanel_addemp;
        private System.Windows.Forms.TextBox txt_editphonenum;
        private System.Windows.Forms.Label lbl_editfirstname;
        private System.Windows.Forms.Button btnEmpEditSubmit;
        private System.Windows.Forms.CheckBox chkbox_editactivate;
        private System.Windows.Forms.DateTimePicker dateTime_editstartdate;
        private System.Windows.Forms.DateTimePicker dateTime_editenddate;
        private System.Windows.Forms.Label lbl_editenddate;
        private System.Windows.Forms.Label lbl_editstartdate;
        private System.Windows.Forms.Label lbl_editemail;
        private System.Windows.Forms.TextBox txt_editemail;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lb_editllastname;
        private System.Windows.Forms.TextBox txt_editlastname;
        private System.Windows.Forms.TextBox txt_editfirstname;
    }
}