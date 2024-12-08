using Tyuiu.BilousEYu.Sprint6.Task2.V19.Lib;
namespace Tyuiu.BilousEYu.Sprint6.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMass()
        {
            DataService ds = new DataService();
            double[] wait = new double[] { -5.04, -6, -7.85 };
            int start = -1, end = 1;
            double[] res = new double[ds.GetMassFunction(start, end).Length];
            res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}