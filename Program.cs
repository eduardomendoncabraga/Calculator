﻿using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Primeio valor: ");
      float v1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      float resultado = v1 + v2;
      Console.WriteLine("");
      Console.WriteLine($"O resultado da soma é {resultado} ");
    }
  }
}
