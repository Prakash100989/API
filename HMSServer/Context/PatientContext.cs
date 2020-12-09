using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HMSServer.Models;
using Microsoft.EntityFrameworkCore;

namespace HMSServer.Context
{
    public class PatientContext : DbContext
    {
        public PatientContext(DbContextOptions<PatientContext> options) : base(options)
        {

        }
        public DbSet<Patient> Patient { get; set; }

    
    }
}
