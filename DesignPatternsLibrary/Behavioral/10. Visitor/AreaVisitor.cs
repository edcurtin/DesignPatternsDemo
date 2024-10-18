using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._10._Visitor
{
    public class AreaVisitor : IShapeVisitor
    {
        public void VisitCircle(Circle circle)
        {
            double area = Math.PI * circle.Radius * circle.Radius;
            Console.WriteLine($"Circle Area: {area}");
        }

        public void VisitRectangle(Rectangle rectangle)
        {
            double area = rectangle.Width * rectangle.Height;
            Console.WriteLine($"Rectangle Area: {area}");
        }
    }

}
