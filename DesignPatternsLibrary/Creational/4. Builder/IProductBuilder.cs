using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Creational._4._Builder
{
    public interface IProductBuilder
    {
        IProductBuilder SetName(string name);
        IProductBuilder SetSize(string size);
        IProductBuilder SetColor(string color);
        Product Build();
    }
}
