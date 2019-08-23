using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N= ");
            string str = Console.ReadLine();
            int N = int.Parse(str);
            for (int i = 0; i < N; i++)
            {
                for (int j = N; j >= N-(2*i); j-- )
                    Console.Write("*");
                   Console.WriteLine();
               
            }
            
            Console.ReadLine();
        }
    }
}
