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
        private int[] arr;
        private Rectangle[] recs;
        Drawing draw = new Drawing();

        public selectionSort(int[] shuffledArray)
        {
            arr = shuffledArray;
            recs = new Rectangle[arr.Length];
        }
        public void Sort(int[] values)
        {
            for(int i = 0; i < values.Length; i++)
            {
                int currentMin = i;
                int currentMax;
                for (currentMax = i + 1; currentMax < values.Length; currentMax++)
                {
                    draw.DrawTowers(currentMin, currentMax, arr, recs);
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
