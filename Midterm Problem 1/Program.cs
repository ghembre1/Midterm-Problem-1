using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompts users to input their numbers
            Console.WriteLine("Input number 1");
            int num1 = Convert.ToInt32(Console.ReadLine()); // converts the input to int
            Console.WriteLine("Input number 2");
            int num2 = Convert.ToInt32(Console.ReadLine()); // converts the input to int
            Console.WriteLine("Inpute number 3");
            int num3 = Convert.ToInt32(Console.ReadLine()); //converts the input to int
            if (num1 > num2)  // compares num1 to num2
            {
                if (num1 > num3) //compares num1 to num2
                {
                    Console.WriteLine("The biggest number is " + num1);
                }
            }
            if (num2 > num1) //compares num1 to num2
            {
                if (num2 > num3) compares num2 to num3
                {
                    Console.WriteLine("The biggest number is " + num2);
                }
            }
            if (num3 > num1) //compares num3 to num1
            {
                if (num3 > num2) //compares num3 to num2
                {
                    Console.WriteLine("The biggest number is " + num3);
                }
            }

            Console.ReadLine();
        }
    }
}
