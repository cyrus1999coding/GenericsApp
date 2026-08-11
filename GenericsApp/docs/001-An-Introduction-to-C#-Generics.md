# 001 An Introduction to C# Generics

We using 🔑`Generics` to build 🔑`Generic Functiionalities`

We can create :

- `Generics` `Classes`
- `Generics` `Methods`
- `Generics` `Interfaces`
- `Generics` `delegates`

👀 ) `List<>`
inisde the 🔑`<>` we can specify a `Type`

```cs
List<int> numbers = new List<int>();
```

```cs
List<string> names = new List<string>();
```

```cs
List<Product> products = new List<Product>();
```

🧠 Mybe we've seen already, If we want to use a `List` or `Dictionary` we have to **Implement** a specific **namespace** ↓  
`System.Collections.Generic` 

```cs 
Dictionary<TKey, TValue>.Enumerator
Dictionary<TKey, TValue>.KeyCollection.Enumerator
Dictionary<TKey, TValue>.ValueCollection.Enumerator
HashSet<T>.Enumerator
KeyValuePair<TKey, TValue>
LinkedList<T>.Enumerator
List<T>.Enumerator
```

There are some more 

## Why we would create our Generic Types ❔

💡 :  
Just like a `List` we don't want to create the whole functionality for each single `DataType`  
Instead we want to **Share Functionality** across Multiple `DataType`s .

```cs
List<Product> products = new List<Product>();

products.Add(...);
products.Find(...);
products.Remove(...);
```
- 🚀 If we create a `List` no matter of what `DataType` we have *.Add*, *.Find* and *.Remove*  
  No matter what `DataType` we specify .

if we would get deeper to the **Implementation** of the *List<>* we would fine ↓  

```cs
public class List<T>
{

}
```

If we would create our own functionality  
```cs
public class Logger<T>👈
{

}
```
- Now we can create `Logger<int>`, `Logger<Person>`, `Logger<string>`

We can also create `Generics` `Methods` for example ↓

👀 )

```cs
public void Log<T👈>(T👈 objectToLog)
{
	Console.WriteLine(objectToLog.ToString());
}
```

📝 :  

- We can create `Generic` `Classes`, `Structs`, `Interfaces`, `Methods` and `Delegates` .
- Share functionality across multiple `DataTypes` .
- Reduce duplication and improve maintainability .
- Used by Advanced Code Design Patterns ( e.g Repository Desugn Pattern )

⚠ Biggest Pitfall :
Over-Architecting the code when a simpler solution would have the job too .

🚀 Biggest Upsides :  
Unlocking next-level C# Code, The ability to work on well-designed software, And Creating our own `Frameworks` .

