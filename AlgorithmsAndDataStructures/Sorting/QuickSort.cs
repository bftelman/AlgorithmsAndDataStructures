namespace AlgorithmsAndDataStructures.Sorting
{
    internal class QuickSort
    {
        public static void Sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int q = Partition(arr, start, end);
                Sort(arr, start, q - 1);
                Sort(arr, q + 1, end);
            }
        }

        private static int Partition(int[] arr, int start, int end)
        {
            int x = arr[end];
            int i = start - 1;

            for(int j = start; j <= end - 1; j++)
            {
                if (arr[j] < x)
                {
                    i = i + 1;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }

            (arr[i+1], arr[end]) = (arr[end], arr[i+1]);
            return i+1;
        }
    }
}
