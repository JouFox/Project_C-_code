using System;

namespace Code_001_DOG
{
    class Program
    {
        static void Main(string[] args)
        {
            double U1 = new Random().Next(1, 10);
            double U2 = new Random().Next(1, 10); ;
            double Udog = new Random().Next(1, 30); 
            Console.WriteLine(U1);
            Console.WriteLine(U2);
            Console.WriteLine(Udog);
            int frend = 1;
            double S = new Random().Next(1000, 100000001);;
            int count = 0;
            double time;
            while (S > 10)
            {
                if (frend == 1)
                {
                    time = S / (U1 + Udog);
                    frend = 2;
                }
                else
                {
                    time = S / (U2 + Udog);
                    frend = 1;
                }
                int Time = (int)time;
                double s = S;
                S = S - (U1 + U2) * Time;
                s = S - s;

                if (s == 0)
                    break;
                else
                    count = count + 1;
               
            }
            Console.WriteLine(count);
        }
    }
}
