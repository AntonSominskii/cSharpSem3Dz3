//  Задача 21: Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Программа для вычисления расстояния между 2 точками в 3D пространстве.\nВведите значение X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));

Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {Math.Round(result, 2)}");