using System.Diagnostics;

namespace Del1;

public class Program
{
    private static int[] array;

    public static void Main(string[] args)
    {
        int count = ReadInput("Enter the number of elements in the array: ");
        int min = ReadInput("Enter the minimum value of the array: ");
        int max = ReadInput("Enter the maximum value of the array: ");
        CreateArray(count, min, max);

        int number = ReadInput("Enter the number to count: ");
        int countNumber = CountNumbers(number);
        Console.WriteLine($"The number {number} appears {countNumber} times in the array.");
    }

    static void CreateArray(int Count, int Min, int Max)
    {
        array = new int[Count];
        var random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(Min, Max);
        }
    }

    static int ReadInput(string Text)
    {
        Console.Write(Text);
        return int.Parse(Console.ReadLine());
        Console.WriteLine();
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
}