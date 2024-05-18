# C# 

## Basics

### Basic structure
```csharp
using System; // 'using' allows for easier access to types in a namespace. namespace YourNamespace
// Namespaces organize code and prevent
naming collisions.
{
  class YourClass // A 'class' defines the blueprint of objects.
  {
    static void Main(string[] args) // 'Main' is where the program
    starts execution.
    {
      Console.WriteLine("Hello, World!"); // Displays text in the console.
    }
  }
}
 ```

### Data Types
Every variable and constant in C# has a type, determining the values it can hold and operations that can be performed on it.
- Reference Types: Store a memory address. They point to the address of the value
  - string, class, array are commlonly used.
- Value Types:Directly store the data. Once you assign a value, it holds that data.
  - int,char,float are just a few examples.

### Variables
```csharp
int num = 5; // Declares an integer variable and assigns it the value 5.
string word = "Hello"; // Declares a string variable and assigns it the value "Hello".
// We can use var because the compiler knows that "..." is a string
var name = "Peter";
// We can use var because we state that we create a new object of type Person.
var person = new Person();
```
The var keyword helps us keep the code short and improves readability

### Constants
Constants are immutable. Once their value is set cannot be cahnged.
```csharp
const int ConstNum = 5; //The value of ConstNum always be 5.
```
**Hint:** Constants follow Pascal Case.
### Conditional Statements
```csharp
if (condition) { /*...*/ } // Executes if 'condition' is true.
else if (condition) { /*...*/ } // Additional conditions if the above ones fail.
else { /*...*/ } // Executes if no conditions are met

switch (variable) // Useful when comparing a single variable to many values.
{
  case value1:
    // Code for value1
    break; // Exits the switch statement.
    // ... other cases ...
    default:
    // Executes if no other case matches.
    break;
}
```
### Loops
```csharp
for (int i = 0; i < 10; i++) { /*...*/ } // Loops 10 times, incrementing 'i' each time.
foreach (var item in collection) { /*...*/ } // Loops over each item in 'collection'.
while (condition) { /*...*/ } // Continues looping as long as 'condition' remains true.
do { /*...*/ } while (condition); // Executes once before checking 'condition'
```
### Methods
```csharp
public returnType MethodName(parameters) { /*...*/ } // A method's signature.
// A Sum method returning int with two int parameters.
public int Sum(int a, int b)
{
  return a + b;
}
```

## Classes
```csharp
public class MyClass
{
  public string PropertyName { get; set; } // Properties store data for an object.
  public void MethodName() { /*...*/ } // Methods define actions an object can take.
}
MyClass obj = new MyClass(); // Creates a new object of type 'MyClass'.
```
**Hint:**Auto-properties (as used in the example above), tell the compiler to create a
backing field. We do not have to create the backing field and fill it within the Set method
or get the value within the Get method. However, we can still implement custom logic when required
### Extension Methods
Add new methods to existing types without altering them.
```csharp
public static class StringExtensions
{
  public static bool IsNullOrEmpty(this string str)
  {
    return string.IsNullOrEmpty(str);
  }
}
```
### Partial Classes
Allows the splitting of a single class definition over multiple files or sections in the samefile
```csharp
public partial class MyClass
{
  public void MethodOne() { /*...*/ }
}
public partial class MyClass
{
  public void MethodTwo() { /*...*/ }
}
```

## Anonymous Types
## Exception Handling
A mechanism to handle runtime errors gracefully, ensuring the program continues or fails gracefully
```csharp
try
{
  // Code that might throw an exception.
}
catch (SpecificException ex) // Catches specific exceptions, allowing tailored responses.
{
  // Handle this specific error.
}
finally
{
  // Cleanup code. Executes regardless of whether an exception was thrown.
}
```
**Hint:**It’s best practice to catch an exception with a specific type (e.g. SqlException) and
have a single general fallback try-catch to catch exceptions of type Exception

## Structs

## Interfaces

## Arrays
Fixed-size collections that hold elements of the same type.
```csharp
int[] numbers = new int[5] {1, 2, 3, 4, 5}; // Declares an array of integers
```
## String
```csharp
string.Concat(); // Combines multiple strings.
string.Join(); // Joins elements with a separator.
str.Split(); // Splits a string based on delimiters.
str.ToUpper(); // Converts to uppercase.
str.ToLower(); // Converts to lowercase.
str.Trim(); // Removes leading and trailing whitespace.
str.Substring(); // Extracts a portion of the string
```
## Properties

## Generic Types
Generics allow for type-safe data structures without compromising type integrity or performance
```csharp
public class MyGenericClass<T> // 'T' is a placeholder for anytype.
{
  private T item;
  public void UpdateItem(T newItem)
  {
    item = newItem;
  }
}
```

## Indexers, Enumerators, and Iterators

## Strings

## Enumerations

