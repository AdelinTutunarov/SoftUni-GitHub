using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            double lostgames = int.Parse(Console.ReadLine());
            double headsetprice = double.Parse(Console.ReadLine());
            double mouseprice = double.Parse(Console.ReadLine());
            double keyboardprice = double.Parse(Console.ReadLine());
            double displayprice = double.Parse(Console.ReadLine());
            bool p = false;
            double sum = 0;
            for (int i = 1; i <= lostgames; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    sum += headsetprice + mouseprice;
                    if (p == true)
                    {
                        sum += keyboardprice + displayprice;
                        p = false;
                    }
                    else
                    {
                        sum += keyboardprice;
                        p = true;
                    }
                }
                else if (i % 2 == 0) sum += headsetprice;
                else if (i % 3 == 0) sum += mouseprice;
            }
            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
        }
    }
}
