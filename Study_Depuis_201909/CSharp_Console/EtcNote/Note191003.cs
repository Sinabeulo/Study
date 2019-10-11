using CSharp_Console.GlobalInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CSharp_Console.EtcNote
{
    class Note191003 : IExampleRun
    {
        public Note191003() { }

        public void RunExample()
        {
            object o = 3;
            int j = 4;
            List<string> list = new List<string>
            {
                "a","b","c","d"
            };

            // is 키워드를 통해 보다 안전하게 코드 작성할 수 있다.
            if (o is int i)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                Console.WriteLine("o is not an int so it cannot multiply!");
            }

            string args = string.Empty;

            // #gotofail Error 발생할 확률 존재
            if (args.Length == 0)
                Console.WriteLine("There are no arguments.");
            else
                Console.WriteLine("There is at least one argument.");

            // 좀 더 안전성 있음.
            if (args.Length == 0)
            {
                Console.WriteLine("There are no arguments.");
            }
            else
            {
                Console.WriteLine("There is at least one argument.");
            }

            WriteLine(" === === Next Note === ===");
            //=====================================================
            //foreach의 동작 방식
            //IEnumerable 인터페이스를 구현한 모든 타입은 사용가능.
            //컴파일러는 아래와 같이 변환해 처리한다.
            IEnumerator e = list.GetEnumerator();
            while (e.MoveNext())
            {
                string name = (string)e.Current;// Current 속성은 읽기 전용이다.
                Console.WriteLine($"{name} has {name.Length} characters.");
            }

            WriteLine(" === === Next Note === ===");
            //=====================================================
            // Convert VS 명시적 강제형 변환
            double g = 9.8;
            int d = (int)g;
            WriteLine($"(int) {d}");    // 9  -> 버림
            d = ToInt32(g);
            WriteLine($"ToInt32 {d}");  // 10 -> 반올림

            WriteLine(" === === Next Note === ===");
            //=====================================================
            // Checked 문 사용 예제
            // 결과 : System.OverflowException: '산술 연산으로 인해 오버플로가 발생했습니다.'
            try
            {
                checked
                {
                    int x = int.MaxValue - 1;
                    WriteLine(x);
                    x++;
                    WriteLine(x);
                    x++;    //  >> >> Error Occur System.OverflowException
                    WriteLine(x);
                    x++;
                    WriteLine(x);
                    x++;
                }
            }
            catch(Exception ex)
            {
                WriteLine(ex);
            }

            WriteLine(" === === Next Note === ===");



        }
    }
}
