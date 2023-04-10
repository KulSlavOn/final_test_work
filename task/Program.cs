// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна
// 3 символам. Первоначальный массив можно ввести с клавиатуры, либо
// задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] ReadArrayFromInput()
{
    Console.Write("Введите элементы массива, разделенные пробелом: ");
    string[] array = Console.ReadLine()!.Split();
    return array;
}

string[] FilterArrayByLength(string[] array, int maxLength)
{
    int newSize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength) newSize++;
    }
    string[] newArray = new string[newSize];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    Console.Write("Новый массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void task()
{
    string[] sourceArray = ReadArrayFromInput();
    string[] newArray = FilterArrayByLength(sourceArray, 3);
    PrintArray(newArray);
}

task();