using System;
using System.Diagnostics;
using System.Threading;

namespace Sortering_uppgift
{
    class Program
    {
        static void bubblesort(int[]iArray){
            int n = iArray.Length;
            for (int i = 0; i < n - 1; i++){
                for (int j = 0; j < n - i - 1; j++){
                    if (iArray[j] > iArray[j + 1])
                    {
                        int temp = iArray[j];
                        iArray[j] = iArray[j + 1];
                        iArray[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int[] iArray = new int[8000];
            Random random = new Random();
            for(int i = 0; i < 8000; i++){
                iArray[i] = random.Next(1, 101); //1 - 100, including 100
            }
            bubblesort(iArray);
            Console.WriteLine("iArray är sorterad");
            int n = iArray.Length;
            for (int i = 0; i < n; ++i){
                Console.WriteLine(iArray[i] + " " +watch.ElapsedMilliseconds);
            }
            watch.Stop();
            long ts = watch.ElapsedMilliseconds;
            Console.WriteLine("RunTime " + ts);
            Console.ReadKey();
        }
    }
}
