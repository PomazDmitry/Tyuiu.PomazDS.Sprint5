using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PomazDS.Sprint5.Task5.V3.Lib
{
    public class DataService : ISprint5Task5V3
    {
        public double LoadFromDataFile(string path)
        {
            double result = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Peek() != -1)
                {
                    result += double.Parse(sr.ReadLine());
                }
            }
            return Math.Round(result, 3);
        }
    }
}