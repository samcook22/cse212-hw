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
    // Game Plan...
    // 1. Create an array of doubles with the specified length.
    // 2. Use a loop to fill the array. Each element will be the 'number' multiplied by the index + 1 to get doubled.
    // 3. Return the array.

    double[] multiples = new double[length]; // This is the array

    for (int i = 0; i < length; i++) // Loop
    {
        multiples[i] = number * (i + 1); // Get the multiple of 'number' and fill the array
    }

    return multiples; // Return the array
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
    // Game Plan 2:
    // 1. Get the amount of rotation by using modulo to handle cases where 'amount' >= data.Count.
    // 2. Use slicing:
    //    a. The stuff rotating up front.
    //    b. The remaining items.
    // 3. Clear the original list and rebuild it by appending the two slices.

    // Use modulo to rotate
    amount = amount % data.Count; 

    // Get the two slices
    var lastPart = data.GetRange(data.Count - amount, amount); // Last items
    var firstPart = data.GetRange(0, data.Count - amount);     // First items

    // Clear the original list and add the slices in the rotated order
    data.Clear();
    data.AddRange(lastPart); // Bring the last items to the front
    data.AddRange(firstPart); // Put the remaining items out back
}

}
