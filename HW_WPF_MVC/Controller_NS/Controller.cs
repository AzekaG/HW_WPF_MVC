using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_WPF_MVC.Model;

namespace HW_WPF_MVC.Controller
{
    public class Controller
    {
        BD bD = new BD();

        public void AddPerson(string name, int age) => bD.Add(new Person { Name = name, Age = age });

        public List<Person> GetAllPersons() => bD.GetPeople();

        public void DeletePerson(Person obj) => bD.DeletePeople(obj);

        public List<Person> Search(string name) => bD.SearchByName(name);








    }
}
