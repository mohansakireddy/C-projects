using System;

namespace InterfaceExample
{ 
    interface IFirst
    {
        void Method1()
        {

        }
    }
    interface ISecond
    {
        void Method1()
        {

        }

    }
    class TestInterface:IFirst,ISecond
    {
         void IFirst.Method1()
        {
            Console.WriteLine("Method of First Interface Is called");
        }
        void ISecond.Method1()
        {
            Console.WriteLine("Method of Second Interface is Called");
        }
        static void Main(string[] args)
        {
            TestInterface obj = new TestInterface();       //IFirst i1=new TestInterface();
                                                            //i1.Method1();
            ((IFirst)obj).Method1();
            ((ISecond)obj).Method1();
        }
    }
}
