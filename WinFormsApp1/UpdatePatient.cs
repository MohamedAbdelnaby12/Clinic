using Clinic.BLL.Repository.Abstract;
using Clinic.DAL.Enums;

namespace WinFormsApp1
{
    public partial class UpdatePatient : Form
    {
        private readonly IPatientService _patientService;
        private int PatientId;

        public UpdatePatient(IPatientService patientService, int PatientId)
        {
            InitializeComponent();
            _patientService = patientService;
            this.PatientId = PatientId;
        }
        private async void UpdatePatient_Load(object sender, EventArgs e)
        {
            try
            {
                // Fetch patient from the database
                var patient = await _patientService.GetPatientById(PatientId);

                if (patient == null)
                {
                    MessageBox.Show("Patient not found.");
                    this.Close();
                    return;
                }

                //initialize gender
                gender.DataSource = Enum.GetValues(typeof(Gender));

                // Fill form fields with retrieved data
                name.Text = patient.Name;
                age.Text = patient.Age.ToString();
                phone.Text = patient.Phone;
                email.Text = patient.Email;
                gender.SelectedItem = patient.Gender;
            }
            catch (Exception ex)
            {
                MessageBox.Show("please try again ..");
            }
        }
        private async void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(name.Text) ||
                    string.IsNullOrWhiteSpace(age.Text) ||
                    string.IsNullOrWhiteSpace(phone.Text))
                {
                    MessageBox.Show("Please fill all required fields.");
                    return;
                }

                if (!int.TryParse(age.Text, out int ageValue))
                {
                    MessageBox.Show("Please enter a valid number for age.");
                    return;
                }

                if (gender.SelectedItem == null)
                {
                    MessageBox.Show("Please select a gender.");
                    return;
                }

                // Convert gender string to enum
                Gender genderToAdd = (Gender)Enum.Parse(typeof(Gender), gender.SelectedItem.ToString());

                // Create updated patient object
                var updatedPatient = new Clinic.DAL.Entities.Patient
                {
                    Id = PatientId,
                    Name = name.Text,
                    Age = ageValue,
                    Phone = phone.Text,
                    Email = email.Text,
                    Gender = genderToAdd
                };

                // Update patient in database
                bool isUpdated = await _patientService.UpdateAsync(updatedPatient);
                if (isUpdated)
                {
                    MessageBox.Show("Patient updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update patient.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {

            //    var patient = new Patient
            //    {
            //        Name = UpdatePatient_Name.Text,
            //        Age = int.Parse(UpdatePatient_Age.Text),
            //        Phone = UpdatePatient_Phone.Text,
            //        Email = UpdatePatient_Email.Text,
            //        Gender = (Gender)Enum.Parse(typeof(Gender), UpdatePatient_Gender.Text)
            //    };
            //    bool isUpdated = await _patientService.UpdateAsync(patient);
            //    if (isUpdated)
            //        MessageBox.Show("Updated Successfully");
            //    MessageBox.Show("Failed To Update");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


    }
}
