string[] getStringsEqualOrLessThenNSimbols(string[] stringArray, int maxNumberOfSimbols)
{
    string resultString = string.Empty;
    string separator = ",";

    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= maxNumberOfSimbols)
        {
            resultString += stringArray[i] + separator;
        }
    }

    if (resultString.Length > 0)
    {
        return resultString.Substring(0, resultString.Length - 1).Split(separator);
    }
    else
    {
        return resultString.Split();
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

string[] array = { "false", "true" };
PrintArray(array);
string[] resultArray = getStringsEqualOrLessThenNSimbols(array, 3);
PrintArray(resultArray);