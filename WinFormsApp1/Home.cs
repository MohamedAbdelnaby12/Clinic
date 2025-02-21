using Clinic.BLL.Repository.Abstract;
using Clinic.BLL.Services.Abstract;
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
        private bool isAdmin;
        private readonly IReceptionistService _receptionistService;
        private readonly IAuthService _authService;

        public Home(IPatientService patientService, bool isAdmin,IReceptionistService receptionistService,IAuthService authService)
        {
            InitializeComponent();
            _patientService = patientService;
            this.isAdmin = isAdmin;
            _receptionistService = receptionistService;
            _authService = authService;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (!isAdmin)
                addUser.Hide();
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

        private void addUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(_receptionistService ,_authService);
            addUser.Show();
        }
    }
}
