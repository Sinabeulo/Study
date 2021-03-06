﻿using CSharp_Console.GlobalInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Console.EtcNote
{
    public class NoteController : IExampleRun
    {
        public NoteController() { }

        public void RunExample()
        {
            bool isExit = false;

            IExampleRun example = null;

            while (isExit == false)
            {
                Console.WriteLine("Note Control");
                Console.Write(" >> : ");
                string cmd = Console.ReadLine();

                switch (cmd.ToLower())
                {
                    case "191003":
                        example = new Note191003();
                        break;
                    case "191010":
                        example = new Note191010();
                        break;
                    case "191014":
                        example = new Note191014(); // 정규식 (Regex)
                        break;
                    case "191018":
                        example = new Note191018(); // 값형식, 참조형식 궁금증
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
