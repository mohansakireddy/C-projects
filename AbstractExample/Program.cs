using System;

namespace AbstractExample
{
    public abstract class AbsExample
    {
        public string Name = "Field in Abstract Class";
        public abstract void Define();
        public void Impliment()
        {
            Console.WriteLine("Providing Implimentation in abstract Class");
        }
    }
    class TestAbstract:AbsExample
    { 
        public override void Define()
        {
            Console.WriteLine("provides Implimentation in derived class");

        }
        static void Main(string[] args)
        {
            AbsExample a1 = new TestAbstract();
            a1.Define();
            a1.Impliment();
            Console.WriteLine(a1.Name);
        }
    }
}
