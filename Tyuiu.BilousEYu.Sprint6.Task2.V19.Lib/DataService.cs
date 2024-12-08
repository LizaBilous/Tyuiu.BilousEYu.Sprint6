using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BilousEYu.Sprint6.Task2.V19.Lib
{
    public class DataService : ISprint6Task2V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            int d = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i + 1.7 != 0)
                {
                    double r = Math.Sin(i) / (i + 1.7) - Math.Cos(i) * 4 * i - 6;
                    res[d] = Math.Round(r, 2);
                }
                else
                {
                    res[d] = 0;
                }
                d++;
            }
            return res;
        }
    }
}
