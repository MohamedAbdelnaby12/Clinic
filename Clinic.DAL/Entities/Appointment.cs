using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL.Entities
{
    public class Appointment:BaseEntity
    {
        public DateTime Time { get; set; }
        public DateTime FollowUpDate { get; set; }


        //Relations
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }

        public Patient Patient { get; set; }
        public int PatientId { get; set; }

        public Payment Payment { get; set; }
        public int PaymentId { get; set; }
        public Receptionist Receptionist { get; set; }
        public int ReceptionistId { get; set; }
    }
}
