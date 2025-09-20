using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EtgAcademy2025
{
    internal class ClassesandObject
    {
    }


    abstract public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string Designation { get; set; }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }


    public class Programmer : Person
    {
        public string Language { get; set; }
        public void Code()
        {
            Console.WriteLine($"{GetFullName()} is coding in {Language}");
        }
    }

    public class Manager : Person
    {
        public int TeamSize { get; set; }
        public void Manage()
        {
            Console.WriteLine($"{GetFullName()} is managing a team of {TeamSize} people.");
        }
    }


    public class Intern : Person
    {
        public string University { get; set; }
        public void Learn()
        {
            Console.WriteLine($"{GetFullName()} is learning at {University}");
        }
    }


    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Colour { get; set; } = "Black";
        public virtual void Speak()
        {
            Console.WriteLine($"{Name} makes a Talk.");
        }
    }

    class Dog : Animal
    {
        public string Breed { get; set; }
        public override void Speak()
        {
            Console.WriteLine($"{Name} barks.");
        }
    }

    class Cat : Animal
    {
        private int MyProperty { get; set; }

        public override void Speak()
        {
            //Console.WriteLine($"{Name} meows. Color:{Color}");
        }



        public void ShowColor(string myColow = null)
        {
            myColow = myColow ?? Colour;

            Console.WriteLine($"{Name} is Color:{myColow}");
        }


        public void ShowColor( string Name1,string myColow )
        {
            myColow = myColow ?? Colour;
            var prize = Sumasult();

            Console.WriteLine($"{Name1} is Color:{myColow}. with sumasult prize of {prize}");
        }

        private int  Sumasult()
        {
            
            Console.WriteLine($"{Name} is Sumasulting.");
            return 5;
        }




    }



}
