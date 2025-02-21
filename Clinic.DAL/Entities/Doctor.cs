using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.DAL.Repository.Abstract;

namespace Clinic.DAL.Entities
{
    public class Doctor:BaseEntity 
    {
        public string Name { get; set; }
        public string? Specialization { get; set; }
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        //Relations
        public Schedule Schedule { get; set; }
        public int ScheduleId { get; set; }

        public ICollection<Appointment> Appointments = new HashSet<Appointment>();
    }
}
