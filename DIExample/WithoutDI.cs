using System;

namespace WithoutDI{
    public class Horn{
        public void Beep() => Console.WriteLine("beep-beep-beep-.....");
    }

    public class Car{
        public void Beep(){
            Horn horn = new Horn();
            horn.Beep();
        }
    }
}
