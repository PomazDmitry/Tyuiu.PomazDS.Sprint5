using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PomazDS.Sprint5.Task4.V22.Lib
{
    public class DataService : ISprint5Task4V22
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            double x = double.Parse(str.Replace('.', ','));
            double y = Math.Round(Math.Pow(x, 3) * Math.Sin(x) - 4 * x, 3);
            return y;
        }
 
          
        
    }
}
