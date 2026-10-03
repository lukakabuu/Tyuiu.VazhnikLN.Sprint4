using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.VazhnikLN.Sprint4.Task2.V23.Lib
{
    public class DataService : ISprint4Task2V23
    {
        public int Calculate(int[] array)
        {
            int s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) s += array[i];
            }
            return s;
        }
    }
}
