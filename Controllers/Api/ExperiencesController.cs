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
    public class ExperiencesController : ControllerBase
    {
        private readonly ResumeAngularDBContext _ctx;
        public ExperiencesController(ResumeAngularDBContext ctx)
        {
            _ctx = ctx;
        }

        // GET: api/<ExperiencesController>
        [HttpGet]
        public IEnumerable<Company> Get()
        {
            //var myExperience = db.Experiences;
            //List<Experience> myExperienceNow = myExperience.Where(e => e.contact == 8).ToList();
            //return myExperienceNow;
            var myExperience = _ctx.Experience.Where(e => e.Contact == 8);
            var myEx = myExperience.Select(e => new Company
            {
                company = e.Company,
                City = e.City,
                Country = e.Country,
                //ExperienceItems = e.ExperienceItem.Select(i => new CompanyItem
                ExperienceItems = e.ExperienceItem.Select(i => new CompanyItem
                {
                    dateIni = i.DateIni,
                    dateFin = i.DateFin,
                    description = i.Description,
                    title = i.Title
                }).ToList()
            }).ToList();
            return myEx;
        }

        // GET api/<ExperiencesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ExperiencesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExperiencesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExperiencesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
