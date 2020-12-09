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
    public class DoctorController : ControllerBase
    {
        readonly DoctorContext DocDetails;
        public DoctorController(DoctorContext doctorContext)
        {
            DocDetails = doctorContext;
        }

        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            var data =DocDetails.Doctor.ToList();
            return data;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Doctor obj)
        {
            var data = DocDetails.Doctor.Add(obj);
            DocDetails.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Doctor obj)
        {
            var data = DocDetails.Doctor.Update(obj);
            DocDetails.SaveChanges();
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var data = DocDetails.Doctor.Where(a => a.ID == id).FirstOrDefault();
            DocDetails.Doctor.Remove(data);
            PatDetails.SaveChanges();
            DocDetails Ok();

        }
    }
}
