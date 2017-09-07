using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AreaCalculator
{
	/// <summary>
	/// Quick and easy program to compute the circumference and area of a circle
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			// Prompt the user for a radius.
			///Console.Write("Enter the radius of the circle:  ");

			// The user will type a number and that must be converted into
			// a type double because the ReadLine method returns a String.
			///double radius = Convert.ToDouble(Console.ReadLine());

			// Compute the circumference of the circle
			///double circumference = 2 * Math.PI * radius;
            //"Math." has a lot of useful math functions in it

			// Compute the area of the circle.
            ///double area = Math.PI * Math.Pow(radius, 2);

			///Console.WriteLine("The circumference is {0}u\nThe area is {1}u^2", circumference, area);
			///Console.ReadKey();
            Console.Write("What is the length of side 1 of a trianle");
            double sideA = Convert.ToDouble(Console.ReadLine());

			Console.Write("What is the length of side 2 of a trianle");
			double sideB = Convert.ToDouble(Console.ReadLine());

			Console.Write("What is the length of side 3 of a trianle");
			double sideC = Convert.ToDouble(Console.ReadLine());

			double perimeter = sideA + sideB + sideC;
			double s = (perimeter) / 2;
			double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));



            if(area > 0)
            {
                Console.WriteLine("The perimeter of the triangle is {0}. The area of the triangle is {1}", perimeter, area);
                Console.ReadLine();
            }else{
                Console.WriteLine("Please enter side lengths that make a triangle.");
                Console.ReadLine();
            }

		}
	}
}
