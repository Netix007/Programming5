// Задача 40: В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.

int[] GetArray(int sizeArray)  // Задаем массив из случайных целых чисел в диапазоне [-100;100] и выводим массив на экран
{
    Random randomizer = new Random();
    Console.Write("Исходный массив: ");
    int[] newArray = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        newArray[i] = randomizer.Next(-100,101);
        Console.Write($"{newArray[i]}  ");
    }
    Console.WriteLine();
    return newArray;
}

int[] newArray = GetArray(11);
int maxElement = newArray[0];
int minElement = newArray[0];
foreach (int item in newArray)
{
    if (item > maxElement)
        maxElement = item;
    if (item < minElement)
        minElement = item;
}
Console.WriteLine($"Разница между максимальным и минимальным элементом равна: {maxElement-minElement}");
