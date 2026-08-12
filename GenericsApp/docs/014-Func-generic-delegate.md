# 014 Func generic delegate

```cs
using System.Reflection;

namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action action = () =>
            {
                Console.WriteLine("Hello World");
            };

            action();
        }
    }
}
```

## 🚩 Difference between Action and Func  

🔑🔑 `Func` `Returns` a `Value` 

🔑 `Action` is ↓  
> delegate 👉void👈 System.Action

Very often we don't want to Run an `Action` ↓  

👀 ) Le'ts Assume that we want to Upload something so we wuld want to have a function right ?  
That function would start Uploaing and as soon as it's done it would return a status code saying ok i'm done  with the Upload .  
Or for the sum for exmaple

```cs
using System.Reflection;

namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            👇
            Func<string> getName = () =>
            {
                return "Cyrus";
            };
            👆
        }
    }
}
```
- `Func👉<string>👈 getName = () =>` :  
  > delegate TResult System.Func< in T1, in T2, ..., in T16, out TResult>(T1 arg1, T2 arg2, ..., T16 arg16)
  > where T1:allows ref struct
  > where T2:allows ref struct
  > where T3:allows ref struct
  > where T4:allows ref struct
  > ...
  > where T16:allows ref struct
  > where TResult:allows ref struct
  > Encapsulates a method that has 16 parameters and returns a value of the type specified by the out TResult parameter .  
  > Returns: 
  > The return value of the method that this delegate encapsulates .

🔑 Basically it is like this `Method` ↓  

```cs
using System.Reflection;

namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            👇
            Func<string> getName = () =>
            {
                return "Cyrus";
            };
            👆
        }
        👇
        string GetName()
        {
            return "Cyrus";
        }
        👆
    }
}
```

Now we can ↓

```cs
using System.Reflection;

namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string> getName = () =>
            {
                return "Cyrus";
            };

            var myName = getName(); 👈
            Console.WriteLine(myName); 👈
        }


    }
}
```

```console
Cyrus 👈
```

👀 ) Let's Assume that we want to create a sum function that sums 2 numbers and then provides back   
a value .
- 🔑 This means that we have `3 Parameters` ↓  
  Input a  
  Input b  
  Then we need to provide the information of what kind of Return Value do we want to provide .

```cs
using System.Reflection;

namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            👇
            Func<int, int, int> sum = (x, y) =>
            {
                return x + y;
            };
            👆
        }


    }
}
```


```cs
using System.Reflection;

namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, string👈> sum = (x, y) =>
            {
                return "Your result is: " + (x + y).ToString();👈
            };
        }


    }
}
```

📝 :  
This is basically how we can create a 🔑`Func` .  