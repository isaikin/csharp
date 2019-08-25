using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];
            
            int s = 0;
            for (int i=0; i<arr.GetLength(0); i++)
            {
                for (int j=0; j<arr.GetLength(1); j++)
                {
                    Console.Write("Введите arr[{0}, {1}]=", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                   
                    
                }
               
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                        if ((i%2 ==0 &&  j%2==0) || (i % 2 != 0 && j % 2 != 0))
                        s += arr[i, j];

                }

            }
            Console.WriteLine("Сумма равна:"+s);
            
        }
    }
}
