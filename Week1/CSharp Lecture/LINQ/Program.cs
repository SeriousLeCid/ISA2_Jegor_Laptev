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

            //1st case = 2nd case
            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }

            //2nd case
            var bmws1 = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            foreach (var car in bmws1)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }

            //3rd case = 4th
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN);
            }


            //4th case
            var orderedCars2 = myCars.OrderByDescending(p => p.Year);

            foreach (var car in orderedCars2)
            {
                Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN);
            }


            //5th  case = 6th case
            var firstBMW = myCars.First(p => p.Make == "BMW");
            Console.WriteLine(firstBMW.VIN);

            //6th case
            var firstBMW2 = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            Console.WriteLine(firstBMW2.VIN);

            //7th case
            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2007));

            //8th case
            myCars.ForEach(p => p.StickerPrice -= 3000);
            myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            //9th case
            Console.WriteLine(myCars.Exists(p => p.Model == "745li"));
            Console.WriteLine(myCars.Sum(p => p.StickerPrice));

            //10th case
            Console.WriteLine(myCars.GetType());
            var orderedCars3 = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars3.GetType());

            //11th case
            var bmws2 = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            Console.WriteLine(bmws2.GetType());

            //12th case
            var newCars = from car in myCars
                          where car.Make == "BMW"
                          && car.Year == 2010
                          select new { car.Make, car.Model };
            Console.WriteLine(newCars.GetType());

            
            Console.ReadLine();

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
