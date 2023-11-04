namespace AlgorithmsAndDataStructures.Sorting
{
    internal class Heap
    {
        private static int Parent(int i)
        {
            return i / 2;
        }

        private static int Left(int i)
        {
            return 2 * i + 1;
        }

        private static int Right(int i)
        {
            return 2 * i + 2;
        }

        public static void MaxHeapify(int[] arr, int i, int heapSize)
        {
            int left = Left(i);
            int right = Right(i);
            int largest;
            if (left < heapSize && arr[left] > arr[i])
            {
                largest = left;
            }
            else
            {
                largest = i;
            }

            if (right < heapSize && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                (arr[largest], arr[i]) = (arr[i], arr[largest]);
                MaxHeapify(arr, largest, heapSize);
            }

        }

        public static void Sort(int[] arr, int n)
        {
            int heapSize = n;

            for (int i = arr.Length / 2 - 1; i >= 0; i--)
            {
                MaxHeapify(arr, i, heapSize);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                (arr[0], arr[i]) = (arr[i], arr[0]);
                heapSize--;
                MaxHeapify(arr, 0, heapSize);
            }
        }
    }
}
