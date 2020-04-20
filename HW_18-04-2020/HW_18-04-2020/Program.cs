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

            int Gen1 = Convert.ToInt32(Console.ReadLine());
            int Gen2 = Convert.ToInt32(Console.ReadLine());

            command<int> do_it = Calculator<double>.SUM<int>;
            Console.WriteLine($"Sum={do_it.Invoke(Gen1,Gen2)}");
            Console.ReadKey();


        }
    }

}
