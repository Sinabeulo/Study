using CSharp_Console.GlobalInterface;
using System;

namespace CSharp_Console.EtcNote
{
    /// <summary>
    /// 파라미터 변수의 할당 예제
    /// </summary>
    internal class Note191018 : IExampleRun
    {
        public void RunExample()
        {
            // 1. about parameter
            TestClass testClass = new TestClass();
            testClass.message = "default value";

            Console.WriteLine("before : " + testClass.message);
            TestMethod(testClass);
            Console.WriteLine("after : " + testClass.message);

            Console.WriteLine();
            //================================================
            // 2. about struct
            TestStruct testStruct;
            testStruct.memberStr = "Hello World";
            testStruct.SayHello();

            testStruct = new TestStruct();

            Console.WriteLine(testStruct.memberStr);
        }

        private void TestMethod(TestClass testClass)
        {
            testClass.message = "Changed in Method";
            
            testClass = new TestClass() { message = "new object" };
            Console.WriteLine("inside : " + testClass.message);
        }

        private class TestClass
        {
            public string message = "";
        }

        private struct TestStruct : IExampleRun
        {
            public string memberStr;

            public void RunExample()
            {
                
            }

            public void SayHello()
            {
                Console.WriteLine("You Said Hello");
            }
        }

        private struct TestStruct2 { 
}
        /*   make object                Method                          new object
         * address  | value         >> address |   value         >>  address | value
         *    A     | default       >>    A    |   Changed       >>     A    |  changed
         *    B     |               >>    B    |   [address] A   >>     B    |  [address] C
         *    C     |               >>    C    |                 >>     C    |  new object
         */
    }
}