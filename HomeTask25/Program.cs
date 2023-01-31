// Задача №25. Напишите функцию, которая принимает на вход два числа (A и B) и возводит
// число A в натуральную степень B
int Result(int arg1, int arg2)
{
    int sum = 1;
    for (int i = 1; i <= arg2; i++)
    {
        sum = sum * arg1;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{A} в степени {B} будет равно {Result(A, B)}");
