namespace Src.Core;

public class Lambdas
{
  public static void Run()
  {
    List<int> numbers = [1, 2, 3, 4];
    Func<int, int> multiply = (number) => number * 2;

    var updated = numbers.Select(multiply).ToList();
    updated.ForEach(n => Console.WriteLine(n));
  }
}