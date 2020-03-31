using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] ca = s.ToCharArray();
            string m = Console.ReadLine();
            char[] ma = m.ToCharArray();
            for (int i = 0; i < ca.Length; i++)
            {
                Console.Write(ca[i]);
                for (int j = 0; j < ma.Length; j++)
                {
                    if (ca[i] == ma[j])
                    {
                        Console.Write(ca[i]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
© 2020 GitHub, Inc.
