Console.Write("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());
int need = day;
int week = 0;
while (need > 7)
{
    need = need - 7;
    week = week + 1;
}
if      (day % 7 == 0)              Console.WriteLine($"Число {day} экваволентное воскресению является выходным");
else if ((day - week) % 6 == 0)     Console.WriteLine($"Число {day} экваволентное субботе является выходным ");
else if (day < 0 )                  Console.WriteLine($"Число {day} вышло за пределы допустимых значений");
else                                Console.WriteLine($"Число {day} не является выходным ");
                               