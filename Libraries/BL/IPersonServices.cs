using DL;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IPersonServices
    {
        public IEnumerable<Person> GetPersonList();
        public Person GetPerson(int id);
        public void UpdatePerson(Person person);
        public bool CheckPerson(int id);
        public void AddPerson(Person person);
        public void DeletePerson(Person person);
    }
}
