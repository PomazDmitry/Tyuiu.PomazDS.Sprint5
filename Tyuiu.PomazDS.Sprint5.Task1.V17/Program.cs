using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint5.Task1.V17.Lib;
using autofill_pattern_lib;
using System.IO;

namespace Tyuiu.PomazDS.Sprint5.Task1.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(5, "Класс File. Класс File. Запись набора данных в текстовый файл", 1, 17, "Дана функция f(x) = 2x - 4 + ((2x-1)/sin(x)+1. f(x) на заданном диапазоне [-5;5] с шагом 1. При делении на 0 вернуть 0.");

            int startValue = -5;
            int stopValue = 5;

            ptrn.ResultPattern();

            Console.WriteLine("Путь: {0}\nРезультат:\n{1}", ds.SaveToFileTextData(startValue,stopValue), File.ReadAllText($@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt"));
        }
    }
}
