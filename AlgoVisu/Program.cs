using AlgoVisu;
using System.Linq;
using Raylib_cs;
using System.Globalization;

namespace HelloWorld;

// Number array class
class NumList
{
    public int[] shuffledArray;

    // Constructor creates shuffled array ^^
    public NumList() {
        // Value in brackets is the array length
        int[] values = new int[100];

        // For loop to add cards from 1 to array length
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = i + 1;
        }

        // Shuffles the cards using Random
        var rng = new Random();
        shuffledArray = values.OrderBy(e => rng.NextDouble()).ToArray();
    }

    // Prints out the array's contents on different lines
    public void Print()
    {
        foreach (int value in shuffledArray)
        {
            Console.WriteLine(value);
        }
    }
}


class Program
{
    public static void Main()
    {
        
        // RAYLIB SETUP
        const int windowHeight = 480;
        const int windowWidth = 800;
        Raylib.InitWindow(windowWidth, windowHeight, "AlgoVisu");
        Raylib.SetTargetFPS(60);

        // INSTANTIATE CLASSES
        NumList numbers = new();
        selectionSort selectionSort = new selectionSort(numbers.shuffledArray);
        bubbleSort bubbleSort = new bubbleSort(numbers.shuffledArray);

        
        while (!Raylib.WindowShouldClose())
        {
            // SORTING
            // THIS CAN BE CHANGED TO selectionSort/bubbleSort
            selectionSort.Sort(numbers.shuffledArray);
        }
        Raylib.CloseWindow();
    }
}