// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.


int M = GetNumberM();
int N = GetNumberN();

ListNumbers(M, N);

int GetNumberN()
{
    Console.WriteLine("Введите число N: ");
    int numN = Convert.ToInt32(Console.ReadLine());
    return numN;
}

int GetNumberM()
{
    Console.WriteLine("Введите число M: ");
    int numM = Convert.ToInt32(Console.ReadLine());
    return numM;
}


void ListNumbers (int start, int end)
{
    if (start<=end)
    {
        Console.WriteLine(start);
        ListNumbers(start +1, end);
    }
}