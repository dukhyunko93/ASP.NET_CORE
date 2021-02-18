using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 10; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            var name = "Duke Ko";
            foreach(var i in name)
            {
                Console.WriteLine(i);
            }

            var numbers = new int[] { 1, 2, 3, 4, 5 };
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            var j = 0;
            while(j <= 10)
            {
                if(j % 2 == 0)
                    Console.WriteLine(j);
                j++;
            }
        }
    }
}
