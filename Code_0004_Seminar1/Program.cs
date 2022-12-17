// Написано в Microsoft Visual Studio Community 
int a, b, c, N, n; 
Console.Write("Введите число a = ");
a = Convert.ToInt32(Console.ReadLine()); // Ввод 1 числа a
Console.Write("Введите число b = ");
b = Convert.ToInt32(Console.ReadLine()); // Ввод 2 числа b
Console.Write("Введите число c = ");
c = Convert.ToInt32(Console.ReadLine()); // Ввод 3 числа c
Console.Write("Введите число N = ");
N = Convert.ToInt32(Console.ReadLine()); // Ввод числа N
if ( a > b) // Блок задагтя 2
{
    Console.WriteLine($"Число {a} наибольшее а число {b} наименьшее");
}
else 
{
    Console.WriteLine($"Число {b} наибольшее а число {a} наименьшее");
}
if ((a > b) & (a > c)) // Блок задания 4
{
    Console.Write($"Число {a} наибольшее из чисел ");
    if (c > b)
    { Console.WriteLine($"{c}, {b} "); }
    else { Console.WriteLine($"{b}, {c} "); }
}
else if ((b > c) & (b > a))
{
    Console.Write($"Число {b} наибольшее из чисел ");
    if (a > c)
    { Console.WriteLine($"{a}, {c} "); }
    else { Console.WriteLine($"{c}, {a} "); }
}
else
{
    Console.Write($"Число {c} наибольшее из чисел ");
    if (b > a)
    { Console.WriteLine($"{b}, {a} "); }
    else { Console.WriteLine($"{a}, {b} "); }
}
Console.Write($"Число {a} "); // Блок задачи 6
a = a % 2;
if (a == 0)
    Console.WriteLine($" четное остаток от деления на 2 = {a} ");
else
    Console.WriteLine($" нечетное остаток от деления на 2 = {a} ");

if (N > 0) 
    {
    Console.Write($"Серия четных чисел до {N}: "); // Блок задачи 8
    n = 0;
    while (n < N)
    {
    n = n + 1;
    int Ncou = n % 2;
    if (Ncou == 0)
        Console.Write($" {n} ");
    else
        Console.Write("");
    }
    }
else // Исключение при вводе отрицательного значения (декор не нужное)
{
    Console.WriteLine($" Число {N} меньшн нуля и выполнение задачи не возможно");
}

