using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudwithRepositary.Model
{
    public class appointments
    {
        [Key]
        public int AppointmentID { get; set; }
        public int ReturnCode { get; set; }
    }
}
