using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string m = Console.ReadLine();
            int s = 0, k = 0;
            for (int i = 0; i < m.Length; i++)
            {
                if (char.IsLetter(m[i]))
                {
                    s++;
                }
                if ((char.IsWhiteSpace(m[i]) && char.IsLetter(m[i + 1])) || (i == m.Length - 1 && char.IsLetter(m[i])) || (char.IsWhiteSpace(m[i]) && char.IsLetter(m[i - 1])))
                    k++;

            }
            if (k == 0)
                Console.WriteLine("Средняя длина слова: 0");
            else
                Console.WriteLine("Средняя длина слова:" + s / k);
            Console.ReadLine();
        }
    }
}
