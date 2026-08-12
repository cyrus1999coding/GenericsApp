using System.Reflection;

namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> IsEven = (x) =>
            {
                return x % 2 == 0;
            };

            List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            var evenInts = ints.FindAll(IsEven);
        }
    }
}