using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            float sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите число");
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine("Среднее арифметическое введенных числе: " + sum/array.Length);
            Console.ReadKey();
        }
    }
}
