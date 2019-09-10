using CSharp_Console.GlobalInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Console.Algorithm
{
    class AlgorithmEx
    {
        public AlgorithmEx()
        {
            bool isExit = false;

            IExampleRun example = null;

            while (isExit == false)
            {
                Console.WriteLine("Algorithm Category");
                Console.Write(" >> : ");
                string cmd = Console.ReadLine();

                switch (cmd.ToLower())
                {
                    case "1":
                    case "pn":
                        example = new PrimaryNumber();
                        break;

                    case "exit": case "quit": case "e": case "q": isExit = true; break;
                }
                
                example?.RunExample();

                Console.Write("Press Enter Key....");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
