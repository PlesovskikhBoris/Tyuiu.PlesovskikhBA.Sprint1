using Tyuiu.PlesovskikhBA.Sprint1.Task4.V29.Lib;

namespace Tyuiu.PlesovskikhBA.Sprint1.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 0.1;
            double wait = 32.489;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
