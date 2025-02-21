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
using Clinic.DAL;
using Clinic.DAL.Entities;
using Clinic.DAL.Repository.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace WinFormsApp1
{
    public partial class Doctor : Form
    {

        private readonly IDoctorService _doctorService;
        public Doctor(IDoctorService doctorService)
        {
            InitializeComponent();
            _doctorService = doctorService;
        }



        private void Doctor_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var services = Program.ServiceProvider.GetRequiredService<IDoctorService>();
            var scheduleService = Program.ServiceProvider.GetRequiredService<IScheduleService>();
            var AddDoctorWindoes = new AddDoctor(services, scheduleService);
            AddDoctorWindoes.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a doctor to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedDoctor = (Clinic.DAL.Entities.Doctor)dataGridView1.SelectedRows[0].DataBoundItem;

            var doctorService = Program.ServiceProvider.GetRequiredService<IDoctorService>();
            var scheduleService = Program.ServiceProvider.GetRequiredService<IScheduleService>();
            var updateDoctorForm = new UpdateDoctor(doctorService, selectedDoctor, scheduleService);
             updateDoctorForm.Show();

            //this.Hide();
            LoadDoctors();

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a doctor to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedDoctor = dataGridView1.SelectedRows[0].DataBoundItem as Clinic.DAL.Entities.Doctor;

            if (selectedDoctor == null)
            {
                MessageBox.Show("Invalid selection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await _doctorService.DeleteAsync(selectedDoctor);
            MessageBox.Show("Doctor deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            await LoadDoctors();
        }

        private async Task LoadDoctors()
        {
            var doctors = await _doctorService.GetAllAsync();
            dataGridView1.DataSource = doctors.ToList();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text.ToLower();

            var doctors = await _doctorService.GetAllAsync();
            var filteredDoctors = doctors.Where(d => d.Name.ToLower().Contains(searchQuery)).ToList();

            dataGridView1.DataSource = filteredDoctors;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var services = Program.ServiceProvider.GetRequiredService<IScheduleService>();
            var sheduleWindow = new Schedule(services);
            sheduleWindow.Show();
        }
    }
}
