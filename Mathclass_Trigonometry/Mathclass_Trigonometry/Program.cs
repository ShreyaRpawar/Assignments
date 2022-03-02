using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathclass_Trigonometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Mathclass");
                Console.WriteLine(Math.Acos(4)); // cosin angle must be less than 0 or 0
                Console.WriteLine(Math.Acos(0.5));
                Console.WriteLine(Math.Cos(2)); //Returns the cosine of the specific no

                Console.WriteLine(Math.Asin(0.2));
                Console.WriteLine(Math.Sin(2)); //Returns the sine of the specified angle.
                Console.WriteLine(Math.Asin(Double.PositiveInfinity)); //returns NAN

                Console.WriteLine(Math.Atan(5));
                Console.WriteLine(Math.Tan(1));

                Console.WriteLine(Math.Pow(2, 3));
                Double a = 2344.00;
                Console.WriteLine(Math.Abs(a));//Returns the absolute value of a specified number.
                Double b = 40.203;
                Console.WriteLine(Math.Floor(b)); // finds largest integer
                Double c = -10.223;
                Console.WriteLine(Math.Ceiling(c));  // finds smallest integer

                int a1 = 20, a2 = 30;
                Console.WriteLine(Math.Max(a1, a2));
                Console.WriteLine(Math.Min(a1, a2));

                Console.WriteLine(Math.Sqrt(100));

                Double u = 9894.0091183;
                Console.WriteLine(Math.Round(u, 4));

            
        }
    }
}
