using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox2
{

    public delegate void KeyPressDelegate(char s);
    public delegate void OnQuitDelegate();


    public class KeyPressHandler
    {

        public event KeyPressDelegate OnKey;
        public event OnQuitDelegate OnQuit;

        public void Start()
        {

            Console.WriteLine("KeyPressHandler is running. Press Q to quit.");

            while (true)
            {
                var key = Console.ReadKey(true).KeyChar;

                if (key == 'q')
                {
                    OnQuit();
                    break;
                    
                }

                OnKey(key);
                
            }
        
        }

    }
}
