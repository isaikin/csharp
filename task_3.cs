using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N= ");
            string str = Console.ReadLine();
            int N = int.Parse(str);
            for (int i=0; i<N; i++)
            {
                for (int j = i; j < N; j++)
                    Console.Write(" ");
                for (int k = N; k >= N - (2 * i); k--)
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
