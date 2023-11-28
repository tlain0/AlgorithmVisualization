using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoVisu
{
    internal class Drawing
    {

        private int windowWidth = 800;
        private int windowHeight = 480;
        public void DrawTowers(int currentMin, int currentMax, int[] arr, Rectangle[] recs)
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            float towerWidth = windowWidth / arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                float towerHeight = windowHeight * (1.00f - ((float)arr[i] / (float)arr.Length));
                recs[i].Width = towerWidth;
                recs[i].Height = towerHeight;
                recs[i].X = towerWidth * i;
                recs[i].Y = 0;

                Raylib.DrawRectangle((int)recs[i].X, (int)recs[i].Y, (int)recs[i].Width, (int)recs[i].Height, Color.BLACK);
                Raylib.DrawRectangle((int)recs[currentMin].X, (int)recs[currentMin].Height, (int)recs[currentMin].Width, 480, Color.RED);
                Raylib.DrawRectangle((int)recs[currentMax - 1].X, (int)recs[currentMax].Height, (int)recs[currentMax - 1].Width, 480, Color.GREEN);


            }
            Raylib.EndDrawing();
        }


    }
}
