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
    class Program
    {
        static void Main(string[] args)
        {
            DesignPatternsExample();
        }

        static private void DesignPatternsExample()
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
                example.RunExample();

                Console.Write("Press Enter Key....");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
