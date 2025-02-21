using Clinic.DAL.Entities;

namespace Clinic.BLL.Services.Abstract
{
    public interface IExcelSheetService
    {
        void ExportToExcel<T>(List<T> data, string filePath);
        List<Patient> ImportPatientsFromExcel(string filePath);
    }
}
