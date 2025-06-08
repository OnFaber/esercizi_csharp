public class BubbleSort : ISortingAlgorithm
{
    public string Name => "Bubble Sort";

    protected bool Less(int value1, int value2) => value1 < value2;
    protected bool More(int value1, int value2) => value1 > value2;

    protected virtual void Swap(int[] arr, int index1, int index2)
    {
        int temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
    }

    public virtual int[] Sort(int[] arr)
    {
        int size = arr.Length;
        bool swapped;
        for (int passIndex = 0; passIndex < size - 1; passIndex++)
        {
            swapped = false;
            for (int currentIndex = size - 1; currentIndex > passIndex; currentIndex--)
            {
                if (More(arr[currentIndex - 1], arr[currentIndex]))
                {
                    Swap(arr, currentIndex - 1, currentIndex);
                    swapped = true;
                }
            }
            if (!swapped) break;
        }

        return arr;
    }
}
