using AlgoVisu;
using System.Linq;
using Raylib_cs;

namespace HelloWorld;

class Program
{
    private static int[] genArray()
    {
        int[] values = new int[10000];
        
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = i;
        }

        var rng = new Random();
        var shuffledArray = values.OrderBy(e => rng.NextDouble()).ToArray();

        /*foreach (int i in shuffledArray)
        {
            Console.WriteLine(i);
        }*/

        return shuffledArray;
    }

    public static void Main()
    {
        algos sort = new algos();
        int[] values = genArray();
        sort.bubble(values);
       
        foreach (int i in values)
        {
            Console.WriteLine(i);
        }
    }
}





/*'
Raylib.InitWindow(800, 480, "Hello World");
while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);
    Raylib.DrawText("Hello, world!", 12, 12, 20, Color.BLACK);


    Raylib.EndDrawing();;
}

Raylib.CloseWindow();
*/