//Write a base class: ‘Shape’ and add properties like id, name and color and method like ‘calculate area’ .
//Inherit circle shape from base class and add properties like radius. override calculate area logic for circle.
//Inherit square class from shape and add change the calculate area logic. Add property like side of square.
//Take the input from user to select circle or square and display the calculated area . no hard coded values!

using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Transactions;

namespace Assignment2._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            do
            {
                Console.WriteLine("Welcome to the console area shape calculation app, please make a selection: ");
                Console.WriteLine("Type C to calculate the area of a Circle: ");
                Console.WriteLine("Type S to calculate the area of a Square: ");
                Console.WriteLine("Type R to calculate the area of a Rectangle: ");
                Console.WriteLine("Type X to exit the app ");
                Console.WriteLine();

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "C":
                    case "c":
                        Console.WriteLine("Enter the radius value of the circle: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Circle circleArea = new Circle();
                        circleArea.CalculateArea(radius);
                        Console.WriteLine();
                        break;
                    case "S":
                    case "s":
                        Console.WriteLine("Enter a single side length of the square:  ");
                        double lengthOfSide = Convert.ToDouble(Console.ReadLine());
                        Square squareArea = new Square();
                        squareArea.CalculateArea(lengthOfSide);
                        Console.WriteLine();
                        break;
                    case "R":
                    case "r":
                        Console.WriteLine("Enter the width of the Rectangle: ");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the Length of the Rectangle: ");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Rectangle rectangleArea = new Rectangle();
                        rectangleArea.CalculateArea(width, length);
                        Console.WriteLine();                        
                        break;
                    case "X":
                    case "x":
                        Console.WriteLine("You are now exiting the program hit enter");
                        break;
                } 
            } while (userInput != "X" && userInput != "x");
        }
    }

  
    public enum ColorValues { Red, Blue, Green }
    public class Shape
    { 
        public int ShapeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ColorValues Color { get; set;}

        public void CalculateArea() 
        {
            Console.WriteLine("The area of this shape is: ");
        }

    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public void CalculateArea(double radius)
        {
            
            Console.WriteLine("The area of a circle is:  " + Math.PI * Math.Pow(radius, 2));
        }
    }


    public class Square : Shape 
    {
        public double LengthOfSide { get; set; }

        public void CalculateArea(double LengthOfSide)
        {
            
           Console.WriteLine("The area of the square is: " + Math.Pow(LengthOfSide, 2));
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public void CalculateArea(double width, double height) 
        {
            Console.WriteLine("The area of the rectable is:  " + width * height);
        }

    }
}
