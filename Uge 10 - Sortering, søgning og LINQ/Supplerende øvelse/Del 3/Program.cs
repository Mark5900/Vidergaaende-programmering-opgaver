using System.Diagnostics;

namespace Del3;

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

        int numberInsert = ReadInput("Enter the number to insert: ");
        bool inserted = Insert(numberInsert, array);
        if (inserted)
        {
            Console.WriteLine($"The number {numberInsert} was inserted in the array.");
            PrintArray();
        }
        else
        {
            Console.WriteLine($"The number {numberInsert} was not inserted in the array.");
        }
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

    static bool Insert(int number, int[] list)
    {
        if (list == null || list.Length == 0)
        {
            return false; // Returnerer false, hvis listen er null eller tom
        }

        int position = Array.BinarySearch(list, number);

        if (position < 0)
        {
            position = ~position; // Find indsættelsespositionen, hvis nummeret ikke findes i listen
        }

        // Flyt elementer til højre fra den fundne position
        for (int i = list.Length - 1; i > position; i--)
        {
            list[i] = list[i - 1];
        }

        list[position] = number; // Indsæt nummeret på den rette plads

        return true; // Returnerer true, da indsættelsen lykkedes
    }
}