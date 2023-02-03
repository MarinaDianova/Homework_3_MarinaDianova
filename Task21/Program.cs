// Задача 21: Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int InputNumber(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int ax = InputNumber("Введите координату Х точки А: ");
int ay = InputNumber("Введите координату Y точки A: ");
int az = InputNumber("Введите координату Z точки А: ");
int bx = InputNumber("Введите координату X точки B: ");
int by = InputNumber("Введите координату Y точки B: ");
int bz = InputNumber("Введите координату Z точки B: ");

System.Console.Write(Math.Round(Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2)), 2));