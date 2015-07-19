using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFatorial
{
    class Program
    {
        static void Main(string[] args)
        {

            var fatorial = Fatorial(5);
            Console.WriteLine(fatorial);

        }

        private static int Fatorial(int p)
        {
            if (p == 0 || p == 1)
                return 1;

            return p * Fatorial(p - 1);
        }
    }
}
