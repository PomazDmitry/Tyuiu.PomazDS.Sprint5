using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PomazDS.Sprint5.Task1.V17.Lib;

namespace Tyuiu.PomazDS.Sprint5.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = $@"C:\Users\admin\source\repos\Tyuiu.PomazDS.Sprint5\Tyuiu.PomazDS.Sprint5.Task1.V17\bin\Debug\OutPutFileTask1.txt";
            bool result = File.Exists(path);
            Assert.AreEqual(true, result);
        }
    }
}
