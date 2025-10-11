using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtgAcademy2025
{
    public class CollectionClass
    {

        public void ListExample()
        {

            List<Person> people = new List<Person>()
            {new Programmer { FirstName = "Peter", LastName = "Ayo", Language="J#" },
                new Programmer { FirstName = "John", LastName = "Doe", Language="C#" },
                new Manager { FirstName = "Jane", LastName = "Smith", TeamSize= 5 },
                new Intern { FirstName = "Doe", LastName = "Johnson", University="MIT" }
            };

            List<string> names = new List<string>();
            names.Add("John");
            names.Add("Jane");
            names.Add("Doe");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


            names.Remove("John");


            var ppppp = people.OfType<Programmer>().Select(x => x.Language ).ToList();
            var progs1 = people.OfType<Programmer>().ToList().Where(x => x.Language == "C#").ToList();

            var ppp = people.Where(x => x.FirstName == "John" && x.LastName == "Doe").Select(x => x.LastName).ToList();



            //  var p = people.Select(x => x.FirstName && x.LastName== "").ToList();

            //Linq
            var jname = names.Where(x => x == "John").FirstOrDefault();


            var progs = people.OfType<Programmer>().ToList().Where(x => x.Language == "C#").ToList();

            var prog = people.Where(x => x.GetType() == typeof(Programmer)).ToList();

            List<Programmer> programmers = prog.Cast<Programmer>().ToList();


            var newList= progs.Concat(prog).ToList();


            List<Programmer> programmers2 = people.Select(x => new Programmer
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Designation = x.LastName

            }).ToList();






            var person = people.Where(x => x.FirstName == "John" && x.LastName == "Doe").FirstOrDefault();

            var arrStr = names.ToArray();
            arrStr.Append("Bingo");

            var arrstr2 = new string[] { "John", "Jane", "Doe" };
            arrstr2.Append("Bingo");


        }






    }
}
