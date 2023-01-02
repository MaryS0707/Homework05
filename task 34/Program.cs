/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

int CheckArray (int [] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine($"Количество четных чисел в массиве: {count}");
    return count;
}

Random rnd = new Random();
int sizeArray = rnd.Next(2, 31);
int [] numbers = new int [sizeArray];

for (int i = 0; i < sizeArray; i++)
{
    numbers[i] = rnd.Next(100, 1000);
}

PrintArray(numbers);
CheckArray(numbers);