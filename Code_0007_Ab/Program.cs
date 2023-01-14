/*дача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16*/
using System;
Console.Write("Введите число A: ");             //Ввод чисел
double A = Convert.ToInt32(Console.ReadLine());
double a = A;
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
if (B < 0)                                      // Определение отрицательности степени
{
    for (int i = -1; i > B; i--)
    {
        A = A * a;
    }
    A = 1 / A;
}
else for (int i = 1; i < B; i++)
    {
        A = A * a;
    }     
Console.Write($"{a}^{B} = {A}");                //Вывод