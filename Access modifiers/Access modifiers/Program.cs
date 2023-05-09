using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);

            b1._name = "Cat in the Hat";
            Console.WriteLine(b1.GetDescription());

            b1.setName("Grapes of Wrath");
            b1.setAuthor("John Steinbeck");
            b1.setPagecount(464);
            Console.WriteLine(b1.GetDescription());
            Console.ReadKey();
        }
    }
}
