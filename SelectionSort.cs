using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAFinalProject {
    // Kenth Alexis Osila | BSIT 2-3
    internal class SelectionSort : Program {
        public void selectionSort(int[] arr) {
            int n = arr.Length;
            int pass = 0;

            if (!isSorted(arr)) {
                for (int i = 0; i < n - 1; i++) {
                    // Find the minimum element in unsorted array
                    int min_idx = i; // min_idx = i is the index to track the minimum value
                    for (int j = i + 1; j < n; j++) // int j = i + 1 to compare the element next to the value of minimum value
                        if (arr[j] < arr[min_idx]) {
                            min_idx = j;
                        }

                    // Swap the found minimum element with the first element
                    int temp = arr[min_idx];
                    arr[min_idx] = arr[i];
                    arr[i] = temp;

                    pass++;
                    countPass(pass, arr);
                }

            } else {
                pass++;
                countPass(pass, arr);
            }

            printPass(pass);
            printSortedArray(arr);
        }
    }
}
