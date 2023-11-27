using AlgoVisu;
using System.Linq;
using Raylib_cs;
using System.Globalization;

namespace HelloWorld;

class NumList
{
    public int[] shuffledArray;

    public NumList() {
        int[] values = new int[10000];

        for (int i = 0; i < values.Length; i++)
        {
            values[i] = i;
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
        selectionSort selectionSort = new();
        numbers.Print();

        
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            Raylib.DrawText("Hello, world!", 12, 12, 20, Color.BLACK);

            // SORTING
            selectionSort.Sort(numbers.shuffledArray);
            Raylib.EndDrawing(); ;
        }
        Raylib.CloseWindow();
    }
}