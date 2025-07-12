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

        // Step 1: Create a new array of doubles with the size of 'length'
        // Step 2: Loop from 0 to length - 1
        // Step 3: For each index i, set array[i] = number * (i + 1)
        // Step 4: Return the array after the loop finishes

        double[] result = new double[length]; // Step 1

        for (int i = 0; i < length; i++) // Step 2
        {
            result[i] = number * (i + 1); // Step 3
        }

        return result; // Step 4

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


        // Step 1: Determine the number of elements to rotate (already given as 'amount')
        // Step 2: Get the last 'amount' elements from the list (i.e., the part that will rotate to the front)
        // Step 3: Remove those elements from the end of the list
        // Step 4: Insert those elements at the beginning of the list
        // This modifies the list in place without returning anything

        int count = data.Count;
        List<int> toMove = data.GetRange(count - amount, amount); // Step 2
        data.RemoveRange(count - amount, amount);                 // Step 3
        data.InsertRange(0, toMove);                              // Step 4 
    }
}
