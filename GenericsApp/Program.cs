using System.Reflection;

namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, string> sum = (x, y) =>
            {
                return "Your result is: " + (x + y).ToString();
            };
        }


    }
}