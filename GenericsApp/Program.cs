using System.Reflection;

namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action action = () =>
            {
                Console.WriteLine("Hello World");
            };

            action();

            Action<int> numPrint = x =>
            {
                Console.WriteLine(x);
            };

            numPrint(10);

            Action<float, float, float> sum = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };

            sum(1, 2, 3);
        }
    }


}