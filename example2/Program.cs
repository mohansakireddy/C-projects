using System;
using System.Diagnostics.CodeAnalysis;

namespace example2
{
    public class TestPolymorphism1
    {
        public void Calculate(int a, int b)
        {
            Console.WriteLine("multiplication ={0}", a * b);
        }
        public void Calculate(int a, int b, int c)
        {

            Console.WriteLine("addition={0}", a + b + c);
        }
        public void Calculate(int a, int b, out int c)
        {
            c = a + b;
            Console.WriteLine("sum={0}", c);
        }
        public virtual void Message()
        {
            Console.WriteLine("message method in the base class");
        }
        public virtual void HideMethod()
        {
            Console.WriteLine("hide method of base class");

        }

    }
    class TestPolymorphism2:TestPolymorphism1

    {
        public override void Message()
        {
            Console.WriteLine(" message method in the drerived class");
        }
        public new void HideMethod()
        {
            Console.WriteLine("hide method of derived  class");

        }
        static void Main(string[] args)
        {
            int c = 0;
            TestPolymorphism1 t1 = new TestPolymorphism1();
            t1.Calculate(1, 2);
            t1.Calculate(1, 2, 3);
            t1.Calculate(1, 2, out c);
            TestPolymorphism1 t2 = new TestPolymorphism2();
            t2.Message();
            TestPolymorphism1 t3 = new TestPolymorphism2();
            t3.HideMethod();
            TestPolymorphism2 t4 = new TestPolymorphism2();
            t4.HideMethod();
        }
    }
}
