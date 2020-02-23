using System;

class DoubleIt
{
  static void Main()
  {
    //program logic will go here
    Console.WriteLine("Give me a number and I will double it for you!");
    string stringNumber = Console.ReadLine();
    int yourNumber = int.Parse(stringNumber);
    int yourDoubledNumber = yourNumber * 2;
    string stringDoubledNumber = yourDoubledNumber.ToString();
    Console.WriteLine("I doubled your number for you: " + yourDoubledNumber);
  }
}

// string stringNumber = Console.ReadLine(); is gathering the user's input in the correct data type, which is string. We call this variable stringNumber.

// int yourNumber = int.Parse(stringNumber); defines the yourNumber variable as the result of transforming stringNumber from a string into an int and uses the built-in int.Parse() method.

// string stringDoubledNumber = yourDoubledNumber.ToString(); takes the result of multiplying our int by two and turns it back into a string using the toString() method. This way, it can be concatenated with the rest of our statement and printed to the console.


