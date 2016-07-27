using Social_geo_search.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models;

namespace Social_geo_search.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public IEnumerable<Person> GetPersons()
        {
            throw new NotImplementedException();
        }
    }
}
