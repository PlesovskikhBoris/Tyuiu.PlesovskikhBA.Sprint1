using Tyuiu.PlesovskikhBA.Sprint1.Task7.V8.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint1.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = -6.489;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
