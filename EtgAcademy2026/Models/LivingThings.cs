using System;
using System.Collections.Generic;
using System.Text;

namespace EtgAcademy2026.Models
{
    public abstract class LivingThings
    {

        public int Age { get; set; }
        public string Location { get; set; }

        public bool Alive { get; set; }


    }



    public class Animal : LivingThings
    {
        public string Species { get; set; }
        public string Diet { get; set; }
    }




    public class Plant : LivingThings
    {
        public string Species { get; set; }
        public string Type { get; set; }
    }



    public class Human : Animal
    {
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class LivingThingsInfoDisplay
    {


        


        public void DisplayInfo(LivingThings livingThing)
        {

            var human= new Human();


            human.Age = 30;
            human.Location = "New York";
            human.Species = "Homo sapiens";




            Console.WriteLine($"Age: {livingThing.Age}");
            Console.WriteLine($"Location: {livingThing.Location}");
            Console.WriteLine($"Alive: {livingThing.Alive}");
            if (livingThing is Animal animal)
            {
                Console.WriteLine($"Species: {animal.Species}");
                Console.WriteLine($"Diet: {animal.Diet}");
            }
            else if (livingThing is Plant plant)
            {
                Console.WriteLine($"Species: {plant.Species}");
                Console.WriteLine($"Type: {plant.Type}");
            }
            else if (livingThing is Human human)
            {
                Console.WriteLine($"Name: {human.Name}");
                Console.WriteLine($"Gender: {human.Gender}");
                Console.WriteLine($"Species: {human.Species}");
                Console.WriteLine($"Diet: {human.Diet}");
            }
        }
    }




    }
