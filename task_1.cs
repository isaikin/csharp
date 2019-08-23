using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        
    
        static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter side a");
            string str = Console.ReadLine();
            int a = int.Parse(str);
            Console.Write("Enter side b");
            str = Console.ReadLine();
            int b = int.Parse(str);
            int s = a * b;
            Console.WriteLine("Area=" + s);
            
        }
        catch (Exception e)
        {

                Console.WriteLine("Wrong input");
               
        }
            Console.ReadLine();
        }

    }
}
