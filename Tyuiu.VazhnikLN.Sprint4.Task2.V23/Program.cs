using System;
using System.ComponentModel.DataAnnotations;
using Tyuiu.VazhnikLN.Sprint4.Task2.V23.Lib;
namespace Tyuiu.VazhnikLN.Sprint4.Task2.V23

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int len;
            Console.WriteLine("Введите кол-во элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[] s = new int[len];

            for (int i = 0; i < len - 1; i++)
            {
                s[i] = r.Next(3, 8);
            }
            Console.WriteLine("Массив:");
            foreach (int i in s)
            {
                Console.WriteLine(i + "\t");
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(s);
            Console.WriteLine("Сумма четных элементов массива = " + res);
            Console.ReadLine();

        }
    }
}