namespace AlgorithmsAndDataStructures.Sorting
{
    internal class Utils
    {
        public static int[] FillArray(int num)
        {
            int[] res = new int[num];

            for (int i = 0; i < num; i++)
            {
                res[i] = num - i;
            }

            return res;
        }
    }
}
