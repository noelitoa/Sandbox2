using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Linq.Expressions;

namespace Sandbox2.Test
{
    [TestFixture]
    public class AnonymousFunctionsTest
    {
        public delegate void Int32Action(int value);

        public delegate void GenericAction<T>(T value);


        public void MethodTakingString(string value)
        {
            Console.WriteLine(value);
        }


        public double SquareRoot(int x)
        {
            return Math.Sqrt(x);
        }

        [Test]
        public void ListConversion()
        {
            List<int> original = new List<int> { 1, 2, 3 };
            List<double> squareRoots = original.ConvertAll(SquareRoot);
            foreach (var item in squareRoots)
            {
                Console.WriteLine(item);
            }
        }

        [Test]
        public void MethodGroupConversion()
        {
            GenericAction<string> action = MethodTakingString;
            action.Invoke("hello");
        }

        [Test]
        public void AnonymousMethods()
        {
            Converter<int, double> converter = delegate(int x)
            {
                return Math.Sqrt(x);
            };

            List<int> original = new List<int> { 1, 2, 3 };
            
            List<double> squareRoots = original.ConvertAll(delegate(int x)
            {
                return Math.Sqrt(x);
            });
            
            foreach (var item in squareRoots)
            {
                Console.WriteLine(item);
            }
        }

        [Test]
        public void ClosureAnonymousMethods()
        {
            int calls = 0;
            double power = 0.5;

            Converter<int, double> converter = delegate(int x)
            {
                calls++;
                return Math.Pow(x, power);
            };


            List<int> original = new List<int> { 1, 2, 3 };
            List<double> squareRoots = original.ConvertAll(converter);

            foreach (var item in squareRoots)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total Calls : {0}", calls);

            power = 2;
            List<double> squares = original.ConvertAll(converter);

            foreach (var item in squares)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Total Calls : {0}", calls);


        }


        [Test]
        public void ClosureLambda()
        {
            double power = 0.5;

            Converter<int, double> converter = x => Math.Pow(x, power);
           


            List<int> original = new List<int> { 1, 2, 3 };
            List<double> squareRoots = original.ConvertAll(converter);

            foreach (var item in squareRoots)
            {
                Console.WriteLine(item);
            }

            power = 2;
            List<double> squares = original.ConvertAll(converter);

            foreach (var item in squares)
            {
                Console.WriteLine(item);
            }


        }

        [Test]
        public void ExpressionTrees()
        {
            double power = 0.5;

            Expression<Converter<int, double>> converter = x => Math.Pow(x, power);

            Console.WriteLine(converter);
        }

        [Test]
        public void DangerWillRobinson()
        {

            

            List<string> words = new List<string> { "Danger", "Will", "Robinson" };

            List<Action> actions = new List<Action>();

            foreach (string word in words)
            {
                actions.Add(() => Console.WriteLine(word));
            }

            foreach (Action action in actions)
            {
                action();
            }

            

        }



        
    }
}
