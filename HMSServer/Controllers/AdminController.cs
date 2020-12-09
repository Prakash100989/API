using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HMSServer.Context;
using HMSServer.Models;
using Microsoft.AspNetCore.Http;

namespace HMSServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        readonly AdminContext AdmDetails;
        public AdminController(AdminContext adminContext)
        {
            AdmDetails = adminContext;
        }

        [HttpGet]
        public IEnumerable<Admin> Get()
        {
            var data = AdmDetails.Admin.ToList();
            return data;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Admin obj)
        {
            var data = AdmDetails.Admin.Add(obj);
            AdmDetails.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Admin obj)
        {
            var data = AdmDetails.Admin.Update(obj);
            AdmDetails.SaveChanges();
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var data = AdmDetails.Admin.Where(a => a.ID == id).FirstOrDefault();
            AdmDetails.Admin.Remove(data);
            AdmDetails.SaveChanges();
            return Ok();

        }
    }
}
