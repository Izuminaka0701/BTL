using System;

class RecursiveSelectionSort
{
    // Hàm đệ quy đơn giản để sắp xếp mảng
    static void Sort(int[] arr, int startIndex = 0)
    {
        if (startIndex >= arr.Length - 1)
            return;
        int minIdx = startIndex;
        for (int i = startIndex + 1; i < arr.Length; i++)
            if (arr[i] < arr[minIdx])
                minIdx = i;
        int temp = arr[startIndex];
        arr[startIndex] = arr[minIdx];
        arr[minIdx] = temp;
        Sort(arr, startIndex + 1);
    }
    static void Main(string[] args)
    {
        int[] arr = { 64, 25, 12, 22, 11 };
        Console.WriteLine("Mảng ban đầu: " + string.Join(" ", arr));
        Sort(arr);

        Console.WriteLine("Mảng sau khi sắp xếp: " + string.Join(" ", arr));
    }
}
