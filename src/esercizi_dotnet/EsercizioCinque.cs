public class EsercizioCinque : IEsercizio
{
    private readonly int _arraySize;
    private readonly int _minValue;
    private readonly int _maxValue;
    private readonly Random _rng = new Random();
    private readonly ISortingAlgorithm _sorting;

    public EsercizioCinque(
        ISortingAlgorithm sorting,
        int arraySize = 10,
        int minValue = 1,
        int maxValue = 100)
    {
        _sorting = sorting;
        _arraySize = arraySize;
        _minValue = minValue;
        _maxValue = maxValue;
    }

    public virtual void PrintArray(TextWriter output, int[] array)
    {
        output.WriteLine("Array: " + string.Join(", ", array));
    }

    public virtual bool PrintSearchResult(TextWriter output, int index)
    {
        if (index.Equals(-1))
        {
            output.WriteLine("Il numero non è stato trovato");
            return false;
        }
        
        else
        {
            output.WriteLine("Il numero cercato si trova ad indice {0}", index);
            return true;
        }        
    }

    public int[] CreateArray()
    {
        int[] arr = new int[_arraySize];
        for (int i = 0; i < _arraySize; i++)
        {
            arr[i] = _rng.Next(_minValue, _maxValue + 1);
        }
        return arr;
    }

    public int[] RemoveDuplicates(int[] arr) =>  arr.Distinct().ToArray();
    public void Run(TextReader? input = null, TextWriter? output = null)
    {
        output ??= Console.Out;

        int[] array;
        int index;

        do {
            array = CreateArray();
            array = RemoveDuplicates(array);
            array = _sorting.Sort(array);
            index = SearchAlgorithms.BinarySearch(array, 50);
            PrintArray(output, array);
            if (PrintSearchResult(output, index)) return;
        } while (true);
    }
}
