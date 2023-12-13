using System;
class Program
{
    static int BinarySearch(int[] array, int value)
    {
        int left = 0;
        int right = array.Length - 1;
        while (left <= right)
        {
            int middle = (left + right) / 2;
            if (array[middle] == value)
                return middle;
            else if (array[middle] < value)
                left = middle + 1;
            else
                right = middle - 1;
        }
        return -1;
    }

    static void Main()
    {
        int[] array = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31 };
        int value = 7;
        int index = BinarySearch(array, value);
        Console.WriteLine(index);
    }
}