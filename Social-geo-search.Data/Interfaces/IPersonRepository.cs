using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models;

namespace Social_geo_search.Data.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPersons();
    }
}
