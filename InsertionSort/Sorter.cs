using System;

// ReSharper disable InconsistentNaming
#pragma warning disable SA1611

namespace InsertionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with insertion sort algorithm.
        /// </summary>
        public static void InsertionSort(this int[] array)
        {
            // #1. Implement the method using a loop statements.
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int j = 1; j < array.Length; j++)
            {
                var key = array[j];
                var i = j - 1;
                while (i >= 0 && array[i] > key)
                {
                    array[i + 1] = array[i];
                    i--;
                }

                array[i + 1] = key;
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive insertion sort algorithm.
        /// </summary>
        public static void RecursiveInsertionSort(this int[] array)
        {
            // #2. Implement the method using recursion algorithm.
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            static void Sort(int[] arr, int length)
            {
                if (length <= 1)
                {
                    return;
                }

                Sort(arr, length - 1);

                var key = arr[length - 1];
                var i = length - 2;

                while (i >= 0 && arr[i] > key)
                {
                    arr[i + 1] = arr[i];
                    i--;
                }

                arr[i + 1] = key;
            }

            Sort(array, array.Length);
        }
    }
}
