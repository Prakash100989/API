using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMSServer.Models
{
    public class Admin
    {
        [Key]
        public int? ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string DOB { get; set; }
        public int OptAdmin { get; set; }
        public int OptDoctor { get; set; }
        public int OptPatient { get; set; }
        public string Location { get; set; }
        public string CreatedaDate { get; set; }
    }
}
