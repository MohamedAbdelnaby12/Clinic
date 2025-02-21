using Clinic.BLL.Services.Abstract;
using Clinic.DAL.Entities;
using Clinic.DAL.Enums;
using OfficeOpenXml;


namespace Clinic.BLL.Services
{
    public class ExcelSheetService : IExcelSheetService
    {
        public void ExportToExcel<T>(List<T> data, string filePath)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // Required for EPPlus

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Patients");
                var properties = typeof(T).GetProperties();

                // Add headers
                for (int i = 0; i < properties.Length; i++)
                {
                    worksheet.Cells[1, i + 1].Value = properties[i].Name;
                }

                // Add data if available
                if (data.Count > 0)
                {
                    for (int row = 0; row < data.Count; row++)
                    {
                        for (int col = 0; col < properties.Length; col++)
                        {
                            var value = properties[col].GetValue(data[row]);
                            worksheet.Cells[row + 2, col + 1].Value = value;
                        }
                    }
                }

                worksheet.Cells.AutoFitColumns();

                File.WriteAllBytes(filePath, package.GetAsByteArray());
            }
        }

        public List<Patient> ImportPatientsFromExcel(string filePath)
        {
            List<Patient> patients = new List<Patient>();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Required for EPPlus

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets.FirstOrDefault();
                if (worksheet == null)
                    return null;

                // Expected headers
                List<string> expectedHeaders = new List<string> { "Name", "Age", "Phone", "Email", "Gender", "Id" };
                List<string> fileHeaders = new List<string>();

                for (int col = 1; col <= expectedHeaders.Count; col++)
                {
                    fileHeaders.Add(worksheet.Cells[1, col].Text);
                }

                // Validate headers
                if (!fileHeaders.SequenceEqual(expectedHeaders))
                    return null;

                // Read data from row 2 onward
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    if (string.IsNullOrWhiteSpace(worksheet.Cells[row, 1].Text)) continue; // Skip empty rows

                    patients.Add(new Patient
                    {
                        //Id = int.TryParse(worksheet.Cells[row, 6].Text, out int id) ? id : 0,
                        Name = worksheet.Cells[row, 1].Text,
                        Age = Convert.ToInt32(worksheet.Cells[row, 2].Text),
                        Phone = worksheet.Cells[row, 3].Text,
                        Email = worksheet.Cells[row, 4].Text,
                        Gender = (Gender)Enum.Parse(typeof(Gender), worksheet.Cells[row, 5].Text)
                    });
                }
            }

            return patients;

        }
    }

}
