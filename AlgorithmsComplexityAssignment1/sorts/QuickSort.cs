namespace AlgorithmsComplexityAssignment1.sorts;

public class QuickSort : SortAlgorithm 
{
    private static void _Swap(ref int a, ref int b)
    {
        (a, b) = (b, a);
    }
    private static int _Partition(int[] array, int low, int high)
    {
        // Last element as pivot
        int pivot = array[high];
        //Get the lower element index
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                _Swap(ref array[i], ref array[j]);
            }
        }
        
        //Fix pivot position
        _Swap(ref array[i + 1], ref array[high]);
        return i + 1;
    }
    private static void _Sort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIdx = _Partition(array, low, high);
            _Sort(array, low, pivotIdx - 1);
            _Sort(array, pivotIdx + 1, high);
        }
    }

    public override void Run(int[] array)
    {
        _Sort(array, 0, array.Length - 1);
    }
}