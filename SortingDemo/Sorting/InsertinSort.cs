using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemo.Sorting
{
    internal class InsertinSort : SortBase
    {
        public override int[] Sort(int[] inputArray)
        {
            var length = inputArray.Length;

            for (int i = 0; i < length-1; i++)
            {
                // This is sorted Array.

                // Check if next element is less than that of last. Then put it in right place, using kinda bubble sort.
                if (inputArray[i] > inputArray[i + 1])
                {
                    for (int j = i+1; j > 0; j--)
                    {
                        // As previous array is sorted, only check till it's size is less. preveious elements are already sorted hence no need to check.
                        if (inputArray[j] >= inputArray[j - 1]) 
                            break;
                        //Swap.
                        else if (inputArray[j] < inputArray[j - 1])
                            Swap(inputArray, j, j - 1);
                    }
                }
            }

            return inputArray;
        }
    }
}
