using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemo.Sorting
{
    internal abstract class SortBase : ISort
    {
        public abstract int[] Sort(int[] inputArray);

        protected void Swap(int[] inputArray, int j, int v)
        {
            if (j == v) return;
            int temp = inputArray[j];
            inputArray[j] = inputArray[v];
            inputArray[v] = temp;
        }

    }
}
