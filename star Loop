using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_Star
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Jing Li
             * Game & Sim
             * 10/16/18
             */
            
            Console.WriteLine("Insert a number");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 1)
            {
                Console.WriteLine("Can't be lower than one");
            }
            else
            {
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                }
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine();
                    for (int j = x - 1; j > i; j--)
                    {
                        Console.Write("*");
                    }

                }
            }
            Console.ReadKey();
        }
    }
}
