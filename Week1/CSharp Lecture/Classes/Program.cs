using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Color = "Red";
            myCar.Make = "Dodge";
            myCar.Model = "Viper";
            myCar.Year = 2004;

            Car mySecondCar = new Car("Nissan", "GTR", 2012, "Gray");

            Car myThirdCar;
            myThirdCar = myCar;



            myThirdCar.Color = "White"; //Поменялось как и в myCar, так и в myThirdCar

            Car.WriteSomeTextInConsole("SomeText"); // Static Method - можно использовать везде 

            Do.WriteHello(); //Static Metod with private helper method
            
            Console.ReadLine();
        }
    }


    class WorkingWithClasses
    {
        //Do.WriteHello();   - Not Working

    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            Make = "Nissan";
        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public static void WriteSomeTextInConsole(string text)
        {
            Console.WriteLine(text);

        }
    }


    public static class Do
    {
        public static void WriteHello()
        {
            Console.WriteLine(HelperMethod());
        }

        private static string HelperMethod()
        {
            return "Hello World!";
        }
    }
}
