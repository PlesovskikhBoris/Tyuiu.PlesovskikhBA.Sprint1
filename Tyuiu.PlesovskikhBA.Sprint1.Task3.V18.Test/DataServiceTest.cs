using Tyuiu.PlesovskikhBA.Sprint1.Task3.V18.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 3;
            double b = 4;
            double c = 2;
            double wait = 3;
            var res = ds.HowManySquares(a, b, c);
            Assert.AreEqual(wait, res);
        }
    }
}