using System;

public class ActionDelegrate{
    public static void Info(string x){
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(string.Format("Info: {0}", x));
        Console.ResetColor();
    }

    public static void Warning(string x){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(string.Format("Warning: {0}", x));
        Console.ResetColor();
    }

    public static void TestAction(string x){
        Action<string> showLog = null;

        showLog += Warning;
        showLog += Info;
        showLog += Warning;

        showLog(x);
    }
}