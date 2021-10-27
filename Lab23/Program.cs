using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int res = FactorialAsync(n).Result;
            Console.WriteLine(res);
            Console.ReadKey();
        }

        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        static async Task<int> FactorialAsync(int n)
        {
            int res = await Task.Run(() => Factorial(n));
            return res;
        }

    }
}
