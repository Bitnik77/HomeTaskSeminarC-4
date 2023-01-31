// Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки
// и рисует ее в консоли звездочками
Console.Write("Введите высоту ёлочки: ");
int H = int.Parse(Console.ReadLine()!);

int Sosna(int x, int y)
{
    while (y <= H)
    {
      int a = 0;
      int b = 0;
      Console.SetCursorPosition(x, y);
      Console.Write("*");
      Console.WriteLine();
      while (a < y)
      {
        Console.SetCursorPosition(x - a, y);
        Console.Write("*");
        Console.WriteLine();
        a++;
      }
      while (b < y)
      {
        Console.SetCursorPosition(x + b, y);
        Console.Write("*");
        Console.WriteLine();
        b++;
      }
      y++;
    } 
    return x;
}
Console.Clear();
Sosna(60, 1);