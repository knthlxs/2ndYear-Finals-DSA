using System;

namespace DSAFinalProject {
    // Kenth Alexis Osila | BSIT 2-3
    internal class Program {
        static void Main(string[] args) {
            int elemNum = 0;

            try {
                bool validCount = false;
                // Let the user input number of elements from 1 to 10 only
                while (!validCount) {
                    Console.Write("Enter the number of elements to be sorted (1 to 10): ");
                    elemNum = Convert.ToInt32(Console.ReadLine());
                    if (elemNum > 0 && elemNum <= 10) {
                        validCount = true;
                    }
                }
            } catch (FormatException ex) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{ex.Message}. Please input an integer only.\n");
                Console.ResetColor();
                Main(args);
            }

            int[] randomNum = new int[elemNum]; // Create an array - Length of array is based from user

            Program p = new Program();
            // Let user input elements
            p.enterElements(randomNum);

            // Ask the user what sorting do they want
            p.menu(randomNum);
        }

        // Method for user input, checks user input
        public void enterElements(int[] arr) {
            Console.WriteLine("Enter the elements to be sorted: ");
            try {
                for (int i = 0; i < arr.Length; i++) {
                    arr[i] = Convert.ToInt32(Console.ReadLine()); // Insert the value inputted by user to the array
                }
            } catch (FormatException ex) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{ex.Message}. Please input an integer only.\n");
                Console.ResetColor();
                enterElements(arr);
            }
        }

        // Method for letting the user choose a sorting algorithm
        public void menu(int[] arr) {
            bool sortAgain = true;
            string again = "";
            string[] sortingName = { "Bubble Sort", "Selection Sort", "Merge Sort", "Insertion Sort", "Quick Sort", "Heap Sort" };

            while (sortAgain) {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("\nThe original array is: ");
                printArray(arr);
                Console.ResetColor();

                Console.Write($"\nSelect the sorting algorithm:\n\t1. {sortingName[0]}\n\t2. {sortingName[1]}\n\t3. {sortingName[2]}\n\t4. {sortingName[3]}\n\t5. {sortingName[4]}\n\t6. {sortingName[5]}\n> ");
                try {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice) {
                        case 1: {
                            printSortName(sortingName, 0);
                            int[] sortedArr = arr.ToArray(); // Create a copy of original array, so that the original array values will not be changed
                            BubbleSort bs = new BubbleSort();
                            bs.bubbleSort(sortedArr);
                            break;
                        }
                        case 2: {
                            printSortName(sortingName, 1);
                            int[] sortedArr = arr.ToArray();
                            SelectionSort ss = new SelectionSort();
                            ss.selectionSort(sortedArr);
                            break;
                        }
                        case 3: {
                            printSortName(sortingName, 2);
                            int[] sortedArr = arr.ToArray();
                            MergeSort ns = new MergeSort();
                            ns.mergeSortF(sortedArr);
                            break;
                        }
                        case 4: {
                            printSortName(sortingName, 3);
                            int[] sortedArr = arr.ToArray();
                            InsertionSort ins = new InsertionSort();
                            ins.insertionSort(sortedArr);
                            break;
                        }
                        case 5: {
                            printSortName(sortingName, 4);
                            int[] sortedArr = arr.ToArray();
                            QuickSort qs = new QuickSort();
                            qs.quickSortF(sortedArr);

                            break;
                        }
                        case 6: {
                            printSortName(sortingName, 5);
                            int[] sortedArr = arr.ToArray();
                            HeapSort hs = new HeapSort();
                            hs.heapSort(sortedArr);
                            break;
                        }
                        default: {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please input number from 1 to 6 only.");
                            Console.ResetColor();
                            menu(arr); // Call the method again if user input is invalid
                            break;

                        }
                    }
                    // Check if the user want to select a sorting algorithm again
                    bool validInput = false;
                    while (!validInput) {
                        Console.Write("\nDo you want to select a sorting algorithm again? [Y/N]: ");
                        again = Console.ReadLine();
                        if (again.Equals("Y", StringComparison.InvariantCultureIgnoreCase)) {
                            sortAgain = true;
                            validInput = true;
                        } else if (again.Equals("N", StringComparison.InvariantCultureIgnoreCase)) {
                            sortAgain = false;
                            validInput = true;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Program closed.");
                            Console.ResetColor();
                            Environment.Exit(0); // Exit the application 
                        } else {
                            validInput = false;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input please input 'Y' or 'N' only.");
                            Console.ResetColor();
                        }
                    }

                } catch (FormatException ex) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{ex.Message}. Please input an integer only.\n");
                    Console.ResetColor();
                    menu(arr); // Call the method again if there is a string format exception
                }
            }

        }
        public void printSortName(string[] arr, int i) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{arr[i]} Algorithm");
            Console.ResetColor();
        }
        // Method for checking if the array is already sorted
        public bool isSorted(int[] arr) {
            for (int i = 0; i < arr.Length - 1; i++) {
                if (arr[i] > arr[i + 1]) {
                    return false; // Array is not sorted in ascending order
                }
            }
            return true; // Array is sorted in ascending order
        }

        // Method for printing the elements of an array
        public void printArray(int[] arr) {
            foreach (int i in arr) Console.Write(i + " ");
        }

        // Method for counting and printing the pass/es
        public void countPass(int pass, int[] arr) {
            Console.Write($"Pass {pass}: ");
            printArray(arr);
            Console.WriteLine();
        }

        // Method for printing the number of pass/es
        public void printPass(int pass) {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"The number of pass is: {pass}");
            Console.ResetColor();
        }

        // Method for printing the sorted array
        public void printSortedArray(int[] arr) {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("The sorted array is: ");

            foreach (int i in arr) {
                Console.Write(i + " ");
            }
            Console.ResetColor();
        }
    }
}