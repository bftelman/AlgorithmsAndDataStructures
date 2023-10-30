using AlgorithmsAndDataStructures.Sorting;

namespace AlgorithmsAndDataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = Utils.FillArray(100);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}