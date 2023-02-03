// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125

void PrintSquares(int x)
{
    for (int i = 1; i <= x; i++)
    {
        System.Console.Write(Math.Pow(i, 3) + " ");
    }
}

System.Console.Write("Введите число N: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
System.Console.WriteLine($"Кубы чисел от 1 до {a}: ");
PrintSquares(a);