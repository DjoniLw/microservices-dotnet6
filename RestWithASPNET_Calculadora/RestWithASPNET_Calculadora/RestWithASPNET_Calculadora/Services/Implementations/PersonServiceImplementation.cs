using RestWithASPNET_Calculadora.Models;

namespace RestWithASPNET_Calculadora.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            };
            return persons;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementeAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Address = "Some Adress" + i,
                Gender = "Male" + i
            };
        }

        private long IncrementeAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementeAndGet(),
                FirstName = "Djoni",
                LastName = "Lewin",
                Address = "Blumenau",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
