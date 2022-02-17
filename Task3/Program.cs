// Задача 38: Найти сумму чисел одномерного массива, стоящих на нечетной позиции.

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
int sum = 0;
for (int i = 1; i < newArray.Length; i += 2)
{
    sum = sum + newArray[i];
}
Console.WriteLine($"Сумма чисел массива, стоящих на нечетной позиции: {sum}");
