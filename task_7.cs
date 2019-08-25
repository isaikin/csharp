using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-10, 10);
                Console.WriteLine("arr[{0}]={1}", i, arr[i]);

             }
            int max = arr[0], min = arr[0];
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine("max=" + max);
            Console.WriteLine("min=" + min);
            
        }
    }
}
