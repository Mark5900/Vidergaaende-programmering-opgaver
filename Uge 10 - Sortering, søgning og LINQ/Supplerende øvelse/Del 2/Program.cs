﻿using System.Diagnostics;

namespace Del2;

public class Program
{
    private static int[] array;

    public static void Main(string[] args)
    {
        int count = ReadInput("Enter the number of elements in the array: ");
        int min = ReadInput("Enter the minimum value of the array: ");
        int max = ReadInput("Enter the maximum value of the array: ");
        CreateArray(count, min, max);
        PrintArray();

        Console.WriteLine();

        int number = ReadInput("Enter the number to count: ");
        int countNumber = CountNumbers(number);
        Console.WriteLine($"The number {number} appears {countNumber} times in the array.");
    }

    static void CreateArray(int Count, int Min, int Max)
    {
        int[] arrayTemp = new int[Count];
        var random = new Random();
        for (int i = 0; i < arrayTemp.Length; i++)
        {
            arrayTemp[i] = random.Next(Min, Max);
        }

        // Sort arrayTemp
        Array.Sort(arrayTemp);
        array = arrayTemp;
    }

    static int ReadInput(string Text)
    {
        Console.Write(Text);
        return int.Parse(Console.ReadLine());     
    }

    static int CountNumbers(int Number)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == Number)
            {
                count++;
            }
        }
        return count;
    }

    static void PrintArray()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}