using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());

            Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

            Console.WriteLine(myValue.Month);

            DateTime myBirthday = new DateTime(1999, 5, 15);
            Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirhday2 = DateTime.Parse("15/05/1999");
            TimeSpan myAge = DateTime.Now.Subtract(myBirhday2);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
            Console.Clear();
        }
    }
}
