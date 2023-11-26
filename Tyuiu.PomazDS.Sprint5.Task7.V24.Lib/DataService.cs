using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.PomazDS.Sprint5.Task7.V24.Lib
{
    public class DataService : ISprint5Task7V24
    {
        public string LoadDataAndSave(string path)
        {
            Regex regex = new Regex(@"\b\p{IsCyrillic}+\b");
            string pathSaveFile = $"{Directory.GetCurrentDirectory()}\\OutPutDataFileTask7V24.txt";
            string str = File.ReadAllText(path);
            string replacedText = null;

            if (regex.IsMatch(str))
            {
                replacedText = regex.Replace(str, "слово");
            }

            File.WriteAllText(pathSaveFile, replacedText);
            return pathSaveFile;
        }
    }
}
