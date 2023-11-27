using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoVisu
{
    internal class selectionSort
    {
        public void Sort(int[] values)
        {
            for(int i = 0; i < values.Length; i++)
            {
                int currentMin = i;
                int currentMax;
                for (currentMax = i + 1; currentMax < values.Length; currentMax++)
                {
                    if(values[currentMax] < values[currentMin])
                    {
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
