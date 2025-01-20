using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // print out the prompt to ask for the length of the rectangle
            Console.WriteLine("Enter the length of the rectangle: ");

            // declare an int variable using a string to hold the user input for the rectangle length
            int length = Convert.ToInt32(Console.ReadLine()); // Note this code uses the "Convert.ToInt32" method to convert the string input to a integer

            // print out the prompt to ask for the width of the rectangle
            Console.WriteLine("Enter the width of the rectangle: ");

            // declare an int variable using a string to hold the user input for the rectangle width
            int width = Convert.ToInt32(Console.ReadLine()); // Note this code uses the "Convert.ToInt32" method to convert the string input to a integer

            // declare an int variable to hold and calculate the area of the rectangle
            int area = length * width;

            // declare an int variable to hold and calculate the perimeter of the rectangle
            int perimeter = 2 * (length + width);

            // print out the results of the area and perimeter of the rectangle using the variables
            Console.WriteLine("Results: ");

            Console.WriteLine("Area of the rectangle " + area);

            Console.WriteLine("Perimeter of the rectangle " + perimeter);

            //stops the screen for user to see the result
            Console.ReadLine();
        }
    }
}