## Attributes
Add metadata to your code. This metadata can be inspected at runtime.
```csharp
[Obsolete("This method is deprecated.")] // An attribute warning developers about deprecated methods.
public void OldMethod() { /*...*/ }
```
## Attributes & Reflection
Attributes provide metadata about program entities, while reflection allows introspection into types at runtime
```csharp
[MyCustomAttribute] // Custom attribute applied to a class.
public class MyClass
{
  //...
}
// Using reflection to get the attribute:
Attribute[] attrs = Attribute.GetCustomAttributes(typeof(MyClass));
```

## Delegates, Anonymous Methods, and Lambdas
Essential for event-driven programming and for treating methods as first-class citizens
```csharp
// A type that represents methods with a specific signature.
public delegate void MyDelegate();
// An event that can be triggered when certain actions occur.
event MyDelegate MyEvent;
Func<int, int, int> add = (a, b) => a + b; // Lambda expression. A concise way to define methods
```

## Events

## Dynamic Typing

## User-Defined Conversions

## Operator Overloading



## Nullable Types

## Linq 
Introduces native query capabilities into C#, making data manipulation simpler and more readable
```csharp
using System.Linq; // Required for LINQ queries.
var result = from s in list where s.Contains("test") select s; // Sample query to filter data.
```

## Collection
### Lists
Like arrays, but can dynamically change in size.
```csharp
using System.Collections.Generic; // Required namespace for Lists.
List<int> list = new List<int>() {1, 2, 3, 4, 5}; // Initializes a List with 5 integers.
list.Add(6); // Add the number 6 to the list
list.Remove(2) // Remove the element at index 2 (0-based) from the list.
```
### Dictionaries
Associative containers that store key-value pairs
```csharp
using System.Collections.Generic;
Dictionary<string, int> dict = new Dictionary<string, int>()
{
  {"one", 1}, // "one" is the key, 1 is its associated value.
  {"two", 2}
};
dict.Add("key", "value"); // Add a new item to the dictionary.
dict["key"] // Access the value of the dictionary at the key 'key'
```


## Threading

## Asynchronous and Parallel Programming
Modern mechanism for writing non-blocking (asynchronous) code, especially useful for I/O-bound operations.
```csharp
public async Task<returnType> MethodName()
{
  return await OtherAsyncMethod(); // 'await' pauses method execution until the awaited task completes.
}
```

## Dependency Injection
A software design pattern that facilitates loosely coupled code, improving maintainability and testability
```csharp
public interface IService
{
  void DoSomething();
}
public class MyService : IService
{
  public void DoSomething()
  {
  // Implementation here
  }
}
public class Consumer
{
  private readonly IService _service;
  public Consumer(IService service)
  {
    _service = service; // Dependency injection through constructor
  }
}
//Register services to the internal dependency injection container in the Program.cs file
builder.Services.AddScoped<IService, MyService>();
```
## Interoperability
C# allows interoperability with other languages, particularly with legacy Win32API functions
```csharp
using System.Runtime.InteropServices; // Required for DllImport.
[DllImport("user32.dll")]
public static extern int MessageBox(IntPtr h, string m, string c, int type);
```
## Anonymous Types
Allows creation of unnamed types with automatic property definition.
```csharp
var anon = new { Name = "John", Age = 25 }; // The type of 'anon' is inferred at compile time
```
## Pattern Matching
```csharp
object obj = "hello";
if (obj is string str)
{
  Console.WriteLine(str); // str is "hello"
}
```
## Local Functions
Functions can be defined within methods, allowing for encapsulation of logic without polluting class or namespace scopes.
```csharp
public void MyMethod()
{
  void LocalFunction()
  {
    // Implementation
  }
LocalFunction(); // Calling the local function
}
```
## Records
## Tuples
Tuples are data structures that have a specific number and sequence of elements
```csharp
var person = Tuple.Create("John", 25); // Creates a tuple with two items.
```
## with Expressions
## using Declaration
## Nullable Reference Type
## Nullables
C# allows value types to be set to null using nullable types.
```csharp
int? nullableInt = null; // '?' makes the int nullable.
bool hasValue = nullableInt.HasValue; // Checks if nullable type has a value
```
## Pattern-Based Using
## Property Patterns
## Default Interface Implementations
## Dynamic Binding
## File I/O
Interactions with the filesystem are common tasks. C# makes reading from and writing to files straightforward.
```csharp
using System.IO; // Necessary for most File I/O operations.
File.ReadAllText(path); // Reads the entire content of a file into a string.
File.WriteAllText(path, content); // Writes a string to a file,creating or overwriting it.
File.Exists(path); // Checks if a file exists at the specifiedpath
```
## Date & Time
```csharp
DateTime current = DateTime.Now; // Gets the current date and time.
current.AddDays(1); // Adds a day to the current date.
current.ToShortDateString(); // Converts the date to a short date string format.
```



