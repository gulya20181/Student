// See https://aka.ms/new-console-template for more information
//  № 54 Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] numbers = new int[3, 4];
FillArrayRandom(numbers);
PrintArray(numbers);
SortToLower(numbers);
Console.WriteLine();
PrintArray(numbers );
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void SortToLower(int[,] array)// сортировка по убыванию
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
     {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
 {
         if (array[i, k] < array[i, k + 1])
        {
         int temp = array[i, k + 1];
        array[i, k + 1] = array[i, k];
         array[i, k] = temp;
         }
 }
}
 }
}
void PrintArray(int[,] array) // ф-я ввода 2х мерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
     {
     Console.Write($"{array[i, j]} ");
    }
        Console.WriteLine();
    }
}


// № 56 Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:1 4 7 2, 5 9 2 3,  8 4 2 4, 5 2 6 7
Console.WriteLine("массив");
     int[,] matrix =
      {{1,4,7,2},
      {5,9,2,3},
      {8,4,2,4},
      {5,2,6,7}};
    int sum = 0;
     int index = 0;
   for (int i = 0; i < 3; i++)
 {
     int temp = 0;
    for (int j = 0; j < 4; j++)
 {
  temp += matrix[j, i];
 }
    if (temp > sum)
 {
  sum = temp;
  index = i;
 }
 }
   Console.WriteLine("Столбец: ");
   for (int i = 0; i < 4; i++)
   {
    Console.WriteLine(matrix[i, index]);
   }  

   

   // №58 Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы ");
int n = InputNumbers("Введите число столбцов 1-й матрицы ");
int p = InputNumbers("Введите число столбцов 2-й матрицы ");
int range = InputNumbers("Введите диапазон случайных чисел от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\n Первая матрица");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\n Вторая матрица:");
WriteArray(secomdMartrix);
int[,] resultMatrix = new int[m,p];
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц");
WriteArray(resultMatrix);
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
