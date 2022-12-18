// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("введите число ");
double ferstnumber = Convert.ToInt32(Console.ReadLine());

if (ferstnumber % 2 == 1)
    Console.Write($"Число{ferstnumber} не является чётным");
else
    Console.Write($"Число{ferstnumber} является чётным");
