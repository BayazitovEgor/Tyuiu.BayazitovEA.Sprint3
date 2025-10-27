using Tyuiu.BayazitovEA.Sprint3.Task3.V12.Lib;
namespace Tyuiu.BayazitovEA.Sprint3.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "bkkrk ckkkcs ksr";
            char item = 'k';




            double res = ds.GetMaxCharCount(value, item);

            double wait =7;

            Assert.AreEqual(wait, res);
        }
    }
}
