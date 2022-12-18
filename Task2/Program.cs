// Задача 2:Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("введите первое число ");
int ferstnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("введите второе число ");
int Secondtnumber = Convert.ToInt32(Console.ReadLine());

if (ferstnumber > Secondtnumber)
    Console.Write($"Число больше {ferstnumber} чем {Secondtnumber}");
else
    Console.Write($"Число больше {Secondtnumber} чем {ferstnumber}");

