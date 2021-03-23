using System;

namespace MyDelegate
{
   public class Program
    {
        public static void Main(string[] args)
        {
            var class1 = new Class1();
            var class2 = new Class2();
            class1.ShowHandler = Show;
            class1.ShowHandler(class2.Calc(class1.Pow, 5, 5).Invoke(2));
        }

        public static void Show(bool result)
        {
            Console.WriteLine(result);
        }
    }
}
