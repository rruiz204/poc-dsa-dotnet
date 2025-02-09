namespace Src.Dsa;

public class Node(int value)
{
  public int Value { get; set; } = value;
  public Node? Next { get; set; } = null;
}


public class Linked
{
  public Node? Head { get; set; } = null;

  public void Add(int value)
  {
    Node newNode = new(value);
    if (Head == null)
    {
      Head = newNode;
    }
    else
    {
      Node current = Head;
      while (current.Next != null)
      {
        current = current.Next;
      }
      current.Next = newNode;
    }
  }

  public void Remove(int value)
  {
    if (Head == null) return;

    if (Head.Value == value)
    {
      Head = Head.Next;
    }

    Node? current = Head;
    while (current?.Next != null && current.Next.Value != value)
    {
      current = current.Next;
    }

    if (current?.Next != null)
    {
      current.Next = current.Next.Next;
    }
  }

  public void Display()
  {
    Node? current = Head;

    while (current != null)
    {
      Console.WriteLine($"{current.Value} ->");
      current = current.Next;
    }

    Console.WriteLine("null");
  }
}