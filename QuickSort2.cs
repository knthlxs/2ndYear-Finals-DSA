using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAFinalProject {


    internal class QuickSort2 : Program {
        int MAX;
        int pass = 0;
        public QuickSort2(int MAX) {
            this.MAX = MAX;
        }

        public void swap(int[] arr, int num1, int num2) {
            int temp = arr[num1];
            arr[num1] = arr[num2];
            arr[num2] = temp;
        }
        public int partition(int[] arr, int left, int right, int pivot) {
            int pivotValue = arr[right]; // Choose the last element as the pivot

            int leftPointer = left - 1;
            int rightPointer = right;

            while (true) {
                while (arr[++leftPointer] < pivotValue) { }
                while (rightPointer > 0 && arr[--rightPointer] > pivotValue) { }

                if (leftPointer >= rightPointer) {
                    break;
                } else {
                    swap(arr, leftPointer, rightPointer);
                }
            }

            // Swap the pivot element to its final position
            swap(arr, leftPointer, right);

            // Increment pass count and print it after each pass
            pass++;
            countPass(pass, arr);

            return leftPointer;
        }

        public void quickSort(int[] arr, int left, int right) {
            if (right - left <= 0) {
                return;
            } else {
                int pivot = arr[right];
                int partitionPoint = partition(arr, left, right, pivot);
                quickSort(arr, left, partitionPoint - 1);
                quickSort(arr, partitionPoint + 1, right);
            }
        }


    }
}
