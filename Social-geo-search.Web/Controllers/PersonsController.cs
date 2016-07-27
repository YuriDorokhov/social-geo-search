using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.Models;
using Social_geo_search.Data.Interfaces;

namespace Web.Controllers
{
    public class PersonsController : ApiController
    {
        private IPersonRepository _personRepository;

        public PersonsController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public IEnumerable<Person> GetPersons()
        {
            return _personRepository.GetPersons();
        }
    }
}
