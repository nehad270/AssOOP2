using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP2
{
    internal struct Rectangle
    {
        private double  height;
        private double area { get; } = 3.44;

        public Rectangle(double _width, double _height)
        {
            height = _height;
            Width = _width;
        }
        private  double Width;

        public double WidthValue
        {
            get { return Width; }
            set
            {
                if (value > 0)
                    Width = value;
                else
                    Console.WriteLine("Error: Width cannot be negative.");
            }
        }


        public double HeightValue
        {
            get { return height; }
            set
            {
                if (value >= 0)
                    height = value;
                else Console.WriteLine("eroor: height cannot be negative.");
            }


        }
        public double Area
        {
            get { return Width * height; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Rectangle Dimensions: Width = {Width}, Height = {height}");
            Console.WriteLine($"Area: {Area}");
        }





    }
}

