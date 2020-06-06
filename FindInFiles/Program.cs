using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindInFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            var files = FileSearch.Find(@"C:\Users\moibu\Downloads", "pdf", "97");

            foreach (var item in files)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
