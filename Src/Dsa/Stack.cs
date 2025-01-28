namespace Src.Dsa;

public class Stack
{
  private readonly List<string> Letters = [];
  private bool IsEmpty() => Letters.Count == 0;

  public void Push(string letter) => Letters.Add(letter);

  public void Pop() {
    if (!IsEmpty()) Letters.RemoveAt(Letters.Count - 1);
  }

  public void Peek() {
    if (!IsEmpty()) Console.WriteLine(Letters[^1]);
  }
}