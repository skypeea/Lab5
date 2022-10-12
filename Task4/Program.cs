using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int k = 0;
            int[] array = new int[20];

            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0,4} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 20; i+=2)
            {
                if(array[i] %2 != 0 && array[i] >=0)
                {
                    k++;
                    Console.Write("{0,3}", array[i]);
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Количество нечетных положительных чисел на четных местах: ");
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
