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

namespace WinFormsApp1
{
    public partial class Patient : Form
    {
        private readonly IPatientService _patientService;

        public Patient(IPatientService patientService)
        {
            InitializeComponent();
            _patientService = patientService;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdatePatient updatePatient = new UpdatePatient(_patientService,2);
            updatePatient.Show();
            //this.Hide();
        }
    }
}
