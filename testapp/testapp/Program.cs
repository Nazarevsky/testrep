using System;

namespace testapp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool isOddNumber(int x)
        {
            if (x % 2 == 0)
                return true;
            return false;
        }
    }
}
