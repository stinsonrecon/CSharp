using System;

public class Callback{
    static void TinhTong(int a, int b, Action<string> callback){
        int c = a + b;

        callback(c.ToString());
    }

    public static void TestCallback(int x, int y){
        TinhTong(x,y, (z) => Console.WriteLine($"Tong hai so la: {z}"));

        TinhTong(x,y, ActionDelegrate.Info);
    }
}