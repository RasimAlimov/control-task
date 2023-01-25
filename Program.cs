string[] array1 = new string[5] {"566", "12399", "task", "fix", "//"};
string[] finalarray = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] finalarray)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        finalarray[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, finalarray);
PrintArray(finalarray);
