namespace AlgorithmsComplexityAssignment1;
using System;

public class Exercise1
{
    public void Run()
    {
        Utils utils = new Utils();
        int size = utils.NumberInput("Type the list size: ");
        
        RandomList<int> list = new RandomList<int>();
        list.FillList(size);
        list.PrintList();
    }
}