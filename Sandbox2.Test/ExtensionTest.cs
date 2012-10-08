using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using MasteringCSharp4;
using System.Net;

namespace Sandbox2.Test
{
    [TestFixture]
    public class ExtensionTest
    {
        [Test]
        public void InvokeReverse()
        {
            string reversed = "hello".Reverse();
            Assert.AreEqual("olleh", reversed);
        }

        //[Test]
        //public void ReadFully()
        //{
        //    var request = WebRequest.Create("http://www.google.com.ph");
        //    using (var response = request.GetResponse())
        //    {
        //        using (var responseStream = response.GetResponseStream())
        //        {
        //            byte[] data = responseStream.ReadFully();
        //            Console.WriteLine(data.Length);
        //        }
        //    }
            
        //}

        [Test]
        public void MiniLinq()
        {
            string[] persons = { "Noel", "Jon", "Aiych", "Scott" };

            //var result = persons.Select(x => x.Length)
            //                    .Where(x => x < 5);

            //var result = persons.Where(x => !x.EndsWith("h"))
            //                    .Select(x => x.ToUpper());


            var query = MasteringCSharp4.Extensions.Select(
                            MasteringCSharp4.Extensions.Where(
                                persons,
                                x => !x.EndsWith("h")),
                                x => new
                                {
                                    UpperName = x.ToUpper(),
                                    NameLenght = x.Length
                                });


            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

        }

    }
}
