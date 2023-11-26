using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint5.Task5.V3.Lib;
using autofill_pattern_lib;
using System.IO;

namespace Tyuiu.PomazDS.Sprint5.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(5, "Чтение набора данных из текстового файла", 5, 3, "Дан файл С:\\DataSprint5\\InPutDataFileTask5V3.txt (файл взять из архива согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё файл) в котором есть набор значений. Найти сумму всех целых чисел в файле. Полученный результат вывести на консоль. У вещественных значений округлить до трёх знаков после запятой.");

            string path = $@"C:\DataSprint5\InPutDataFileTask5V3.txt";
            double result = ds.LoadFromDataFile(path);

            ptrn.ResultPattern();
            
            Console.WriteLine(result);
        }
    }
}
