using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._10._Visitor
{
    public class PerimeterVisitor : IShapeVisitor
    {
        public void VisitCircle(Circle circle)
        {
            double perimeter = 2 * Math.PI * circle.Radius;
            Console.WriteLine($"Circle Perimeter: {perimeter}");
        }

        public void VisitRectangle(Rectangle rectangle)
        {
            double perimeter = 2 * (rectangle.Width + rectangle.Height);
            Console.WriteLine($"Rectangle Perimeter: {perimeter}");
        }
    }
}
