namespace CarManufacturer
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Car firstCar = new Car();
            Car secondCar = new Car("Audi", "8", 2015);
            Car thirdCar = new Car("Mercedes", "C-class", 2012, 20, 7);

            Console.WriteLine(firstCar.WhoAmI());
            Console.WriteLine();
            Console.WriteLine(secondCar.WhoAmI());
            Console.WriteLine();
            Console.WriteLine(thirdCar.WhoAmI());
        }
    }
}
