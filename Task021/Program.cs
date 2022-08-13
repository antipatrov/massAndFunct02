//Задача 21

//Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки A по оси x: ");
int Ax = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки A по оси y: ");
int Ay = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки A по оси z: ");
int Az = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки B по оси x: ");
int Bx = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки B по оси y: ");
int By = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки B по оси z: ");
int Bz = Convert.ToInt32(Console.ReadLine());

double lenghtAB = Math.Sqrt(Math.Pow(Ax-Bx,2)+Math.Pow(Ay-By,2)+Math.Pow(Az-Bz,2));
Math.Round(lenghtAB,2);
Console.WriteLine("Длина отрезка АВ: " + Math.Round(lenghtAB,2));
