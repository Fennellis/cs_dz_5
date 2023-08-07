// Задача 36: 
// Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int EvenNumbers(int[] arr)
{
    int sumnum = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        sumnum += arr[i]; 
    }
    return sumnum;
}

int[] array = CreateArrayRndInt(100, -99, 99);
PrintArray(array);

int result = EvenNumbers(array);
Console.WriteLine($" -> {result}");