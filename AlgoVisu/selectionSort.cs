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
        private int windowWidth = 800;
        private int windowHeight = 480;
        private Rectangle[] recs = new Rectangle[100];


        public selectionSort(int[] shuffledArray)
        {
            arr = shuffledArray;
        }
        public void DrawTowers()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            int towerWidth = windowWidth / arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                float towerHeight = windowHeight * (100 - arr[i]) / 100;

                recs[i].Width = towerWidth;
                recs[i].Height = towerHeight;
                recs[i].X = towerWidth * i;
                recs[i].Y = 0;

                Raylib.DrawRectangle((int) recs[i].X, (int)recs[i].Y, (int)recs[i].Width, (int)recs[i].Height, Color.BLACK);


            }
            Raylib.EndDrawing();
        }
        public void Sort(int[] values)
        {
            for(int i = 0; i < values.Length; i++)
            {
                int currentMin = i;
                int currentMax;
                for (currentMax = i + 1; currentMax < values.Length; currentMax++)
                {
                    DrawTowers();
                    Thread.Sleep(1);



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
