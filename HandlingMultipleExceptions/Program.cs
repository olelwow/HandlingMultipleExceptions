
HandleMultipleExceptions("1", 1);

static void HandleMultipleExceptions (string text, int index)
{
    int[] numbers = { 1, 2, 3 };
    try
    {
        int integerFromString = Int32.Parse(text);
        int valueAtIndex = numbers[index];
        
        Console.WriteLine(valueAtIndex);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid format");
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Index out of range");
    }
}
