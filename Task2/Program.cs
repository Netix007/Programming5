// Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел.

int[] GetArray() // Задаем массив из 10 положительных трехзначных чисел
{
    Random randomizer = new Random();
    Console.Write("Исходный массив: ");
    int[] newArray = new int[10];
    for (int i = 0; i < 10; i++)
    {
        newArray[i] = randomizer.Next(100,1000);
        Console.Write($"{newArray[i]}   ");
    }
    Console.WriteLine();
    return newArray;
}

int[] newArray = GetArray();
int countEven = 0;
int countNotEven = 0;
foreach (int item in newArray)
{
    if (item % 2 == 0)
        countEven++;
    else
        countNotEven++;
}
Console.WriteLine($"Количество нечетных чисел в массиве - {countNotEven}, четных - {countEven}");
