using System;
using CS021_ASYNCHRONOUS;

namespace Program{
    public class Program{
        // public static void Main(string[] args){
        //     //DownloadWebite01.TestDownloadWebPage(); 
        //     Console.WriteLine($"{' ', 5} {Thread.CurrentThread.ManagedThreadId,3} MainThread");
        //     Task<string> t1 = TestTask.Async1("A", "B");
        //     Task t2 = TestTask.Async2();

        //     Console.WriteLine("Lam gi do o thread chinh sau khi 2 task chay");

        //     t1.Wait();
        //     String s = t1.Result;
        //     TestTask.WriteLine(s, ConsoleColor.Red);

        //     Console.ReadKey();
        // }

        static async Task Main(string[] args)
        {
            var t1 = TestAsyncAwait.Async1("x", "y");
            var t2 = TestAsyncAwait.Async2();

            // Làm gì đó khi t1, t2 đang chạy
            Console.WriteLine("Task1, Task2 đang chạy");


            await t1; // chờ t1 kết thúc
            Console.WriteLine("Làm gì đó khi t1 kết thúc");

            await t2; // chờ t2 kết thúc
        }
    }
}