# 007 Custom interface constraint

Real-Word example, This is something that we would face when using 🔑`Entity Framework` we'll find similar  
Structure .  

🔑🔑`Repository` :  
Is where we can store things inside like the  
👀 : Github **Repository** inisde of a Github Repository we can find the Source Code  
👀 : Inside of a **Repository** we may find `Data Storage` for a *Database* or whatever


`Repository.cs` :

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Repository<T> 👈
    {
    }
}
```

However we always want to make sure that in our application whatever we save to that *Repository* has  
an *Id* so the *Id* is mandatory, So let's create an `Interface` .

`Repository.cs` :

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{   
    👇
    internal interface IEntity
    { 
        int Id { get; } 👈
    }
    👆
    internal class Repository<T>
    {
    }
}
```
In this *IEntity* `Interface` we specidy that whatever **Implements** it should have an *Id* `Property` .

Now we can use that `Interface` inside of our `Generic Class` *Repository<T>* Declaration   

`Repository.cs` :

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal interface IEntity
    { 
        int Id { get; }
    }

    internal class Repository<T> 👉 where T : IEntity 👈
    { 
    }
}
```

- 🔑 Whatever `Type` we submit here for our `Generic Class` *Repository<T>* that `Type`  
  Has to **Implement** the `Interface` .  
  That's already is a 🔑`Constraint`

`Repository.cs` :

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal interface IEntity
    { 
        int Id { get; }
    }

    internal class Repository<T> where T : IEntity
    {
        👇
        private List<T> _values = new List<T>();

        public void Add(T entity)
        {
            _values.Add(entity);
        }
        👆

    }
}
```

Now the crutial part is the `Instance` of the *Repository<T>* `Generic Class`,  
Let's say we wanna store *Products* inside of our *Reposity<T>* ↓

`Program.cs` :

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

    public class Product 👉 : IEntity 👈
    {

    }
}
```
- `public class Product : IEntity` :  
  🔑🔑 We need to make sure that our *Product* **Implement**s the *IEntity* `Interface`  
 
`Program.cs` :

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Repository<Product> repository = new Repository<Product>(); 👈
            var product = new Product(); 👈
            
            Console.ReadKey();
        }
    }

    public class Product : IEntity
    {
        public int Id { get; } 👈
    }
}
```
- 🔑🔑 Remember that the *Id* `Peoperty` only has the 🔑`Get Accessor`  
  Assume that any kind of Framework will set the *Id* for us or we'll write any Internal Logic in  
  The we'll Assign the *Id* .  
  🔑⛔ : In the end we never should Manually **Set** an *Id* .
  🔑✅ : We should've any Logic for that .

Now we can take our *repository* and add this *product* to it ↓

`Program.cs` :

```cs
namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Repository<Product> repository = new Repository<Product>();
            var product = new Product();
            repository.Add(product); 👈✅
            
            Console.ReadKey();
        }
    }

    public class Product : IEntity ✅
    {
        public int Id { get; }
    }
}
```