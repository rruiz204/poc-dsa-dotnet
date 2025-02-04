namespace Src.Core;

public class Structures
{
  public static void Run()
  {
    List<int> numbers = [1, 2, 3, 4];
    numbers.ForEach(n => Console.WriteLine(n));

    Dictionary<string, int> fruits = new() {
      {"apple", 1000},
      {"banana", 9999},
      {"watermelon", 3333},
    };

    foreach (var fruit in fruits)
    {
      Console.WriteLine($"Fruit: {fruit.Key}, Price: {fruit.Value}");
    }

    HashSet<int> ids = [1, 2, 3, 2];
    foreach (var id in ids)
    {
      Console.WriteLine($"ID: {id}");
    }
  }
}