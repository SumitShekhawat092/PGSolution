using PGSolution.Consl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGSolution.Consl
{
    class Program
    {
        static void Main()
        {
            //// declare
            //Calculation calc;
            //// Memory alocation
            //calc = new Calculation();

            Console.WriteLine("plz enter first value");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("plz enter Second value");
            int secondValue = Convert.ToInt32(Console.ReadLine());

            Calculation calc = new Calculation();
            int calResult = calc.Addition(firstValue, secondValue);

            if (calResult <= 30)
            {
                Console.WriteLine($"Value in range 0 - 30 || Value is {calResult}");
            }
            else if (calResult > 30 && calResult <= 60) // 31 - 60
            {
                Console.WriteLine($"Value in range 31 - 60 || Value is {calResult}");
            }
            else
            {
                Console.WriteLine($"Remaing Value || Value is {calResult}");
            }

            Console.ReadLine();
        }
    }
}
