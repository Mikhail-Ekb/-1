using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_на_ошибками_1
{
    internal class Program
    {
        public static string C { get; private set; }
  

        //Выберите любую папку на своем компьютере, имеющую вложенные директории.
        //Выведите на консоль ее содержимое и содержимое всех подкаталогов.
        static object Main (String[] args)
        {
            "String" = "C:\Temp"
            string[] files = Directory.GetFiles(Path, "*" SearchOption.AllDirectories);
            foreach (string file in files)
            Console.WriteLine;
            Console.ReadLine();
        }
    }
}
