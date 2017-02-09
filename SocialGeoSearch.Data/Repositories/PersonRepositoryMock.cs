using SocialGeoSearch.Data.DataAccess;
using SocialGeoSearch.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models;

namespace SocialGeoSearch.Data.Repositories
{
    public class PersonRepositoryMock : IPersonRepository
    {
		public IEnumerable<Person> GetPersons(double latitude, double longitude, int radius)
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
