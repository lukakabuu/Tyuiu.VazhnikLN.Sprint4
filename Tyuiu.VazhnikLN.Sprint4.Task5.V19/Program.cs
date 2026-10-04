using System;
using System.ComponentModel.DataAnnotations;
using Tyuiu.VazhnikLN.Sprint4.Task5.V19.Lib;
namespace Tyuiu.VazhnikLN.Sprint4.Task5.V19 

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int r, c;
            Console.WriteLine("Введите количество строк массива:");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива:");
            c = Convert.ToInt32(Console.ReadLine());
            Random g = new Random();
            int[,] s = new int[r, c];

            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    s[i, j] = g.Next(-2, 3);
                }
            }
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.WriteLine($"{s[i, j]} \t");
                }
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(s);
            Console.WriteLine("Количество положительных элементов = " + res);
            Console.ReadLine();

        }
    }
}