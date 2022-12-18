// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("введите первое число ");
int ferstnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("введите второе число ");
int Secondtnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("введите третье число ");
int Freenumber = Convert.ToInt32(Console.ReadLine());

int max = ferstnumber;


if ((max > Freenumber) & (max > Secondtnumber))
    Console.Write($"Число один наиболшее, равно {max}");
else if(Freenumber < Secondtnumber)
    Console.Write($"Число два наиболшее, равно {Secondtnumber}");
else
    Console.Write($"Число три наиболшее, равно {Freenumber}");

