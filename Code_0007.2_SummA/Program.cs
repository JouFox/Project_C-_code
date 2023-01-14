/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.Write("Введите число: ");                   //Ввод числа
string B = Console.ReadLine();
int vara, summ = 0;
int leng = B.Length;                                //Нахождение длины
for (int i = 0; i < leng; i++)                      //Преобразование нахождение суммы цифр числа   
{
    if (B[i] == '-') 
    { 
        vara = int.Parse(Convert.ToString(B[i+1]));
        summ = summ - vara;
        i++;
    }
    else
    {
        vara = int.Parse(Convert.ToString(B[i]));
        summ = summ + vara;                     
    } 
   
}
Console.WriteLine($"Сумма чисел {B} = {summ}");      //Вывод