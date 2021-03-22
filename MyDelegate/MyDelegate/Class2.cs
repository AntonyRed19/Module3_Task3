using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegate
{
    public class Class2
    {
        private int _result;
        public Predicate<int> Calc(Func<int, int, int> func, int a, int b)
        {
            _result = func(a, b);
            Predicate<int> predicate = Result;
            return predicate;
        }

        public bool Result(int c)
        {
            return (_result % c == 0) ? true : false;
        }
    }
}