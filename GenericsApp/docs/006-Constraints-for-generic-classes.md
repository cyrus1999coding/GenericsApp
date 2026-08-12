# 006 Constraints for generics classes

`Box.cs` :

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Box<T>
    {

    }
}
```

`Program.cs` :

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Box<int> boxInt = new Box<int>(); 👈
            Box<Book> bookBox = new Box<Book>(); 👈
            
            Console.ReadKey();
        }
    }

    public class Book
    {

    }
}
```
- `Box<int> boxInt = new Box<int>();` :  
  Here we got a 🔑`Value` `Type` .
- `Box<Book> bookBox = new Box<Book>();` :  
  Here we have a *Book* which is a `Class`, So we have an `Instance`/`Object` so it's 🔑`Reference` `Type` .

What if we want our *Box<>* `Generic Class` to avaiable for `Classes` for example ❔  
So in easier word we don't want the *Box<>* to be able to get Created with `int` `Type` or any `Value` `Type`  
In that case we can **Set Up** a 🔑`Constraint` .

💡 :

`Box.cs` :

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Box<T> 👉where T : class👈
    {
         
    }
}
```
- 🔑`internal class Box<T> where T : class` :  
  Now we can only create an Instance of our `Generic Class` *Box<>*  
  Where the 🔑`Generic Type` is a `Class` .

`Program.cs`

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Box<int> boxInt = new Box<int>(); ❌
            Box<Book> bookBox = new Box<Book>();
            
            Console.ReadKey();
        }
    }

    public class Book
    {

    }
}
```

- ❌ : The type 'int' must be a reference type in order to use it as parameter 'T' in the generic type or method 'Box<T>'
