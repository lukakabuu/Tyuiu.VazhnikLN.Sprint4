using System;
using System.ComponentModel.DataAnnotations;
using Tyuiu.VazhnikLN.Sprint4.Task7.V10.Lib;
namespace Tyuiu.VazhnikLN.Sprint4.Task7.V10

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
            r = 3;
            c = 4;
            string[,] s = new string[r, c];
            string n = "695847142536";
            int index = 0;
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0;  j < c; j++)
                {
                    Console.Write($"{n[index]} \t");
                    index++;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(r, c, n);
            Console.WriteLine("Сумма нечетных элементов = " + res);
            Console.ReadLine();

        }
    }
}
