using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint5.Task0.V3.Lib;
using autofill_pattern_lib;
using System.IO;

namespace Tyuiu.PomazDS.Sprint5.Task0.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(5, "Класс File. Запись данных в текстовый файл", 0, 3, "Дано выражение вычислить его значение при x = 3, результат сохранить в текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до трёх знаков после запятой.", "x=3. Формула: -(1.0 / 4) * (x^3 - 3 * x^2 + 4)");

            int x = 3;

            ptrn.ResultPattern();

            Console.WriteLine("Путь: {0}\nРезультат: {1}",ds.SaveToFileTextData(x),File.ReadAllText($@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt"));
        }
    }
}
