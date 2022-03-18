using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingDemo.Sorting;
namespace SortingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var intArray = new int[] { 10, 20, 50, 40, 5, 18, 36, 100 };
            //var intArray = new int[] { 10, 20, 30, 40, 50 };
            var intArray = new int[] { 10, 20, 50, 40, 50, 18, 36, 22 };
            //var intArray = new int[] { 90, 80, 70, 60, 50, 40, 30, 22 };

            ISort sortingTech = new MergeSort();
 
            var outputArray = sortingTech.Sort(intArray);
            foreach (var item in outputArray)
            {
                Console.Write(item + " ");
            }
        }       
    }        
}