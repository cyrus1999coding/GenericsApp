# 009 Generic interfaces

More Advanced C# `Generic` Topics, Which is `Generic interfaces`

🧠🔑 In earlier lessions we have used `Generic Classes` which **Implement**s  
`Default Interfaces` .  
🚀 : This time we will use `Default Class` which **Impelement**s a `Generic Interface` .  

`Program.cs`

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
    👇
    internal interface IRepository<T> 
    {
        void Add(T entity); 👈
    }  
    👆
}
```
- `void Add(T entity);` :  
  🔑 We don't wanna make it to specific let's say we would like to Create a `ProductRepository` in the end .  
  But since this *IRepository<T> * `Generic Interface` that we'll use in that `Class` is  
  we don't waana call the Parameter here a product right ?  ↓  
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
        👇
        internal interface IRepository<T> 
        {
            void Add(T product⛔); 👈
        }  
        👆
    }
  ```
  - 🔑 Because it's `Generic`  
    ⛔ We don't what to be too specific if it's not Mandatory .
    ⛔ If it's not needed for our application .

- 🔑🔑 Most of the time 🔑`entity` is the word but `Instance` can also be the word .  
  Because 🔑`entity` is pretty `Generic` right ?

So :

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

    internal interface IRepository<T> 
    {
        void Add(T entity); 👈
        void Remove(T entity); 👈
    }    
}
```

So let's create a *ProductRepository* ↓

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

    internal interface IRepository<T> 
    {
        void Add(T entity);
        void Remove(T entity);
    }
    👇
    internal class Product
    { 
        public int Id { get; set; }
        public string Name { get; set; }
    }
    👆
    👇
    internal class ProductRepository : IRepository<Product> ❌
    { 
    }
    👆
}
```
- This time :  
  ⛔ We are not saying our *ProductRepository* `Class` is `Generic` .  
  ✅ Instead the `Generic` part is specified in the `Interface` *IRepository<T>* .
- ❌ : 'ProductRepository' does not implement interface member 'IRepository<Product>.Add(Product)'

So ↓

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

    internal interface IRepository<T> 
    {
        void Add(T entity);
        void Remove(T entity);
    }

    internal class Product
    { 
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class ProductRepository : IRepository<Product> 
    {
        👇
        public void Add(Product entity)
        {

        }
        public void Remove(Product entity)
        {

        }
        👆
    }
}
```

## Why would we choose a Generic Interface over a Generic Class ❔    

If we want to have 🔑`Flexible Contract` across Multiple `Classes`  
It's more about **Code Design** not the **Functionality** in the first place .  
Usually when we create Real-Word sofware we would have a 🔑`Design Pattern` and one very commonly used 🔑`Design Pattern`  
Is the 🔑`Repository Pattern` which is basically what we did 🚀✅ .
We can take it even furture so let's move tot he next lesson .