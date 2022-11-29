using System;

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {3, -2, 3, 2, 1, -4, 3, 6, 8, -7 }; 
            double s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                
                {
                    for (int j = i; j < array.Length; j++)
                    {
                        s += Math.Abs(array[i]);
                    }
                    break;
                }

            }
            Console.WriteLine("сумма модулей элементов последовательности: " +s); 
            Console.ReadKey();
        }
    }
}