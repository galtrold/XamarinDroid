using System.Collections.Generic;
using System.Linq;
using XamarinDroid.Core.Model;

namespace XamarinDroid.Core.Repository
{
    public class PersonRepository
    {
        private List<Person> _devices;

        public PersonRepository()
        {
            _devices =  new List<Person>()
            {
                new Person() {Id = 1, Firstname = "Richard", Lastname= "Tomsen"},
                new Person() {Id = 2, Firstname = "Hanne", Lastname= "Riffel"},
                new Person() {Id = 3, Firstname = "Danse", Lastname= "Staffan"},
            };
        }

        public IEnumerable<Person> Get()
        {
            return _devices;
        }

        public Person GetById( int id)
        {
            return _devices.FirstOrDefault(p => p.Id == id);
        }
    }
}