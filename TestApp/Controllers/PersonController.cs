using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TestApp.Models;
using TestApp.Repos;

namespace TestApp.Controllers
{
    public class PersonController : ApiController
    {
        private readonly IRepository _repository;

        public PersonController()
        {
            _repository = new DbPersonRepo();
        }

        public IEnumerable<Person> GetPersons()
        {
            return _repository.GetPersons;
        }

        public Person GetPerson(int id)
        {
            return _repository.GetPerson(id);
        }
        [HttpGet]
        public IHttpActionResult PiopleSex(bool id)
        {
            var result = _repository.GetSexPerson(id);
            return Ok(result);
        } 
    }
}
