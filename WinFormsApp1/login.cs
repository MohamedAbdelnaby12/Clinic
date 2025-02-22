using Clinic.BLL.Repository.Abstract;
using Clinic.BLL.Services.Abstract;
using Clinic.DAL.Entities;
using Microsoft.AspNetCore.Identity;

namespace WinFormsApp1
{
    public partial class login : Form
    {
        private readonly IAuthService _authService;
        private readonly IPatientService _patientService;
        private readonly IReceptionistService _receptionistService;
        private readonly IExcelSheetService _excelSheetService;
        private readonly IDoctorService _doctorService;
        private readonly IAppointmentService _appointmentService;
        private readonly IPaymentService _paymentService;
        private readonly UserManager<Receptionist> _userManager;

        public login(IAuthService authService, IPatientService patientService, IReceptionistService receptionistService, IExcelSheetService excelSheetService,IDoctorService doctorService,IAppointmentService appointmentService , IPaymentService paymentService,UserManager<Receptionist> userManager)
        {
            InitializeComponent();
            _authService = authService;
            _patientService = patientService;
            _receptionistService = receptionistService;
            _excelSheetService = excelSheetService;
            _doctorService = doctorService;
            _appointmentService = appointmentService;
            _paymentService = paymentService;
            _userManager = userManager;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = Password.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isAuthenticated = await _authService.LoginUser(username, password);

           //find user
           var user =await _userManager.FindByNameAsync(username);

            // Check if user is admin
            bool isAdmin = await _authService.CheckAdminRole(username);

            if (isAuthenticated)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Home homeForm = new Home(_patientService, isAdmin, _receptionistService, _authService, _excelSheetService,_doctorService,_appointmentService ,_paymentService,user.Id);
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
