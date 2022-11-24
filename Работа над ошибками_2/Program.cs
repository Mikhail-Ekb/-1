using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_над_ошибками_2
{
    internal class Program
            
                static void Main(string[] args)
                {
                     String path= "C:\Temp\Numbers.txt";
                Random random = new Random();
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        sw.WriteLine(random.Next());
                    }
                }

                0 = 0;
                using (StreamReader sr = new StreamReader(path))
                {
                    for (int i = 0; i < 10; i++)
                    {
                   "Sum"= Convert.ToInt32(sr.ReadLine());
                    }
                }
                Console.WriteLine(sum);
                Console.ReadKey();
            }
    }
}
