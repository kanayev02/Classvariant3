using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        int C;
        public Class1(int A, int B)
        {
            if (A > B)
            {
                C = A;
            }
            else
            {
                C = B;
            }
        }
        public Class1()
        {
            C = 1;
        }

        public override string ToString()
        {
            return C.ToString();
        }
    }
}
