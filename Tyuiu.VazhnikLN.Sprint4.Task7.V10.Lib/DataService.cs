using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.VazhnikLN.Sprint4.Task7.V10.Lib
{
    public class DataService : ISprint4Task7V10
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] s = new int[n, m];
            int h = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    s[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (s[i, j] % 2 == 0) h += s[i, j];
                }
            }
            return h;
        }
    }
}
