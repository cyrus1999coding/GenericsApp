# 003 Using a generic class type in a method

`Box.cs` :

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Box<T>
    {
        private T _content; 👈
    }
}
```
- `private T _content;` :  
  Here we have a `private` `Field` of `Type` `T`  
  ⛔ : We cannot access the *_content* from outside
  ✅🛠 : We'll have to make use of `Method`s that can then add information to the *Box<T>*  
  Like Adding, Deleting and Getting information from that *Box<T>* 

So let's create a `Constructor` ↓

`Box.cs` :

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Box<T>
    {
        private T👈 _content;

        public Box(T👈 initialValue)
        {
            _content = initialValue;
        }
    }
}
```

Now let's create 3 `Method`s which also using the same `Type` inside of the `Parameter`s ↓

`Box.cs` :

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Box<T>
    {
        private T _content;

        public Box(T initialValue) 👈🔑 Generic Constructor 
        {
            _content = initialValue;

        }

        public void UpdateContent(T👈 newContent)
        {
            _content = newContent;
            Console.WriteLine($"Updated content to {_content}");
        }

        public T👈🔑 GetContent()
        { 
            return _content;
        }
    }
}
```

Lew let's go to the `Program.cs` ↓

`Program.cs` :

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<string> boxStr = new Box<string>("Hello World"); 👈🔑 Constructor needs initialValue
            boxStr.UpdateContent("Teaching c# is fun"); 👈
            Console.WriteLine(boxStr.GetContent()); 👈
        }
    }
}
```

```console
Updated content to Teaching c# is fun
Teaching c# is fun
```

Now we can create anoter *Box<>* of `Type` `int` and do the same .

📝 :  
So we can use the `T` that we defined in the `Class` **Declaration** in everywhere → `Fields`, `Constructor`, `Methods` and also 🔑 As the **return** `Type` of a `Method` .