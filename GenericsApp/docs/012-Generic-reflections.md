# 012 Generic reflections

How we can Inspect our `Generic Types`, The thing with `Generics` is that we basically  
⛔ Don't know what `Type` we have during `Compile Time`

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }

    internal class ConfigurationManager<T>
    { 
        public T LoadedConfiguration { get; private set; }

        public ConfigurationManager(T config)
        {
            LoadedConfiguration = config;
        }

        public static void SaveConfig(T configToSave)
        { 
            // Logic
        }
    }
}
```

Whenever we need to Inspect an `Instance` of a `Generic Class` we can use a so-called 
🔑`System.Reflection namesapce` .

So ↓

`Program.cs` :

```cs
using System.Reflection; 👈

namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }

    internal class ConfigurationManager<T>
    { 
        public T LoadedConfiguration { get; private set; }

        public ConfigurationManager(T config)
        {
            LoadedConfiguration = config;
        }

        public static void SaveConfig(T configToSave)
        { 
            // Logic
        }
    }
}
```


```cs
using System.Reflection; 👈

namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            👉Type type = typeof(ConfigurationManager<>);👈


            Console.ReadKey();
        }
    }

    internal class ConfigurationManager<T>
    { 
        public T LoadedConfiguration { get; private set; }

        public ConfigurationManager(T config)
        {
            LoadedConfiguration = config;
        }

        public static void SaveConfig(T configToSave)
        { 
            // Logic
        }
    }
}
```

- `Type type = typeof(ConfigurationManager<>);` :
  We can use the `System.Reflection` by 🔑`Type` 

- Using **breakpoint** we can see all the information from the `Generic Structure` *ConfigurationManager<T>*  
  That we have .

- Used for pretty advanced stuff

👀 ) small example 

```cs
using System.Reflection;

namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Cyrus"; 👈
            👇 
            if (myName.GetType() == typeof(string))
            {
                // Hey this is a string
            }
            👆
        }
    }

    internal class ConfigurationManager<T>
    { 
        public T LoadedConfiguration { get; private set; }

        public ConfigurationManager(T config)
        {
            LoadedConfiguration = config;
        }

        public static void SaveConfig(T configToSave)
        { 
            // Logic
        }
    }
}
```

🔑 Another usecase is in `Inheritance` where we want to check with `virtual` and `override` .

## Usecases  

Are pretty advanced we'll use that whenever we're create our `own .NET Framework` or `Mock Testing APIs` or ..  
So Really Adcanced stuff .
