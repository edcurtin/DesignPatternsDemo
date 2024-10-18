using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._10._Visitor
{
    public interface IShapeVisitor
    {
        void VisitCircle(Circle circle);
        void VisitRectangle(Rectangle rectangle);
    }
}
