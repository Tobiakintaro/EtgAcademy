using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtgAcademy2025
{
    public class ControlStructures
    {

        public void IfElseExample(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
        public void SwitchExample(string day)
        {
            switch (day.ToLower())
            {
                case "monday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "tuesday":
                    Console.WriteLine("It's Tuesday!");
                    break;
                case "wednesday":
                    Console.WriteLine("It's Wednesday!");
                    break;
                case "thursday":
                    Console.WriteLine("It's Thursday!");
                    break;
                case "friday":
                    Console.WriteLine("It's Friday!");
                    break;
                case "saturday":
                    Console.WriteLine("It's Saturday!");
                    break;
                case "sunday":
                    Console.WriteLine("It's Sunday!");
                    break;
                default:
                    Console.WriteLine("Not a valid day.");
                    break;
            }
        }
        public void ForeachExample()
        {
            string[] fruits = { "Apple", "Banana", "Cherry" };
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }



        public void ForLoopExample()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Iteration {i}");
            }
        }
        public void WhileLoopExample()
        {
            int count = 1;
            while (count <= 5)
            {
                Console.WriteLine($"Count is {count}");
                count++;
            }
        }
        public void DoWhileLoopExample()
        {
            int count = 1;
            do
            {
                Console.WriteLine($"Count is {count}");
                count++;
            } while (count <= 8);
        }





    }
}
