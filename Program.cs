using System;
using System.Collections.Generic;

namespace dictionary_of_words
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();
      wordsAndDefinitions.Add(
          "Awesome",
           "The feeling of students when they are learning C#"
           );
      wordsAndDefinitions.Add(
          "Apples",
          "Round objects that fall from trees and help people discover gravity"
          );

      foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
      {
        Console.WriteLine($"The definition of {word.Key} is {word.Value}");
      }
    }
  }
}
