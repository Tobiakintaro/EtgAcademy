using EtgAcademy2026.Models;
using EtgAcademy2026.Service;
using System.Text;

namespace EtgAcademy2026
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vehicle.DisplayVehicleInfo();


            string CardNumber = "1234567890123456";

            var maskedCardNumber = CardNumber.MaskString(4, 4);

            var maskedCardNumber1 = CardNumber.MaskString(4, 4, '#');

            var Reg = new SchoolRegistration();

            var student1 = new Models.Student { Name = "Jane Doe", Age = 22, MatricNo = "MAT456" };
            Reg.UpdateStudentAgeByValue(student1, 25);
            var stud1 = student1;

            Student myStudent = new Student();

            myStudent.Name = "John Doe";
            myStudent.Age = 20; 


            var student2 = new Models.Student { Name = "Jane Doe", Age = 22, MatricNo = "MAT456" };
            Reg.UpdateStudentAgeByReference(ref student2, 30);
            var stud2 = student2;



            var sb = new StringBuilder();


            sb.Append("Hello World");
            sb.Append(" Peter");
            var str = sb.ToString();








            //
            long numberOfBoys = 5000000000;
            long numberOfGirls = 12;
            long totalStudents = numberOfBoys + numberOfGirls;

            Console.WriteLine("Hello, World!");
            Console.WriteLine($"Number of boys: {numberOfBoys}");
            Console.WriteLine($"Number of girls: {numberOfGirls}");
            Console.WriteLine($"Total students: {totalStudents}");


            double price = 100.50;
            decimal price2 = 100.50m;

            bool isTrue = true;
            bool isFalse = false;

            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Price2: {price2}");
            Console.WriteLine($"Is True: {isTrue}");
            Console.WriteLine($"Is False: {isFalse}");


            char letter = 'A';
            Console.WriteLine($"Letter: {letter}");

            string name = "John Doe";
            Console.WriteLine($"Name: {name}");


            string phone1 = "2347026261698";


            var input = Console.ReadLine();

            string NumberofBoys = Convert.ToString(numberOfBoys);
            int num = int.Parse("456a");



            string NumberofGirls = int.TryParse("456a", out int girls) ? girls.ToString() : "0";


        }
    }
}
