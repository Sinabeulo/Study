using CSharp_Console.GlobalInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CondTest.SamllFeatures
{
    public class MakeRandom_6Numbers : IExampleRun
    {
        /// <summary>
        /// 6개의 난수 생성기 1-45
        /// 1 번째 입력 인자 : 6자리 난수 생성 횟수 (ex 100 이면 6자리 100개 생성)
        ///  - 생성된 난수에서 가장 많이 나온 숫자 6개 출력
        /// 2 번째 입력 인자 : 표시헐 목록 수
        /// </summary>
        public void RunExample()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("\tRandom Numbers");
            Console.WriteLine("=============================");
            Console.Write("Base Data Count : ");            // 6자리 수를 얻기 위해 참고할 랜덤 데이터양
            var input = Console.ReadLine();

            Console.Write("How many list do you want? : "); // 목록 개수
            string input2 = Console.ReadLine();


            if (!int.TryParse(input,out int count))
            {
                Console.WriteLine("Input Error");
                Console.ReadLine();
                return;
            }

            if(!int.TryParse(input2, out int listCount))
            {
                Console.WriteLine("Input Error");
                Console.ReadLine();
                return;
            }

            for (int i = 0; i < listCount; i++)
            {
                Thread.Sleep(30);
                GetRandom6(count);
            }

            #region 원본 테스트 코드
            //Random randNum = new Random();

            //List<Tuple<int, int>> manySelectedNumbers = new List<Tuple<int, int>>();
            //int[] retNum;
            //List<int[]> retList = new List<int[]>();

            //for (int i = 0; i < 47; i++)
            //{
            //    manySelectedNumbers.Add(new Tuple<int, int>(i, 0));
            //}


            //for (int a = 0; a < count; a++)
            //{
            //    retNum = new int[6];
            //    for (int i = 0; i < 6; i++)
            //    {
            //        GET_NEW_NUMBER:
            //        int rn = randNum.Next(1,46);
            //        if(retNum.Any(b=>b==rn))
            //        {
            //            goto GET_NEW_NUMBER;
            //        }

            //        retNum[i] = rn;
            //    }
            //    retList.Add(retNum);
            //    //Console.WriteLine($"{a} 번째 : {retNum[0]} {retNum[1]} {retNum[2]} {retNum[3]} {retNum[4]} {retNum[5]}");
            //}

            ////=======================================================
            //// 가장 많이 나온 수 구하기

            //foreach(var item in retList)
            //{
            //    // item은 int[6]의 배열로 6개의 숫자를 가지고 있음.
            //    foreach(int i in item)
            //    {
            //        manySelectedNumbers[i] = new Tuple<int, int>(i, manySelectedNumbers[i].Item2 + 1);
            //    }
            //}

            //int[] retData = new int[6];

            //var max = manySelectedNumbers.Max(a => a.Item2);

            //var highList = manySelectedNumbers.Where(w => w.Item2 == max).ToList();
            //int numCount = highList.Count();

            //int numStack = 0;

            //for (numStack = 0; numStack < numCount; numStack++)
            //{
            //    if (numStack > 5)
            //        break;
            //    retData[numStack] = highList[numStack].Item1;
            //}



            //while (numCount < 6)
            //{
            //    max -= 1;
            //    highList = manySelectedNumbers.Where(s => s.Item2 == max).ToList();
            //    numCount += highList.Count();

            //    int i = 0;
            //    for (; numStack < numCount; numStack++)
            //    {
            //        if (numStack > 5)
            //            break;
            //        retData[numStack] = highList[i++].Item1;
            //    }
            //}

            //Console.WriteLine($">>> : {retData[0]} {retData[1]} {retData[2]} {retData[3]} {retData[4]} {retData[5]}");
            //Console.ReadLine();
            #endregion
        }

        private void GetRandom6(int count)
        {
            Random randNum = new Random();

            List<Tuple<int, int>> manySelectedNumbers = new List<Tuple<int, int>>();
            int[] retNum;
            List<int[]> retList = new List<int[]>();

            for (int i = 0; i < 47; i++)
            {
                manySelectedNumbers.Add(new Tuple<int, int>(i, 0));
            }


            for (int a = 0; a < count; a++)
            {
                retNum = new int[6];
                for (int i = 0; i < 6; i++)
                {
                GET_NEW_NUMBER:
                    int rn = randNum.Next(1, 46);
                    if (retNum.Any(b => b == rn))
                    {
                        goto GET_NEW_NUMBER;
                    }

                    retNum[i] = rn;
                }
                retList.Add(retNum);
                //Console.WriteLine($"{a} 번째 : {retNum[0]} {retNum[1]} {retNum[2]} {retNum[3]} {retNum[4]} {retNum[5]}");
            }

            //=======================================================
            // 가장 많이 나온 수 구하기

            foreach (var item in retList)
            {
                // item은 int[6]의 배열로 6개의 숫자를 가지고 있음.
                foreach (int i in item)
                {
                    manySelectedNumbers[i] = new Tuple<int, int>(i, manySelectedNumbers[i].Item2 + 1);
                }
            }

            int[] retData = new int[6];

            var max = manySelectedNumbers.Max(a => a.Item2);

            var highList = manySelectedNumbers.Where(w => w.Item2 == max).ToList();
            int numCount = highList.Count();

            int numStack = 0;

            for (numStack = 0; numStack < numCount; numStack++)
            {
                if (numStack > 5)
                    break;
                retData[numStack] = highList[numStack].Item1;
            }

            while (numCount < 6)
            {
                max -= 1;
                highList = manySelectedNumbers.Where(s => s.Item2 == max).ToList();
                numCount += highList.Count();

                int i = 0;
                for (; numStack < numCount; numStack++)
                {
                    if (numStack > 5)
                        break;
                    retData[numStack] = highList[i++].Item1;
                }
            }

            Console.WriteLine($">>> : {retData[0]} {retData[1]} {retData[2]} {retData[3]} {retData[4]} {retData[5]}");
        }
    }
}
