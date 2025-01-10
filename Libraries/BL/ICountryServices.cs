using DL;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface ICountryServices
    {
        public SelectList GetCountrySelectList();
        public IEnumerable<Country> GetCountryList();
        public Country GetCountry(int id);
        public void UpdateCountry(Country country);
        public bool CheckCountry(int id);
        public void AddCountry(Country country);
        public void DeleteCountry(Country country);

    }
}
