using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace AlgoVisu
{
    internal class selectionSort
    {
        // Declare variables and instantiate the drawing class
        private int[] arr; // arr[] is the random numbers array
        private Rectangle[] recs; // recs[] stores positions of the different blocks
        Drawing draw = new Drawing();

        // Assigns values to arr and adds empty rectangles to recs[]
        public selectionSort(int[] shuffledArray)
        {
            arr = shuffledArray;
            recs = new Rectangle[arr.Length];
        }

        // Selection sort written from wikipedia's example
        public void Sort(int[] values)
        {
            for(int i = 0; i < values.Length; i++)
            {
                int currentMin = i;
                int currentMax;
                for (currentMax = i + 1; currentMax < values.Length; currentMax++)
                {
                    draw.DrawTowers(currentMin, currentMax, arr, recs); // Drawing function which updates every loop
                    if (values[currentMax] < values[currentMin])
                    {
                        recs[currentMin].X = recs[currentMax].X;
                        currentMin = currentMax;
                    }
                }
                if (currentMin != i)
                {
                    int temp = values[i];
                    values[i] = values[currentMin];
                    values[currentMin] = temp;
                }


            }
        }
    }
}
