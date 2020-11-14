using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ResumeAngularNet.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ResumeAngularNet.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly ResumeAngularDBContext _ctx;
        public ContactController(ResumeAngularDBContext ctx)
        {
            _ctx = ctx;
        }

        // GET: api/<ContactController>

        //[HttpGet]
        //public IEnumerable<Contact> Get()
        //{
        //    var myContact = _ctx.Contact;
        //    List<Contact> myContactNow = myContact.Where(e => e.Id == 8).ToList();
        //    return myContactNow;
        //}

        [HttpGet]
        public Contact Get()
        {
            var myContact = _ctx.Contact;
            Contact myContactNow = myContact.Where(e => e.Id == 8).FirstOrDefault();
            return myContactNow;
        }



        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ContactController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
