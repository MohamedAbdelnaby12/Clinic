using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic.BLL.Repository.Abstract;
using Clinic.BLL.Repository.Implementation;
using Clinic.DAL.Entities;

namespace WinFormsApp1
{
    public partial class AddDoctor : Form
    {
        private readonly IDoctorService _doctorService;
        private readonly IScheduleService _scheduleService;
        public AddDoctor(IDoctorService doctorService, IScheduleService scheduleService)
        {
            InitializeComponent();
            _doctorService = doctorService;
            _scheduleService = scheduleService;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
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


            var newdoc = new Clinic.DAL.Entities.Doctor
            {
                Name = textBox1.Text,
                Specialization = textBox2.Text,
                Phone = textBox3.Text,
                Email = textBox4.Text,
                ScheduleId = Convert.ToInt32(textBox5.Text),
            };
            var doctorWithSameSchedule = await _doctorService.GetByScheduleIdAsync(scheduleId);
            if (doctorWithSameSchedule != null)
            {
                MessageBox.Show("This Schedule ID is already assigned to another doctor. Please choose a different one.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await _doctorService.AddAsync(newdoc);
            MessageBox.Show("Doctor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
