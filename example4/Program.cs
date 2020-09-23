using System;
using System.Security.Cryptography;

namespace example4
{
    public class Electronics
    {
        public void Type()
        {
            Console.WriteLine("Electronic  Device");
        } 
    }
    public class LCD:Electronics
    {
        public void Technology()
        {
            Console.WriteLine("Uses Liquid Crystal Display");
        }
    }
    public class Name:LCD
    {
        public void DeviceName()
        {
            Console.WriteLine("Television");
        }
    }
    class InheritanceEx
    {
        static void Main(string[] args)
        {
            Name obj = new Name();
            obj.DeviceName();
            obj.Technology();
            obj.Type();
        }
    }
}
