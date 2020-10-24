using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Model;
using WebAPI.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private ContextDB _db;
        public ContactController(ContextDB db)
        {
            _db = db;
        }

        // GET: api/<ContactController>
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            var lista = _db.Contacts.ToList();
            return lista;
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public Contact Get(int id)
        {
            return _db.Contacts.SingleOrDefault(c => c.ContactID == id);
        }

        // POST api/<ContactController>
        [HttpPost]
        public void Post([FromBody] ContactViewModel value)
        {
            var contact = new Contact()
            {
                ContactName = value.ContactName,
                ContactEmail = value.ContactEmail,
                ContactTel = value.ContactTel
            };

            _db.Contacts.Add(contact);
            _db.SaveChanges();
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ContactViewModel value)
        {
            var contact = _db.Contacts.SingleOrDefault(c => c.ContactID == id);
            if (contact != null)
            {
                contact.ContactName = value.ContactName;
                contact.ContactEmail = value.ContactEmail;
                contact.ContactTel = value.ContactTel;
            }
            _db.SaveChanges();
        }

        //// DELETE api/<ContactController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
