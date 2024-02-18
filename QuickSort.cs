using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAFinalProject {
    // Kenth Alexis Osila | BSIT 2-3
    internal class QuickSort : Program {

        int pass = 0;

        public void quickSortF(int[] arr) {
            if (!isSorted(arr)) { // Check if the array is not already sorted
                quickSort(arr, 0, arr.Length - 1);
            } else {
                pass++; // Increment the pass count if the array is already sorted
                countPass(pass, arr);
            }

            printPass(pass);
            printSortedArray(arr);
        }

        public void quickSort(int[] array, int start, int end) {
            if (end <= start) return; // Base case: return if the array has one element or is empty

            int pivot = partition(array, start, end); // Get the pivot element and partition the array
            quickSort(array, start, pivot - 1); // Recursively sort the left subarray
            quickSort(array, pivot + 1, end); // Recursively sort the right subarray
        }

        public int partition(int[] array, int start, int end) {
            int pivot = array[end]; // Choose the pivot as the last element
            int i = start - 1; // Initialize the index of the smaller element

            for (int j = start; j <= end; j++) {
                if (array[j] < pivot) { // If the current element is smaller than the pivot
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp; // Swap array[i] and array[j]
                }
            }

            i++;
            int temp2 = array[i];
            array[i] = array[end];
            array[end] = temp2; // Swap array[i+1] and the pivot

            pass++;
            countPass(pass, array);
            return i; // Return the index of the pivot element
        }
    }

}
