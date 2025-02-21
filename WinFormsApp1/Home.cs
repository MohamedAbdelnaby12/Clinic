using Microsoft.Extensions.DependencyInjection;

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
            Doctor doctor = new Doctor();
            doctor.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var patient = Program.ServiceProvider.GetRequiredService<PatientWindow>();
            patient.Show();
            //Patient Patient = new Patient();
            //Patient.Show();
            ////this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            //this.Hide();
        }
    }
}
