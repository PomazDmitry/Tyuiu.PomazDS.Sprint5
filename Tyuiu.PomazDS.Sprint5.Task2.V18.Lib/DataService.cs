using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PomazDS.Sprint5.Task2.V18.Lib
{
    public class DataService : ISprint5Task2V18
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";

            if (File.Exists(path))
                File.Delete(path);

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            string str = null;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                        matrix[i, j] = 0;

                    str = matrix[i, j].ToString();
                    if (j == cols - 1)
                    {
                        File.AppendAllText(path, str + "\n");
                        break;
                    }
                    File.AppendAllText(path, str + ";");
                }
            }
            return path;
        }
    }
}
