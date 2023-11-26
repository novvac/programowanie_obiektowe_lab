using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    internal class Circle: Shape
    {
        public Circle(double X, double Y, double Height, double Width, string name) : base(X, Y, Height, Width, name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle: {Width}x{Height} | XY: {X} {Y}");
        }
    }
}
