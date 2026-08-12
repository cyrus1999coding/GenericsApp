using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Comparer
    {
        public static bool AreEqual<T>(T first, T second) where T : class
        {
            return first == second;
        }

    }
}
