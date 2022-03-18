using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemo.Sorting
{
    internal class BubbleSortMinFirst : SortBase
    {
        public override int[] Sort(int[] inputArray)
        {
            int arrayLength = inputArray.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = arrayLength-1 ; j > i ; j--)
                {
                    if (inputArray[j] < inputArray[j - 1])
                        Swap(inputArray, j, j-1);
                }
            }
            return inputArray;
        }
    }
}
