// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] FillArray(int sizeArrayWords)
{
    string[] array = new string[sizeArrayWords];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

int CountWordsThreeSymbol(string[] array, int countDesired)
{
    int sizeArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= countDesired) sizeArray++;
    }
    return sizeArray;
}

string[] ArrayWords(string[] array, int sizeArray, int countDesired)
{
    string[] resultArray = new string[sizeArray];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= countDesired)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;
}

const int countSymbol = 3;

Console.Write("Введите количество строк: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 1)
{
    Console.Write("Введите натуральное число");
    return;
}

string[] oldArray = FillArray(size);

int count = CountWordsThreeSymbol(oldArray, countSymbol);

string[] newArray = ArrayWords(oldArray, count, countSymbol);

Console.Write($"[{string.Join(", ", oldArray)}]");
Console.WriteLine();

Console.Write($"[{string.Join(", ", newArray)}]");