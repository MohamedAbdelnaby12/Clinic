using Clinic.BLL.Repository.Abstract;
using Clinic.DAL.Entities;
using Clinic.DAL.Enums;

namespace WinFormsApp1
{
    public partial class AddPatient : Form
    {
        private readonly IPatientService _patientService;

        public AddPatient(IPatientService patientService)
        {
            InitializeComponent();
            _patientService = patientService;
        }
        public AddPatient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var genderList = Enum.GetValues(typeof(Gender))
                        .Cast<Gender>()
                        .Select(g => new { Name = g.ToString(), Value = (int)g })
                        .ToList();

            AddPatient_Gender.DataSource = genderList;
            AddPatient_Gender.DisplayMember = "Name";
            AddPatient_Gender.ValueMember = "Value";
            //AddPatient_Gender.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_3(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            var patient = new Patient
            {
                Name = AddPatient_Name.Text,
                Age = int.Parse(AddPatient_Age.Text),
                Phone = AddPatient_Phone.Text,
                Email = AddPatient_Email.Text,
                Gender = (Gender)Enum.Parse(typeof(Gender), AddPatient_Gender.Text)
            };
            await _patientService.AddAsync(patient);
            MessageBox.Show("Added Successfully");
            AddPatient_Name.Clear();
            AddPatient_Age.Clear();
            AddPatient_Phone.Clear();
            AddPatient_Email.Clear();
        }

        private void AddPatient_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddPatient_Gender.DataSource = Enum.GetValues(typeof(Gender));
        }

    }
}
