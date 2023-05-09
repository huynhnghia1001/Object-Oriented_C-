using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_C__classes
{
    class Book
    {
        string _name;
        string _author;
        int _pagecount;

        public Book(string name, string authour, int pages) { 
            _name = name;
            _author = authour;
            _pagecount = pages;
        }
        public string GetDescription()
        {
            return $"{_name} by {_author}";
        }
    }
}
