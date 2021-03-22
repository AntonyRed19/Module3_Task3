using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegate
{
    public class Class1
    {
        public Action<bool> ShowHandler { get; set; }
        public int Pow(int a, int b)
        {
            return a * b;
        }
    }
}
