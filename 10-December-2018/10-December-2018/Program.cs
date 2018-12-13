using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_December_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"C:\Users\mihaRik\Desktop\sample.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            Console.WriteLine(reader.ReadLine());

        }
    }
}
