using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForYou
{
    class task4
    {
        public void NTriangle()
        {
            Console.WriteLine("Введите n");
            string str = Console.ReadLine();
            int n;
            bool res = int.TryParse(str, out n);
            if (res)
            {
                for (int k = 1; k < n; k++)
                {
                    string s = "";
                    for (int i = 0; i < k; i++)
                    {
                        for (int y = i; y < k; y++)
                            Console.Write(" ");
                        for (int j = n / 2; j >= k - n / 2; j--)
                            Console.Write(" ");
                        Console.Write(s);
                        s += "*";
                        s.Insert(1, s);
                        Console.Write(s);
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
