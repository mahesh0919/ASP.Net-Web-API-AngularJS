using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVC4_WebAPI.Models;

namespace MVC4_WebAPI.Controllers
{
    public class PersonController : ApiController
    {
        PersonOperations persons = new PersonOperations();

        // GET api/person
        public IEnumerable<Person> Get()
        {
            return persons._persons.AsEnumerable();
        }

        // GET api/person/5
        public Person Get(int id)
        {
            return persons.GetPersonbyID(id);
        }

        // POST api/person
        public void Post([FromBody]Person value)
        {
        }

        // PUT api/person/5
        public void Put(int id, [FromBody]Person value)
        {
        }

        // DELETE api/person/5
        public void Delete(int id)
        {
        }
    }
}
