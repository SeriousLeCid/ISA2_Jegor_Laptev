using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "My\"so-called\" life";
            string myString2 = "What if I need a\nnew line?";
            string myString3 = "Go to c:\\ drive";
            string myString4 = @"Go to your c:\ drive";

            string myString5 = String.Format("{1} = {0}", "First", "Second");

            string myString6 = String.Format("{0:C}", 123.45);
            string myString7 = String.Format("{0:N}", 1234567890);
            string myString8 = String.Format("Percentage: {0:P}", .123);
            string myString9 = String.Format("Phone Number: {0: (###) ###-####}", 1234567890);

            string myString10 = "  That summer we took threes across the board ";

            myString10 = myString10.Substring(6, 14);
            myString10 = myString10.ToUpper();
            myString10 = myString10.Replace(" ", "--");
            myString10 = myString10.Remove(6, 14);

            myString10 = String.Format("Lenght before: {0} -- Lenght after {1}",
                myString10.Length,
                myString10.Trim().Length);

            StringBuilder myString11 = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString11.Append("--");
                myString11.Append(i);
            }
        }

    }
}
