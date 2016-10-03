using System.Collections.Generic;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Repos
{
    public interface IRepository
    {
        IEnumerable<Person> GetPersons { get; }
        Person GetPerson(int id);
        IEnumerable<Person> GetSexPerson(bool sex);
        Task<int> AddPersonAsync(Person person);
        Task<Person> DeletePersonAsync(int personId);

        IEnumerable<Interest> GetInterests { get; }
        Task<int> AddInterestAsync(Interest interest);
        Task<Interest> DeleteInterestAsync(int interestId);
    }
}