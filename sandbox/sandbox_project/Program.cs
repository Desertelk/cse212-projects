using System;
using System.Globalization;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        List<int> test = new() {1,2,3,4,5,6,7,8,9};
        foreach(int item in test)
        {
            Console.WriteLine(item);
        }
        RotateListRight(test, 3);
        foreach(int item in test)
        {
            Console.WriteLine(item);
        }       

    }

    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person..

        //I create a for loop that will iterate over the list. I will remove the last amount of items and then insert them at the beginning.

        for(int j = 0; j < amount; j++)
        {
            int temp = data[data.Count-1];
            data.Remove(data[data.Count - 1]);
            data.Insert(0,temp);
        }
    }
}