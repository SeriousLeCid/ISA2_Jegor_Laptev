using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            // LINQ query
            
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;
            

            
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;


            // LINQ method

            //1st = 2
            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }

            //2nd
            var bmws1 = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            foreach (var car in bmws1)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }

            //3rd = 4

            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN);
            }


            //4th
            var orderedCars2 = myCars.OrderByDescending(p => p.Year);

            foreach (var car in orderedCars2)
            {
                Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN);
            }



        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
