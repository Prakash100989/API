using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HMSServer.Models;
using Microsoft.EntityFrameworkCore;

namespace HMSServer.Context
{
    public class DoctorContext : DbContext
    {
        public Doctor(DbContextOptions<PatientContext> options) : base(options)
        {

        Doctor
        public DbSet<Doctor> Doctor { get; set; }


    }
}
