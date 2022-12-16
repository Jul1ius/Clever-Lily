using System;

namespace Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double sum = 0;
            int moneyRecieved = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sum += moneyRecieved;
                    moneyRecieved += 10;
                    sum--;
                }
                else
                {
                    sum += toyPrice;
                }
            }
            if (sum < washingMachinePrice)
            {
                Console.WriteLine($"No! {washingMachinePrice - sum:f2} ");
            }
            else
            {
                Console.WriteLine($"Yes! {sum - washingMachinePrice:f2} ");
            }
        }

    }
}

