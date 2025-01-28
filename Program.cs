using Src.Core;
using Src.Dsa;

Console.WriteLine("==== Fundamentals");
Lambdas.Run();
Variables.Run();
Exceptions.Run();
Structures.Run();

Console.WriteLine("==== Data Structures");
Stack example = new();
example.Push("A");
example.Push("B");
example.Push("C");

example.Peek();
example.Pop();
example.Peek();