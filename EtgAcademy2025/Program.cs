using EtgLibrary;
using System;
using System.ComponentModel.DataAnnotations;

namespace EtgAcademy2025
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DatabaseClass.DeletePerson();


        

            var coll = new CollectionClass();
            coll.ListExample();






            var result = ErrorHandling.CheckFile();

            string phon = "0702 6261";
            var phone = ErrorHandling.FormatPhone(phon);




            var staff = new Manager();

            staff.FirstName = "John";
            staff.LastName = "Doe";
            staff.Age = 30;
            staff.Designation = "Project Manager";
            Console.WriteLine(staff.GetFullName());



            var dog = new Dog();
            dog.Name = "Buddy";
            dog.Age = 3;
            dog.Speak();


            var cat = new Cat();
            cat.Name = "Whiskers";
            cat.Age = 2;

            cat.ShowColor();

            cat.ShowColor("Blue");
            cat.ShowColor("Bingo", "Blue");



            cat.Speak();










            var ctrl = new ControlStructures();

            ctrl.IfElseExample(5);

            ctrl.SwitchExample("Monday");

            ctrl.ForeachExample();

            ctrl.ForLoopExample();

            ctrl.WhileLoopExample();

            ctrl.DoWhileLoopExample();















            /* 
             * DATA TYPES
             * Interger
             * Double
             * decimal
             * string
             */

            /* 
             * OPERATORS
             *  - + * / * %
             *  ++ --            
             */


            int a = 2_000_000_000;
            long b = 3000000000;
            decimal c = 3.14m;
            float d = 3.14f;
            double e = 3.14;



            Console.WriteLine("Hello, World!");
        }


        public void ExampleMethod()
        {

            var car = new Car();

            car.Start("Toyota");
            car.Model = "Corolla";

            Console.WriteLine("This is an example method.");
        }



    }
}
