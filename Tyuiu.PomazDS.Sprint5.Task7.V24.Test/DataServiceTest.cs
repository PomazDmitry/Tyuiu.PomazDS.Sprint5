using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PomazDS.Sprint5.Task7.V24.Lib;

namespace Tyuiu.PomazDS.Sprint5.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = "C:\\DataSprint5\\InPutDataFileTask7V24.txt";
            bool result = File.Exists(path);
            Assert.AreEqual(true, result);
        }
    }
}
