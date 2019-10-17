using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int k = 1;
            for (int i = 1; i < 4000000;) {
                int test = i + k;
                k = i;
                if (test % 2 == 0){
                    sum = sum + test;
                }
                i = test;
            }
            System.Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
