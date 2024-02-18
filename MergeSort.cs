using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAFinalProject {
    // Kenth Alexis Osila | BSIT 2-3
    internal class MergeSort : Program {
        int pass = 0;
        public void mergeSortF(int[] arr) {
            if (!isSorted(arr)) {
                mergeSort(arr);
            } else {
                pass++;
                countPass(pass, arr);
            }

            printPass(pass);
            printSortedArray(arr);
        }
        // Merge Sort function for int
        public void mergeSort(int[] array) {
            int length = array.Length;
            int mid = length / 2;

            if (length <= 1) {
                return;
            }
            // Split the array into two halves
            int[] leftArray = new int[mid];
            int[] rightArray = new int[length - mid];

            for (int i = 0; i < mid; i++) {
                leftArray[i] = array[i];
            }

            for (int i = mid; i < length; i++) {
                rightArray[i - mid] = array[i];
            }

            // Recursively sort each half
            mergeSort(leftArray);
            mergeSort(rightArray);

            // Merge the sorted halves
            Merge(array, leftArray, rightArray);
            countPass(pass, array);
        }

        // Merge function to merge two halves into a single sorted array
        public void Merge(int[] array, int[] leftArray, int[] rightArray) {
            int i = 0, j = 0, k = 0;

            // Compare elements and merge
            while (i < leftArray.Length && j < rightArray.Length) {
                if (leftArray[i] <= rightArray[j]) {
                    array[k] = leftArray[i];
                    i++;
                } else {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements from leftArray, if any
            while (i < leftArray.Length) {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            // Copy remaining elements from rightArray, if any
            while (j < rightArray.Length) {
                array[k] = rightArray[j];
                j++;
                k++;
            }
            pass++;
        }
    }
}
