int Forse(int leg) // Функция подсчёта разрядов
{ 
    var count = 0;
    if (leg > 0)
    {
        while (leg > 0)
        {
            leg = leg / 10;
            count++;
        }
    }
    else
        while (leg < 0)
        {
            leg = leg / 10;
            count++;
        }
    count = count - 3;
    return count;
}

Console.Write("Ведите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (((a < 100) & (a >0)) || ((-100 < a) & (a <= 0)))
    Console.WriteLine($"Третья цифра числа {a}, не найдена ");
else if ((a > 999) || (-999 > a)) // Блок 2 Задания
{
    int col = Forse(a);
    int i = Convert.ToInt32(Math.Pow(10, col));
    int x = a / i % 10;
    if (x < 0) x = x * -1;
    Console.WriteLine($"Третья цифра числа {a} = {x}");
}
else
{
    Console.WriteLine("Вторая цифра числа " + a + " = " + a / 10  % 10); // Блок 1 Задания
    Console.WriteLine("Третья цифра числа " + a + " = " + a % 10); 
}



