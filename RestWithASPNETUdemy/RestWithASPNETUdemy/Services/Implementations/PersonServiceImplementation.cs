using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplementation: IPersonService
    {
        private volatile int count;
        public Person Create(Person person)
        {
            return person;
        }
        public Person Update(Person person) 
        {
            return person;        
        }
        public Person FindById(long id) 
        {
            return new Person
            {
                Id = 1,
                FirstName = "Leandro",
                LastName = "Costa",
                Address = "Uberlând - Minas Gerais, Brasil",
                Gender = "Male"
            };

        }
        public List<Person> FindAll() 
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;

        }
            
        public void Delete(long id) { }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person Last Name" + i,
                Address = "Some Address" + i,
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
