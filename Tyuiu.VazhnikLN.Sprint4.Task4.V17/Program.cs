using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using Tyuiu.VazhnikLN.Sprint4.Task4.V17.Lib;
namespace Tyuiu.VazhnikLN.Sprint4.Task3.V17

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int r, s;
            Console.WriteLine("Введите количество строк:");
            r = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            s = Convert.ToInt16(Console.ReadLine());
            int[,] mtr = new int[r, s];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0;  j < s; j++)
                {
                    Console.WriteLine("Введите " + i + "," + j + " элемент");
                    mtr[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    Console.WriteLine($"{mtr[i,j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(mtr);
            Console.WriteLine("Сумма четных элементов матрицы = " + res);
            Console.ReadLine();

        }
    }
}