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
            Console.WriteLine("\t1--> Operation Sum:");
            Console.WriteLine("\t2--> tOperation Minus:");
            Console.WriteLine("\t3--> Operation Multipy:");
            Console.WriteLine("\t4--> Operation Divide:\n");
        label1:
            Console.Write("You choice(Only number 1-4): ");
            int myChoice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number1= ");
            double Gen1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number2= ");
            double Gen2 = Convert.ToDouble(Console.ReadLine());

            if (myChoice==1)
            {
                command<double> do_it = Calculator<double>.SUM<double>;
                Console.WriteLine($"Sum = {do_it.Invoke(Gen1, Gen2)}");
            }
            if(myChoice==2)
            {
                command<double> do_it = Calculator<double>.MIN<double>;
                Console.WriteLine($"Min = {do_it.Invoke(Gen1, Gen2)}");
            }
            if(myChoice==3)
            {
                command<double> do_it = Calculator<double>.MUL<double>;
                Console.WriteLine($"Mul = {do_it.Invoke(Gen1, Gen2)}");
            }
            if (myChoice == 4)
            {
                if(Gen2>0)
                {
                    command<double> do_it = Calculator<double>.DIV<double>;
                    Console.WriteLine($"Div = {do_it.Invoke(Gen1, Gen2)}");
                }
                else
                {
                    Console.WriteLine("Infinity!");
                }
                
            }
            else if(myChoice>4 || myChoice<1)
                Console.WriteLine("Error! You are out of range!");
        goto label1;

        }
    }

}
