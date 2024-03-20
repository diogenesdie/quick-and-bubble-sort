namespace AlgorithmsComplexityAssignment1;
using System.Diagnostics;
using AlgorithmsComplexityAssignment1.sorts;

public class Exercise2
{
    public double Run(String algorithm, RandomList<int>? list = null, Boolean printResults = true){
        Utils utils = new Utils();
        Dictionary<string, SortAlgorithm> algorithms = new Dictionary<string, SortAlgorithm>
        {
            {"quick", new QuickSort()},
            {"bubble", new BubbleSort()}
        };

        if (list == null)
        {
            int size = utils.NumberInput("Type the list size: ");
            list = new RandomList<int>();
            list.FillList(size);
        } 
        
        int[] randomArray = list.ConvertToList();
        
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        if (printResults)
        {
            Console.Write("Before: ");
            utils.PrintIntArray(randomArray);
        }

        algorithms[algorithm].Run(randomArray);

        if (printResults)
        {
            Console.Write("After: ");
            utils.PrintIntArray(randomArray);
        }

        stopwatch.Stop();
        if (printResults)
        {
            Console.WriteLine($"Execution time: {stopwatch.Elapsed.TotalMilliseconds}ms");
        }

        return stopwatch.Elapsed.TotalMilliseconds;
    }
}