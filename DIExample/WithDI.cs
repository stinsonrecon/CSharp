using System;

namespace WithDI{
    public class Horn {
        public void Beep () => Console.WriteLine ("Beep - beep - beep ...");
    }

    public class Car {
        // horn là một Dependecy của Car
        Horn horn;

        // dependency Horn được đưa vào Car qua hàm khởi tạo
        public Car(Horn horn) => this.horn = horn;

        public void Beep () {
            // Sử dụng Dependecy đã được Inject
            horn.Beep ();
        }
    }
}