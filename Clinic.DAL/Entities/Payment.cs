using Clinic.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL.Entities
{
    public class Payment:BaseEntity
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public PaymentMethod  PaymentMethod { get; set; }


        //Relations
        public Appointment Appointment { get; set; }
    }
}
