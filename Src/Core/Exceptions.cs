namespace Src.Core;

public class CustomException(string message) : Exception(message) {}

public class Exceptions
{
  public static void Run()
  {
    try
    {
      throw new CustomException("random exception message");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }
}