using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegate
{
    public class Class1
    {
        private delegate bool Action();
        public int Pow(int a, int b)
        {
            return a * b;
        }
    }
}
