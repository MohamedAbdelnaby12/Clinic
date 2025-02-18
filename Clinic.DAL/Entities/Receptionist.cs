using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL.Entities
{
    public class Receptionist:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        //Relations
        public ICollection<Appointment> Appointments = new HashSet<Appointment>();
    }
}
