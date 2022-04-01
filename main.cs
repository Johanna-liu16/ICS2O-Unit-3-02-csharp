// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function states user's address input.
        float length;
        float width;
        float height;

        Console.WriteLine("This program will calculate the volume of a pyramid.");
        Console.WriteLine("");
        Console.Write("Enter length: ");
        length = float.Parse(Console.ReadLine());
        Console.Write("Enter width: ");
        width = float.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        height = float.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("The volume is: " + ((length * width * height).ToString("0.00") + " mm³."));

        Console.WriteLine("\nDone.");
    }
}