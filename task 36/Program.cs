/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

int GetSum (int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}

Random rnd = new Random();
int sizeArray = rnd.Next(4, 16);
int [] numbers = new int [sizeArray];

for (int i = 0; i < sizeArray; i++)
{
    numbers[i] = rnd.Next(-100, 101);
}

PrintArray(numbers);

int Sum = GetSum(numbers);
Console.WriteLine($"Сумма элементов на нечетных позициях равна {Sum}");