using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint5.Task6.V14.Lib;
using autofill_pattern_lib;
using System.IO;

namespace Tyuiu.PomazDS.Sprint5.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(5, "Обработка текстовых файлов", 6, 14, "Дан файл С:\\DataSprint5\\InPutDataFileTask6V14.txt (файл взять из архива согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё файл) в котором есть набор символьных данных.Найти количество знаков препинания в заданной строке.");

            string path = @"C:\DataSprint5\InPutDataFileTask6V14.txt";
            int result = ds.LoadFromDataFile(path);

            ptrn.ResultPattern();

            Console.WriteLine(result);
        }
    }
}
