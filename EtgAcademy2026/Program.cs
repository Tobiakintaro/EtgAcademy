namespace EtgAcademy2026
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Week












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


            var input= Console.ReadLine();

            string NumberofBoys= Convert.ToString(numberOfBoys);
            int num = int.Parse("456a");



            string NumberofGirls =int.TryParse("456a", out int girls) ? girls.ToString() : "0";    

           
        }
    }
}
