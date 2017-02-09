using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models;

namespace SocialGeoSearch.Data.Interfaces
{
    public interface IPersonRepository
    {
		IEnumerable<Person> GetPersons(double latitude, double longitude, int radius);
    }
}
