using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Sandbox2.Test
{
    [TestFixture]
    public class AnonoymousTest
    {

        private void DoSomething<T>(T value)
        {
            Console.WriteLine(value);
        }


        [Test]
        public void Demo()
        {
            var person = new { FirstName = "Noel", LastName = "Arlante" };
            var person2 = new { FirstName = "Jon", LastName = "Skeet" };
            var person3 = new { FirstName = "Noel", LastName = "Arlante" };

            DoSomething(person);

            var weirdperson = new { FirstName = 10, LastName = 20 };

            Assert.AreNotEqual(person, person2);
            Assert.AreEqual(person, person3);
            Assert.AreEqual(person.GetHashCode(), person3.GetHashCode());

            string[] s = { "string1", "string2" };

            var s1 = s.Length;

            Assert.AreEqual(2, s.Length);

            var people = new[] {

                person,
                new { FirstName="Don", LastName="Villamor"}


            };

        }

    }
}
