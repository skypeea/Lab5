using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[15];
           
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0,50);
                Console.Write("{0} ", array[i]);
            }
            for (int i = 0; i < 15; i++)
            {
                for (int j = i+1; j < 15; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Массив после сортировки");
            for (int i = 0; i < 15; i++)
            {
                
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Сумма максимального и минимального значения: " + (array[0] + array[14]));
            Console.ReadKey();
        }
    }
}
