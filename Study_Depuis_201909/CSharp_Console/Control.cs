using CSharp_Console.Algorithm;
using CSharp_Console.EtcNote;
using CSharp_Console.GlobalInterface;
using CSharp_Console.SmallFeature;
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
            IExampleRun example = null;
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
                        example = new AlgorithmEx();
                        break;

                    case "3":
                    case "note":
                        example = new NoteController();
                        break;
                    case "4":
                    case "features":
                        example = new FeatureControl();
                        break;
                }
                example?.RunExample();
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
