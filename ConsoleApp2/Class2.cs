using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class2
    {
        public static string txt;
        public static string Vtoroe(char S, int N)
        {
            string str = "";
            int k = 0;
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == S)
                {
                    for (int j = i; k < N; j++)
                    {
                        str += txt[j];
                        k++;
                    }
                    return str;
                }

            }
            return str;
        }
    }
}

