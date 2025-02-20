using Clinic.DAL.Enums;
using System.ComponentModel.DataAnnotations;

namespace Clinic.DAL.Entities
{
    public class Patient : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public Gender Gender { get; set; }

        //Relations
        public ICollection<Appointment> Appointments = new HashSet<Appointment>();


    }
}
