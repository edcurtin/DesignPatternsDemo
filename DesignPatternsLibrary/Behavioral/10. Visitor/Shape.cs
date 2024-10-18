using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._10._Visitor
{
    public abstract class Shape
    {
        public abstract void Accept(IShapeVisitor visitor);
    }
}
