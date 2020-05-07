using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace ExtraLessonsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ref vs Out

            //int myNumber = 0;
            //AddToMyNumber(myNumber);
            //Console.WriteLine($"myNumber after the method = {myNumber}");
            //Console.WriteLine("******************");

            //var myNumber2 = 0;
            //AddToMyNumber(ref myNumber2);
            //Console.WriteLine($"ref myNumber after the method = {myNumber2}");
            //Console.WriteLine("******************");

            #endregion

            #region Break

            //Console.WriteLine("Break");
            //for (int i = 1; i < 25; i++)
            //{
            //    if (i == 10)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("*************");
            #endregion

            #region Continue

            //Console.WriteLine("Continue");
            //for (int i = 1; i < 25; i++)
            //{
            //    if (i > 14 && i < 21)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("*************");
            #endregion

            #region Yield Return
            //foreach (var num in GetNumbers())
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region Files and Dir

            var dir = @"C:\Projects\InClassDirectory2\";

            if (Directory.Exists(dir))
            {
                var files = Directory.GetFiles(dir);                
                foreach (var item in files)
                {
                    Console.WriteLine(item);
                }
            }

            var filePath = dir + "sample.txt";
            if (File.Exists(filePath))
            {
                var text = File.ReadAllText(filePath);
                File.Delete(filePath);
                var stream = File.Create(dir + "SecondSample.txt");
                stream.Close();

                text += "From C#";

                Thread.Sleep(2000);
                File.WriteAllText(dir + "SecondSample.txt", text);
            }
            
            #endregion

            #region Dynamic

            //dynamic myCoolDynamic = 1;

            //var someOtherString = myCoolDynamic.ToUpper();

            //Console.WriteLine(myCoolDynamic.MaxValue);
            //Console.WriteLine(someOtherString);
            #endregion
        }

        private static void AddToMyNumber(int myNumber)
        {
            myNumber += 100;
            Console.WriteLine($"myNumber inside of the method = {myNumber}");
        }

        private static void AddToMyNumber(ref int myNumber)
        {
            myNumber += 100;
            Console.WriteLine($"ref myNumber inside of the method = {myNumber}");
        }

        private static IEnumerable<int> GetNumbers()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            foreach (var item in arr)
            {
                if (item > 5)
                {
                    yield return item;
                }
            }
        }
    }
}
