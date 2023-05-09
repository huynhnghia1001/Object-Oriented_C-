using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers
{
    class Book
    {
        public string _name;
        protected string _author;
        private int _pagecount;

        public Book(string name, string author, int pages)
        {
            _name = name;
            _author = author;
            _pagecount = pages;
        }
        public string GetDescription()
        {
            return $"{_name} by {_author},{_pagecount} pages";
        }
        public string getName()
        {
            return _name ;
        }
        public void setName(string s)
        {
            _name = s;
        }
        public void setAuthor(string s)
        {
            _author = s;
        }
        public void setPagecount(int c)
        {
            _pagecount = c;
        }
    }
}
