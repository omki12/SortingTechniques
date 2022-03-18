using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemo.Sorting
{
    internal class QuickSort : SortBase
    {
        public override int[] Sort(int[] inputArray)
        {
            QuickSortR(inputArray,0,inputArray.Length-1);
            return inputArray;
        }

        private void QuickSortR(int [] array, int StartIndex, int EndIndex)
        {
            // Exit Condition.
            if (EndIndex-StartIndex <= 1)
            {
                if(array[EndIndex] < array[StartIndex])
                    Swap(array,StartIndex,EndIndex);
                return;
            }

            int pivot = EndIndex;
            int lowerElementThanPivotIndex = StartIndex - 1;

            for (int i = StartIndex; i <= EndIndex; i++)
            {
                if (array[i] < array[pivot] || i==pivot)
                {
                    lowerElementThanPivotIndex++;
                    if (lowerElementThanPivotIndex != i)
                        Swap(array, lowerElementThanPivotIndex, i);
                }
            }

            pivot = lowerElementThanPivotIndex;
            // will end up in infinte loop, if pivot is last element.
            if (pivot == EndIndex)
                pivot--;

            //QuickSortR on left array.
            QuickSortR(array, StartIndex, pivot);

            //QuickSortR on right array.
            QuickSortR(array, pivot+1, EndIndex);
        }
    }
}
