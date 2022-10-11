int MAX_WORD_LENGTH = 3;
string[] array1 = { "Hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

string[] GetShortWordsArray(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= MAX_WORD_LENGTH)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);

    return result;
}

void PrintArray(string[] array)
{
    if (array.Length == 0) // Проверяем на пустоту массив
    {
        Console.WriteLine("Массив пустой");
    }
    else
    {
        Array.ForEach(array, (str) => Console.Write($"{str} "));
        Console.WriteLine();
    }
}

void PrintTask(string[] array)
{
    Console.WriteLine("Исходный массив:");
    PrintArray(array);
    string[] shortArray = GetShortWordsArray(array);
    Console.WriteLine($"Массив результирующий (строка меньше или равна {MAX_WORD_LENGTH} символам) либо пустой массив:");
    PrintArray(shortArray);
    Console.WriteLine();
}

PrintTask(array1);
PrintTask(array2);
PrintTask(array3);
