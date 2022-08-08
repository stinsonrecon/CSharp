using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

public class TestTask{
    public static void WriteLine(string s, ConsoleColor color){
        Console.ForegroundColor = color;
        Console.WriteLine(s);
    }

    public static Task<string> Async1(string thamso1, string thamso2){
        Func<object, string> myFunc = (object thamso) => {
            dynamic ts = thamso;
            for(int i = 1; i <= 10; i++){
                WriteLine($"{i,5} {Thread.CurrentThread.ManagedThreadId, 3} Tham so {ts.x} {ts.y}", 
                ConsoleColor.Green);

                Thread.Sleep(500);
            }
            return $"Ket thuc Async1! {ts.x}";
        };

        Task<string> task = new Task<string> (myFunc, new { x = thamso1, y = thamso2 });
        task.Start();

        Console.WriteLine("Async1 : lam gi do sau khi task chay");

        return task;
    }

    public static Task Async2(){
        Action myAction = () => {
            for(int i = 1; i <= 10; i++){
                WriteLine ($"{i, 5} {Thread.CurrentThread.ManagedThreadId, 3}", 
                ConsoleColor.Yellow);

                Thread.Sleep(300);
            }
        };
        Task task = new Task(myAction);
        task.Start();

        Console.WriteLine("Async2 : lam gi do sau khi task chay");

        return task;
    }
}
