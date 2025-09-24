using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAssignment
{
    public class Utility
    {
        /// <summary>
        /// Performs a linear search of an array for a given target
        /// 
        /// Pseudocode:
        /// 
        /// for (i = 0; i < arrayLength; i++):
        ///     if array[i] == target:
        ///         return i
        /// return -1
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to search through</param>
        /// <param name="target">The item to search for</param>
        /// <returns>The index if the target, or -1 if it is not found</returns>
        public static int LinearSearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo(target) == 0)
                    return i;
            }

            return -1;
        }

        /// <summary>
        /// Performs a binary search of a sorted array for a given target
        /// 
        /// Pseudocode:
        /// 
        /// min = 0
        /// max = arrayLength - 1
        /// 
        /// while min < max:
        ///     mid = (min + max) / 2
        ///     if result == 0:
        ///         return mid
        ///     else if array[mid] > target:
        ///         max = mid - 1
        ///     else:
        ///         min = mid + 1
        /// return -1
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The sorted array to search through</param>
        /// <param name="target">The item to search for</param>
        /// <returns>The index if the target, or -1 if it is not found</returns>
        public static int BinarySearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int min = 0;
            int max = array.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                int result = array[mid].CompareTo(target);

                if (result == 0)
                    return mid;
                else if (result == 1)
                    max = mid - 1;
                else
                    min = mid + 1;
            }

            return -1;
        }

        /// <summary>
        /// Sorts the given array in ascending order using the Insertion Sort algorithm
        /// 
        /// Pseudocode:
        /// 
        /// for (int i = 1; i < arrayLength; i++):
        ///     key = array[i]
        ///     j = i - 1
        ///     
        ///     while (j >= 0 && array[j] > 0):
        ///         array[j + 1] = array[j]
        ///         j--;
        ///     array[j + 1] = key
        /// 
        /// </summary>
        /// <typeparam name="T">Class that implements IComparable interface</typeparam>
        /// <param name="array">The array to sort</param>
        public static void SortAscending<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }
        }

        /// <summary>
        /// Sorts the given array in descending order using the Insertion Sort algorithm
        /// 
        /// Pseudocode:
        /// 
        /// for (int i = 1; i < arrayLength; i++):
        ///     key = array[i]
        ///     j = i - 1
        ///     
        ///     while (j >= 0 && array[j] < 0):
        ///         array[j + 1] = array[j]
        ///         j--;
        ///     array[j + 1] = key
        /// 
        /// </summary>
        /// <typeparam name="T">Class that implements IComparable interface</typeparam>
        /// <param name="array">The array to sort</param>
        public static void SortDescending<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j].CompareTo(key) < 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }
        }
    }
}
