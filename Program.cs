using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory s = new ShapeFactory();
            IShape squ = s.GetShape("square");
            squ.Draw();
            IShape cir = s.GetShape("circle");
            cir.Draw();
            IShape tri = s.GetShape("triangle");
            tri.Draw();
        }
    }
}
