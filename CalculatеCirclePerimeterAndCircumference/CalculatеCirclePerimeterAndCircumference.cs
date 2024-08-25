using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculating
{
    public class CalculatingCirclePerimeterAndCircumference
    {
        public static double CalculatingPerimeter(double radius)
        {
            return 2 * Math.PI * radius;
        }
        public static double CalculatingCircumference(double radius)
        {
            return Math.PI * radius * radius;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = CalculatingPerimeter(radius);
            double circumference = CalculatingCircumference(radius);
            Console.WriteLine($"The perimeter of the circle with radius {radius} is {perimeter}");
            Console.WriteLine($"The circumference of the circle with radius {radius} is {circumference}");
        }
    }
}
