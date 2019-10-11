using CSharp_Console.GlobalInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Console.EtcNote
{
    /// <summary>
    /// 191010 Enum 결합 예제
    /// </summary>
    public class Note191010 : IExampleRun
    {
        
        public void RunExample()
        {
            Days workDays = Days.Monday | Days.Thusday | Days.Wednesday | Days.Thursday | Days.Friday;
            Console.WriteLine(workDays);
            for (int i = 1; i <= 1 << 6; i *= 2) 
            {
                //var a = ((int)workDays & i) == 1 ? ((Days)i).ToString() : "";//Console.WriteLine((Days)i) : Console.WriteLine();
                var a = (int)workDays & i;
                Console.WriteLine((Days)a);
            }

            // 튜플 개념 
            var tuple = ValueTuple();
            Console.WriteLine("\n>>> Value Tuple need to add from nuget");
            Console.WriteLine($"{tuple.Item1} {tuple.Item2}");

            // 파티시알 개념
            TestPartialClass testPartialClass = new TestPartialClass();

            // delegate
            TestDelegates test = new TestDelegates(GetLength);
        }

        public int GetLength(string str)
        {
            return str.Length;
        }

        public (int, string) ValueTuple()
        {
            return (0, "ValueTuple");
        }

        // 이것도 가능
        //public (int Number, string Name) ValueTuple()
        //{
        //    return (Number : 0, Name : "ValueTuple");
        //}
    }

    public enum Days
    {
        Sunday = 1,
        Monday = 1 << 1,
        Thusday = 1 << 2,
        Wednesday = 1 << 3,
        Thursday = 1 << 4,
        Friday = 1 << 5,
        Saturday = 1 <<6
    }

    public partial class TestPartialClass
    {
        #region 프로퍼티 설정
        private string name = "p1_Nick";

        private string Origin
        {
            get
            {
                return $"{name} was born on SomeWhere";
            }
        }

        private string Greeting => $"{name} says 'Hello There!'";

        private int Age => (int)20;
        #endregion

        public TestPartialClass()
        {
            Console.WriteLine("\n===TestPartialClass===");
            Console.WriteLine($"{name},{name2}");
        }
    }
    public partial class TestPartialClass
    {
        private string name2 = "p2_Nick";
        // 여러번 정의 불가
        //private string name = "p1_Nick";  // 프러퍼티 중복 선언 불가
        //public TestPartialClass()         // 생성자 중복 선언 불가
        //{

        //}
    }

    public class TestDelegates
    {
        public delegate int GetLength(string str);
        GetLength GetLen;
        public TestDelegates(GetLength GLM)
        {
            GetLen = GLM;
            Console.WriteLine("delegate : " + GetLen("Test"));
            //GetLength = new GetLength()
        }

        //public TestDelegates((string name)=>{ })
        //{
        //    GetLen = GLM;
        //    //GetLength = new GetLength()
        //}

        public int StrLength(string str)
        {
            return str.Length;
        }
    }
}
