namespace AlgorithmsComplexityAssignment1;

public class Program
{
    static void Main(string[] args)
    {
        Exercise1 exercise1 = new Exercise1();
        Exercise2 exercise2 = new Exercise2();
        Utils utils = new Utils();
        
        Dictionary<string, double> executionTimes = new Dictionary<string, double>
        {
            { "quick", 0 },
            { "bubble", 0 }
        };
        int chosen = 0;
        List<int> validOptions = [1, 2, 3, 4, 5];

        do
        {
            chosen = 0;
            Console.Clear();
            Console.WriteLine("Which exercise do you want to run?");
            while (!validOptions.Contains(chosen))
            {
                Console.WriteLine("1: Exercise 1");
                Console.WriteLine("2: Exercise 2 (QuickSort)");
                Console.WriteLine("3: Exercise 2 (BubbleSort)");
                Console.WriteLine("4: Compare QuickSort with BubbleSort");
                Console.WriteLine("5: Exit");
                chosen = utils.NumberInput("Option: ");
                Console.Clear();
            }

            switch (chosen)
            {
                case 1:
                    Console.WriteLine("Running Exercise 1...");
                    exercise1.Run();
                    break;
                case 2:
                    Console.WriteLine("Running Exercise 2 (QuickSort)...");
                    executionTimes["quick"] = exercise2.Run("quick");
                    break;
                case 3:
                    Console.WriteLine("Running Exercise 2 (BubbleSort)...");
                    executionTimes["bubble"] = exercise2.Run("bubble");

                    break;
                case 4:
                    Console.WriteLine("Running comparison (QuickSort vs BubbleSort)...");

                    RandomList<int> randomList = new RandomList<int>();
                    int size = utils.NumberInput("Type the list size: ");
                    randomList.FillList(size);
                    randomList.ConvertToList();

                    executionTimes["quick"] = exercise2.Run("quick", randomList, false);
                    executionTimes["bubble"] = exercise2.Run("bubble", randomList, false);

                    Console.WriteLine($"Quick Sort -> {executionTimes["quick"]}ms");
                    Console.WriteLine($"Bubble Sort -> {executionTimes["bubble"]}ms");
                    break;
            }

            Console.ReadKey();
        } while (chosen != 5);
    }
}