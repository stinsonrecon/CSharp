using System;

namespace Program{
    public class Program{
        public static void Main(string[] args){
            FuncAction.TestFunc(2,3);

            FuncAction.TestOutput("Tien", 11);

            ActionDelegrate.TestAction("test");

            Callback.TestCallback(2,3);
        }
    }
}