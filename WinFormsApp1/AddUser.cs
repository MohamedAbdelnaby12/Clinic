using Clinic.BLL.Repository.Abstract;
using Clinic.BLL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class AddUser : Form
    {
        private readonly IReceptionistService _receptionistService;
        private readonly IAuthService _authService;

        public AddUser(IReceptionistService receptionistService , IAuthService authService)
        {
            InitializeComponent();
            _receptionistService = receptionistService;
            _authService = authService;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string name = tName.Text.Trim();
            string phone = Phone.Text.Trim();
            string email = Email.Text.Trim();
            string password = Password.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email) ||
                 string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            bool success = await _receptionistService.AddReceptionistAndUserAsync(name, phone, email, password);

            if (success)
            {
                MessageBox.Show("User added successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add user. Please try again.");
            }
        }
    }
}
