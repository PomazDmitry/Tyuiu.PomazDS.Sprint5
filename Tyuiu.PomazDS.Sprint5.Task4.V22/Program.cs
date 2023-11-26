using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint5.Task4.V22.Lib;
using autofill_pattern_lib;

namespace Tyuiu.PomazDS.Sprint5.Task4.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(5, "Чтение данных из текстового файла", 4, 22, "Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt (файл взять из архива согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё файл) в котором есть вещественное значение. Прочитать значение из файла и подставить вместо Х в формуле . Вычислить значение по формуле (Полученное значение округлить до трёх знаков после запятой) и вернуть полученный результат на консоль.", "Формула: y = x^3 * sin(x) - 4x");

            string path = $@"C:\DataSprint5\InPutDataFileTask4V22.txt";
            double result = ds.LoadFromDataFile(path);

            ptrn.ResultPattern();

            Console.WriteLine(result);
        }
    }
}
