# 013 Action generic delegate

There are some `Built-In` 🔑`Generic Delegates` in C# That ew should talk about .  
We're talking about 🔑`Action` and 🔑`Func` .

🧠 : We've already talked about `Delegates` .  
🚀 : Now we're going to talk about the 🔑`Action<>` `Generic Delegate` .

```cs
using System.Reflection;

namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action 👈
        }
    }
}
```

Let's say this `Action` doesn't take any `Parameter` we just want to write down a *Console Log* .

So ↓

```cs
using System.Reflection;

namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action action = () => { Console.WriteLine("Hello World"); }; 👈
        }
    }


}
```
- 🔑 `Action action = () => { Console.WriteLine("Hello World"); };` :  
  🔑🔑 This `() => { Console.WriteLine("Hello World"); };` part is basically is very similar to a `Method` .  
  🚩 However a `Method` have to `Return` something, An 🔑`Action` has no `Return Value` we cam jsut Execute some code .  
  🔑🔑 We can have some Parameteres in the `()` if we have some .

👀 ) We can do it like this too ↓

```cs
using System.Reflection;

namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            👇
            Action action = () => { 
                Console.WriteLine("Hello World"); 
                Console.WriteLine("Hello World"); 
            };
            👆
        }
    }
}
```

We can call it like a `Method` ↓  

```cs
using System.Reflection;

namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action action = () => { 
                Console.WriteLine("Hello World"); 
            };

            action(); 👈
        }
    }
}
```

```console
Hello World 👈
```

🔑 : in the `Action`s We can submit Multiple `Parameters` we'll get to that .

## So what makes it Generic ❔  

The `Generic` part begins when we creating another `Action` and this time it is of `Type` → *Action<int>*  ↓

```cs
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
            👇
            Action<int> numPrint = (x) =>
            {
                Console.WriteLine(x);
            };
            👆
        }
    }

}
```

If we only have 1 `Parameter` we can remove the `()` ↓  

```cs
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

            Action<int> numPrint = 👉x👈 =>
            {
                Console.WriteLine(x);
            };
        }
    }
}
```
Kinda look like the 🔑`Labmda Expression` .

Now let's call it ↓

```cs
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

            numPrint(10); 👈
        }
    }
}
```

```console
Hello World
10 👈
```

Now Let's create another `Action` this time of `Type` `float` .  
🔑🚀 We can use up to **16** `Parameters` in `Action`s .

```cs
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
            👇
            Action<float, float, float> sum = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };
            👆
            sum(1, 2, 3); 👈
        }
    }
}
```

```console
Hello World
10
6  👈
```

🔑 : As we said an `Action`  
⛔ : Doesn't return a Value  
✅ : We just create the function ( 🔑`Arrow Function` )

📝 :  
This is how we can create `Generic Actions` in C# .