using CSharp_Console.Algorithm;
using CSharp_Console.EtcNote;
using CSharp_Console.GlobalInterface;
using DesignPattern.DecoratorPattern;
using DesignPattern.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Console
{
    class Control
    {
        public Control()
        {
            while (true)
            {
                Console.WriteLine("Input Category");
                Console.Write(" >> : ");
                string cmd = Console.ReadLine();
                switch (cmd.ToLower())
                {
                    case "dp":
                        DesignPatternsExample();
                        break;

                    case "al":
                        AlgorithmEx algorithmEx = new AlgorithmEx();
                        break;

                    case "3":
                    case "note":
                        NoteController aa = new NoteController();
                        aa.RunExample();
                        break;
                }
            }
        }

        private void DesignPatternsExample()
        {
            bool isExit = false;

            IExampleRun example = null;

            while (isExit == false)
            {
                Console.WriteLine("Input Design Pattern");
                Console.Write(" >> : ");
                string cmd = Console.ReadLine();

                switch (cmd.ToLower())
                {
                    case "1":
                    case "observer":
                        example = new WeatherStation();
                        break;
                    case "2":
                    case "deco":
                        example = new Decorator();
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
