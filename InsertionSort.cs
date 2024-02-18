using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAFinalProject  {
    internal class InsertionSort : Program {
        public void insertionSort(int[] arr) {
            int n = arr.Length; // Get the length of the array
            int pass = 0, val; // Initialize pass count and a variable to store the current value being considered

            if (!isSorted(arr)) { // Check if the array is not already sorted
                for (int i = 1; i < n; i++) { // Iterate through the array starting from the second element
                    val = arr[i]; // Store the current element in the variable val
                    for (int j = i - 1; j >= 0;) { // Iterate through the sorted part of the array (from i-1 to 0)

                        if (val < arr[j]) { // Compare the current element with the elements in the sorted part
                            arr[j + 1] = arr[j]; // If val is smaller, shift the greater element to the right
                            j--; 
                            arr[j + 1] = val; // Place val in its correct sorted position
                        } else {
                            break; // If val is greater or equal, break out of the inner loop
                        }
                    }
                    pass++; // Increment the pass count for each iteration
                    countPass(pass, arr); // Call a function to count and display the pass
                }
            } else {
                pass++; // If the array is already sorted, increment the pass count
                countPass(pass, arr); // Call a function to count and display the pass
            }

            printPass(pass); // Print the total number of passes
            printSortedArray(arr); // Print the sorted array
        }

    }
}
