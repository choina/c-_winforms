using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which one fibonnaci number do you want to know?");
            int i  = new int();
            string input = Console.ReadLine();
            Int32.TryParse(input, out i);
            Console.WriteLine("n={0} => {1}", i, fib(i));
        }
        static int fib(int n)
        {
            if (n == 0 || n == 1)
                return n;
            return fib(n - 1) + fib(n - 2);
        }
    }
}
