using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Repos
{
    public class DbPersonRepo : IRepository
    {
        private readonly DataContext _context = new DataContext();

        public IEnumerable<Interest> GetInterests => _context.Interests.Distinct();

        public IEnumerable<Person> GetPersons => _context.Persons.ToList();

        public async Task<int> AddInterestAsync(Interest interest)
        {
            if (interest.Id == 0)
            {
                _context.Interests.Add(interest);
            }
            else
            {
                var dbInterest = _context.Interests.Find(interest.Id);
                if (dbInterest!=null)
                {
                    dbInterest.Title = interest.Title;
                }
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<int> AddPersonAsync(Person person)
        {
            if (person.Id == 0)
            {
                _context.Persons.Add(person);
            }
            else
            {
                var dbPerson = _context.Persons.Find(person.Id);
                if (dbPerson == null) return await _context.SaveChangesAsync();
                dbPerson.FirstName = person.FirstName;
                dbPerson.LastName = person.LastName;
                dbPerson.Age = person.Age;
                dbPerson.IsMale = person.IsMale;
                dbPerson.Photo = person.Photo;
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<Interest> DeleteInterestAsync(int interestId)
        {
            var dbInterest = _context.Interests.Find(interestId);
            if (dbInterest!=null)
            {
                _context.Interests.Remove(dbInterest);
            }
            await _context.SaveChangesAsync();
            return dbInterest;
        }

        public async Task<Person> DeletePersonAsync(int personId)
        {
            var dbPerson = _context.Persons.Find(personId);
            if (dbPerson!=null)
            {
                _context.Persons.Remove(dbPerson);
            }
            await _context.SaveChangesAsync();
            return dbPerson;
        }

        public Person GetPerson(int id)
        {
            return _context.Persons.Find(id);
        }

        public IEnumerable<Person> GetSexPerson(bool sex)
        {
            return _context.Persons.Where(gender => gender.IsMale == sex).ToList();
        }
    }
}