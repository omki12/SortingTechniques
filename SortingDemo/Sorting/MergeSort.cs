using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemo.Sorting
{
    internal class MergeSort : SortBase
    {
        public override int[] Sort(int[] inputArray)
        {
            return MergeSortR(inputArray);
        }

        private int[] MergeSortR (int[] array)
        {
            if (array.Length <= 1) 
                return array;

            int FullLength = array.Length;
            int Middle = array.Length / 2;
            
            var LeftArray = array.Slice(0, Middle);
            var RightArray = array.Slice(Middle, FullLength-Middle);

            LeftArray = MergeSortR(LeftArray);
            RightArray  = MergeSortR(RightArray);
            
            var sortedMergedArray = Merge(LeftArray, RightArray);
            
            return sortedMergedArray;
        }

        private int[] Merge(int[] leftArray, int[] rightArray)
        {
            var NewArray = new int[leftArray.Length + rightArray.Length];
            int iNewArray = 0;
            var LLength = leftArray.Length;
            var RLength = rightArray.Length;

            int RHead = 0;

            // IF Left array = 0,1 and Right array is 2,3            
            if (leftArray[LLength - 1] <= rightArray[0])
            {
                StraightUpMerge(leftArray, rightArray, NewArray, ref iNewArray);
            }
            
            // IF Left array = 4,5 and Right array is 2,3
            else if (rightArray[RLength - 1] <= leftArray[0])
            {
                StraightUpMerge(rightArray, leftArray, NewArray, ref iNewArray);
            }

            else
            {
                for (int i = 0; i < LLength; i++)
                {
                    while (RHead < RLength)
                    {
                        if (leftArray[i] > rightArray[RHead])
                        {
                            NewArray[iNewArray] = rightArray[RHead];
                            iNewArray++;
                            RHead++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    // Need to add this element it it was in while-else block or even while is never hit.
                    // Add Left array items.
                    NewArray[iNewArray] = leftArray[i];
                    iNewArray++;
                }

                // Add remaining Right array Items.                
                for (int i =  RHead; i < RLength; i++)
                {
                    NewArray[iNewArray] = rightArray[i];
                    iNewArray++;
                    RHead++;
                }
            }

            return NewArray;
        }

        private void StraightUpMerge(int[] FirstArray, int [] SecondArray, int[] DestinationArray, ref int DestinationCurrentHead)
        {
            Array.Copy(FirstArray, 0, DestinationArray, DestinationCurrentHead, FirstArray.Length);
            DestinationCurrentHead += FirstArray.Length;

            Array.Copy(SecondArray, 0, DestinationArray, DestinationCurrentHead, SecondArray.Length);
            DestinationCurrentHead += SecondArray.Length;
        }
    }

    public static class Extension
    {
        public static int[] Slice(this int [] array, int startIndex, int count)
        {
            int[] returnArray = new int [count];                        

            for (int i = 0; i < count; i++)
            {
                returnArray[i] = array[startIndex + i];
            }
            return returnArray;
        }


    }
}
