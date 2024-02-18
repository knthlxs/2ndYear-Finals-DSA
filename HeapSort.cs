using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAFinalProject {
    // Kenth Alexis Osila | BSIT 2-3
    internal class HeapSort : Program {
        int pass = 0;

        public void heapSort(int[] array) {
            int n = array.Length; // Get the length of the array

            if (!isSorted(array)) {
                // Check if the array is not already sorted
                // Build a max heap by heapifying each non-leaf node in reverse order
                for (int i = n / 2 - 1; i >= 0; i--) {
                    heapify(array, n, i);
                }

                // Extract elements from the heap one by one and build the sorted array
                for (int i = n - 1; i >= 0; i--) {
                    // Swap the root (maximum element) with the last element
                    int temp = array[0];
                    array[0] = array[i];
                    array[i] = temp;

                    pass++; // Increment the pass count for each swap
                    countPass(pass, array); // Call a function to count and display the pass

                    // Heapify the reduced heap to maintain the max heap property
                    heapify(array, i, 0);
                }
            } else {
                pass++; // Increment the pass count if the array is already sorted
                countPass(pass, array); // Call a function to count and display the pass
            }

            printPass(pass); // Print the total number of passes
            printSortedArray(array); // Print the sorted array
        }

        public void heapify(int[] arr, int n, int i) {
            int largest = i;
            int l = 2 * i + 1; // Index of the left child
            int r = 2 * i + 2; // Index of the right child

            // Check if the left child is larger than the root
            if (l < n && arr[l] > arr[largest]) {
                largest = l;
            }

            // Check if the right child is larger than the current largest
            if (r < n && arr[r] > arr[largest]) {
                largest = r;
            }

            // If the largest is not the root, swap the root with the largest element
            if (largest != i) {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Recursively heapify the affected sub-tree
                heapify(arr, n, largest);
            }
        }

    }
}