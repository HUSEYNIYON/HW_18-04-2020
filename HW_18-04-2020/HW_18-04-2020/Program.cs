using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_18_04_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose command to work:");
            Console.WriteLine("Operand Sum:");
            Console.WriteLine("Operand Minus:");
            Console.WriteLine("Operand Multipy:");
            Console.WriteLine("Operand Divide:");

            double Gen1 = Convert.ToInt32(Console.ReadLine());
            double Gen2 = Convert.ToInt32(Console.ReadLine());

            command<double> do_it = Calculator<double>.SUM<double>;
            Console.WriteLine($"Sum={do_it.Invoke(Gen1,Gen2)}");

            command<double> do_it1 = Calculator<double>.MIN<double>;
            Console.WriteLine($"Min={do_it1.Invoke(Gen1, Gen2)}");

            command<double> do_it3 = Calculator<double>.MUL<double>;
            Console.WriteLine($"Mul={do_it3.Invoke(Gen1, Gen2)}");
            Console.ReadKey();


        }
    }

}
