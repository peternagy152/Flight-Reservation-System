﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace LoginPage
{
    public partial class Crystal_Report : Form
    {
        CrystalReport1 c;
        public Crystal_Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            {

                c.SetParameterValue(0, global.passuser);
                crystalReportViewer1.ReportSource = c;
            }
        }

        private void Crystal_Report_Load(object sender, EventArgs e)
        {
             c = new CrystalReport1();

        }
    }
}
