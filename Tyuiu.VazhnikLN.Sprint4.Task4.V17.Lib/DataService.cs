using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.VazhnikLN.Sprint4.Task4.V17.Lib
{
    public class DataService : ISprint4Task4V17
    {
        public int Calculate(int[,] matrix)
        {
            int s = 0;
            int r = matrix.GetUpperBound(0) + 1;
            int c = matrix.Length / r;
            for (int i = 0; i < r;  i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (matrix[i, j] % 2 == 0) s += matrix[i, j];
                }
            }
            return s;
        }
    }
}
