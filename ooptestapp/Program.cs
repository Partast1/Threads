using System;

namespace ooptestapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine eng = new Engine(180, 8);

            Car car = new Car("Volvo", "White", 4, eng);
            Console.WriteLine("Brand = {0} Color = {1} Numberofdoors = {2} Horsepower = {3} Cylinders = {4}", car.Brand, car.Color,car.NumOfDoors, eng.HorsePower, eng.Cylinder);
        }
    }
}
