using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoVisu
{
    internal class algos
    {
        public void bubble(int[] values)
        {
            bool swapped = true;
            int n = values.Length;

            // Repeat while values are being swapped
            // Sorts from smallest to biggest
            while (swapped){
                swapped = false;
                for (int i = 0; i < n -1; i++)
                {
                    if (values[i] > values[i + 1])
                    {
                        swapped = true;
                        int placeholder = values[i + 1];
                        values[i + 1] = values[i];
                        values[i] = placeholder;
                    }
                }
                n = n - 1;
            }
        }
        public void 
    }
}
