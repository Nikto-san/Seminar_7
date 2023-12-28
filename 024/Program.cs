// Задача 2: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

//m = 2, n = 3 -> A(m,n) = 29

int m = GetFirstNumber();
int n = GetSecondNumber();

int GetFirstNumber()
{
    Console.WriteLine("Введите число: ");
    int numOne = Convert.ToInt32(Console.ReadLine());
    return numOne;
}

int GetSecondNumber()
{
    Console.WriteLine("Введите число: ");
    int numTwo = Convert.ToInt32(Console.ReadLine());
    return numTwo;
}


int result = AckermannFunction(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");
Console.ReadLine();


int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
    else
    {
        return 0;
    }
}

