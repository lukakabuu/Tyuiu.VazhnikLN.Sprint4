using System;
using System.ComponentModel.DataAnnotations;
using Tyuiu.VazhnikLN.Sprint4.Task1.V28.Lib;
namespace Tyuiu.VazhnikLN.Sprint4.Task1.V28

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
            int[] s = new int[len];
            
            for (int i = 0;  i < len - 1; i++)
            {
                Console.WriteLine("Введите значение " + i + " элемента");
                s[i] = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("Произведение нечетных элементов массива = " + res);
            Console.ReadLine();

        }
    }
}
