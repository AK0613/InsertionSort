using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertion sort is a simple sorting algorithm that works similar to the way you sort playing cards in your hands. The array is virtually split into a sorted and an unsorted part. Values from the unsorted part are picked and placed at the correct position in the sorted part. ");
            int[] arr = { 50, 63, 183, 87, 90, 5, 15, 382 };

            Console.Write("This is the unsorted array: ");
            print(arr);

            Console.WriteLine("\nNow sorted: ");
            int[] sortedArray = InsertionSort(arr);

            print(sortedArray);
        }

        public static void print(int[] arr)
        {
            foreach (int x in arr)
                Console.Write(x + " ");
        }


        public static int[] InsertionSort(int[] arr)
        {
            //Iterate from arr[1] to arr[n]
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                //While whithin bounds, move all bigger numbers than the current key over to the right. 
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
            return arr;
        }
    }
}
