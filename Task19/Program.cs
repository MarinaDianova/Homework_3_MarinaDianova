// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     int i = 0;
//     while (i < count)
//     {
//         Console.Write(array[i]);
//         i++;
//     }
// }

System.Console.WriteLine("Введите пятизначное число: ");

int a = Convert.ToInt32(Console.ReadLine());

if (a >= 10000 && a < 100000)
{
    string astring = a.ToString();
    int[] arrayInt = new int[astring.Length];
    for (int i = 0; i < astring.Length; ++i)
    {
        arrayInt[i] = int.Parse(astring[i] + " ");
    }

    if (arrayInt[0] == arrayInt[4] && arrayInt[1] == arrayInt[3])

    {
        Console.WriteLine($"Число {a} - палиндром");
    }

    else
    {
        Console.WriteLine($"Число {a} - не палиндром");
    }

    // PrintArray(arrayInt);

}
else
{
    Console.WriteLine("Введенное число не пятизначное");
}