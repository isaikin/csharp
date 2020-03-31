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
            Console.WriteLine("Введите n");
            string str = Console.ReadLine();
            int n;
            bool res = int.TryParse(str, out n);
            if (res)
            {
                string s = "";
                for (int i = 0; i < n; i++)
                {
                    for (int j = i; j < n; j++)
                        Console.Write(" ");
                    Console.Write(s);
                    s += "*";
                    s.Insert(1, s);
                    Console.Write(s);
                    Console.WriteLine();
                }
            }
        }
    }
}
