using System;

namespace InversionDependency{
    interface IClassB{
        public void ActionB();
    }

    interface IClassC{
        public void ActionC();
    }

    public class ClassC : IClassC{
        public void ActionC() => Console.Write("Action in class C");

        public ClassC() => Console.WriteLine("Created class C");
    }
    class ClassC1 : IClassC
    {
        public ClassC1() => Console.WriteLine ("ClassC1 is created");
        public void ActionC()
        {
            Console.WriteLine("Action in C1");
        }
    }

    class ClassB : IClassB{
        IClassC c_dependency;

        public ClassB(IClassC classC){
            c_dependency = classC;
            Console.WriteLine("Created class B");
        } 
        public void ActionB() {
            Console.WriteLine("Action in class B");
            c_dependency.ActionC();
        } 
    }

    class ClassB1 : IClassB
    {
        IClassC c_dependency;
        public ClassB1(IClassC classc)
        {
            c_dependency = classc;
            Console.WriteLine("ClassB1 is created");
        }
        public void ActionB()
        {
            Console.WriteLine("Action in B1");
            c_dependency.ActionC();
        }
    }

    class ClassA{
        IClassB b_dependency;

        public ClassA(IClassB classB){
            b_dependency = classB;
            Console.WriteLine("Created class A");
        }

        public void ActionA(){
            Console.WriteLine("Action in class A");
            b_dependency.ActionB();
        }
    }
}