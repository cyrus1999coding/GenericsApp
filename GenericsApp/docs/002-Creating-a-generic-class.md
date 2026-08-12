# 002 Creating a generic class

We'll create a new `.cs` file ↓

`Box.cs` :

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Box
    {
    }
}
```
- Doesn't matter if it is `public` or `internal`

1. Now we can specify a 🔑`Type Parameter` ↓

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Box<T> 👈
    {
    }
}
```

🔑 Think of a *Box* like a package, if we have a Box it could be closed and we don't know whats inside  
It could be a bbooks, fruits and basically anything .  
Let's think of that as 🔑`<T>` which typically stands for `Type` and that's a Naming Convention .

We can use that `<T>` in our Entire `Class`, by using that `<T>` we truned our c# `Class` to a 🔑`Generic Class`

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Box<T>
    {
        public T👈 Content { get; set; } 
    }
}

```

Now let's create a usual `Method` ↓

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Box<T>
    {
        public T Content { get; set; }

        👇
        public string Log()
        {
            return $"Box contains {Content}";
        }
        👆
    }
}
```

Now let's go to `Program.cs` to see how we can create an `Instance` of our `Generic Class`

`Program.cs` :

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> Box = new Box<int>(); 👈

            Console.ReadKey();
        }
    }
}
```

Now being the scenes at the **Compile Time** in the `Box.cs` this `T` ↓  

`Box.cs`

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Box<T👈>
    {
        public T👈 Content { get; set; }

        public string Log()
        {
            return $"Box contains {Content}";
        }
    }
}
```
- 🔑 Will get replaced for that specific `Instance` with the `int` for that **specific** `Instance` .

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            👇
            Box<int> box = new Box<int>();
            box.Content = 1;
            Console.WriteLine(box.Log());
            👆
            Console.ReadKey();
        }
    }
}
```
We can also create a Box again with `Custom` `DataType` (👀 Like a *Person*) or `string` `DataType` .

`Program.cs`:

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Content = 1;
            Console.WriteLine(box.Log());
            👇
            Box<string> boxStr = new Box<string>();
            boxStr.Content = "Hello World";
            Console.WriteLine(boxStr.Log());
            👆
            Console.ReadKey();
        }
    }
}
```

```consle
Box contains 1
Box contains Hello World
```

🔑 So both of those `Instances` (*box*, *boxStr*) share the same `Structure` (our *Box<T>* `Structure`) .  
But they both use the different `DataType`s .