using System;
using System.Dynamic;

namespace example3
{
    public class TestInheritance
    {
        public string CompanyName = "Tcs";
        public String Location;
        
        public void GetLocation(string loc)
        {
            Location = loc;
            Console.WriteLine("Location={0}", Location);
            Console.WriteLine("Company={0}", CompanyName);
        }
    }
    class ChildClass:TestInheritance
    {
        public string Name;
        public string Skills;
        public void UserInfo()
        {
            Console.WriteLine("EmpName={0}", Name);
            Console.WriteLine("Skills={0}", Skills);
        }
        static void Main(string[] args)

        {
            ChildClass c1 = new ChildClass();
            Console.WriteLine("please enter your name:");
           c1.Name = Console.ReadLine();
            Console.WriteLine("please mention your skills:");
            c1.Skills = Console.ReadLine();
            c1.GetLocation("Hyderabad");
            c1.UserInfo();
        }
    }
}
