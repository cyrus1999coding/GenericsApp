using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Logger
    {

        public void Log<T>(T message)
        {
            Console.WriteLine(message.ToString());
        }
    }
}
