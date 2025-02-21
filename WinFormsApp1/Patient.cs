using Clinic.BLL.Repository.Abstract;
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
using Clinic.BLL.Services.Abstract;
using Clinic.DAL.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace WinFormsApp1
{
    public partial class PatientWindow : Form
    {
        private readonly IPatientService _patientService;
        private readonly IExcelSheetService _excelSheetService;

        public PatientWindow(IPatientService patientService, IExcelSheetService excelSheetService)
        {

            InitializeComponent();
            _patientService = patientService;
            _excelSheetService = excelSheetService;
        }
        public PatientWindow()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private async Task SearchPatientsAsync()
        {
            //  get by name in txtbox
            string searchText = Patient_Search_TxtBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                Patient_DGV.DataSource = null;
                return;
            }

            var patients = await _patientService.GetPatientByName(searchText);

            if (patients.Any())
            {
                Patient_DGV.DataSource = patients;
            }
            else
            {
                MessageBox.Show("There is no matching patient.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Patient_DGV.DataSource = null;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await SearchPatientsAsync();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var patient = Program.ServiceProvider.GetRequiredService<AddPatient>();
            patient.Show();
            //AddPatient addPatient = new AddPatient();
            //addPatient.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdatePatient updatePatient = new UpdatePatient(_patientService,2);
            updatePatient.Show();
            //this.Hide();
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            // To Search During Typing.... 
            await SearchPatientsAsync();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            //select patient
            if (Patient_DGV.SelectedRows.Count > 0)
            {
                var Ans = MessageBox.Show("Are You Sure To Delete This Patient?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Ans == DialogResult.Yes)
                {
                    var PatientID = Convert.ToInt32(Patient_DGV.SelectedRows[0].Cells["Id"].Value);
                    await _patientService.DeleteAsync(PatientID);
                    await SearchPatientsAsync();
                    MessageBox.Show("Patient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a patient to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(async () =>
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                    openFileDialog.Title = "Select Patients Excel File";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;

                        try
                        {
                            List<Patient> patients = _excelSheetService.ImportPatientsFromExcel(filePath);

                            if (patients == null)
                            {
                                MessageBox.Show("Invalid file structure! Please use the correct template.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            foreach (Patient pat in patients)
                            {
                                await _patientService.AddAsync(pat);
                            }

                            MessageBox.Show("Patients uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error processing file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            #region Old
            //using (OpenFileDialog openFileDialog = new OpenFileDialog())
            //{
            //    openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            //    openFileDialog.Title = "Select Patients Excel File";

            //    if (openFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        string filePath = openFileDialog.FileName;

            //        try
            //        {
            //            List<Patient> patients = _excelSheetService.ImportPatientsFromExcel(filePath);

            //            if (patients == null)
            //            {
            //                MessageBox.Show("Invalid file structure! Please use the correct template.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                return;
            //            }
            //            foreach (Patient pat in patients)
            //            {
            //                await _patientService.AddAsync(pat);

            //            }
            //            //SaveCustomersToDatabase(customers);
            //            MessageBox.Show("Patients uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Error processing file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //} 
            #endregion
        }  // ImportToDBButton

        private async void button6_Click(object sender, EventArgs e)   // ExportToExcelButton
        {
            List<Patient> patients = await _patientService.GetAllAsync();

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Patients.xlsx");

            try
            {
                _excelSheetService.ExportToExcel(patients, filePath);
                MessageBox.Show("Excel file exported successfully at: " + filePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
