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
    public class PatientController : ControllerBase
    {
        readonly PatientContext PatDetails;
        public PatientController(PatientContext patientContext)
        {
            PatDetails = patientContext;
        }

        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            var data = PatDetails.Patient.ToList();
            return data;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Patient obj)
        {
            var data = PatDetails.Patient.Add(obj);
            PatDetails.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Patient obj)
        {
            var data = PatDetails.Patient.Update(obj);
            PatDetails.SaveChanges();
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var data = PatDetails.Patient.Where(a => a.ID == id).FirstOrDefault();
            PatDetails.Patient.Remove(data);
            PatDetails.SaveChanges();
            return Ok();

        }
    }
}
