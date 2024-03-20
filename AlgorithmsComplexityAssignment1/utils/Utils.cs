namespace AlgorithmsComplexityAssignment1;

public class Utils
{
    public int NumberInput(string message)
    {
        int number;
        Console.Write(message);
        while (!int.TryParse(Console.ReadLine(), out number) || number < 1)
        {
            Console.WriteLine("Invalid number. Type a positive integer number.");
            Console.Write(message);
        }
        return number;
    }

    public void PrintIntArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                Console.Write($"{array[i]}");
            }
            else
            {
                Console.Write($"{array[i]},");
            }
        }
        Console.WriteLine("");
    }
}