using System;

namespace selectionsort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] selectionArray = { 2, 3, 2, 4, 5, 67, 3, 4, 3 };
            SelectoinSort(selectionArray);
        }

        public static void SelectoinSort(int[] arr)
        {

            int theLargest = 0;

            for (int unsortedArr = arr.Length - 1; unsortedArr > 0; unsortedArr--)
            {

                for (int i = 0; i <= unsortedArr; i++)
                {

                    if (arr[i] > arr[theLargest])
                    {
                        theLargest = i;

                    }
                }

                Swap(arr, theLargest, unsortedArr);

            }
            PrintFunction(arr);
        }


        public static void PrintFunction(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++) 
               Console.WriteLine(arr[i]);
            Console.WriteLine();
        }

        public static void Swap(int[] arry, int x, int y)
        {

            if (x == y)
                return;

            int temp;
            temp = arry[x];
            arry[x] = arry[y];
            arry[y] = temp;

        }
    }
}
