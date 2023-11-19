using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PomazDS.Sprint5.Task1.V17.Lib
{
    public class DataService : ISprint5Task1V17
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            double y = 0;
            string str = null;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(2 * x - 4 + ((2 * x - 1) / (Math.Sin(x) + 1)), 2);

                if (double.IsNaN(y) || double.IsInfinity(y))
                {
                    y = 0;
                }

                str = y.ToString();

                if (x == stopValue)
                {
                    File.AppendAllText(path, str);
                    break;
                }
                File.AppendAllText(path, str + "\n");
            }

            return path;
        }
    }
}
