using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtgAcademy2025
{
    enum Role
    {
        Admin,
        User,
        Guest
    }

    public class CollectionClass
    {
        public Person Programmer1()
        {
            return new Programmer
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30,
                Language = "C#"
            };
          
        }



        public void ListExample()
        {

            //convert the roles to string array if not already. Get this from the arguments 
            var list = new string[] { "Admin", "User", "Guest" };

         
            if (list.Contains(nameof(Role.User)) || list.Contains(nameof(Role.Guest)))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }






            List<Person> people = new List<Person>()
            {new Programmer { FirstName = "Peter", LastName = "Ayo", Language="J#" },
                new Programmer { FirstName = "John", LastName = "Doe", Language="C#" },
                new Manager { FirstName = "Jane", LastName = "Smith", TeamSize= 5 },
                new Intern { FirstName = "Doe", LastName = "Johnson", University="MIT" }
            };

            var str = "peter";

            string query = $"John " + str;
            query = $"John {str}";

            var sorted = from p in people where p.FirstName == "John" select new { p.Age, p.Designation }; //linq: language integrated query


            var sql= "SELECT Age, Designation FROM people WHERE FirstName = 'John' "    ;



            List<string> names = new List<string>();
            names.Add("John");
            names.Add("Jane");
            names.Add("Doe");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


            names.Remove("John");


            var ppppp = people.OfType<Programmer>().Select(x => x.Language).ToList();
            var progs1 = people.OfType<Programmer>().ToList().Where(x => x.Language == "C#").ToList();

            var ppp = people.Where(x => x.FirstName == "John" && x.LastName == "Doe").Select(x => x.LastName).ToList();



            //  var p = people.Select(x => x.FirstName && x.LastName== "").ToList();

            //Linq
            var jname = names.Where(x => x == "John").FirstOrDefault();


            var progs = people.OfType<Programmer>().ToList().Where(x => x.Language == "C#").ToList();

            var prog = people.Where(x => x.GetType() == typeof(Programmer)).ToList();

            List<Programmer> programmers = prog.Cast<Programmer>().ToList();


            var newList = progs.Concat(prog).ToList();


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
