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
            string m=Console.ReadLine();
              string[] ar = { ",", ".", "!", "?", "-", " ", "^", ":" };
              for (int i = 0; i < ar.Length; i++)
              {
                  m = m.Replace(ar[i], "");
              }
                     
            Console.WriteLine("Длина строки:" + m.Length);
            Console.ReadLine();
        }
    }
}
