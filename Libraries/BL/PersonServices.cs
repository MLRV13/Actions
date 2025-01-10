using DL;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.X86;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Storage;


namespace BL
{
    public class PersonServices : IPersonServices
    {
        private DBContext _context;
        public PersonServices(DBContext context)
        {
            _context = context;
        }
        public IEnumerable<Person> GetPersonList()
        {
            return _context.Persons.Include(x => x.Country);
        }

        public Person GetPerson(int id) 
        {
            try
            {
                Person person = _context.Persons.Include(x => x.Country).First(x => x.PersonID == id);
                return person;
            }
            catch
            {
                throw;
            }
        }
        public void UpdatePerson(Person person) 
        {
            try
            {
                _context.Update(person);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
               
        public void AddPerson(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeletePerson(Person person) 
        {
            _context.Persons.Remove(person);
            _context.SaveChanges();
        }

        public bool CheckPerson(int id) 
        { 
            return _context.Persons.Any(e => e.PersonID == id);
        }
    }
}
