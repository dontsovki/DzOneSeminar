// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("введите первое число ");
int ferstnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("введите второе число ");
int Secondtnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("введите третье число ");
int Freenumber = Convert.ToInt32(Console.ReadLine());

if (ferstnumber > Secondtnumber)
    else if(ferstnumber > Freenumber)
    Console.Write($"Число больше {ferstnumber}");
else
    Console.Write($"Число больше {Freenumber}");
