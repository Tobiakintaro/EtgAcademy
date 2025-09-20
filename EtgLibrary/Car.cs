namespace EtgLibrary
{
    public class Car
    {

        private string BreakDown(string brand)
        {
            return $"The {brand} car has broken down.";
        }

        public string Model { get; set; }
        public string Start(string brand)
        {
            return $"The {brand} car has started.";
        }


    }


    public class Truck
    {
        public int SpeedLimit { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
    }

}
