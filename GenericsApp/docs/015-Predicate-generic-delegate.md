# 015 Predicate generic delegate

In order to complete the 🔑`Generic Delegate` no we talk about the 🔑`Predicate<>` .

🔑`Predicate<>` :  
Basically return bool
> delegate bool System.Predicate<in T>(T obj)

👀 ) If we wanna check if a *Person* has specific Age

```cs
using System.Reflection;

namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int>👈 IsEven = (x) =>
            {
                return x % 2 == 0;
            };

            Console.WriteLine(IsEven(5));
            Console.WriteLine(IsEven(4));
        }
    }
}
```

```console
False
True
```

👀 )

```cs
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

            var evenInts = ints.FindAll(IsEven); 👈
        }
    }
}
```
- `var evenInts = ints.FindAll(IsEven);` :  
  Because *.FindAll* takes a `Predicate` .