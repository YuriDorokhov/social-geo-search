using Social_geo_search.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models;

namespace Social_geo_search.Data.Repositories
{
    public class PersonRepositoryMock : IPersonRepository
    {
        public IEnumerable<Person> GetPersons()
        {
            return new Person[]
            {
                new Person(){FacebookLink = "facebookLinkMock_1"},
                new Person(){FacebookLink = "facebookLinkMock_2"},
                new Person(){FacebookLink = "facebookLinkMock_3"}
            };
        }
    }
}
