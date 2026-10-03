using System;
using Tyuiu.VazhnikLN.Sprint4.Task0.V16.Lib;
namespace Tyuiu.VazhnikLN.Sprint4.Task0.V16

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[] s = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            Console.WriteLine("Дан массив: { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 }");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.GetMultEvenArrEl(s);
            Console.WriteLine("Произведение четных чисел равно: " + res);
            Console.ReadLine();

        }
    }
}
