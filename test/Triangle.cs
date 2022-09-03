using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Triangle
    {
        public double xDotA;
        public double yDotA;
        public double xDotB;
        public double yDotB;
        public double xDotC;
        public double yDotC;

        public double sideAB;
        public double sideBC;
        public double sideAC;

        public double perimeter;



        public Triangle(double xDotA, double yDotA, double xDotB, double yDotB, double xDotC, double yDotC)
        {
            this.xDotA = xDotA;
            this.yDotA = yDotA;
            this.xDotB = xDotB;
            this.yDotB = yDotB;
            this.xDotC = xDotC;
            this.yDotC = yDotC;

            sideAB = Math.Sqrt(Math.Pow(xDotB - xDotA, 2) + Math.Pow(yDotB - yDotA, 2));
            sideBC = Math.Sqrt(Math.Pow(xDotC - xDotB, 2) + Math.Pow(yDotC - yDotB, 2));
            sideAC = Math.Sqrt(Math.Pow(xDotC - xDotA, 2) + Math.Pow(yDotC - yDotA, 2));

            perimeter = sideAB + sideAC + sideBC;
        }

        public void equiTriangle()
        {

            if (sideAB == sideAC && sideAB == sideBC)
            {
                Console.WriteLine("Triangle IS Equilateral");
            } else
            {
                Console.WriteLine("Triangle IS NOT Equilateral");
            }
        }

        public void isosTriangle()
        {
            if (sideAB == sideBC || sideAB == sideAC || sideBC == sideAC)
            {
                Console.WriteLine("Triangle IS Isosceles");
            } else
            {
                Console.WriteLine("Triangle IS NOT Isosceles");
            }

        }

        public void rightTriangle()
        {
            double c2=0;
            double a2=0;
            double b2=0;

            if (sideAB>sideAC && sideAB>sideBC)
            {
                c2 = Math.Pow(sideAB, 2);
                a2 = Math.Pow(sideAC, 2);
                b2 = Math.Pow(sideBC, 2);
            } else if (sideAC>sideAB && sideAC>sideBC)
            {
                c2 = Math.Pow(sideAC, 2);
                a2 = Math.Pow(sideAB, 2);
                b2 = Math.Pow(sideBC, 2);
            } else if (sideBC>sideAB && sideBC>sideAC)
            {
                c2 = Math.Pow(sideBC, 2);
                a2 = Math.Pow(sideAB, 2);
                b2 = Math.Pow(sideAC, 2);
            } 

            if ((c2-(b2+a2))<= Math.Pow(10,-6))
            {
                Console.WriteLine("Triangle IS Right");
            } else
            {
                Console.WriteLine("Triangle IS NOT Right");
            }
        }

        public double getPerimeter()
        {
            return perimeter;
        }

        public void getEvenNumbers()
        {

            Console.WriteLine("Parity numbers in range from 0 to triangle perimeter: ");

            for (int i=0;i<=perimeter;i+=2)
            {
                Console.WriteLine(i);
            }
        }

    }
}
