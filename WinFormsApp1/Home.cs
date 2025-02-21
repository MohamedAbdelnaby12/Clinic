﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic.BLL.Repository.Implementation;
using Clinic.DAL.Repository.Implementation;
using Clinic.DAL;
using static System.Windows.Forms.DataFormats;
using Microsoft.Extensions.DependencyInjection;
using Clinic.BLL.Repository.Abstract;

namespace WinFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Service = Program.ServiceProvider.GetRequiredService<IDoctorService>();
            var doctorWindow = new Doctor(Service);
            doctorWindow.Show();

            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Patient Patient = new Patient();
            Patient.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            //this.Hide();
        }
    }
}
