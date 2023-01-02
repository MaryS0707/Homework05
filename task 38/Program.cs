/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
void PrintArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

double DifferenceMinMax (double [] array)
{
    double dif;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i];
        
        if (max < array[i])
            max = array[i];
    }

    dif = max - min;
    return dif;
}

Random rnd = new Random();
int sizeArray = rnd.Next(5, 11);
double [] numbers = new double [sizeArray];
double dif;

for (int i = 0; i < sizeArray; i++)
{
    
    numbers[i] = rnd.NextDouble() * 100;
}

PrintArray(numbers);
dif = DifferenceMinMax(numbers);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {dif}");

