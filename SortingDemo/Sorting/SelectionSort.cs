using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemo.Sorting
{
    // Two array. First is sorted, another is unsorted.
    // Increase size of sorted, and reduce of unsorted.
    // SELECT the smallest number from unsorted array, and append at the end of the sorted array.
    // as we will be finding smallest fist
    internal class SelectionSort : ISort
    {
        public int[] Sort(int[] inputArray)
        {
            int length = inputArray.Length;
            for (int i = 0; i < length-1; i++)
            {
                // Sorted array
                int smallestNumberIndex = i ;
                for (int j = i+1; j < length; j++)
                {
                    // Unsorted Array.
                    
                    // Find the smallest.
                    int current = inputArray[j];
                    if (current < inputArray[smallestNumberIndex])
                        smallestNumberIndex = j;
                }
                if(smallestNumberIndex != i )
                    Swap(inputArray, i, smallestNumberIndex);
            }

            return inputArray;
        }


        private void Swap(int[] inputArray, int j, int v)
        {
            int temp = inputArray[j];
            inputArray[j] = inputArray[v];
            inputArray[v] = temp;
        }
    }
}
