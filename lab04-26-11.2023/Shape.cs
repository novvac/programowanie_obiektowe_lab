using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    internal class Shape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Height { get; set; } 
        public double Width { get; set; }
        public string Name { get; set; }

        public Shape(double X, double Y, double Height, double Width, string name)
        {
            this.X = X;
            this.Y = Y;
            this.Height = Height;
            this.Width = Width;
            this.Name = name;
        }

        public virtual void Draw() { }
    }
}
