using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponvaljanje4Dzad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi unesi broj n, te če izračunati n-ti član Fibonaccijelov niz: ");
            int n = Convert.ToInt16(Console.ReadLine()), niz = 0, niz1 = 1, niz2 = 0;
            if (n >= 1) { 
                Console.WriteLine("\r\n"+niz2);
            }
            if (n >= 2)
            {
                Console.WriteLine(niz1);
            }
            for (int i = 2; i < n; i++)
            {
                niz = niz1+niz2;
                niz2 = niz1;
                niz1 = niz;
                Console.WriteLine(niz);
            }
            Console.ReadLine();
        }
    }
}
