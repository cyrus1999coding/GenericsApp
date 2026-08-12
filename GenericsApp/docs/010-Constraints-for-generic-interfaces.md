# 010 Constraints for generic interfaces

We'll tkae a look at `Constraints` for `Generic Interfaces` .

🧠 )

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

So ↓

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
    internal interface IEntity
    { 
        int Id { get; }
    }
    👆
    👇
    internal interface IRepository<T> 👉 where T : IEntity 👈
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

    internal class ProductRepository❌ : IRepository<Product> 
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
- ❌ : The type 'GenericsApp.Product' cannot be used as type parameter 'T' in the generic type or method 'IRepository<T>'. There is no implicit reference conversion from 'GenericsApp.Product' to 'GenericsApp.IEntity'.
- 💡 : Because this ↓  
  ```cs
    internal class Product 👈
    { 
        public int Id { get; set; }
        public string Name { get; set; }
    }
  ```
  Is not working in that way, It's not Implemnting the *IEntity* `Interface`

So let's fix that ↓  

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

    internal interface IEntity
    { 
        int Id { get; }
    }

    internal interface IRepository<T> where T : IEntity
    {
        void Add(T entity);
        void Remove(T entity);
    }

    internal class 👉 Product : IEntity 👈
    { 
        public int Id { get; set; } 👈
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
- 🔑🔑 So here we make sure that whatever `Class` we have for the the *entity* `Parameter` has the  
  *Id* `Property` .


👀 )

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

    internal interface IEntity
    {
        int Id { get; }
    }

    internal interface IRepository<T> where T : IEntity
    {
        void Add(T entity);
        void Remove(T entity);
    }

    internal class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    👇
    internal class User
    {
        public string Name { get; set; }
    }
    👆
    internal class ProductRepository : IRepository<Product>
    {
        public void Add(Product entity)
        {

        }
        public void Remove(Product entity)
        {

        }
    }
    👇
    internal class UserRepository❌ : IRepository<User>
    {
        public void Add(User entity)
        {

        }
        public void Remove(User entity)
        {

        }
    }
    👆
}
```
- ⛔ We can't make use of this *User* `Class` .
- ❌ : The type 'GenericsApp.User' cannot be used as type parameter 'T' in the generic type or method 'IRepository<T>'. There is no implicit reference conversion from 'GenericsApp.User' to 'GenericsApp.IEntity'.  
- 💡 Because we're not **Implementing** the *IEntity* `Interface` for the *User* `Class` .

🔑 That was the usecase of `Constraint` for `Generic Inteface` that's some more Advanced Stuff  
for example Connecting and saving entity to a Database we need an *Id* for example .