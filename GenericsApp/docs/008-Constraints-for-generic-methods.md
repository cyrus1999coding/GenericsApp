# 008 Constraints for generic methods

🧠 We already how to seu up a `Constraint` on a `Class` .  

Now let's see how we can set up a `Constraint` on a 🔑`Generic Method` inside of a Default C# `Class` .

So :


`Comparer.cs` :

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Comparer
    {
    }
}
```
- *GenericsApp* is  
  ✅ a usual C# `Class`  
  ⛔ It's not a `Generic`

`Comparer.cs` :

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Comparer
    {
        public static bool AreEqual<T>(T first, T second)
        {
            return first == second; ❌
        }

    }
}
```
- ❌ : Operator '==' cannot be applied to operands of type 'T' and 'T'  
- 🔑🛠💡 : We're trying to compare those 2 Elements but the problem is  
  That this `return first == second;` only works for 🔑`Reference Type`s  
  Therefore we have to set up a `Constranit` in our `Method` 

So :  

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Comparer
    {
        public static bool AreEqual<T>(T first, T second) 👉 where T : class 👈 ✅🛠
        {
            return first == second;
        }

    }
}
```
- 🔑🔑 `return first == second;`  
  This kinda of comparison only works in we have 🔑`Reference Type` .
- `public static bool AreEqual<T>(T first, T second) where T : class` :  
  With this we create a `Constraint` for our `Generic Method` jsut like we did for `Generic Classes` .

`Program.cs` :

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comparer.AreEqual(1, 1); ❌
            
            Console.ReadKey();
        }
    }


}
```
- ❌ : The type 'int' must be a reference type in order to use it as parameter 'T' in the generic type or method 'Comparer.AreEqual<T>(T, T)'  
- 💡 : This would work because `int` is not a 🔑`Reference Type` its a 🔑`Value Type`

🛠✅ ↓

`Program.cs` :

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productOne = new Product(); 👈
            var productTwo = new Product(); 👈

            Comparer.AreEqual(productOne, productTwo); ✅👈
            
            Console.ReadKey();
        }
    }

    public class Product() 
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
            var productOne = new Product();
            var productTwo = new Product();

            var result = Comparer.AreEqual(productOne, productTwo); 👈
            Console.WriteLine(result); 👈 
            
            Console.ReadKey();
        }
    }

    public class Product() 
    {
        
    }


}
```

```console
False
```