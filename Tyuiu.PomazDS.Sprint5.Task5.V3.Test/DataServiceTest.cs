using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PomazDS.Sprint5.Task5.V3.Lib;

namespace Tyuiu.PomazDS.Sprint5.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = "C:\\DataSprint5\\InPutDataFileTask5V3.txt";
            bool result = File.Exists(path);
            Assert.AreEqual(true, result);
        }
    }
}
