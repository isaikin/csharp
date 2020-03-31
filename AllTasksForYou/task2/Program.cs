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
            Console.Write("Enter N= ");
            string str = Console.ReadLine();
            int N;
            bool res = int.TryParse(str, out N);
            if (res)
            {
                string s = "";
                for (int j = 0; j < N; j++)
                {
                    s += "*";
                    s.Insert(1, s);
                    Console.Write(s);
                    Console.WriteLine();
                }


                Console.ReadLine();
            }
        }
    }
}
