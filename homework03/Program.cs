﻿
// №60 сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");
int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
    {
      while (temp[i] == temp[j])
     {
        temp[i] = new Random().Next(10, 100);
        j = 0; number = temp[i];
      }
       number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
    {
      array3D[x, y, z] = temp[count];  count++;
    }
      {
      Console.Write($"[x,y,z] ({x},{y},{z})");
      Console.WriteLine();
      }
    }
  }
}

// № 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] SpiralMassive(int side)
{
int[,] spiralMassive = new int[side, side];
int value = 0;
int count = side;
int vol = -side;
int ind = -1;
  while (count > 0)
{
vol = -1 * vol / side;
for (int i = 0; i < count; i++)
{
ind += vol;
spiralMassive[ind / side, ind % side] = value++;
}
vol *= side;
count--;
for (int i = 0; i < count; i++)
{
ind += vol;
spiralMassive[ind / side, ind % side] = value++;
}
}
  return spiralMassive;
}
void PrintArray(int[,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
for (int j = 0; j < inArray.GetLength(1); j++)
{
Console.Write(inArray[i, j] + "\t");
}
Console.WriteLine();
}
}
int x = 6;
int[,] arrey = SpiralMassive(x);
PrintArray(array);
            