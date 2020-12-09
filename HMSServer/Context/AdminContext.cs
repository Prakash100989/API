using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HMSServer.Context;
using HMSServer.Models;
using Microsoft.AspNetCore.Http;

namespace HMSServer.Context
{
    public class AdminContext : DbContext
    {
        public Admin(DbContextOptions<AdminContext> options) : base(options)
        {

            Doctor
        public DbSet<Admin> Admin { get; set; }


    }
    {
    }
}
