using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint5.Task2.V18.Lib;
using autofill_pattern_lib;
using System.IO;

namespace Tyuiu.PomazDS.Sprint5.Task2.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(5, "Класс File. Запись структурированных данных в текстовый файл", 2, 18, "Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями с клавиатуры. Заменить положительные элементы массива на 1, отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.");

            int[,] matrix = new int[3,3];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }

            ptrn.ResultPattern();

            Console.WriteLine("Путь: {0}\nРезультат:\n{1}", ds.SaveToFileTextData(matrix), File.ReadAllText($@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv"));
        }
    }
}
