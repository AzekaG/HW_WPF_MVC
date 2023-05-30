using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_WPF_MVC.Model
{
    public class BD
    {
        List<Person> persons;

        public BD() { persons = new List<Person>(); }

        public void Add(Person obj ) => persons.Add( obj );

        public List<Person> GetPeople() => persons;

        public void DeletePeople(Person person) => GetPeople().Remove(person);

        public List<Person> SearchByName(string name)
        {
            List< Person> res = new List<Person>();
            foreach(var el in persons)
            {
                if( el.Name == name )
                    res.Add( el );
            }
            return res;
        }


    }
}
