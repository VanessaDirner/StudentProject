﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWindowsFormsApp
{
    public partial class EditDepartment : Form
    {

        private readonly studentprojectEntities _studentprojectEntities = new studentprojectEntities();


        public EditDepartment()
        {
            InitializeComponent();
            _studentprojectEntities = new studentprojectEntities();
        }

        private void btn_editdepartment_Click(object sender, EventArgs e)
        {

        }
    }
}
