using API_ASPNET5_FINANCIAL.Controllers.Model;
using API_ASPNET5_FINANCIAL.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace API_ASPNET5_FINANCIAL.Service.Implementation
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IList<Person> FindALL()
        {
            List<Person> people = new List<Person>();
            for (int x = 0; x < 10; x++)
            {
                Person person = MockPerson(x);
                people.Add(person);
            }
            return people;
        }


        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Marcus Vinicius",
                LastName = "Citolino",
                Address = "Sao Paulo - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
        private Person MockPerson(int x)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Marcus Vinicius "+x,
                LastName = "Citolino",
                Address = "Sao Paulo - Brasil",
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
