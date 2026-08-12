# 005 Generic methods without generic classes

Let's create a new `Class` ↓

`Logger.cs`:

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Logger
    {
    }
}
```

Now we want to have 1 `Method` use a `Generic Type` .

`Logger.cs` :

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Logger
    {

        public void Log👉<T>👈(T👈 message)
        { 
        
        }
    }
}
```

- Now we have `Genric Method` inside of a **Default** C# `Class` .

`Logger.cs` :

```cs
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
```

Now let's see it ↓

`Progrma.cs` :

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            logger.Log 👈
        }
    }
}
```
- `logger.Log ` :  
  Now we see 🔑`Log<>`, Which now we'll have to provide the `DataType`  

`Progrma.cs` :

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
             
            logger.Log<int>(10); 👈
            logger.Log<string>("Hello World!"); 👈

        }
    }
}
```

```console
10
Hello World!
```

- 🔑 Not that we still refering the same `Instance`/`Object` of the *Logger* .  
  Becaus now the `Generic Type` is only neededd inside of the *.Log<>* `Method` now .

🚀 ) We can even do this ↓ because C# is clever enough to Automatically recognize what `Type` we are **sending in** .  

`Progrma.cs` :

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            logger.Log(10); 👈
            logger.Log("Hello World!"); 👈

        }
    }
}
```

We can also passing an `Object` ↓

`Program.cs`

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            logger.Log(10);
            logger.Log("Hello World!");

            logger.Log(new { Name = "John", Age = 30 }); 👈
        }
    }
}
```

```cs
10
Hello World!
{ Name = John, Age = 30 } 👈
```

- 🔑 We're able also to see that **Entry** ( Simple C# `Object` ), Because our `Method` is `Generic` .