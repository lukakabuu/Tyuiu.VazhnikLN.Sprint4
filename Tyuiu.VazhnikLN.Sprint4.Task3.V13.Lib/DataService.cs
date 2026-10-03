using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.VazhnikLN.Sprint4.Task3.V13.Lib
{
    public class DataService : ISprint4Task3V13

    {
        public int Calculate(int[,] array)
        {
            int s = 0;
            int r = array.GetUpperBound(0) + 1;
            int c = array.Length / r;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (j == 2)
                    {
                        s += array[i, j];
                    }
                }
            }
            return s;
        }
    }
}
