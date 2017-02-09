using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models;

namespace SocialGeoSearch.Data.DataAccess
{

	public class FacebookApiEmulator
	{
		Dictionary<string, Person> _users = new Dictionary<string, Person>()
        {
            {
                "1",
                new Person() {Id = "1", FacebookLink = "facebookLinkMock_1"}
            },
            {
                "2",
                new Person() {Id = "2", FacebookLink = "facebookLinkMock_2"}
            },
            {
                "3",
                new Person() {Id = "3", FacebookLink = "facebookLinkMock_3"}
            },
            {
                "4",
                new Person() {Id = "4", FacebookLink = "facebookLinkMock_4"}
            },
            {
                "5",
                new Person() {Id = "5", FacebookLink = "facebookLinkMock_5"}
            },
            {
                "6",
                new Person() {Id = "6", FacebookLink = "facebookLinkMock_6"}
            },
            {
                "7",
                new Person() {Id = "7", FacebookLink = "facebookLinkMock_7"}
            },
            {
                "8",
                new Person() {Id = "8", FacebookLink = "facebookLinkMock_8"}
            },
        };
		public IEnumerable<Person> GetPersons(string[] ids)
		{
			return ids.Select(x => _users[x]);
		}
	}
}
