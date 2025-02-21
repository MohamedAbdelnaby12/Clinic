using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic.BLL.Repository.Abstract;
using Clinic.BLL.Repository.Implementation;
using Clinic.DAL.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class UpdateDoctor : Form
    {
        private readonly IDoctorService _doctorService;
        private readonly IScheduleService _scheduleService;

        private Clinic.DAL.Entities.Doctor _doctor;


        public UpdateDoctor(IDoctorService doctorService, Clinic.DAL.Entities.Doctor doctor, IScheduleService scheduleService)
        {
            InitializeComponent();
            _doctorService = doctorService;
            _doctor = doctor;
            _scheduleService = scheduleService;

            LoadDoctorData();
        }

        private void LoadDoctorData()
        {
            textBox1.Text = _doctor.Name;
            textBox2.Text = _doctor.Specialization;
            textBox3.Text = _doctor.Phone;
            textBox4.Text = _doctor.Email;
            textBox5.Text = _doctor.ScheduleId.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (_doctorService == null)
            {
                MessageBox.Show("Doctor service is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _doctor.Name = textBox1.Text;
            _doctor.Specialization = textBox2.Text;
            _doctor.Phone = textBox3.Text;
            _doctor.Email = textBox4.Text;
            _doctor.ScheduleId = Convert.ToInt32(textBox5.Text);

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox5.Text, out int scheduleId))
            {
                MessageBox.Show("Invalid Schedule ID. Please enter a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existingSchedule = await _scheduleService.GetByIdAsync(scheduleId);
            if (existingSchedule == null)
            {
                MessageBox.Show("The entered Schedule ID does not exist.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           

            bool isUpdated = await _doctorService.UpdateAsync(_doctor);
            if (isUpdated)
            {
                MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateDoctor_Load(object sender, EventArgs e)
        {

        }
    }
}
