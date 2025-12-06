using Tyuiu.AkopovaLV.Sprint4.Task1.V17.Lib;
namespace Tyuiu.AkopovaLV.Sprint4.Task1.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 1, 2, 3 };
            int res = ds.Calculate(array);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
