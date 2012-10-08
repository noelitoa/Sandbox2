using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasteringCSharp4
{

    public delegate void FakeEventHandler(string reason);

    public class FakeEventRaiser
    {

        private FakeEventHandler currentHandler = null;

        public void AddHandler(FakeEventHandler handler)
        {
            currentHandler = currentHandler + handler;
        }

        public void RemoveHandler(FakeEventHandler handler)
        {
            currentHandler = currentHandler - handler;
        }

        public void DoSomething(string message)
        {
            FakeEventHandler tmp = currentHandler;

            if (tmp != null)
            {
                tmp.Invoke(message);
            }

        }

    }
}
