using Tyuiu.BilousEYu.Sprint6.Task6.V25.Lib;
namespace Tyuiu.BilousEYu.Sprint6.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\ivano\source\repos\Tyuiu.BilousEYu.Sprint6\InPutDataFileTask6V25.txt";
            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(path);
            string wait = "ELHLVt EgQpG dsE jiUFMDjMsEervIz ZujmucpYQE";
            Assert.AreEqual(wait, res);
        }
    }
}