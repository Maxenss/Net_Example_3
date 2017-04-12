using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net_Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double D = 0;
            double root_1 = 0;
            double root_2 = 0;

            Console.WriteLine("The general equation-form : ax^2 + bx + c = 0\n");

            while (true)
            {
                try
                {
                    Console.Write("Enter a: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error in input a");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter b: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error in input b");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter c: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error in input c");
                }
            }

            Console.WriteLine("\nOur equation : {0}x^2 + {1}x + {2} = 0\n", a, b, c);

            D = b * b - (4 * a * c);

            if (D > 0)
            {
                root_1 = (-b + Math.Sqrt(D)) / (2 * a);
                root_2 = (-b - Math.Sqrt(D)) / (2 * a);

                Console.WriteLine("The equation has two different roots : ");
                Console.WriteLine("Root 1 = {0}", Math.Round(root_1, 3));
                Console.WriteLine("Root 2 = {0}", Math.Round(root_2, 3));

            }
            else if (D == 0)
            {
                root_1 = root_2 = -b / (2 * a);
                Console.WriteLine("The equation has two identical roots : ");
                Console.WriteLine("Root 1 = Root 2 = {0}", Math.Round(root_1, 3));
            }
            else
            {
                Console.WriteLine("The equation has no roots");
            }

            Console.WriteLine("\nEnter any key...");
            Console.ReadKey();
        }
    }
}
