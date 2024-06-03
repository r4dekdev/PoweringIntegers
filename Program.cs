﻿using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Give an integer: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Give a power of the integer: ");
            int y = int.Parse(Console.ReadLine());
            double powX = Math.Pow(x, y);

            Console.WriteLine($"Result: " + powX);
        }
    }
}