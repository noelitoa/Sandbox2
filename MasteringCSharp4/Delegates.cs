using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasteringCSharp4
{
    
    public delegate void Int32Action(int value);

    public interface IInt32Action
    {
        void DoIt(int value);
    }

    public class Delegates : IInt32Action
    {
        string name;

        public Delegates(string name)
        {
            this.name = name;
        }

        public Delegates() : this("unknown")
        {

        }

        public void DoIt(int value)
        {
            Console.WriteLine("Interface implementation : {0}", value);
        }

        public void RandomNoel(int value)
        {
            Console.WriteLine("{0} : Delegate implementation : {1}", name, value);
        }

        public static void StaticNoel(int value)
        {
            Console.WriteLine("Static implementation 1 : {0}", value);
        }

        public static void StaticNoel2(int value)
        {
            Console.WriteLine("Static implementation 2 : {0}", value);
        }

    }
}
