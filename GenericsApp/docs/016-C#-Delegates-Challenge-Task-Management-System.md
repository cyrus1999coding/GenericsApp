# 016 C# Delegates Challenge Task Management System

# C# Delegates Challenge — Task Management System

## Question 1 — Challenge

Build a task management system that can handle different types of tasks, such as sending emails and generating reports, using **generic interfaces and classes**.

The goal is to practice writing generic code and using generic constraints.

---

## Question 2 — Step 1: Create the `ITask` Interface

Define a generic interface named `ITask`.

Add one method named `Perform` that returns a type `T`.

```csharp
internal interface ITask<T>
{
    T Perform();
}
```

This interface serves as the base for all tasks in the system, allowing different implementations to return different types of results.

---

## Question 3 — Step 2: Create the `EmailTask` Class

Implement the `ITask<string>` interface in a class called `EmailTask`.

Include properties for:

* `Recipient`
* `Message`

Implement the `Perform` method to simulate sending an email and return a confirmation message using the `Recipient` and `Message` properties.

```csharp
internal class EmailTask : ITask<string>
{
    public string Recipient { get; set; }
    public string Message { get; set; }

    public string Perform()
    {
        return $"Email sent to {Recipient}: {Message}";
    }
}
```

---

## Question 4 — Step 3: Create the `ReportTask` Class

Implement the `ITask<string>` interface in a class called `ReportTask`.

Include a property for:

* `ReportName`

Implement the `Perform` method to simulate generating a report and return a string status message.

```csharp
internal class ReportTask : ITask<string>
{
    public string ReportName { get; set; }

    public string Perform()
    {
        return $"Report generated: {ReportName}";
    }
}
```

---

## Question 5 — Step 4: Define the `TaskProcessor` Class

Create a generic class named `TaskProcessor` with two type parameters:

* `TTask`
* `TResult`

Add a constraint to `TTask` so that it must implement `ITask<TResult>`.

Include:

* A constructor that accepts a `TTask`
* An `Execute` method that calls `Perform` and returns the result

```csharp
internal class TaskProcessor<TTask, TResult>
    where TTask : ITask<TResult>
{
    private TTask task;

    public TaskProcessor(TTask task)
    {
        this.task = task;
    }

    public TResult Execute()
    {
        return task.Perform();
    }
}
```

The generic constraint ensures that only tasks implementing the correct `ITask<TResult>` interface can be used with the processor.

---

## Question 6 — Step 5: Write the `Main` Method

In the main program:

1. Create an instance of `EmailTask`.
2. Create an instance of `ReportTask`.
3. Create a `TaskProcessor` for each task.
4. Execute each task.
5. Output the results to the console.

```csharp
static void Main(string[] args)
{
    EmailTask emailTask = new EmailTask
    {
        Recipient = "test@example.com",
        Message = "Hello!"
    };

    ReportTask reportTask = new ReportTask
    {
        ReportName = "Sales Report"
    };

    TaskProcessor<EmailTask, string> emailProcessor =
        new TaskProcessor<EmailTask, string>(emailTask);

    TaskProcessor<ReportTask, string> reportProcessor =
        new TaskProcessor<ReportTask, string>(reportTask);

    Console.WriteLine(emailProcessor.Execute());
    Console.WriteLine(reportProcessor.Execute());

    Console.ReadKey();
}
```

---

```console
Email sent to example@example.com with message Hello, this is a test email.
Report Annual Report generated succesfully
```

## Question 7 — Completed

Congratulations! You have completed the C# generics challenge.

The challenge demonstrates:

* Generic interfaces
* Generic classes
* Generic type parameters
* Generic constraints
* Interfaces
* Polymorphism
* Type safety
* Executing different task types through the same generic processor
