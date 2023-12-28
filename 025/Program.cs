// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

//[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int[] array = new int [10];
FillArray(array);
PrintArray(array);

Console.WriteLine();

Console.WriteLine("Reversed Array:");
ReverseArray(array, array.Length - 1);

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

void ReverseArray (int[] array, int index)
{
    if (index <0)
    {
        return;
    }
    Console.Write(array[index] + " ");
    ReverseArray(array, index - 1);
}
