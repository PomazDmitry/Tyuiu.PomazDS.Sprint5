using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PomazDS.Sprint5.Task2.V18.Lib;

namespace Tyuiu.PomazDS.Sprint5.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = $@"C:\Users\admin\source\repos\Tyuiu.PomazDS.Sprint5\Tyuiu.PomazDS.Sprint5.Task2.V18\bin\Debug\OutPutFileTask2.csv";
            bool result = File.Exists(path);
            Assert.AreEqual(true, result);
        }
    }
}
