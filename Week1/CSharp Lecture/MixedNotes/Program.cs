using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // IF STATEMENT
            int userValue = 1;
            string massage = (userValue == 1) ? "boat" : "strand of lint"; // если True, то massage = "boat"
                                                                           // если False, то massage = "strand of lint"


            // CHAR ARRAYS
            string value = "Some Text";
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);

            foreach (char i in charArray) // Reverse text: "txeT emoS"
            {
                Console.Write(i);
            }

            Console.WriteLine("\n" + String.Concat(charArray)); // output text: "txeT emoS"

            //String.Format("{0} {1} {2}", a,b,c); //Форматирование текста



            //WHILE STATEMENT
            bool choise = false;
            do
            {
                Console.WriteLine("Some Text"); // Сначала выполняется этот блок

            } while (choise); // если True - выполняктся этот блок снова

            Console.ReadLine();
        }
    }
}
