﻿// See https://aka.ms/new-console-template for more information
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");

}