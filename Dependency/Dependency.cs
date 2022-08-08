using System;

namespace Dependency{
    public class ClassC{
        public void ActionC(){
            Console.WriteLine("Action in class C");
        }
    }

    public class ClassB{
        ClassC c_dependency;

        public ClassB(ClassC classC) => c_dependency = classC;

        public void ActionB(){
            Console.WriteLine("Action in class B");
            c_dependency.ActionC();
        }
    }

    public class ClassA{
        ClassB b_dependency;

        public ClassA(ClassB classB) => b_dependency = classB;

        public void ActionA(){
            Console.WriteLine("Action in class A");
            b_dependency.ActionB();
        }
    }
}
