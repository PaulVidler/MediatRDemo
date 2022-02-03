using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    // simple DA layer without coding it all up.
    // We can use the interface to code a DB if required.
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Paul", LastName = "Jones" });
            people.Add(new PersonModel { Id = 2, FirstName = "Sarah", LastName = "Johns" });
        }

        public List<PersonModel> GetPeople()
        {
            // this would otherwise be a DB call to fetch and return people
            return people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new() { FirstName = firstName, LastName = lastName };
            p.Id = people.Max(x => x.Id);
            people.Add(p);
            return p;
        }
    }
}
