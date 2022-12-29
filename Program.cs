using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine(" please enter string number ");
            int strtNum = int.Parse(Console.ReadLine());
            Console.WriteLine(" please enter eding number ");
            int endNum  = int.Parse(Console.ReadLine());
            Console.WriteLine("These are the number between {0} and {1} " , strtNum, endNum);
            for (int i = strtNum; i <= endNum; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                        counter++;
                    break;
                }
                if (counter == 0 && i !=1)
                    Console.WriteLine(" {0} ", i);
            }

        }
    }
}
