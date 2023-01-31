// Задача №29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
// Задача была решена в лекции
void FillArray(int[] col)
{
    int length = col.Length;
    int index = 0;
    while (index < length)
    {
        col[index] = new Random().Next(0,7);
        Console.Write(col[index]);
        if (index != length-1) Console.Write(", ");
        index++;
    }
}
//void PrintArray(int[] col1)
//{
//    int n1 = col1.Length;
//    int index1 = 0;
//    while (index1 < n1)
//    {
//       Console.Write(col1[index1]);
//       if (index1 != n1-1) Console.Write(", ");
//       index1++;
//   }
//}
int[] array = new int[8];
Console.Clear();
FillArray(array);
//PrintArray(array);