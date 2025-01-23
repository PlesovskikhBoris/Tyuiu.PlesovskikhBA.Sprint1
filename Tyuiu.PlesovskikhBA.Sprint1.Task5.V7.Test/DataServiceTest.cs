//Написать программу, которая решает следующую задачу:

//Определить h – полное количество часов прошедших от начала суток до того момента (в первой половине дня),
//когда часовая стрелка повернулась на f градусов (0<f<360, f – вещественное число).

using Tyuiu.PlesovskikhBA.Sprint1.Task5.V7.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double angle = 45;
            DataService ds = new DataService();
            double res = ds.AngleToHoursMinutes(angle);
            int result = Convert.ToInt32(res);
            int wait = 1;
            Assert.AreEqual(wait, result);
        }
    }
}
