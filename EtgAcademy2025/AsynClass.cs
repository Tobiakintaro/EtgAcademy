using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtgAcademy2025
{
    static public class AsynClass
    {


        public static async Task RunAsync()
        {
            Console.WriteLine($"Starting Async Demo... {DateTime.Now} \n");


            var Task1 = Hellal1();

            var Task2 = Hellal2();

            var Task3 = Hellal3();


            await Task.WhenAll(Task1, Task2, Task3);



            Console.WriteLine($"No sleep... {DateTime.Now} \n");

            DoWorkSynchronously1();


            DoWorkAsynchronously1();





            //await DoWorkAsynchronously();


            //DoWorkSynchronously();


            Console.WriteLine($"\nAll tasks complete! {DateTime.Now}");

        }




        static async Task Hellal1()
        {
            Console.WriteLine($"1. I am sleeping {DateTime.Now.ToString("dd-MM-yy hh:mm:ss fffff")}");
            await Task.Delay(5000);
            Console.WriteLine($"1. I finished sleeping {DateTime.Now.ToString("dd-MM-yy hh:mm:ss fffff")}");

        }
        static async Task Hellal2()
        {
            Console.WriteLine($"2. I am sleeping {DateTime.Now.ToString("dd-MM-yy hh:mm:ss fffff")}");
            await Task.Delay(5000);
            Console.WriteLine($"2. I finished sleeping {DateTime.Now.ToString("dd-MM-yy hh:mm:ss fffff")}");

        }
        static async Task Hellal3()
        {
            Console.WriteLine($"3. I am sleeping {DateTime.Now.ToString("dd-MM-yy hh:mm:ss fffff")}");
            await Task.Delay(5000);
            Console.WriteLine($"3. I finished sleeping {DateTime.Now.ToString("dd-MM-yy hh:mm:ss fffff")}");

        }



        static async Task DoWorkAsynchronously()
        {
            Console.WriteLine("xyz  Asynchronous work started...");

            // await releases the thread while waiting (non-blocking)



            int i = 0;
            while (i < 5)
            {
                i = +1;
                Console.WriteLine("xyz Asynchronous work running...");
                await Task.Delay(1000);
            }

            Console.WriteLine("xyz Asynchronous work completed!");
        }




        static void DoWorkSynchronously()
        {
            Console.WriteLine("Synchronous work started...");
            Task.Delay(5000).Wait();  // Blocks thread for 2 seconds
            Console.WriteLine("Synchronous work completed!");
        }














        public static void DoWorkSynchronously1()
        {


            Console.WriteLine($"opq Synchronous Work Started {DateTime.Now}");

            for (int i = 1; i <= 5; i++)
            {
                // Simulate work
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine($"Synchronous Work Step {i} Complete");
            }
            Console.WriteLine($"opq Synchronous Work Finished {DateTime.Now}");
        }

        public static async void DoWorkAsynchronously1()
        {
            Console.WriteLine("abc Asynchronous Work Started");
            _ = Task.Run(async () =>
                   {
                       for (int i = 1; i <= 5; i++)
                       {
                           // Simulate work
                           await Task.Delay(500);
                           Console.WriteLine($"abc Asynchronous Work Step {i} Complete {DateTime.Now}");
                       }
                       Console.WriteLine($"abc Asynchronous Work Finished  {DateTime.Now}");
                   });





        }
    }
}
