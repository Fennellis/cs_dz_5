// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементами массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = (double)rnd.Next(min * 100, (max + 1) * 100) / 100;
    }

    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}; ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

(double, double, double) DifferenceNumber(double[] arr)
{
    double maxnum = arr[0];
    double minnum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minnum)
        {
            minnum = arr[i];
        }
        if (arr[i] > maxnum)
        {
            maxnum = arr[i];
        }
    }
    return (maxnum, minnum, maxnum - minnum);
}

double[] array = CreateArrayRndInt(5, -999, 1000);
PrintArray(array);

var result = DifferenceNumber(array);
Console.WriteLine($"Разница максимального ({result.Item1}) и минимального ({result.Item2}) элементов массива -> {result.Item3}");
