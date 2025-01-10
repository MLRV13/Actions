using DL;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public  class CountryServices : ICountryServices

    {
        private DBContext _context;
        public CountryServices(DBContext context)
        {
            _context = context;
        }
        public SelectList GetCountrySelectList()
        {
            return new SelectList(_context.Countries, "CountryID", "Name");
        }
        public IEnumerable<Country> GetCountryList()
        {
            return _context.Countries;
        }

        public Country GetCountry(int id)
        {
            try
            {
                //.Find(id)
                //FirstOrDefault(u=>u.Name=="{name}") Permite acceder a un elemento aún sin usar primary KEY
                //.Where(u=>u.Id==id).FirstOrDefault();
                Country country= _context.Countries.First(x => x.CountryID== id);
                return country;
            }
            catch
            {
                throw;
            }
        }
        public void AddCountry(Country country)
        {
            try
            {
                _context.Add(country);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void UpdateCountry(Country country)
        {
            try
            {
                _context.Update(country);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

       
        public void DeleteCountry(Country country)
        {
            _context.Countries.Remove(country);
            _context.SaveChanges();
        }

        public bool CheckCountry(int id)
        {
            return _context.Countries.Any(e => e.CountryID == id);
        }


    }
}
