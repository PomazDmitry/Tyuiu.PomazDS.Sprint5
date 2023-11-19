using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint5.Task3.V21.Lib;
using autofill_pattern_lib;
using System.IO;

namespace Tyuiu.PomazDS.Sprint5.Task3.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(5, "Класс File. Запись структурированных данных в текстовый файл", 3, 21, "Дано выражение вычислить его значение при x = 3, результат сохранить в бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до трёх знаков после запятой.", "При x=3. Формула: (x^2+1)/(sqrt(4x^2-3))");

            int x = 3;

            ptrn.ResultPattern();

            Console.WriteLine("Путь: {0}\nРезультат:\n{1}", ds.SaveToFileTextData(x), File.ReadAllText($@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin"));
        }
    }
}
