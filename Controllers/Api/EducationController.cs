using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResumeAngularNet.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ResumeAngularNet.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        private readonly ResumeAngularDBContext _ctx;
        public EducationController(ResumeAngularDBContext ctx)
        {
            _ctx = ctx;
        }
        // GET: api/<EducationController>
        [HttpGet]
        public IEnumerable<Education> Get()
        {
            var myEducation = _ctx.Education;
            List<Education> myEducationNow = myEducation.Where(e => e.Contact == 8).ToList();
            return myEducationNow;
        }

        // GET api/<EducationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EducationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EducationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EducationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
