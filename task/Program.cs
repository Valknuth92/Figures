using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentIncome = 1000;
            double nextIncome = currentIncome;
            int monthAmount=0;
            do
            {
                currentIncome = nextIncome;
                nextIncome = currentIncome * 1.02;
                monthAmount++;
            }
            while ((nextIncome - currentIncome) <= 30);
            Console.WriteLine("Прошло месяцев: "+monthAmount.ToString());
        }
    }
}
