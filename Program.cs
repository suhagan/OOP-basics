using System;

namespace Lab_05_The_basics_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get area of a circle with radius 5
            int radius1 = 5;
            circleClass circle1 = new circleClass(radius1);
            double area1 = circle1.getCircleArea();
            Console.WriteLine("The area: "+area1+ " is of the circle with radius " + radius1);
            
            // Get area of a circle with radius 6
            int radius2 = 6;
            circleClass circle2 = new circleClass(radius2);
            double area2 = circle2.getCircleArea();
            Console.WriteLine("The area: " + area2 + " is of the circle with radius " + radius2);
            Console.ReadLine();

        }
    }
}