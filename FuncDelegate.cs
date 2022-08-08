using System;

public class FuncAction{
    public static int Sum(int x, int y){
        return x + y;
    }

    public static string Output(string x, int y){
        return $"{x} la string nhap vao, " + y + " la int nhap vao"; 
    }

    public static void TestFunc(int x, int y){
        Func<int, int, int> tinhTong;
        tinhTong = Sum;

        var ketqua = tinhTong(x,y);
        Console.WriteLine(ketqua);
    }

    public static void TestOutput(string x, int y){
        Func<string, int, string> output;

        output = Output;

        var ketqua = output(x, y);
        Console.WriteLine(ketqua);

    }
}