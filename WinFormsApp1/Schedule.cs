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
    public partial class Schedule : Form
    {
        private readonly IScheduleService _scheduleService;
        public Schedule(IScheduleService scheduleService)
        {
            InitializeComponent();
            _scheduleService = scheduleService;


            //dateTimePicker1.Format = DateTimePickerFormat.Time;
            //dateTimePicker2.ShowUpDown = true;
            //dateTimePicker1.Format = DateTimePickerFormat.Time;
            //dateTimePicker2.ShowUpDown = true;

        }

        public Schedule()
        {
            InitializeComponent();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Schedule_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            TimeOnly startTime = TimeOnly.FromDateTime(dateTimePicker1.Value);
            TimeOnly endTime = TimeOnly.FromDateTime(dateTimePicker2.Value);
            if (endTime <= startTime)
            {
                MessageBox.Show("End time must be after start time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var schedule = new Clinic.DAL.Entities.Schedule
            {
                StartTime = startTime,
                EndTime = endTime,
            };
            await _scheduleService.AddAsync(schedule);
            MessageBox.Show("Schedule added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
