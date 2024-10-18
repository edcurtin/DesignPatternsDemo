using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._10._Visitor
{
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override void Accept(IShapeVisitor visitor)
        {
            visitor.VisitCircle(this);
        }
    }
}
