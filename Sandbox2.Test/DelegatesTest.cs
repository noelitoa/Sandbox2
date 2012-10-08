using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MasteringCSharp4;

namespace Sandbox2.Test
{
    [TestFixture]
    public class DelegatesTest
    {
        [Test]
        public void SingleMethodInterface()
        {
            IInt32Action action = new Delegates();
            action.DoIt(10);

        }

        [Test]
        public void SimpleDelegateFromMethod()
        {

            Delegates target = new Delegates("Noel");
            Int32Action action = new Int32Action(target.RandomNoel);

            action.Invoke(10);
            action(6);

        }

        [Test]
        public void DelegateFromStaticMethod()
        {
            Int32Action action = new Int32Action(Delegates.StaticNoel);

            action.Invoke(7);
        }

        [Test]
        public void MultiCast()
        {
            Int32Action action1 = new Int32Action(Delegates.StaticNoel);
            Int32Action action2 = new Int32Action(Delegates.StaticNoel2);
            
            Int32Action action3 = action1 + action2;
            action1 = null;
            action3(20);
        
        }


        

    }
}
