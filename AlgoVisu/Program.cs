using AlgoVisu;
using System.Linq;
using Raylib_cs;
using System.Globalization;

namespace HelloWorld;

class NumList
{
    public int[] shuffledArray;

    public NumList() {
        int[] values = new int[100];

        for (int i = 0; i < values.Length; i++)
        {
            values[i] = i + 1;
        }

        var rng = new Random();
        shuffledArray = values.OrderBy(e => rng.NextDouble()).ToArray();
    }
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

        // SETUP
        NumList numbers = new();
        selectionSort selectionSort = new selectionSort(numbers.shuffledArray);
        bubbleSort bubbleSort = new bubbleSort(numbers.shuffledArray);

        
        while (!Raylib.WindowShouldClose())
        {
            // SORTING
            selectionSort.Sort(numbers.shuffledArray);
        }
        Raylib.CloseWindow();
    }
}