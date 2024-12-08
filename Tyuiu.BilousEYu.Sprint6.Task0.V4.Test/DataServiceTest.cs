using Tyuiu.BilousEYu.Sprint6.Task0.V4.Lib;
namespace Tyuiu.BilousEYu.Sprint6.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
           
            double res = ds.Calculate(3);
            double wait = 68.3;
            Assert.AreEqual(wait, res);
        }
    }
}