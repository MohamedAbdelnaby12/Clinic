using Clinic.BLL.Repository.Abstract;
using Clinic.BLL.Services.Abstract;

namespace WinFormsApp1
{
    public partial class Home : Form
    {
        private readonly IPatientService _patientService;
        private bool isAdmin;
        private readonly IReceptionistService _receptionistService;
        private readonly IAuthService _authService;
        private readonly IExcelSheetService _excelSheetService;

        public Home(IPatientService patientService, bool isAdmin, IReceptionistService receptionistService, IAuthService authService, IExcelSheetService excelSheetService)
        {
            InitializeComponent();
            _patientService = patientService;
            this.isAdmin = isAdmin;
            _receptionistService = receptionistService;
            _authService = authService;
            _excelSheetService = excelSheetService;
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

            //var patient = Program.ServiceProvider.GetRequiredService<PatientWindow>();
            //patient.Show();
            //Patient Patient = new Patient();
            //Patient.Show();
            ////this.Hide();
            PatientWindow Patient = new PatientWindow(_patientService, _excelSheetService);
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
            AddUser addUser = new AddUser(_receptionistService, _authService);
            addUser.Show();
        }
    }
}
