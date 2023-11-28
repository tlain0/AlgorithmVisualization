using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace AlgoVisu
{
    internal class bubbleSort
    {
        private int[] arr;
        private Rectangle[] recs;
        Drawing draw = new Drawing();


        public bubbleSort(int[] shuffledArray)
        {
            arr = shuffledArray;
            recs = new Rectangle[arr.Length];
        }


        public void Sort(int[] values)
        {
            bool swapped = true;
            int n = values.Length;

            // Repeat while values are being swapped
            // Sorts from left to right
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {

                    if (values[i] > values[i + 1])
                    {
                        swapped = true;
                        int placeholder = values[i + 1];
                        //draw.DrawTowers( arr, recs);
                        values[i + 1] = values[i];
                        values[i] = placeholder;
                    }
                }
                n = n - 1;
            }
        }
    }
}
