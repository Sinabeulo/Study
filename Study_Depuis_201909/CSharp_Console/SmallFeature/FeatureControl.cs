using CondTest.SamllFeatures;
using CSharp_Console.GlobalInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Console.SmallFeature
{
    public class FeatureControl : IExampleRun
    {
        public void RunExample()
        {
            bool isExit = false;

            IExampleRun example = null;

            while (isExit == false)
            {
                Console.WriteLine("Feature Control");
                Console.Write(" >> : ");
                string cmd = Console.ReadLine();

                switch (cmd.ToLower())
                {
                    case "lotto":
                        example = new MakeRandom_6Numbers();
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
