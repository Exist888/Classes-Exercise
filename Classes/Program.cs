namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Subaru";
            myNewCar.Model = "Outback Wilderness";
            myNewCar.Year = 2024;
            
            Console.Write($"I just got a new car! It is a {myNewCar.Year} {myNewCar.Make} {myNewCar.Model}.");
        }
    }
}
