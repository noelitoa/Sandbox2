using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sandbox2;

namespace KeyDelegateProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            QuitTracker bob = new QuitTracker { Name = "Bob" };

            KeyPressHandler keypresshandler = new KeyPressHandler();
            keypresshandler.OnKey += GotKey;
            keypresshandler.OnQuit += OnQuitting;
            keypresshandler.OnQuit += OnQuitting2;
            keypresshandler.OnQuit += bob.QuitHandler;
            //keypresshandler.OnKey = null;
            keypresshandler.Start();
        }

        static void GotKey(char s)
        {
            Console.WriteLine("Key pressed is {0}", s);
        }

        static void OnQuitting()
        {
            Console.WriteLine("Quitting...");
        }

        static void OnQuitting2()
        {
            Console.WriteLine("Quitting <--- ...");
        }

    }


    public class QuitTracker
    {
        public string Name { get; set; }
        public void QuitHandler()
        {
            Console.WriteLine("{0} has quit the program.", Name);
        }
    }

}
