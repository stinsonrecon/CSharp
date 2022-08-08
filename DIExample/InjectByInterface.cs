using System;

namespace InjectByInterface{
    public interface IHorn{
        public void Beep();
    }

    public class HeavyHorn : IHorn
    {
        public void Beep() => Console.WriteLine("(kêu to lắm) BEEP BEEP BEEP ...");
    }

    public class LightHorn : IHorn
    {
        public void Beep() => Console.WriteLine("(kêu bé lắm) beep  bep  bep ...");
    }

    public class Car{
        IHorn horn;

        public Car(IHorn ihorn){
            horn = ihorn;
        }

        public void Beep() => horn.Beep();
    }
}