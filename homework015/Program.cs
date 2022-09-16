//Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int sum = 0;
for (int a = 0; a< numbers.Length; a+=2)
sum = sum + numbers[a];
Console.WriteLine($"всего {numbers.Length} чис.,сумма эл.на нечётных={sum}");
void FillArrayRandomNumbers(int[] numbers)
{for(int i = 0; i < numbers.Length; i++)
{
numbers[i] = new Random().Next(1,10);
}
}
void PrintArray(int[] numbers)
{
Console.Write("[]");
for(int i = 0; i < numbers.Length; i++)
{
Console.Write(numbers[i] + " ");
}
Console.Write("[]");
Console.WriteLine();
}

//задайте массив заполненный случайными положительными 
//трехзначными числами.напишите программу которая покажет количество
//четных чисел в массиве[345,897,568,234]->2
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine(" массив: ");
PrintArray(numbers);
int count = 0;
for (int a = 0; a < numbers.Length; a++)
if (numbers[a] % 2 == 0) count++;
Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");
void FillArrayRandomNumbers(int[] numbers)
{for(int i = 0; i < numbers.Length; i++)
{
numbers[i] = new Random().Next(1,100);
}
}
void PrintArray(int[] numbers)
{
Console.Write("[]");
for(int i = 0; i < numbers.Length; i++)
{
Console.Write(numbers[i] + " ");
}
Console.Write("[]");
Console.WriteLine();
}

//задать массив вещественных чисел. 
//найти разницу между максимальным и минимальным элементов массива 
Console.WriteLine("Введите размер массива");
int size =Convert.ToInt32(Console.ReadLine());
double[]numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int a = 0; a < numbers.Length; a++)
{
if (numbers[a] > max) max = numbers[a];
if (numbers[a] < min) min = numbers[a];
}
Console.WriteLine($"Разн. между макс и мин зн.={max - min}");
void FillArrayRandomNumbers(double[]numbers)
{
for(int i=0;i<numbers.Length;i++)
{
numbers[i]=Convert.ToDouble(new Random().Next(1,100))/10;
}
}
void PrintArray(double[]numbers)
{
Console.Write("[] ");
for(int i = 0; i < numbers.Length; i++)
{
 Console.Write(numbers[i] + " ");
}
Console.Write("[]");
Console.WriteLine();
}