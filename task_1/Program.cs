//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");

string? number = Console.ReadLine();
//string number = Console.ReadLine();

if (number[0] == number[4] || number[4] == number[0])
{
    Console.WriteLine("Число палиндром: {number} ");
}

else Console.WriteLine($"Число не палиндром: {number}");

if (number!.Length == 5)
Console.WriteLine(number);