using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 ob1 = new Class1(2, 3);
            Console.WriteLine(ob1.ToString());
            Class1 ob2 = new Class1();
            Console.WriteLine(ob2.ToString());
            //Class2.txt = "Тестовая строка";
            //string str = Class2.Vtoroe(' ', 6);
            //Console.WriteLine(str);
        }
    }
}
