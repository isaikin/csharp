using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForYou
{
    class task1
    {
       public void Summa()
        {
            try
            {
                Console.Write("Enter side a=");
                string str = Console.ReadLine();
                int a = int.Parse(str);
                Console.Write("Enter side b=");
                str = Console.ReadLine();
                int b = int.Parse(str);
                int s = a * b;
                Console.WriteLine("Area=" + s);

            }
            catch 
            {

                Console.WriteLine("Wrong input");

            }
            finally
            {
                Console.ReadLine();
            }
            
        }

    }

}
