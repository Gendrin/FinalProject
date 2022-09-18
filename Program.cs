
string[] inputString;
Console.WriteLine("Please enter long checked string?");

if (int.TryParse(Console.ReadLine(), out int longString))
    {
        if (longString > 0)
        {
        Console.WriteLine("Please enter strings through whitespase!");
        inputString = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        PrintString(inputString);
        Console.Write(" -> ");
        PrintString(CheckCountForSimbols(inputString, longString+1));
    }
        else Console.WriteLine("No correct enters!");
}

void PrintString(string[] printStrings)
{
    Console.Write("[");
    for (int i = 0; i < printStrings.Length; i++)
    {
        if (i < printStrings.Length - 1)
        {
            Console.Write($"\"{printStrings[i]}\",");
        }
        else Console.Write($"\"{printStrings[i]}\"");
    }
    Console.Write("]");
}

string[] CheckCountForSimbols(string[] checkString, int longString)
{
    int allCountSmallStrings=0;
    for (int i = 0; i < checkString.Length; i++)
    {
        if (checkString[i].Length < longString)
        {
            allCountSmallStrings++;
        }
    }
    string[] arrRezStrings = new string[allCountSmallStrings];
    int j = 0;
    for (int i=0;i < checkString.Length; i++)
    {
        if (checkString[i].Length < longString)
        {
            arrRezStrings[j]= checkString[i];
            j++;
        }
    }
    return arrRezStrings;
}