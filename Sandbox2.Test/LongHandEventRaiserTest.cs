using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MasteringCSharp4;

namespace Sandbox2.Test
{
    [TestFixture]
    public class LongHandEventRaiserTest
    {

        private void ReportToConsole(object sender, EventArgs e)
        {
            Console.WriteLine("ReportToConsole was called");
        }

        [Test]
        public void RaiseEvents()
        {
            ClickHandler handler = ReportToConsole;

            LongHandEventRaiser raiser = new LongHandEventRaiser();
            raiser.OnClick();

            raiser.Click += handler;
            raiser.OnClick();

            raiser.Click += handler;
            raiser.OnClick();

            raiser.Click -= handler;
            raiser.Click -= handler;
            raiser.OnClick();


            

        }


    }
}
