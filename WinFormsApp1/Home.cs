using Clinic.BLL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Home : Form
    {
        private readonly IPatientService _patientService;

        public Home(IPatientService patientService)
        {
            InitializeComponent();
            _patientService = patientService;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Patient Patient = new Patient(_patientService);
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
