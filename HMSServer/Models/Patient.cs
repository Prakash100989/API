using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HMSServer.Models
{
    public class Patient
    {
        [Key]
        public int? ID { get; set;  }
        public string AppinmentDate { get; set; }
        public string AppoinmentTime { get; set; }
        public string Location { get; set; }
        public string Doctor { get; set; }
    }
}
