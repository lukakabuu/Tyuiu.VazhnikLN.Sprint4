using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using Tyuiu.VazhnikLN.Sprint4.Task3.V13.Lib;
namespace Tyuiu.VazhnikLN.Sprint4.Task3.V13

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Матрица 5x5: ");
            Console.WriteLine("{{4, 7, 4, 2, 1 },\r\n\r\n { 6, 7, 3, 6, 5, },\r\n\r\n { 6, 5, 3, 3, 5 },\r\n\r\n { 4, 4, 6, 4, 7 },\r\n\r\n { 2, 1, 2, 3, 4, } }");
            int[,] s = {{4, 7, 4, 2, 1 },

                            { 6, 7, 3, 6, 5, },

                            { 6, 5, 3, 3, 5 },

                            { 4, 4, 6, 4, 7 },

                            { 2, 1, 2, 3, 4, } };
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(s);
            Console.WriteLine("Сумма элементов 3 столбца матрицы = " + res);
            Console.ReadLine();

        }
    }
}
