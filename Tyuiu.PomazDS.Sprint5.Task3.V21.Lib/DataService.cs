using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PomazDS.Sprint5.Task3.V21.Lib
{
    public class DataService : ISprint5Task3V21
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

            if (File.Exists(path))
                File.Delete(path);

            double y = 0;

            y = Math.Round((Math.Pow(x, 2) + 1) / (Math.Sqrt(4 * Math.Pow(x, 2) - 3)), 3);

            using (BinaryWriter wr = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                wr.Write(BitConverter.GetBytes(y));
            }

            return path;
        }
    }
}
