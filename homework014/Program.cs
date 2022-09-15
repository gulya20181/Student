// See https://aka.ms/new-console-template for more information
// № 34 Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.[345, 897, 568, 234] -> 2
Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int count = 0;

for (int a = 0; a < numbers.Length; a++)
if (numbers[a] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[] ");
    for(int i = 0; i < numbers.Length; i++)
    if( i % 2==0)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("[]");
    Console.WriteLine("количество четных чисел в массиве");
}
