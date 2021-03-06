﻿using CSharp_Console.GlobalInterface;
using System;

namespace CSharp_Console.Algorithm
{
    public class AlgorithmEx : IExampleRun
    {
        public AlgorithmEx()
        {
            
        }

        public void RunExample()
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
