using System;
using System.ComponentModel.DataAnnotations;
using Tyuiu.VazhnikLN.Sprint4.Task6.V1.Lib;
namespace Tyuiu.VazhnikLN.Sprint4.Task6.V1

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
            Console.WriteLine("Введите количество элементов:");
            len = Convert.ToInt32(Console.ReadLine());
            string[] s = new string[len];

            for (int i = 0; i < len; i++)
            {
                s[i] = Console.ReadLine();
            }
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"{s[i]}, \t");
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(s);
            Console.WriteLine("Количество элементов, длина которых больше 6 = " + res);
            Console.ReadLine();

        }
    }
}
