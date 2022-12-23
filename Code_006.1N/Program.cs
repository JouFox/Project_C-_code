Console.Write("Ведите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int cost = 0, secret;
if (n == 0) Console.WriteLine("Число N не может быть меньше или равно нулю");
while ((cost < n) & (n > 0)) 
        {
        cost++;
        secret = cost * cost * cost;
        Console.WriteLine(secret);
        }
    