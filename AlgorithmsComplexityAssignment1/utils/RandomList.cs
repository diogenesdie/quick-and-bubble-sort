namespace AlgorithmsComplexityAssignment1;

public class RandomList<T>: List<T>
{
    private List<T> _list = new List<T>();

    public void PrintList()
    {
        foreach (var item in _list)
        {
            Console.WriteLine(item);
        }
    }

    public void FillList(int size)
    {
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            _list.Add((T)Convert.ChangeType(random.Next(1, 1000000), typeof(T)));
        }
    }
    
    public int[] ConvertToList()
    {
        int[] array = new int[_list.Count];
        for (int i = 0; i < _list.Count; i++)
        {
            array[i] = Convert.ToInt32(_list[i]);
        }
        return array;
    }
}