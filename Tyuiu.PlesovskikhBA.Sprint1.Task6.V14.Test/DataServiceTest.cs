﻿using Tyuiu.PlesovskikhBA.Sprint1.Task6.V14.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint1.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strTest = "aбвгдкёж";
            DataService ds = new DataService();
            bool res = ds.CheckLowerCaseRusLetters(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
