// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("введите число ");
double num = Convert.ToInt32(Console.ReadLine());
int i =1;


Console.WriteLine($"числа от одного до {num}");

while (i <= num)
{
    if (i % 2 != 1)
        Console.Write($", чётное число {i}");
        
        i++;
}

    
        