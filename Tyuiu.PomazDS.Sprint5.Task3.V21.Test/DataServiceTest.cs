using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PomazDS.Sprint5.Task3.V21.Lib;

namespace Tyuiu.PomazDS.Sprint5.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = $@"C:\Users\admin\source\repos\Tyuiu.PomazDS.Sprint5\Tyuiu.PomazDS.Sprint5.Task3.V21\bin\Debug\OutPutFileTask3.bin";
            bool result = File.Exists(path);
            Assert.AreEqual(true, result);  
        }
    }
}
