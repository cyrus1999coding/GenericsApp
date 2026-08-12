# 011 Combing generic classes and generic interfaces

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
        public void Add(Product entity)
        {

        }
        public void Remove(Product entity)
        {

        }
    }
}
```

Let's just Assume that our `Design Guidelines` say that we have to make sure that our  
Say that we have to make sure that our Repository → *ProductRepository* `Class`  
is `Generic` too .  
- Because it doesn't matter if we have a Product .
- If we have a *UserRepository* .
- 🔑 The Repository always behaves the same,  
  It tkaes and loads Data and saves it no matter what *enity* we're talking about .
  In that way having it like this ↓  
  ```cs
    internal class ProductRepository : IRepository<Product> ⛔
    {
        public void Add(Product entity)
        {

        }
        public void Remove(Product entity)
        {

        }
    }
  ```
  - ⛔ : Bad practice because we would have to duplicate the `Class` and duplicate all Code Inside

🚀✅ Better Practice is to say that this `Class` ↓  

```cs
    internal class ProductRepository👈 : IRepository<Product>
    {
        public void Add(Product entity)
        {

        }
        public void Remove(Product entity)
        {

        }
    }
```

- Is a *Repository* and also a `Generic` one 

```cs
    internal class 🚀👉Repository<T>👈 : IRepository<Product>
    {
        public void Add(T👈 entity)
        {

        }
        public void Remove(T👈 entity)
        {

        }
    }
```
- 🚀 Now it doesn't matter what we submit here 

```cs
    internal class Repository<T> : IRepository<T👈>
    {
        public void Add(T entity)
        {

        }
        public void Remove(T entity)
        {

        }
    }
```

So now ↓  

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
    👇🚀
    internal interface IRepository<T> 
    {
        void Add(T entity);
        void Remove(T entity);
    }
    👆
    internal class Product 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    👇🚀
    internal class Repository<T> : IRepository<T>
    {
        public void Add(T entity)
        {

        }
        public void Remove(T entity)
        {

        }
    }
    👆
}
```

- Now we have made use of a `Generic Interface` *IRepository<T>*  .
- And our `Class` *Repository<T>*  itself is also a `Generic` .

👀 ) We could also say 

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

    internal class Repository<T> : IRepository<T>
    {
        public void Add(T entity)
        {
            👇🔑
            if (entity.GetType() == typeof(Product))
            { 
                
            }
            👆🔑
        }
        public void Remove(PrToduct entity)
        {

        }
    }
}
```

And this is bering it together the `Genric Class` and `Generic Interface` .

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

    internal class Repository<T> : IRepository<T>
    {
        public void Add(T entity)
        {
            if (entity.GetType() == typeof(Product))
            {

            }
        }

        public void Remove(T entity)
        {

        }
    }
}
```