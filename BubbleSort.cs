using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAFinalProject {
    // Kenth Alexis Osila | BSIT 2-3
    internal class BubbleSort : Program {
        public void bubbleSort(int[] arr) {
            int i, j, temp, n = arr.Length, pass = 0;
            bool swapped;
            if (!isSorted(arr)) {

                for (i = 0; i < n - 1; i++) {
                    swapped = false;
                    for (j = 0; j < n - i - 1; j++) {
                        if (arr[j] > arr[j + 1]) {

                            // Swap arr[j] and arr[j+1]
                            temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                            swapped = true;
                        }
                    }
                    pass++;
                    countPass(pass, arr);
                    // If no two elements were
                    // swapped by inner loop, then break
                    if (swapped == false)
                        break;
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
