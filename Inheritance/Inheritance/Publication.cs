using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Publication
    {
        private string _name;

        public Publication(string name, int pagecount, decimal price) { 
            _name = name;
            PageCount = pagecount;
            Price = price;
        }

        public int PageCount { 
            get;
            set; 
        }
        public decimal Price
        {
            get;
            set;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value == "") {
                    throw new ArgumentException("Name cannot be black");
                }
                _name = value;
            }
        }
        public virtual string GetDescription()
        {
            return $"{Name}, {PageCount} pages";
        }
    }
}
