/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int[] array = GenerateRandomArray(10, 0, 100);

int[] GenerateRandomArray(int length,int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint+1);
    }
    return resultArray;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int min = array[0];
int max = array[0];

for (int i = 0; i < array.Length; i++)
    {
    if (array[i] > max)
    {
        max = array[i];
    } 
    else if (array[i] < min)
    {
        min = array[i];
    }
    }

printArray(array);
Console.WriteLine($"Минимальное число - {min}. Максимальное число - {max}. Разница между максимальным и минимальным элементами массива = {max-min}");