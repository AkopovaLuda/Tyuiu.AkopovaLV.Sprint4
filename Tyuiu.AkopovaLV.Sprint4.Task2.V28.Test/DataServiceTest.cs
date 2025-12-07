using Tyuiu.AkopovaLV.Sprint4.Task2.V28.Lib;
namespace Tyuiu.AkopovaLV.Sprint4.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int res = ds.Calculate(num);
            int wait = 16;
            Assert.AreEqual(wait, res);
        }
    }
}
