// Написать программу, которая из имеющегося массива строк формирует массив
// из строк, длина которых меньше либо равна три символа.

string[] InputArray(string text)
{
    System.Console.Write(text);
    var array = Array.ConvertAll(Console.ReadLine().Split(", "), Convert.ToString);
    return array;
}

void PrintArray(string[] array)
{
    System.Console.WriteLine("[" + string.Join(",", array) + "]");
}

int CountLessFourSimbolsElements(string[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            result++;
    return result;
}

string[] LessFourSimbolsArray(string[] array, int size)
{
    string[] newArray = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    return newArray;
}

string[] myArray = InputArray("Введите строки через запятую и пробел: ");
int sizeNewArray = CountLessFourSimbolsElements(myArray);
string[] newArray = LessFourSimbolsArray(myArray, sizeNewArray);
System.Console.Write("Массив из строк исходного массива, длина которых меньше либо равна три символа: ");
PrintArray(newArray);
