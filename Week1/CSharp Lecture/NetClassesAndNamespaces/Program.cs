using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using MyClassLibrary;

namespace NetClassesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "I want to write THIS to my file.";
            
            //File.WriteAllText(@"C:\ExampleOfWritingInFile\WriteText.txt", text);

            


            //WebClient client = new WebClient();
            //string reply = client.DownloadString("https://www.shortwalk.app/");

            //Console.WriteLine(reply);
            //System.IO.File.WriteAllText(@"C:\ShortWalkHTML\HTML.txt", reply);


            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebpage("https://www.shortwalk.app/");
            Console.WriteLine(value);

            Console.ReadLine();
        }
    }
}
