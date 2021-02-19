using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__Iteration_
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercise 1
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                    Console.WriteLine(count);
                }
            }

            //Exercise 2
            var result = 0;
            var terminate = false;
            string input;

            while (!terminate)
            {
                Console.WriteLine("Input a number or input 'ok' to exit");
                input = Console.ReadLine();

                if (input == "ok" || input == "")
                {
                    terminate = true;
                }
                else
                {
                    result += Int32.Parse(input);
                }
            }

            Console.WriteLine(result);

            //Exercise 3

            Console.WriteLine("Input a number: ");
            var input2 = Int32.Parse(Console.ReadLine());
            int result2 = 1;
            for (var i = input2; i > 0; i--)
                result2 =  result2 * i;

            Console.WriteLine(String.Format("{0}! = {1}", input2, result2));


            //Exercise 4
            var chances = 4;
            Random random = new Random();
            int number = random.Next(1, 1000);
            int input3;

            while (chances >= 0)
            {
                if (chances == 0)
                {
                    Console.WriteLine("You lost");
                    break;
                }
                Console.WriteLine("Guess a number");
                input3 = Int32.Parse(Console.ReadLine());
                if (number == input3)
                {
                    Console.WriteLine("You won");
                    break;
                }
                else
                {
                    chances--;
                }
            }


            //Exercise 5
            Console.WriteLine("Input numbers separated by comma: ");
            var input4 = Console.ReadLine();
            string[] numbers = input4.Split(',');
            int final = Int32.Parse(numbers[0]);
            int current;
            for (int i = 1; i < numbers.Length; i++)
            {
                current = Int32.Parse(numbers[i]);
                final = (current > final) ? current : final;
            }
            Console.WriteLine(final);



        }
    }
}
