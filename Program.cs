using System;
using Dependency;
using InversionDependency;
using WithoutDI;
using WithDI;
using InjectByInterface;

namespace TestDependency{
    public class Program{
        public static void Main(string[] args){
            // Dependency.ClassC classC = new Dependency.ClassC();
            // Dependency.ClassB classB = new Dependency.ClassB(classC);
            // Dependency.ClassA classA = new Dependency.ClassA(classB);

            // classA.ActionA();

            // IClassC objectC = new InversionDependency.ClassC();
            // IClassB objectB = new InversionDependency.ClassB(objectC);
            // InversionDependency.ClassA objectA = new InversionDependency.ClassA(objectB);

            // objectA.ActionA();
            // var car = new WithoutDI.Car();
            // car.Beep();

            // WithDI.Horn horn1 = new WithDI.Horn();

            // var car1 =  new WithDI.Car(horn1);

            // car1.Beep();

            InjectByInterface.Car car1 = new  InjectByInterface.Car(new HeavyHorn());
            car1.Beep();                             

             InjectByInterface.Car car2 = new  InjectByInterface.Car(new LightHorn());
            car2.Beep();                            

        }
    }
    
}
