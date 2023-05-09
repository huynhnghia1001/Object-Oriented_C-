using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("War and Peace","Leo Tolstoy", 825);

            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.Description);

            b1.ISBN = "100140447938";
            b1.Price = 24.95m;
            Console.WriteLine(b1.ISBN);
            Console.WriteLine(b1.Price);

            b1.Name = "Crime and Punishment";
            b1.PageCount = 652;
            Console.WriteLine(b1.Description);
            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.PageCount);

            Console.ReadKey();      
        }
    }
}
