namespace MergeArrays;

public class Program
{
    public static void Main(string[] args)
    {
        int[] FirstArray = { 4, 6, 10, 12, 14, 16, 18, 21 };
        int[] SecondArray = { 1, 2, 3, 9 };

        System.Console.WriteLine(MergeSortedArrays(FirstArray, SecondArray));
    }

    // TODO 
    public static int[] MergeSortedArrays(int[] array1, int[] array2)
    {
        int[] FullArray = new int[array1.Length + array2.Length];
        int Array1Index = 0;
        int Array2Index = 0;
        while (Array1Index < array1.Length) // This code is hideous but it's doing exactly what you described in the video
        {
            if (Array2Index >= array2.Length)
            {
                FullArray[Array1Index + Array2Index] = array1[Array1Index];
                Array1Index++;
            }
            else if (array1[Array1Index] < array2[Array2Index])
            {
                FullArray[Array1Index + Array2Index] = array1[Array1Index];
                Array1Index++;
            }
            else
            {
                FullArray[Array1Index + Array2Index] = array2[Array2Index];
                Array2Index++;
            }
        }
        while (Array2Index < array2.Length)
        {
            FullArray[Array1Index + Array2Index] = array2[Array2Index];
            Array2Index++;
        }
        return FullArray;
    }

    // TODO 
    private static bool IsSorted(int[] array)
    {
        return true;
    }
}

