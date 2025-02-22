using Clinic.BLL.Repository.Abstract;
using Clinic.DAL.Entities;
using Clinic.DAL.Enums;

namespace WinFormsApp1
{
    public partial class Book : Form
    {
        private readonly IDoctorService _doctorService;
        private readonly IAppointmentService _appointmentService;
        private readonly IPaymentService _paymentService;

        public int PatientId { get; }
        public int RecId { get; }

        public Book(IDoctorService doctorService, int patientId, IAppointmentService appointmentService, IPaymentService paymentService, int recId)
        {
            InitializeComponent();
            _doctorService = doctorService;
            PatientId = patientId;
            _appointmentService = appointmentService;
            _paymentService = paymentService;
            RecId = recId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddPatient form1 = new AddPatient();
            form1.Show();
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Book_Load(object sender, EventArgs e)
        {
            // Load doctors 
            var doctors = await _doctorService.GetAllAsync();
            comboBoxDoctors.DataSource = doctors;
            comboBoxDoctors.DisplayMember = "Name";
            comboBoxDoctors.ValueMember = "Id";

            //initialize payment method
            paymentmethod.DataSource = Enum.GetValues(typeof(PaymentMethod));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // Convert payment  string to enum
            PaymentMethod paymentToAdd = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), paymentmethod.SelectedItem.ToString());
            //Handle paymnet
            var payment = new Payment
            {
                Amount = 200,
                Date = DateTime.Now,
                PaymentMethod = paymentToAdd,
            };
            await _paymentService.AddPaymentAsync(payment);
            int doctorId = (int)comboBoxDoctors.SelectedValue;

            //Add appointment
            try
            {
                await _appointmentService.BookAppointmentAsync(doctorId, PatientId, DateTime.Now, payment, RecId);

                MessageBox.Show("Appointment booked successfully!");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to book. Try again.");

            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
