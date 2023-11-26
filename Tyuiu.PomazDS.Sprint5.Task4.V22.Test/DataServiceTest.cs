﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PomazDS.Sprint5.Task4.V22.Lib;

namespace Tyuiu.PomazDS.Sprint5.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = "C:\\DataSprint5\\InPutDataFileTask4V22.txt";
            bool result = File.Exists(path);        
            Assert.AreEqual(true, result);
        }
    }
}
