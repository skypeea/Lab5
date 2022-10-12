using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i+=2)//четные строки
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = ((j % 2 == 0)) ? 1 : 0;
                }
                
            }
            for (int i = 1; i < n; i += 2)//нечетные строки
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = ( (j % 2 != 0)) ? 1 : 0;
                }

            }
            for (int i = 0; i < n; i++)//вывод массива на экран
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,2}",array[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
