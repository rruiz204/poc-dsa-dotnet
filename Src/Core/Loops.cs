namespace Src.Core;

public class Loops
{
  public static void Run()
  {
    List<string> letters = ["a", "b", "c"];
    letters.ForEach(letter => Console.WriteLine(letter));
  }
}