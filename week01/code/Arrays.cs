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
        // 
        // ==============================================================
        // First, create a new array of doubles with the name "multiples" with the specified length of "length".
        // Next, use a for loop that iterates through by the number of times specified by "length".  
        // Inside the loop take the current index plus 1 and multiply that by the "number" and store that value in the array at the current index.
        // Finally, return the array.
        // ==============================================================

        var multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        return multiples; // replace this return statement with your own
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
        // be implemented by another person.

        // ==============================================================
        // Create a new list called "startData" that extracts the first part of the list "data" using the GetRange method, starting at index "0" and ending at index "data.Count - amount".
        // Create another new list called "end Data" that extracts the last part of the list "data".  Again using the GetRange method, stating at index "data.Count - amount" and ending at index "amount".
        // Clear the original list "data" using the Clear method.
        // Add the "endData" list to the original list "data" using the AddRange method.
        // Add the "startData" list to the original list "data" using the AddRange method.
        // ==============================================================

        var startData = data.GetRange(0, data.Count - amount);
        var endData = data.GetRange(data.Count - amount, amount);
        data.Clear();
        data.AddRange(endData);
        data.AddRange(startData);
    }
}
