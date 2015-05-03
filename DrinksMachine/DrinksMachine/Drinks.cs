using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksMachine
{
    class Drinks
    {
        public Drinks(string brand)
        {
            this.Brand = brand;

        }
        string _brand;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
    }
}
