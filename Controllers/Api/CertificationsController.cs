using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResumeAngularNet.Models;
using ExtensionMethods;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ResumeAngularNet.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificationsController : ControllerBase
    {
        private readonly ResumeAngularDBContext _ctx;
        public CertificationsController(ResumeAngularDBContext ctx)
        {
            _ctx = ctx;
        }
        // GET: api/<CertificationsController>
        [HttpGet]
        //public IEnumerable<string> Get()
        public IEnumerable<string> Get()
        {
            var myCertification = _ctx.Certification;


            //List<Certification> myCertifica = myCertification.Where(e => e.Contact == 8).ToList();
            //.Select(t => t.Title).ToList();


            List<string> myCertifica = myCertification.Where(e => e.Contact == 8)
                .Select(t => "assets/"+t.Title
                .Replace(" ", "").Replace(".", "").Replace(":", "").Replace(",", "").Replace("#", "") + ".png")
                .ToList();
            return myCertifica;
        }


        // GET api/<CertificationsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CertificationsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CertificationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CertificationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}


