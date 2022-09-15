// See https://aka.ms/new-console-template for more information
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵) 2, 4 -> 16
Console.WriteLine("введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int num = a;

for (int i = 1; i < b; i++)
{
num = num * a;
}
Console.WriteLine("A в степени B равно: " + num);

