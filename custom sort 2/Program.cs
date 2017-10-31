using System;

namespace custom_sort_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle[] rectangles = new Rectangle[] { new Rectangle(3, 4), new Rectangle(2, 3) };
            Array.Sort(rectangles, CompareByArea);
            foreach (Rectangle each in rectangles)
                Console.WriteLine(each);
        }

        static int CompareByArea(Rectangle a, Rectangle b)
        {
            if (a.getArea() > b.getArea())
                return 1;
            else if (a.getArea() < b.getArea())
                return -1;
            else
                return 0;
        }
    }

    class Rectangle
    {
        private double length;
        private double height;

        public Rectangle(double x, double y)
        {
            length = x;
            height = y;
        }

        public double getArea()
        {
            return length * height;
        }

        public override string ToString()
        {
            return "Rectangle of length " + length + 
                   ", height " + height +
                   ", area = " + getArea();
        }
    }
}
