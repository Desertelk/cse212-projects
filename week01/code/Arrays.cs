public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //first I create a new list which will become the length that is indicated by the user.
        // Then I make a for loop that will loop over the list. The index will be used to add the number to the array.
        //I will also use the index to multiply the number given to fulfill the requirement.
        double[] multiplesArray = new double[length];
        for(int i = 0; i < length; i++)
        {
            double temp = number * (i + 1);
            multiplesArray[i] = temp;
        }

        return multiplesArray; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person..

        //I create a for loop that will iterate over the list. I will store the last index in a temp variable.
        //Then I'll remove the item at the last index then insert them one at a time at the beginning of the list.

        for(int j = 0; j < amount; j++)
        {
            int temp = data[data.Count-1];
            data.Remove(data[data.Count - 1]);
            data.Insert(0,temp);
        }
    }
}
