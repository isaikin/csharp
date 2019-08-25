using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите число элементов массива:");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int s = 0;
            for (int i=0; i<arr.Length; i++)
            {
                Console.Write("Введите arr[{0}]", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] >= 0)
                    s += arr[i];
            }
            Console.Write("Сумма равна:" + s);
            
        }
    }
}
