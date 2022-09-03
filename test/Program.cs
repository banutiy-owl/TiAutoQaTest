using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter coordinate x of A dot: ");
            double xDotA=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinate y of A dot: ");
            double yDotA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinate x of B dot: ");
            double xDotB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinate y of B dot: ");
            double yDotB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinate x of C dot: ");
            double xDotC = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinate y of C dot: ");
            double yDotC = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Triangle triangle = new Triangle(xDotA, yDotA, xDotB, yDotB, xDotC, yDotC);

            Console.WriteLine("Length of AB is: " + triangle.sideAB);
            Console.WriteLine("Length of BC is: " + triangle.sideBC);
            Console.WriteLine("Length of AC is: " + triangle.sideAC);

            Console.WriteLine();

            triangle.equiTriangle();
            triangle.isosTriangle();
            triangle.rightTriangle();

            Console.WriteLine();

            Console.WriteLine("Perimeter: " + triangle.getPerimeter());

            Console.WriteLine();

            triangle.getEvenNumbers();
        }
    }
}