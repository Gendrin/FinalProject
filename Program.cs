// See https://aka.ms/new-console-template for more information
string[] inputString;
int allCountSmallStrings=0;
Console.WriteLine("Please enter strings through whitespase!");
inputString = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
Console.Write("[");
for (int i = 0; i < inputString.Length; i++)
{
    if (inputString[i].Length < 4)
    {
        allCountSmallStrings++;
    }
    if (i < inputString.Length - 1)
    {
        Console.Write($"\"{inputString[i]}\",");
    }
    else Console.Write($"\"{inputString[i]}\"");
}
Console.Write("]");

string[] arrRezStrings = new string[allCountSmallStrings];


Console.Write(" -> [");
for (int j=0,i = 0; i < inputString.Length; i++)
{
    if (inputString[i].Length < 4)
    {
        arrRezStrings[j] = inputString[i];
        if (j < arrRezStrings.Length-1)
            {
            Console.Write($"\"{arrRezStrings[j]}\",");
            j++;
            }
        else Console.Write($"\"{arrRezStrings[j]}\"");
    }
}
Console.Write("]");

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

