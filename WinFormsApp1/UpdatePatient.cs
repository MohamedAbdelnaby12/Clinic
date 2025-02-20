using Clinic.BLL.Repository.Abstract;
using Clinic.DAL.Entities;
using Clinic.DAL.Enums;

namespace WinFormsApp1
{
    public partial class UpdatePatient : Form
    {
        private readonly IPatientService _patientService;

        public UpdatePatient(IPatientService patientService)
        {
            InitializeComponent();
            this._patientService = patientService;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var patient = new Patient
            {
                Name = UpdatePatient_Name.Text,
                Age = int.Parse(UpdatePatient_Age.Text),
                Phone = UpdatePatient_Phone.Text,
                Email = UpdatePatient_Email.Text,
                Gender = (Gender)Enum.Parse(typeof(Gender), UpdatePatient_Gender.Text)
            };
            bool isUpdated = await _patientService.UpdateAsync(patient);
            if (isUpdated)
                MessageBox.Show("Updated Successfully");
            MessageBox.Show("Failed To Update");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
