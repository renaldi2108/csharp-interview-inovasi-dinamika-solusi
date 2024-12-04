using System;

public class Program {
    public static int[] MergeSortedArrays(int[] arr1, int[] arr2) {
        int i = 0, j = 0, k = 0;
        int[] result = new int[arr1.Length + arr2.Length];

        while (i < arr1.Length && j < arr2.Length) {
            if (arr1[i] < arr2[j]) {
                result[k++] = arr1[i++];
            } else {
                result[k++] = arr2[j++];
            }
        }

        while (i < arr1.Length) {
            result[k++] = arr1[i++];
        }

        while (j < arr2.Length) {
            result[k++] = arr2[j++];
        }

        return result;
    }

    public static void Main() {
        int[] arr1 = { 1, 3, 5, 7 };
        int[] arr2 = { 2, 4, 6, 8 };
        int[] mergedArray = MergeSortedArrays(arr1, arr2);

        Console.WriteLine(string.Join(", ", mergedArray));
    }
}
