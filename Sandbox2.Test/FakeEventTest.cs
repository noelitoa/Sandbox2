using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MasteringCSharp4;

namespace Sandbox2.Test
{
    [TestFixture]
    public class FakeEventTest
    {

        private void ReportToConsole(string text)
        {
            Console.WriteLine("Called {0} ", text);
        }

        [Test]
        public void RaiseEvents()
        {

            FakeEventHandler handler = ReportToConsole;

            FakeEventRaiser raiser = new FakeEventRaiser();
            raiser.DoSomething("Not subscribed!");

            raiser.AddHandler(handler);
            raiser.DoSomething("Subscribed!");

            raiser.AddHandler(handler);
            raiser.DoSomething("Subscribed twice!");

            raiser.RemoveHandler(handler);
            raiser.RemoveHandler(handler);
            raiser.DoSomething("Unsubscribed!");

        }

    }
}
