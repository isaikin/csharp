using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForYou
{
    class task9
    {
        public void PolozSumma()
        {
            int[,,] arr = new int[3, 3, 3];
            Random r = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = r.Next(-10, 10);
                        if (arr[i, j, k] > 0)
                            arr[i, j, k] = 0;
                    }
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {

                        Console.Write("{0}", arr[i, j, k]);
                        Console.Write(" ");
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
