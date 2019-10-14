using CSharp_Console.GlobalInterface;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CSharp_Console.EtcNote
{
    class Note191014 : IExampleRun
    {
        /// <summary>
        /// Regex 활용 예제
        /// </summary>
        public void RunExample()
        {
            List<string> originList = new List<string>()
            {
                "0.가 2.5mg",
                "1.나 2.5mg",
                "2.다 2.5mg",
                "3.라 2.5mg",
                "4.마 2.5mg",
                "5.바 2.5mg",
                "6.사2.5mg",
                "7.아2.5mg",
                "8.자2.5mg",
                "9.차2.5mg",
                "10. 카2.5mg",
                "11. 타a2.5mg"
            };

            // [숫자.] 제거
            Regex regex = new Regex(@"^[0-9]?[0-9]\.");

            foreach (var str in originList)
                Console.WriteLine(regex.Replace(str, ""));

            // (내용) 제거
            string originData = "1.a(b%),2.a(b%),3.a(b%),4.a(b),5.a(b),6.a(b),7.a(b),8.a(b),9.a(b),10.a(b),11.a(b),12.a(b),13.a(b),14.a(b),15.a(b),16.a(b),17.a(b)";

            Regex regex2 = new Regex(@"\((.*?)\)");
            Console.WriteLine(regex2.Replace(originData, ""));

        }
    }
}
