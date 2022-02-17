// Задача 34: Написать программу замену элементов массива на противоположные.

int[] GetArray()  // Задаем массив из 10 случайных целых чисел в диапазоне [-100;100] и выводим массив на экран
{
    Random randomizer = new Random();
    Console.Write("Исходный массив: ");
    int[] newArray = new int[10];
    for (int i = 0; i < 10; i++)
    {
        newArray[i] = randomizer.Next(-100,101);
        Console.Write($"{newArray[i]}  ");
    }
    Console.WriteLine();
    return newArray;
}

int[] ReplacingElements(int[] newArray) // Заменяем элементы массива на противоположные по значению и выводим новый массив на экран
{
    Console.Write("Массив после преобразования: ");
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = -1 * newArray[i];
        Console.Write($"{newArray[i]}  ");
    }
    Console.WriteLine();
    return newArray;
}

int[] newArray = GetArray();
newArray = ReplacingElements(newArray);
