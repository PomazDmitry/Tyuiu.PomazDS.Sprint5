using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PomazDS.Sprint5.Task6.V14.Lib;

namespace Tyuiu.PomazDS.Sprint5.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = "C:\\DataSprint5\\InPutDataFileTask6V14.txt";
            bool result = File.Exists(path);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = "C:\\DataSprint5\\InPutDataFileTask6V14.txt";
            int count = 4;
            int result = ds.LoadFromDataFile(path);
            Assert.AreEqual(count,result);
        }
    }
}
