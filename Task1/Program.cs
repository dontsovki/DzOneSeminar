//Определение является ли иследуемое число квадратом исходного
Console.Write("введите первое число ");
int ferstnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("введите второе число ");
int Secondtnumber = Convert.ToInt32(Console.ReadLine());

if (ferstnumber == Secondtnumber*Secondtnumber)
    Console.Write($"Число {ferstnumber} является квадратом {Secondtnumber}");
else 
    Console.Write($"Число {ferstnumber} не является квадратом {Secondtnumber}");




//Console.Write("введите число ");
//int number = Convert.ToInt32(Console.ReadLine());
//Console.Write($"квадрат числа  {number}  будет равен {number * number}");