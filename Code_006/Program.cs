Console.Write("Ведите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] dis = new int[4];
if ((((999 < a) & (a > 0)) | ((-999 > a) & (a < 0)) && (((a < 100000) & (a > 0)) | ((a > -1000000) & (a < 0)))))
{
    dis[3] = a % 10;
    dis[2] = a / 10 % 10;
    dis[1] = a / 1000 % 10;
    dis[0] = a / 10000;
    if ((dis[0] == dis[3]) && (dis[1] == dis[2])) Console.WriteLine($"Число {a} является палиндромом");
    else Console.WriteLine($"Число {a} является не палиндромом");
}
else Console.WriteLine($"Введённое чесло {a} выходит за допустимую область"); 