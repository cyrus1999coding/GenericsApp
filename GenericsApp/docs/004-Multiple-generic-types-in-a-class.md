# 004 Multiple generic types in a class

🧠 ) We've already seen something similar ↓  

👀 )  

`Program.cs` :

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
        }
    }
}
```
- `List<string> list = new List<string>();` :  
  > class System.Collection.Generics.List<T>

  So we only define 1 `Generic Type` .

But now we want to define 2 `Types` have we seen that before too ❔  
🧠💡 )
Yes ! `Dictionary<>`

`Program.cs` :

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary 👈
        }
    }
}

```
- `Dictionary` :
  > class System.Collection.Generics.Dictionary<TKey, TValue> where Tkey:notnull

👀 )

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string👈,int👈> 
        }
    }
}
```

Now we'll see how can we do somthing similar .  

`Box.cs`

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Box<TFirst👈, TSecond👈>
    {
        public TFirst👈 First { get; set; }
        public TSecond👈 Second { get; set; }

        public Box(TFirst👈 first, TSecond👈 second)
        {
            First = first;
            Second = second;
        }

        public void Display()
        {
            Console.WriteLine($"First: {First}, Second: {Second}");
        }
    }
}
```

So we're not restricted to 1 `Generic Type` .

Now let's use that ↓

`Program.cs` :

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int, string> box = new Box<int, string>(100, "first"); 👈🔑 For the Constructor
            box.Display(); 👈
        }
    }
}
```

```console
First: 100, Second: first
```

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Box<TFirst, TSecond>
    {
        public TFirst First { get; set; }
        public TSecond Second { get; set; }

        public Box(TFirst first, TSecond second)
        {
            First = first;
            Second = second;
        }

        public void Display()
        {
            Console.WriteLine($"First: {First}, Type: {First.GetType()👈}");
            Console.WriteLine($"Second: {Second}, Type: {Second.GetType()👈}");
        }
    }
}
```

```console
First: 100, Type: System.Int32
Second: first, Type: System.String
```