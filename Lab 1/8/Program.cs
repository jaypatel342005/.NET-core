﻿// See https://aka.ms/new-console-template for more information

// Program to create a Simple Calculator for two numbers (Addition, Multiplication, Subtraction, Division)
// Using only switch case

Console.Write("Enter first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Choose operation:");
Console.WriteLine("1. Addition (+)");
Console.WriteLine("2. Subtraction (-)");
Console.WriteLine("3. Multiplication (*)");
Console.WriteLine("4. Division (/)");
Console.Write("Enter your choice (1-4): ");
string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.WriteLine($"Result: {num1 + num2}");
        break;
    case "2":
        Console.WriteLine($"Result: {num1 - num2}");
        break;
    case "3":
        Console.WriteLine($"Result: {num1 * num2}");
        break;
    case "4":
        if (num2 != 0)
            Console.WriteLine($"Result: {num1 / num2}");
        else
            Console.WriteLine("Error: Division by zero.");
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}
