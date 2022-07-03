// Namespace Declaration
using System;

// Program start class
class Name
{
    // Main begins program execution.
    static void Main()
    {
      // Write to console
      Console.WriteLine("Please enter your name:");
      // Read from console
      string name = Console.ReadLine();
      // writing the string and additional argument to console 
      Console.WriteLine("Hello, {0}", name);
      //keep program running till user clicks run
      Console.ReadLine();
    }
}
