using System;
using System.Reflection.PortableExecutable;

namespace lab04
{
    class Lab4
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(4, 7, 340, 422, "rect");
            Triangle t = new Triangle(14, 4, 674, 346, "triangle");
            Circle c = new Circle(24, 67, 32, 46, "Circle");

            rect.Draw();
            t.Draw();
            c.Draw();
        }
    }
}