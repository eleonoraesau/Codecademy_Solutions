using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "~!$%&?";
      int score = 0;

      Console.WriteLine("Enter your password: ");
      string password = Console.ReadLine();

      if (score >= minLength)
      {
        score++;
      }

      if (Tools.Contains(password, uppercase))
      {
        score++;
      }

      if (Tools.Contains(password, lowercase))
      {
        score++;
      }

      if (Tools.Contains(password, digits))
      {
        score++;
      }

      if (Tools.Contains(password, specialChars))
      {
        score++;
      }

      switch (score)
      {
        case 5:
          Console.WriteLine("extremely strong");
          break;
        case 4:
          Console.WriteLine("extremely strong");
          break;
        case 3:
          Console.WriteLine("strong");
          break;
        case 2:
          Console.WriteLine("medium");
          break;
        case 1:
          Console.WriteLine("weak");
          break;
        default:
          Console.WriteLine("password does not meet any standards");
          break;
      }
    }
  }
}
