// Задача №27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
int Result(int arg1)
{
    int sum = 0;
    while (arg1 != 0)
    {
       sum = sum + arg1 % 10;
       arg1 = arg1 / 10;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {A} будет равна {Result(A)}");