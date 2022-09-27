// See https://aka.ms/new-console-template for more information
//№47Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10 );

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
int[,] res = new int[m, n];
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
res[i, j] = new Random().Next(minValue, maxValue + 1);
}
}
return res;
}
void PrintArray(int[,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
for (int j = 0; j < inArray.GetLength(1); j++)
{
Console.Write($"{inArray[i, j]} ");
}
Console.WriteLine();
}
}
PrintArray(array);


Задача 50 напишите программу которая на вход принимает
//позиции элемента в двухмерном массиве и  возвращает
// значение  этого элемента  или же указание что такого элемента нет
Console.Write("введите индек строки");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("введите индекс столбца");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[0,10];
FillArray(numbers);
if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1))
 Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");
void FillArray(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
 {
 for (int j = 0; j < array.GetLength(1); j++)
 {
  array[i, j] = new Random().Next(1, 10);
 }
}
void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
 {
 for (int j = 0; j < array.GetLength(1); j++);
 }
Console.Write(array[1,10] + " ");
{
 Console.WriteLine();
PrintArray(numbers);
}
}
}


Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("введите количество столбцов");
int m= Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("введите количество строк");
int n= Convert.ToInt32(Console.ReadLine());
int[,] array   = new int[m, n];
Random ran = new Random ();
{
    for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++);
}
{
array[m, n ] = new Random().Next(0, 10);
{
Console.Write(array[m,n] + " ");
}

Console.WriteLine("");
Console.WriteLine(array.GetLength(0));
    double sum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
   for (int j = 0; j < array.GetLength(1); i++)
 sum += array[i, j ]; 
    Console.Write($"{ sum / array.GetLength(m*n)} ");
  Console.ReadLine();
}
}
