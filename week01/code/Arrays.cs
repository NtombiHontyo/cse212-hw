using System.Diagnostics;
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

        //My Process:
        // I will start of by creating an empty an array. Then I will implement a for loop. The for loop will loop as long as i
        // is less than or equal to the second input (the number of multiples). As it loops the starting interger is multiplied by i. the answer
        // is stored in a variable and then appended in the list created earlier. The list is then returned.

        //Step One: create an empty array
        double[] result = [];


        //Step two: create a for loop. will loop through a set of intergers that increment until the length.
        for (int i = 1; i <= length; i++)
        {
            var multiple = number * i;
            result = result.Append(multiple).ToArray();
        }

        return result; // replace this return statement with your own
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

        //Plan: 
        // Identify the number(s) to be pushed in the front and store them in a new list. 
        // Remove the aforementioned number(s). 
        // Push them to the front of the line

        //create first list
        Debug.WriteLine("Amount: " + amount);
        foreach (var item in data)
        {
            Debug.WriteLine(item);
        }

        Debug.WriteLine("BREAK");


        List<int> secondList = data.GetRange(data.Count - amount, amount);
        foreach (var item in secondList)
        {
            Debug.WriteLine(item);
        }

        //edit existing list
        data.RemoveRange(data.Count  - amount, amount);

        //combine secondList to original list (data)
        data.InsertRange(0, secondList);

        Debug.WriteLine("BREAK");
        foreach (var item in data)
        {
            Debug.WriteLine(item);
        }

        


    }
}
