using CSharp_Console.GlobalInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Console.Algorithm
{
    public class PrimaryNumber : IExampleRun
    {
        /// <summary>
        /// Not Finished
        /// </summary>
        public void RunExample()
        {
            Console.WriteLine("Input max number");
            Console.Write(" >> : ");
            
            if(!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine(" >> Input Error !!");
            }

            bool isPNum = true;
            int answer = 0;
            for (int i = 2; i < n; i++)
            {
                isPNum = true;
                //int sqrt = Math.Sqrt(i);
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPNum = false;
                        break;
                    }
                }

                if (isPNum)
                {
                    answer++;
                }

                Console.WriteLine(answer);
            }
        }
    }
}
