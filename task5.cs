using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForYou
{
    class task5
    {
        public void SummaVseh()
        {
            int s = 0;
            for (int i = 0; i < 1001; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    s += i;
            }
            Console.Write(s);
        }
    }
}
