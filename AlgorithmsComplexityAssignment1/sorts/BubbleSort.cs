namespace AlgorithmsComplexityAssignment1.sorts;

public class BubbleSort : SortAlgorithm
{
    private static void _Swap(ref int a, ref int b)
    {
        (a, b) = (b, a);
    }

    private static void _Sort(int[] array)
    {
        int length = array.Length;
        bool swapped;

        do
        {
            swapped = false;
            for (int i = 1; i < length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    _Swap(ref array[i - 1], ref array[i]);
                    swapped = true;
                }
            }
            length--;
            
        } while (swapped);
    }

    public override void Run(int[] array)
    {
        _Sort(array);
    }
}