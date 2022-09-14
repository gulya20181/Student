// See https://aka.ms/new-console-template for more information
//Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
//14212 -> нет,12821 -> да,23432 -> да
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int vin = number.Length;

if (vin == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}
