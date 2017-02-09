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
    public class PersonRepository : IPersonRepository
    {
        public IEnumerable<Person> GetPersons(double latitude, double longitude, int radius)
        {
			var ids = Redis.GetIdsInRadius(latitude, longitude, radius);

			FacebookApiEmulator facebookEmulator = new FacebookApiEmulator();
			return facebookEmulator.GetPersons(ids);
        }
    }
}
