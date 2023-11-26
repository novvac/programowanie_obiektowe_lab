using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    internal class Triangle : Shape
    {
        public Triangle(double X, double Y, double Height, double Width, string name) : base(X, Y, Height, Width, name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"Triangle: {Width}x{Height} | XY: {X} {Y}");
        }
    }
}
