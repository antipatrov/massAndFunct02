﻿//Задача 23

//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int cub = 1;
while (cub <= numberN)
{
    double result =  Math.Pow(cub,3);
    Console.Write(" " + result);
    cub++;

}