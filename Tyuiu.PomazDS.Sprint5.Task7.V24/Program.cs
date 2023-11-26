using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint5.Task7.V24.Lib;
using autofill_pattern_lib;

namespace Tyuiu.PomazDS.Sprint5.Task7.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(5, "Добавление к решению итоговых проектов по спринту", 7, 24, "Дан файл С:\\DataSprint5\\InPutDataFileTask7V24.txt (файл взять из архива согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё файл) в котором есть набор символьных данных.Заменить все русские слова на слово \"слово\".Полученный результат сохранить в файл OutPutDataFileTask7V24.txt.");

            string path = @"C:\DataSprint5\InPutDataFileTask7V24.txt";
            string result = ds.LoadDataAndSave(path);

            ptrn.ResultPattern();

            Console.WriteLine(result);
        }
    }
}
