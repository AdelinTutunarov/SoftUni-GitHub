using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine()); 
            BigInteger snowballSnow = 0, snowballTime = 0, snowballQuality = 0;
            BigInteger ss = 0, st = 0, sq = 0, snowballValue = 0, sv = snowballValue;
            for (int i = 0; i < n; i++)
            {
                snowballSnow = BigInteger.Parse(Console.ReadLine());
                snowballTime = BigInteger.Parse(Console.ReadLine());
                snowballQuality = BigInteger.Parse(Console.ReadLine());
                snowballValue = BigInteger.Pow((snowballSnow / snowballTime), (int)snowballQuality);
                if (snowballValue > sv)
                {
                    ss = snowballSnow;
                    st = snowballTime;
                    sq = snowballQuality;
                    sv = snowballValue;
                }
            }
            Console.WriteLine($"{ss} : {st} = {sv} ({sq})");
        }
    }
}
