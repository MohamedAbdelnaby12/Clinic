using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL.Entities
{
    public class Schedule:BaseEntity
    {
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

        //Relations
        public Doctor Doctor { get; set; }
    }
}
