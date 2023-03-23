using RestApsNet6.Model;

namespace RestApsNet6.Services.Implementations
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
            List<Person> people = new List<Person>();

            for(int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                people.Add(person);
            }

            return people;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person name " + i,
                LastName = "Person Last Name " + i,
                Address = "Person Address " + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Lucas",
                LastName = "Amaral",
                Address = "Floripa/SC",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {

            return person;
        }
    }
}
