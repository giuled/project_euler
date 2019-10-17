using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (double i = 0; i < 1000; i++) {
                if ((i/3) %1 == 0 || (i/5)%1 == 0) {
                    sum = sum + i;
                }
            }
            System.Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
