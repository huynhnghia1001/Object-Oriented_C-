using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("War and Peace","Leo Tolstoy",825, 39.25m);
            Magazine m1 = new Magazine("Time", "Time USA, LLC", 75, 4.95m);

            Console.WriteLine($"{b1.Name},{b1.Author}");
            Console.WriteLine($"{m1.Name},{m1.Publisher}");

            

            /*b1.Name = ""*/;

            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b1.Price);
            Console.WriteLine(m1.GetDescription());
            Console.WriteLine(m1.Price);
            Console.ReadKey();
        }
    }
}
