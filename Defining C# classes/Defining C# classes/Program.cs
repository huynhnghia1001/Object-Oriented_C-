using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_C__classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
            Book b2 = new Book("The Grapes of Wrath", "John Steinbeck", 462);

            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());

            b1._name;
            Console.ReadKey();  
        }
    }
}
