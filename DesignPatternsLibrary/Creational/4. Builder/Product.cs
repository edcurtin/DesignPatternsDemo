using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Creational._4._Builder
{
    public class Product
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"Product Name: {Name}, Size: {Size}, Color: {Color}";
        }
    }
}
