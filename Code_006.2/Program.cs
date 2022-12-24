Boolean dot(double x, double y)//функция сравнения объектов
{
    if (x > y)
        return true;
    else
        return false;
}
Console.Write("Введите число x1 = ");//Ввод координат 1 объекта
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число y1 = ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число z1 = ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число x2 = ");//Ввод координат 2 объекта
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число y2 = ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число z2 = ");
double z2 = Convert.ToInt32(Console.ReadLine());
double  yt, res, c2;//Доп переменные
Boolean swih = dot(x2, x1);
if (swih)//сравнение объектов по кординатам 
{
    if (swih = swih = dot(z2, z1)) c2 = Math.Sqrt((c2 = Math.Pow(x2 - x1, 2) + Math.Pow(z2 - z1, 2)));
    else c2 = Math.Sqrt((c2 = Math.Pow(x2 - x1, 2) + Math.Pow(z1 - z2, 2)));
}
else {
    if (swih = swih = dot(z2, z1)) c2 = Math.Sqrt((c2 = Math.Pow(x1 - x2, 2) + Math.Pow(z2 - z1, 2)));
    else c2 = Math.Sqrt((c2 = Math.Pow(x1 - x2, 2) + Math.Pow(z1 - z2, 2)));
}
if (swih= dot(y2,y1)) yt = y2 - y1;
else yt = y1 - y2;
res = Math.Sqrt((res = Math.Pow(c2, 2) + Math.Pow(yt, 2)));//конечный результат
Console.WriteLine($"Растояние от точки с кординатами ({x1},{y1},{z1}) и ({x2},{y2},{z2}) = {res}") ;
//Относительно верно


