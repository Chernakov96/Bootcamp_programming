int[] inputArray = { 9, 12, 9, 2, 17, 1, 6 };

int[] sortedArray = Quicksort(inputArray, 0, inputArray.Length - 1);

Console.WriteLine($"Sorted array: {String.Join(", ", sortedArray)}");

int[] Quicksort(int[] array, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex)
    {
        return array;
    }

    int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

    Quicksort(array, minIndex, pivotIndex - 1);

    Quicksort(array, pivotIndex + 1, maxIndex);

    return array;
}

int GetPivotIndex(int[] array, int minIndex, int maxIndex)
{
    int pivot = minIndex - 1;

    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (array[i] < array[maxIndex])
        {
            pivot++;
            Swap(ref array[pivot], ref array[i]);
        }
    }
    pivot++;
    Swap(ref array[pivot], ref array[maxIndex]);

    return pivot;
}

void Swap(ref int leftItem, ref int rightItem)
{
    int temp = leftItem;
    leftItem = rightItem;
    rightItem = temp;
}