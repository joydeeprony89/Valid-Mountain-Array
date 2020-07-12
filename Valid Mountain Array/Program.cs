using System;

namespace Valid_Mountain_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 3, 2, 1 };
            Console.WriteLine(ValidMountainArray(arr));
            Console.WriteLine("Hello World!");
        }

        public static bool ValidMountainArray(int[] A)
        {
            int len = A.Length;
            if (len < 3) return false;
            int i = 0;
            int j = len - 1;
            while (i < len - 1 && A[i] < A[i + 1]) i++;
            while (j > 0 && A[j - 1] > A[j]) j--;

            if (i == j && i != 0 && j != len - 1) return true;
            return false;
        }
    }
}
